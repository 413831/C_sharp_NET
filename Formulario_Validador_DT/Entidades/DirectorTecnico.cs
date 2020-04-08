using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private int añosExperiencia;

        #region Propiedades

        /// <summary>
        /// Propiedad de solo lectura que retorna campo añosExperiencia
        /// </summary>
        public int AñosExperiencia
        {
            get
            {
                return this.añosExperiencia;
            }
            set
            {
                if(value > 0 && value < 90)
                {
                    this.añosExperiencia = value;
                }
                else
                {
                    this.añosExperiencia = 0;
                }
            }
        }
        #endregion

        #region Métodos

        /// <summary>
        /// Constructor de Director Técnico
        /// </summary>
        /// <param name="nombre">valor de atributo nombre</param>
        /// <param name="apellido">valor de atributo apellido</param>
        /// <param name="edad">valor de atributo edad</param>
        /// <param name="dni">valor de atributo dni</param>
        /// <param name="añosExperiencia">valor de atributo años de experiencia</param>
        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosExperiencia)
        : base(nombre, apellido, edad, dni)
        {
            this.añosExperiencia = añosExperiencia;
        }

        /// <summary>
        /// Método sobrecargado para mostrar todos los datos de un jugador
        /// </summary>
        /// <returns>Retorna todos los datos en un solo string</returns>
        public override string Mostrar()
        {
            StringBuilder datos = new StringBuilder("");

            datos.AppendLine(base.Nombre.ToString().ToString());
            datos.AppendLine(base.Apellido.ToString());
            datos.AppendLine(base.Edad.ToString());
            datos.AppendLine(base.Dni.ToString());
            datos.AppendLine(this.AñosExperiencia.ToString());

            return datos.ToString();
        }

        /// <summary>
        /// Se valida a un director técnico según edad y experiencia
        /// </summary>
        /// <returns>Retorna true si cumple la condición sino retorna false</returns>
        public override bool ValidarAptitud()
        {
            if(base.Edad > 65 && this.AñosExperiencia > 2)
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
