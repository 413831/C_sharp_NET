using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        protected string apellido;
        protected int dni;
        protected int edad;
        protected string nombre;

        #region Propiedades

        /// <summary>
        /// Propiedad de solo lectura que retorna campo apellido
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        /// <summary>
        /// Propiedad de solo lectura que retorna campo dni
        /// </summary>
        public int Dni
        {
            get
            {
                return this.dni;
            }
        }

        /// <summary>
        /// Propiedad de solo lectura que retorna campo edad
        /// </summary>
        public int Edad
        {
            get
            {
                return this.edad;
            }
        }

        /// <summary>
        /// Propiedad de solo lectura que retorna campo nombre
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Método abstracto que retorna los datos de los atributos de Persona
        /// </summary>
        /// <returns>Retorna todos los datos en un solo string</returns>
        public abstract string Mostrar();

        /// <summary>
        /// Constructor de Persona
        /// </summary>
        /// <param name="nombre">valor de atributo nombre</param>
        /// <param name="apellido">valor de atributo apellido</param>
        /// <param name="edad">valor de atributo edad</param>
        /// <param name="dni">valor de atributo dni</param>
        public Persona(string nombre ,string apellido, int edad, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
        }

        /// <summary>
        /// Se valida un objeto segun los valores de sus atributos
        /// </summary>
        /// <returns>Retorna un true al cumplir condición sino un false</returns>
        public abstract bool ValidarAptitud();
 
        #endregion
    }
}
