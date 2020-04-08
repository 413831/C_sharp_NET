using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException : Exception
    {
        #region Métodos

        /// <summary>
        /// Excepciones para validación del formato del DNI
        /// </summary>
        public DniInvalidoException() : this("DNI inválido")
        {
        }

        public DniInvalidoException(Exception exception) :this("DNI inválido",exception)
        {}

        public DniInvalidoException(string message) :this(message,null)
        {
        }

        public DniInvalidoException(string message, Exception exception) : base(message, exception)
        {
        }

        #endregion
    }
}
