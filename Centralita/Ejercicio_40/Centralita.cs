using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    
    public class Centralita : IGuardar<string>
    {
        private List<Llamada> listaDeLlamadas;
        private string razonSocial;
        private string logCentralita;

        #region Propiedades

        public float GananciasPorLocal
        {
            get
            {
                float ganancia = 0;
                Local auxiliar;

                foreach (Llamada llamada in this.Llamadas)
                {
                    if (llamada is Local)
                    {
                        auxiliar = (Local)(llamada); // Corregir
                        ganancia += auxiliar.CostoLlamada;
                    }
                }
                return ganancia;
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                float ganancia = 0;
                Provincial auxiliar;

                foreach (Llamada llamada in this.Llamadas)
                {
                    if (llamada is Provincial)
                    {
                        auxiliar = (Provincial)(llamada);
                        ganancia += auxiliar.CostoLlamada;
                    }
                }
                return ganancia;
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                float ganancia = 0;

                ganancia += this.GananciasPorLocal + this.GananciasPorProvincial;

                return ganancia;
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        public string RutaArchivo
        {
            get
            {
                return this.logCentralita;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region Métodos

        private Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
            this.logCentralita = "logLlamadas.txt";
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    return this.GananciasPorLocal;
                case Llamada.TipoLlamada.Provincial:
                    return this.GananciasPorProvincial;
                case Llamada.TipoLlamada.Todas:
                    return this.GananciasPorTotal;
                default:
                    return 0;
            }
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.listaDeLlamadas.Add(nuevaLlamada);
        }

        protected string Mostrar()
        {
            StringBuilder datos = new StringBuilder("");

            datos.AppendFormat("\nRAZÓN SOCIAL: {0}", this.razonSocial);
            datos.AppendFormat("\nGANANCIAS POR LLAMADAS LOCALES: {0}", this.CalcularGanancia(Llamada.TipoLlamada.Local));
            datos.AppendFormat("\nGANANCIAS POR LLAMADAS PROVINCIALES: {0}", this.CalcularGanancia(Llamada.TipoLlamada.Provincial));
            datos.AppendFormat("\nGANANCIA TOTAL: {0}", this.CalcularGanancia(Llamada.TipoLlamada.Todas));

            foreach (Llamada llamada in this.Llamadas)
            {
                datos.Append("\n" + llamada.ToString());
            }
            return datos.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        /*
     * 55. Tomar el ejercicio 51 de la guía:
        a. El método Guardar de la implementación de IGuardar en Centralita deberá guardar en un
        archivo de texto a modo de bitácora fecha y hora con el siguiente formato “Jueves 19 de
        octubre de 2017 19:09hs – Se realizó una llamada”; para lo cual este método deberá ser
        llamado desde el operador + (suma). En caso de no poder guardar, igualmente agregar la
        llamada a la Centralita y luego lanzar la excepción FallaLogException.
        b. El método Leer deberá obtener los datos de un archivo dado y retornarlos.
        c. En el método Main modificar el código para que, antes de salir, muestre el log.
     * */
        public bool Guardar()
        {
            StreamWriter archivo;
            StringBuilder texto;

            archivo = new StreamWriter(this.RutaArchivo,true);
            texto = new StringBuilder("");

            texto.AppendFormat(DateTime.Now.ToString("dddd dd") + " de ");
            texto.AppendFormat(DateTime.Now.ToString("MMMM") + " de ");
            texto.AppendFormat(DateTime.Now.ToString("yyyy hh:mm") + "hs");
            texto.AppendFormat(" - Se realizó una llamada");

            archivo.WriteLine(texto);
            archivo.Close();
            return true;
        }

        public string Leer()
        {
            StreamReader archivo = new StreamReader(this.RutaArchivo);
            string texto = "";

            if(File.Exists(this.RutaArchivo))
            {
                texto = archivo.ReadToEnd();
                archivo.Close();
            }
            return texto;
        }

        #endregion

        #region Operadores

        public static bool operator ==(Centralita central, Llamada llamada)
        {
            foreach (Llamada auxLlamada in central.listaDeLlamadas)
            {
                if (auxLlamada == llamada)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Centralita central, Llamada llamada)
        {
            return !(central == llamada);
        }

        public static Centralita operator +(Centralita central, Llamada llamada)
        {
            if (central != null && llamada != null && central != llamada)
            {
                central.Guardar();
                central.AgregarLlamada(llamada);
            }
            else
            {
                throw new CentralitaException("La llamada ya se encuentra en la lista",
                                                typeof(Centralita).Name, "Metodo");
            }

            return central;
        }
        #endregion

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            if (obj != null || this.GetType() == obj.GetType())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
