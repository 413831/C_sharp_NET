using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

namespace Archivos
{
    public class Texto: IArchivo<string>
    {
        /// <summary>
        /// Implementación de método para guardar en archivos de tipo texto
        /// </summary>
        /// <param name="archivo">Nombre del archivo donde se guardará</param>
        /// <param name="datos">Datos para guardar en archivo</param>
        /// <returns>Retorna true si logra guardar sino retorna false</returns>
        public bool Guardar(string archivo, string datos)
        {
            StreamWriter txtWriter = new StreamWriter(archivo,false);

            try
            {
                txtWriter.WriteLine(datos);
                return true;

            }
            catch(NotSupportedException exception)
            {
                return false;
                throw new ArchivosException(exception);
            }
            catch (IOException exception)
            {
                return false;
                throw new ArchivosException(exception);
            }
            finally
            {
                txtWriter.Close();
            }
        }

        /// <summary>
        /// Implementación de método para leer de un archivo de texto
        /// </summary>
        /// <param name="archivo">Nombre del archivo para leer</param>
        /// <param name="datos">Variable para guardar los datos leídos</param>
        /// <returns>Retorna true si logra leer los datos sino retorna false</returns>
        public bool Leer(string archivo, out string datos)
        {
            StreamReader txtReader = new StreamReader(archivo, Encoding.UTF8);

            try
            {
                datos = txtReader.ReadToEnd();
                return true;
            }
            catch(OutOfMemoryException exception)
            {
                datos = "";
                return false;
                throw new ArchivosException(exception);
            }
            catch (IOException exception)
            {
                datos = "";
                return false;
                throw new ArchivosException(exception);
            }
            finally
            {
                txtReader.Close();
            }
        }
    }
}
