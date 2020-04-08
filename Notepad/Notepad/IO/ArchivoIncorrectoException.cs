using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public class ArchivoIncorrectoException : Exception
    {
        public ArchivoIncorrectoException(string mensaje)
        {
            new Exception(mensaje);
        }

        public ArchivoIncorrectoException(string mensaje, Exception innerException)
        {
            new Exception(mensaje, innerException);
        }

    }
}
