using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

        #region Propiedades

        /// <summary>
        /// Propiedad de solo lectura que retorna campo altura
        /// </summary>
        public float Altura
        {
            get
            {
                return this.altura;
            }
        }

        /// <summary>
        /// Propiedad de solo lectura que retorna campo peso
        /// </summary>
        public float Peso
        {
            get
            {
                return this.peso;
            }
        }

        /// <summary>
        /// Propiedad de solo lectura que retorna campo posicion
        /// </summary>
        public Posicion Posicion
        {
            get
            {
                return this.posicion;
            }
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Constructor de Jugador
        /// </summary>
        /// <param name="nombre">valor de atributo nombre</param>
        /// <param name="apellido">valor de atributo apellido</param>
        /// <param name="edad">valor de atributo edad</param>
        /// <param name="dni">valor de atributo dni</param>
        /// <param name="peso">valor de atributo peso</param>
        /// <param name="altura">valor de atributo altura</param>
        /// <param name="posicion">valor de atributo posicion</param>
        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion)
            : base(nombre, apellido, edad, dni)
        {
            this.peso = peso;
            this.altura = altura;
            this.posicion = posicion;
        }

        /// <summary>
        /// Método sobrecargado para mostrar todos los datos de un jugador
        /// </summary>
        /// <returns>Retorna todos los datos en un solo string</returns>
        public override string Mostrar()
        {
            StringBuilder datos = new StringBuilder("");

            datos.AppendLine(this.Nombre.ToString());
            datos.AppendLine(this.Apellido.ToString());
            datos.AppendLine(this.Edad.ToString());
            datos.AppendLine(this.Dni.ToString());
            datos.AppendLine(this.Peso.ToString());
            datos.AppendLine(this.Altura.ToString());
            datos.AppendLine(this.Posicion.ToString());

            return datos.ToString();
        }

        /// <summary>
        /// Se valida un jugador segun su edad y estado físico
        /// </summary>
        /// <returns>Retorna un true al cumplir condición sino un false</returns>
        public override bool ValidarAptitud()
        {
            if(this.ValidarEstadoFisico() && this.Edad < 40)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Se valida el estado físico de un jugador según índice de masa corporal
        /// </summary>
        /// <returns>Retorna un true al cumplir condición sino un false</returns>
        public bool ValidarEstadoFisico()
        {
            double IMC = this.Peso / (this.Altura * this.Altura);

            if (IMC > 18.5 && IMC <= 25)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
