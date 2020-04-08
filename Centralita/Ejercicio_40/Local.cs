using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Local : Llamada, IGuardar<Local>
    {
        protected float costoLlamada;
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
            return this.costoLlamada * this.Duracion;
        }

        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }

        public Local(string origen, float duracion, string destino, float costo)
        {
            this.duracion = duracion;
            this.nroDestino = destino;
            this.nroOrigen = origen;
            this.costoLlamada = costo;
            this.RutaArchivo = "Locales.xml";
        }

        protected override string Mostrar()
        {
            StringBuilder datos = new StringBuilder("");

            datos.AppendLine(base.Mostrar());
            datos.AppendFormat("Costo de llamada: ${0}", this.CostoLlamada.ToString());

            return datos.ToString();
        }

        #endregion

        public override bool Equals(object obj)
        {
            if (obj != null && obj is Local)
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

        /*Serializar mediante XML
         * a. Los métodos de la implementación de IGuardar en Local deberán obtener los datos de un
        archivo dado, comprobar que estos sean del tipo Local y retornar un nuevo objeto de este
        tipo. En caso de que no sea del tipo Local, lanzará la excepción InvalidCastException.
        b. Los métodos de la implementación de IGuardar en Provincial deberán guardar y obtener los
        datos de un archivo dado, comprobar que estos sean del tipo Provincial y retornar un nuevo
        objeto de este tipo. En caso 
         */

        public bool Guardar()
        {
            XmlTextWriter escritor;
            XmlSerializer serializador = new XmlSerializer(typeof(Local));
            
            escritor = new XmlTextWriter(this.RutaArchivo, Encoding.UTF8); 
            serializador.Serialize(escritor, this);

            return true;
        }

        public Local Leer()
        {
            XmlTextReader lector;
            XmlSerializer serializador = new XmlSerializer(typeof(Local));

            lector = new XmlTextReader(this.RutaArchivo);

            while (lector.Read()) // Leo todo el archivo XML
            {
                if (lector.Name.ToString() == "Local") // Busco la etiqueta Local en el archivo XML
                {
                    return (Local)serializador.Deserialize(lector);
                }
            }
            throw new InvalidCastException(); // Si llego a este punto es porque el archivo XML no es de llamadas Locales
        }
    }
}
