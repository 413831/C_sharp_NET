using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivosException : Exception
    {
        /// <summary>
        /// Excepción para operaciones de escritura y lectura de archivos
        /// </summary>
        /// <param name="innerException"></param>
        public ArchivosException(Exception innerException) : base("Se produjo un error con el archivo.",innerException)
        {
        }
    }
}
