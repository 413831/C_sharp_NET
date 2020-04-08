using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Excepciones;

namespace Clases_Instanciables
{
    public sealed class Profesor : Universitario
    {
        private Queue<Universidad.EClases> clasesDelDia;
        static Random random;

        #region Métodos

        /// <summary>
        /// Constructor estático que inicializa el atributo del número random
        /// </summary>
        static Profesor()
        {
            random = new Random();
        }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Profesor()
        {}

        /// <summary>
        /// Constructor con cinco parámetros que setea las clases del día
        /// </summary>
        /// <param name="id">Valor para el atributo legajo</param>
        /// <param name="nombre">Valor para el atributo nombre</param>
        /// <param name="apellido">Valor para el atributo apellido</param>
        /// <param name="dni">Valor para el atributo dni</param>
        /// <param name="nacionalidad">Valor para el atributo nacionalidad</param>
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
         : base(id,nombre,apellido,dni,nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();

            for(int i = 2; i > 0;i--)
            {
                this._randomClases();
            }
        }

        /// <summary>
        /// Método que asigna una clase al profesor de forma aleatoria
        /// </summary>
        private void _randomClases()
        {
            this.clasesDelDia.Enqueue((Universidad.EClases)random.Next(0,3));
        }

        /// <summary>
        /// Método que retorna los datos de un Profesor en un string
        /// </summary>
        /// <returns>Retorna un string con todos los datos</returns>
        protected override string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder("");
                                                         
            datos.AppendLine(base.MostrarDatos());      // Muestro apellido, nombre, nacionalidad y el legajo
            datos.AppendLine(this.ParticiparEnClase()); // Muestro las clases del día

            return datos.ToString();
        }

        /// <summary>
        /// Método que retorna las clases del día del objeto
        /// </summary>
        /// <returns>Retorna un string con las clases</returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder clases = new StringBuilder("CLASES DEL DÍA ");

            foreach(Universidad.EClases clase in this.clasesDelDia)
            {
                clases.AppendLine();
                clases.Append(clase.ToString());
            }
            return clases.ToString();
        }

        /// <summary>
        /// Sobrecarga de método ToString() que retorna todos los datos del objeto
        /// </summary>
        /// <returns>Retorna todos los datos en un string</returns>
        public override string ToString()
        {
            StringBuilder datos = new StringBuilder("");

            datos.AppendLine(this.MostrarDatos());

            return datos.ToString();
        }

        #endregion

        #region Operadores

        /// <summary>
        /// Sobrecarga de operador distinto que compara un profesor contra una clase
        /// </summary>
        /// <param name="profesor">Profesor para comparar</param>
        /// <param name="clase">Clase para comparar</param>
        /// <returns>Retorna true si son diferentes sino retorna false</returns>
        public static bool operator !=(Profesor profesor, Universidad.EClases clase)
        {
            return !(profesor == clase);
        }

        /// <summary>
        /// Sobrecarga de operador de igualdad que compara un profesor contra una clase
        /// </summary>
        /// <param name="profesor">Profesor para comparar</param>
        /// <param name="clase">Clase para comparar</param>
        /// <returns>Retorna true si el profesor tiene asignada la clase sino retorna false</returns>
        public static bool operator ==(Profesor profesor, Universidad.EClases clase)
        {
            return profesor.clasesDelDia.Contains(clase);
        }

        #endregion
    }
}