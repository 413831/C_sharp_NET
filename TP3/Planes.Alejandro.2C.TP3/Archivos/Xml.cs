using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
    public class Xml<T>:IArchivo<T>
    {
        /// <summary>
        /// Implementación de método para guardar en un archivo XML
        /// </summary>
        /// <param name="archivo">Nombre del archivo para guardar los datos</param>
        /// <param name="datos">Datos para guardar en el archivo</param>
        /// <returns>Retorna true si logra guardar sino retorna false</returns>
        public bool Guardar(string archivo, T datos)
        {
            XmlTextWriter textWriter = new XmlTextWriter(archivo, Encoding.UTF8);
            XmlSerializer serializador = new XmlSerializer(typeof(T));

            try
            {
                serializador.Serialize(textWriter, datos);
                return true;
            }
            catch(InvalidOperationException exception)
            {
                return false;
                throw new ArchivosException(exception);
            }
            finally
            {
                textWriter.Close();
            }
        }

        /// <summary>
        /// Implementación del método para leer de un archivo XML
        /// </summary>
        /// <param name="archivo">Nombre del archivo para leer los datos</param>
        /// <param name="datos">Variable para retornar los datos leídos</param>
        /// <returns>Retorna true si logró leer sino lanza una excepción del tipo ArchivoException</returns>
        public bool Leer(string archivo, out T datos)
        {
            XmlTextReader textReader = new XmlTextReader(archivo);
            XmlSerializer serializador = new XmlSerializer(typeof(T));

            try
            {
                datos = (T)serializador.Deserialize(textReader);
                return true;
            }
            catch(InvalidOperationException exception)
            {
                throw new ArchivosException(exception);
            }
            finally
            {
                textReader.Close();
            }
        }
    }
}
