using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class GuardaString
    {
        /// <summary>
        /// Método para guardar datos en un archivo de texto
        /// </summary>
        /// <param name="texto"></param>
        /// <param name="archivo"></param>
        /// <returns>Retorna true si pudo guardar sino lanza una excepción</returns>
        public static bool Guardar(this string texto, string archivo)
        {
            StreamWriter escritor;
            
            try
            {
                escritor = new StreamWriter(archivo,true);
                escritor.WriteLine(texto);
                escritor.Close();
            }
            catch(IOException exception) // Lanzo exception a clase superior
            {
                throw exception;
            }
            return true;
        }
    }
}
