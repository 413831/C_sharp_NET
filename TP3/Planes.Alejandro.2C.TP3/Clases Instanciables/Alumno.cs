using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Excepciones;

namespace Clases_Instanciables
{
    public sealed class Alumno : Universitario
    {
        /// <summary>
        /// Enumerado de estados de cuenta
        /// </summary>
        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        };

        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        #region Propiedades

        /// <summary>
        /// Propiedad para el atributo claseQueToma
        /// </summary>
        public Universidad.EClases ClaseQueToma
        {
            get
            {
                return this.claseQueToma;
            }
            set
            {
                this.claseQueToma = value;
            }
        }

        /// <summary>
        /// Propiedad para el atributo estadoCuenta
        /// </summary>
        public EEstadoCuenta EstadoCuenta
        {
            get
            {
                return this.estadoCuenta;
            }
            set
            {
                this.estadoCuenta = value;
            }
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Alumno()
        {}

        /// <summary>
        /// Constructor de seis parámetros que setea la clase que toma
        /// </summary>
        /// <param name="id">Valor para el atributo legajo</param>
        /// <param name="nombre">Valor para el atributo nombre</param>
        /// <param name="apellido">Valor para el atributo apellido</param>
        /// <param name="dni">Valor para el atributo dni</param>
        /// <param name="nacionalidad">Valor para el atributo nacionalidad</param>
        /// <param name="claseQueToma">Valor para el atributo claseQueToma</param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma)
            : base(id,nombre,apellido,dni,nacionalidad)
        {
            this.ClaseQueToma = claseQueToma;
        }

        /// <summary>
        /// Constructor de siete parámetros que setea el estado de la cuenta
        /// </summary>
        /// <param name="id">Valor para el atributo legajo</param>
        /// <param name="nombre">Valor para el atributo nombre</param>
        /// <param name="apellido">Valor para el atributo apellido</param>
        /// <param name="dni">Valor para el atributo dni</param>
        /// <param name="nacionalidad">Valor para el atributo nacionalidad</param>
        /// <param name="claseQueToma">Valor para el atributo claseQueToma</param>
        /// <param name="estadoCuenta">Valor para el atributo estadoCuenta</param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta)
            : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.EstadoCuenta = estadoCuenta;
        }

        /// <summary>
        /// Método que retorna los datos del alumno en un string
        /// </summary>
        /// <returns>Retorna un string con todo los datos</returns>
        protected override string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder("");
                                                      
            datos.AppendLine(base.MostrarDatos());  // Muestro apellido, nombre,nacionalidad y legajo
            datos.AppendLine();

            if (this.EstadoCuenta == 0)
            {
                datos.AppendFormat("ESTADO DE CUENTA: Cuenta al día"); // Muestro estado de cuenta
                datos.AppendLine();
            }
            else
            {
                datos.AppendFormat("ESTADO DE CUENTA: {0}",this.EstadoCuenta.ToString()); // Muestro estado de cuenta
                datos.AppendLine();
            }
            datos.AppendLine(this.ParticiparEnClase()); // Muestro clase que toma 

            return datos.ToString();
        }

        /// <summary>
        /// Método que retorna la clase que toma el Alumno en un string
        /// </summary>
        /// <returns>Retorna un string con la clase</returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder clase = new StringBuilder("\nTOMA CLASES DE ");

            clase.Append(this.ClaseQueToma.ToString());

            return clase.ToString();
        }

        /// <summary>
        /// Sobrecarga de método ToString() que retorna todos los datos del objeto
        /// </summary>
        /// <returns>Retorna un string con los datos</returns>
        public override string ToString()
        {
            StringBuilder datos = new StringBuilder("");

            datos.AppendLine(this.MostrarDatos());

            return datos.ToString();
        }

        #endregion

        #region Operadores

        /// <summary>
        /// Sobrecarga de operador distinto que compara un alumno contra una clase
        /// </summary>
        /// <param name="alumno">Alumno para comparar</param>
        /// <param name="clase">Clase para comparar</param>
        /// <returns>Retorna true si la clase que toma el alumno es diferente sino retorna false</returns>
        public static bool operator !=(Alumno alumno, Universidad.EClases clase)
        {
            return alumno.ClaseQueToma != clase ? true : false;
        }

        /// <summary>
        /// Sobrecarga de operador de igualdad que compara un alumno contra una clase
        /// </summary>
        /// <param name="alumno">Alumno a comparar</param>
        /// <param name="clase">Clase a comparar</param>
        /// <returns>Retorna true si el alumno toma la misma clase y su estado no es deudor, sino retorna false</returns>
        public static bool operator ==(Alumno alumno, Universidad.EClases clase)
        {
            if(alumno.ClaseQueToma == clase && alumno.EstadoCuenta != EEstadoCuenta.Deudor)
            {
                return true;
            }
            return false;
        }

        #endregion
    }
}