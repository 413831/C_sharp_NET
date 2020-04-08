using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        private int legajo;

        #region Métodos

        /// <summary>
        /// Método abstracto para implementar en clases Alumno y Profesor
        /// </summary>
        /// <returns></returns>
        protected abstract string ParticiparEnClase();

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Universitario()
        {}

        /// <summary>
        /// Constructor con cinco parámetros que setea el campo legajo
        /// </summary>
        /// <param name="legajo">Valor para atributo legajo</param>
        /// <param name="nombre">Valor para atributo nombre</param>
        /// <param name="apellido">Valor para atributo apellido</param>
        /// <param name="dni">Valor para atributo dni</param>
        /// <param name="nacionalidad">Valor para atributo nacionalidad</param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }

        /// <summary>
        /// Sobrecarga de Equals para verificar si el objeto recibido es o no de clase Universitario
        /// </summary>
        /// <param name="objeto">Objeto para verificar</param>
        /// <returns>Retorna true si es de la clase Universitario sino retorna false</returns>
        public override bool Equals(object objeto)
        {
            return objeto is Universitario;
        }

        /// <summary>
        /// Método para retornar los datos de un Universitario
        /// </summary>
        /// <returns>Retorna un string con todos los datos del objeto</returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder("");

            datos.AppendFormat(base.ToString()); // Datos de Persona del objeto
            datos.AppendLine();
            datos.AppendFormat("LEGAJO: {0}",this.legajo.ToString()); // Dato del legajo del objeto

            return datos.ToString();
        }

        #endregion

        #region Operadores

        /// <summary>
        /// Sobrecarga de operador de distinto que verifica si dos universitarios son diferentes siempre y cuando
        /// no sean del mismo tipo y no tengan el mismo número de legajo ni de dni
        /// </summary>
        /// <param name="universitarioUno">Primer universitario para comparar</param>
        /// <param name="universitarioDos">Segundo universitario para comparar</param>
        /// <returns>Retorna true si son iguales sino retorna false</returns>
        public static bool operator !=(Universitario universitarioUno, Universitario universitarioDos)
        {
            return !(universitarioUno == universitarioDos);
        }

        /// <summary>
        /// Sobrecarga de operador de igualdad que verifica si dos universitarios son iguales siempre y cuando
        /// sean del mismo tipo y tengan el mismo número de legajo o de dni
        /// </summary>
        /// <param name="universitarioUno">Primer universitario para comparar</param>
        /// <param name="universitarioDos">Segundo universitario para comparar</param>
        /// <returns>Retorna true si son iguales sino retorna false</returns>
        public static bool operator ==(Universitario universitarioUno, Universitario universitarioDos)
        {
            if((universitarioUno.legajo == universitarioDos.legajo)
                || (universitarioUno.Dni == universitarioDos.Dni)
                 &&  (universitarioDos.Equals(universitarioUno)))
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
