using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TrackingIdRepetidoException : Exception
    {
        /// <summary>
        /// Excepción que se lanza cuando hay un trackingID repetido
        /// </summary>
        /// <param name="mensaje">Mensaje de la excepción</param>
        public TrackingIdRepetidoException(string mensaje) : base(mensaje)
        {}

        public TrackingIdRepetidoException(string mensaje, Exception inner): base(mensaje,inner)
        {}
    }
}
