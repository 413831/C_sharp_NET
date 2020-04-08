using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace IO
{
    public class PuntoXml : Archivo, IArchivos<string>
    {
        public bool Guardar(string ruta, string objeto)
        {
            XmlTextWriter archivo;
            XmlSerializer serializador;

            if (this.ValidarArchivo(ruta, true))
            {
                archivo = new XmlTextWriter(ruta, Encoding.UTF8); //Abro y codifico el XML
                serializador = new XmlSerializer(typeof(string));

                serializador.Serialize(archivo, objeto);
                archivo.Close();
                return true;
            }
            return false;
        }

        public bool GuardarComo(string ruta, string objeto)
        {
            XmlTextWriter archivo;
            XmlSerializer serializador;

            archivo = new XmlTextWriter(ruta, Encoding.UTF8); //Abro y codifico el XML
            serializador = new XmlSerializer(typeof(string));

            serializador.Serialize(archivo, objeto);
            archivo.Close();
            return true;
        }

        public string Leer(string ruta)
        {
            XmlTextReader archivo;
            XmlSerializer serializador;
            String texto;

            try
            {
                archivo = new XmlTextReader(ruta); //Abro y codifico el XML
                serializador = new XmlSerializer(typeof(string));

                texto = (String)serializador.Deserialize(archivo);
                archivo.Close();
                return texto; //REVISAR
            }
            catch (FileNotFoundException exception)
            {
                throw new ArchivoIncorrectoException("Archivo inexistente", exception);
            }
        }

        protected override bool ValidarArchivo(string ruta, bool validaExistencia)
        {
            try // REVISAR
            {
                if (base.ValidarArchivo(ruta, validaExistencia))
                {
                    if (Path.GetExtension(ruta) == ".xml")
                    {
                        return true;
                    }
                    else
                    {
                        throw new ArchivoIncorrectoException("El archivo no es un .xml");
                    }
                }
                return false;
            }
            catch (FileNotFoundException exception)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto.", exception);
            }
        }
    }
}
