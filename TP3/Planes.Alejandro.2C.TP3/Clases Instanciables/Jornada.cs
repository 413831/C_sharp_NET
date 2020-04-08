using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;
using System.IO;

namespace Clases_Instanciables
{
    public class Jornada 
    {
        private List<Alumno> alumnos;
        private Universidad.EClases clase; 
        private Profesor instructor;

        #region Propiedades

        /// <summary>
        /// Propiedad para el atributo alumnos
        /// </summary>
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

        /// <summary>
        /// Propiedad para atributo clase
        /// </summary>
        public Universidad.EClases Clase
        {
            get
            {
                return this.clase;
            }
            set
            {
                this.clase = value;
            }
        }

        /// <summary>
        /// Propiedad para atributo instructor
        /// </summary>
        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;
            }
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Constructor privado que setea la lista de alumnos
        /// </summary>
        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }

        /// <summary>
        /// Constructor público que setea los atributos clase e instructor
        /// </summary>
        /// <param name="clase">Valor para el atributo clase</param>
        /// <param name="instructor">Valor para el atributo instructor</param>
        public Jornada(Universidad.EClases clase, Profesor instructor)
        : this()
        {
            this.clase = clase;
            this.instructor = instructor;
        }

        /// <summary>
        /// Método para guardar una Jornada en un archivo de texto
        /// </summary>
        /// <param name="jornada">Objeto para guardar en un archivo</param>
        /// <returns>Retorna true si logra guardar sino retorna false</returns>
        public static bool Guardar(Jornada jornada)
        {
            Texto archivo = new Texto();

            try
            {
                archivo.Guardar("Jornada.txt",jornada.ToString());
                return true;
            }
            catch (ArchivosException exception)
            {
                return false;
                throw exception;
            }
            catch (NullReferenceException exception)
            {
                return false;
                throw new ArchivosException(exception);
            }
            catch(ArgumentException e)
            {
                return false;
                throw new ArchivosException(e);
            }
            catch(Exception exception)
            {
                return false;
                throw new ArchivosException(exception);
            }
        }

        /// <summary>
        /// Método para leer datos de una Jornada de un archivo de texto
        /// </summary>
        /// <returns>Retorna los datos en un string</returns>
        public string Leer()
        {
            Texto archivo = new Texto();
            String datosArchivo;

            try
            {
                archivo.Leer("Jornada.txt", out datosArchivo);
                return datosArchivo;
            }
            catch (ArchivosException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Sobrecarga de método ToString() que retorna todos los datos de una Jornada en un string
        /// </summary>
        /// <returns>Retorna un string con todos los datos</returns>
        public override string ToString()
        {
            StringBuilder datos = new StringBuilder("");

            datos.AppendFormat("CLASE DE {0} ",this.Clase);
            datos.AppendFormat("POR {0}",this.instructor.ToString());
            datos.AppendLine("ALUMNOS:");

            foreach(Alumno alumno in this.Alumnos)
            {
                datos.AppendLine(alumno.ToString());
            }
            return datos.ToString();
        }

        #endregion

        #region Operadores

        /// <summary>
        /// Sobrecarga de operador de distinto entre jornada y alumno
        /// </summary>
        /// <param name="jornada">Jornada para comparar</param>
        /// <param name="alumno">Alumno para comparar</param>
        /// <returns>Retorna true si el alumno no coincide con la clase de la jornada sino retorna false</returns>
        public static bool operator !=(Jornada jornada, Alumno alumno)
        {
            return !(jornada == alumno);
        }

        /// <summary>
        /// Sobrecarga de operador de igualdad entre jornada y alumno
        /// </summary>
        /// <param name="jornada">Jornada para comparar</param>
        /// <param name="alumno">Alumno para comparar</param>
        /// <returns>Retorna true si el alumno coincide con la clase sino retorna false</returns>
        public static bool operator ==(Jornada jornada, Alumno alumno)
        {
            foreach(Alumno auxiliarAlumno in jornada.Alumnos)
            {
                if(auxiliarAlumno == alumno)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del operador de suma para agregar un alumno a la jornada
        /// </summary>
        /// <param name="jornada">Jornada para agregar alumno</param>
        /// <param name="alumno">Alumno para agregar</param>
        /// <returns>Retorna el objeto jornada con el alumno agregado de no estar en el listado de alumnos</returns>
        public static Jornada operator +(Jornada jornada, Alumno alumno)
        {
            if(jornada != alumno)
            {
               jornada.alumnos.Add(alumno);
            }
            return jornada;
        }

        #endregion
    }
}