using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public interface IArchivo<T>
    {
        /// <summary>
        /// Método de interfaz para guardar datos en un archivo
        /// </summary>
        /// <param name="archivo">Archivo donde se guardaran los datos</param>
        /// <param name="datos">Datos a guardar</param>
        /// <returns>Retorna true si logra la operación sino retorna false</returns>
        bool Guardar(string archivo, T datos);

        /// <summary>
        /// Método de interfaz para leer datos de un archivo
        /// </summary>
        /// <param name="archivo">Archivo de donde se leerán los datos</param>
        /// <param name="datos">Variable donde se guardarán los datos</param>
        /// <returns>Retorna true si logra la operación sino retorna false</returns>
        bool Leer(string archivo, out T datos);
    }
}
