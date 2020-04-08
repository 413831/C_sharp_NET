using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Provincial : Llamada, IGuardar<Provincial>
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        };
        protected Franja franjaHoraria;
        private string rutaArchivo;

        #region Propiedades

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public string RutaArchivo
        {
            get
            {
                return this.rutaArchivo;
            }
            set
            {
                this.rutaArchivo = value;
            }
        }

        #endregion

        #region Métodos

        private float CalcularCosto()
        {
            float costoTotal = 0;

            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    costoTotal = (float)(this.Duracion * 0.99);
                    break;
                case Franja.Franja_2:
                    costoTotal = (float)(this.Duracion * 1.25);
                    break;
                case Franja.Franja_3:
                    costoTotal = (float)(this.Duracion * 0.66);
                    break;
            }
            return costoTotal;
        }

        public Provincial(Franja miFranja, Llamada llamada) : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        { }

        public Provincial(string origen, Franja MiFranja, float duracion, string destino)
        {
            this.franjaHoraria = MiFranja;
            this.duracion = duracion;
            this.nroDestino = destino;
            this.nroOrigen = origen;
        }

        protected override string Mostrar()
        {
            StringBuilder datos = new StringBuilder("");

            datos.AppendLine(base.Mostrar());
            datos.AppendFormat("Costo de llamada: ${0}", this.CostoLlamada.ToString());
            datos.AppendFormat("Franja horaria: {0}", this.franjaHoraria.ToString());

            return datos.ToString();
        }

        #endregion

        public override bool Equals(object obj)
        {
            if (obj != null && obj is Provincial)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public bool Guardar()
        {
            XmlTextWriter escritor;
            XmlSerializer serializador = new XmlSerializer(typeof(Local));

            escritor = new XmlTextWriter(this.RutaArchivo, Encoding.UTF8);
            serializador.Serialize(escritor, this);

            return true;
        }

        public Provincial Leer()
        {
            XmlTextReader lector;
            XmlSerializer serializador = new XmlSerializer(typeof(Provincial));

            lector = new XmlTextReader(this.RutaArchivo);

            while (lector.Read()) // Leo todo el archivo XML
            {
                if (lector.Name.ToString() == "Provincial") // Busco la etiqueta Provincial en el archivo XML
                {
                    return (Provincial)serializador.Deserialize(lector);
                }
            }
            throw new InvalidCastException(); // Si llego a este punto es porque el archivo XML no es de llamadas provinciales
        }
    }
}
