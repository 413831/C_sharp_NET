using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IMostrar<T>
    {
        /// <summary>
        /// Método de interfaz para mostrar datos de un elemento
        /// </summary>
        /// <param name="elemento">Elemento para mostrar los datos</param>
        /// <returns>Retorna un string con todos los datos</returns>
        string MostrarDatos(IMostrar<T> elemento);
    }
}
