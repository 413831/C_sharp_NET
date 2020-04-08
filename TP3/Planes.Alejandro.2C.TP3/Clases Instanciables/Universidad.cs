using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;

namespace Clases_Instanciables
{
    [Serializable]
    public class Universidad
    {
        /// <summary>
        /// Enumerado de clases
        /// </summary>
        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        };

        private List<Alumno> alumnos;
        private List<Jornada> jornadas;
        private List<Profesor> profesores;

        #region Propiedades

        /// <summary>
        /// Propiedad para listado de alumnos
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
        /// Propiedad para listado de instructores
        /// </summary>        
        public List<Profesor> Instructores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = value;
            }
        }

        /// <summary>
        /// Propiedad para listado de jornadas
        /// </summary>
        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornadas;
            }
            set
            {
                this.jornadas = value;
            }
        }

        /// <summary>
        /// Propiedad para retornar una jornada de la universidad
        /// </summary>
        /// <param name="i">Indexador</param>
        /// <returns>Retorna la jornadad del índice indicado sino retorna null</returns>
        public Jornada this[int i]
        {
            get
            {
                if(i >= 0 && i < this.Jornadas.Count)
                {
                    return this.Jornadas[i];
                }
                return null;
            }
            set
            {
                if (i >= 0 && i < this.Jornadas.Count)
                {
                    this.Jornadas[i] = value;
                }
                else if(i == this.Jornadas.Count)
                {
                    this.Jornadas.Add(value);
                }
            }
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Constructor público que inicializa los listados
        /// </summary>
        public Universidad()
        {
            this.Alumnos = new List<Alumno>();
            this.Instructores = new List<Profesor>();
            this.Jornadas = new List<Jornada>();
        }

        /// <summary>
        /// Método estático para guardar los datos de una universidad en un archivo XML
        /// </summary>
        /// <param name="universidad">Objeto para guardar los datos</param>
        /// <returns>Retorna true si logra guardar sino retorna false</returns>
        public static bool Guardar(Universidad universidad)
        {
            Xml<Universidad> exportarXml = new Xml<Universidad>();

            if(exportarXml.Guardar("Universidad.xml", universidad))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método estático para leer los datos de un archivo XML
        /// </summary>
        /// <param name="archivo">Nombre del archivo para leer los datos</param>
        /// <param name="datos">Objeto para guardar los datos leídos</param>
        /// <returns>Retorna true si logra leer los datos sino retorna false</returns>
        public static bool Leer(string archivo, out Universidad datos)
        {
            Xml<Universidad> importarXml = new Xml<Universidad>();

            if (importarXml.Leer(archivo,out datos))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método privado estático que retorna todos los datos de una Universidad en un string
        /// </summary>
        /// <param name="universidad">Objeto del que se retornarán los datos</param>
        /// <returns>Retorna un string con todos los datos</returns>
        private static string MostrarDatos(Universidad universidad)
        {
            StringBuilder datos = new StringBuilder("");

            foreach (Jornada jornada in universidad.Jornadas)
            {
                datos.AppendFormat("JORNADA: \n{0}",jornada.ToString());

                datos.AppendFormat("<---------------------------------------->\n");
            }
            return datos.ToString();        
        }

        /// <summary>
        /// Sobrecarga de método ToString() que retorna los datos del objeto actual en un string
        /// </summary>
        /// <returns>Retorna los datos de la instancia en un string</returns>
        public override string ToString()
        {
            return Universidad.MostrarDatos(this);
        }

        #endregion

        #region Operadores

        /// <summary>
        /// Sobrecarga de operador distinto entre universidad y alumno
        /// </summary>
        /// <param name="universidad">Universidad para comparar</param>
        /// <param name="alumno">Alumno para comparar</param>
        /// <returns>Retorna true si la universidad no tiene inscripto al alumno sino retorna false</returns>
        public static bool operator !=(Universidad universidad, Alumno alumno)
        {
            return !(universidad == alumno);
        }

        /// <summary>
        /// Sobrecarga de operador distinto entre universidad y profesor
        /// </summary>
        /// <param name="universidad">Universidad para comparar</param>
        /// <param name="alumno">Profesor para comparar</param>
        /// <returns>Retorna true si la universidad no tiene asignado al profesor sino retorna false</returns>
        public static bool operator !=(Universidad universidad, Profesor profesor)
        {
            return !(universidad == profesor);
        }

        /// <summary>
        /// Sobrecarga de operador de distinto entre universidad y clase
        /// </summary>
        /// <param name="universidad">Universidad para comparar</param>
        /// <param name="clase">Clase para comparar</param>
        /// <returns>Retorna un profesor que no coincida con la clase sino lanza una excepcion de tipo SinProfesorException</returns>
        public static Profesor operator !=(Universidad universidad, EClases clase)
        {
            foreach(Profesor profesor in universidad.Instructores)
            {
                if(profesor != clase)
                {
                    return profesor;
                }
            }
            throw new SinProfesorException();
        }

        /// <summary>
        /// Sobrecarga de operador de igualdad entre universidad y alumno
        /// </summary>
        /// <param name="universidad">Universidad para comparar</param>
        /// <param name="alumno">Alumno para comparar</param>
        /// <returns>Retorna true si la universidad tiene inscripto al alumno sino retorna false</returns>
        public static bool operator ==(Universidad universidad, Alumno alumno)
        {
            foreach(Alumno auxiliarAlumno in universidad.Alumnos)
            {
                if(auxiliarAlumno == alumno)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga de operador de igualdad entre universidad y profesor
        /// </summary>
        /// <param name="universidad">Universidad para comparar</param>
        /// <param name="alumno">Profesor para comparar</param>
        /// <returns>Retorna true si la universidad tiene asignado al profesor sino retorna false</returns>
        public static bool operator ==(Universidad universidad, Profesor profesor)
        {
            foreach(Profesor auxiliarProfesor in universidad.Instructores)
            {
                if(auxiliarProfesor == profesor)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga de operador de igualdad entre universidad y clase
        /// </summary>
        /// <param name="universidad">Universidad para comparar</param>
        /// <param name="clase">Clase para comparar</param>
        /// <returns>Retorna un profesor que coincida con la clase sino lanza una excepcion de tipo SinProfesorException</returns>
        public static Profesor operator ==(Universidad universidad, EClases clase)
        {
            foreach(Profesor profesor in universidad.Instructores)
            {
                if(profesor == clase)
                {
                    return profesor;
                }
            }
            throw new SinProfesorException();
        }

        /// <summary>
        /// Sobrecarga de operador suma entre Universidad y Clase
        /// </summary>
        /// <param name="universidad">Universidad para agregar clase</param>
        /// <param name="clase">Clase para agregar en universidad</param>
        /// <returns></returns>
        public static Universidad operator +(Universidad universidad, EClases clase)
        {
            Jornada jornada;
            Profesor profesor;

            try
            {
                profesor = universidad == clase;// Busco 1 profesor que tenga esa clase en su listado

                if (!Object.Equals(profesor,null)) 
                {
                    jornada = new Jornada(clase,profesor); //Asigno el profesor a la jornada

                    foreach(Alumno alumno in universidad.Alumnos) // Busco todos los alumnos inscriptos en la clase
                    {
                        if(alumno == clase) 
                        {
                            jornada += alumno; // Agrego a cada alumno que tenga esa clase asignada
                        }
                    }
                    universidad.Jornadas.Add(jornada); // Agrego la nueva jornada al listado de la Universidad
                }
                else
                {
                    throw new SinProfesorException();
                }
                return universidad;
            }
            catch(SinProfesorException exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Sobrecarga de operador suma entre universidad y alumno
        /// </summary>
        /// <param name="universidad">Universidad para agregar alumno</param>
        /// <param name="alumno">Alumno para agregar en universidad</param>
        /// <returns>Retorna la universidad con el alumno agregado</returns>
        public static Universidad operator +(Universidad universidad, Alumno alumno)
        {
            if(universidad != alumno)
            {
                universidad.Alumnos.Add(alumno);
            }
            else
            {
                throw new AlumnoRepetidoException();
            }
            return universidad;
        }

        /// <summary>
        /// Sobrecarga de operador suma entre universidad y profesor
        /// </summary>
        /// <param name="universidad">Universidad para agregar profesor</param>
        /// <param name="profesor">Profesor para agregar en universidad</param>
        /// <returns>Retorna la universidad con el profesor agregado</returns>
        public static Universidad operator +(Universidad universidad, Profesor profesor)
        {
            if(universidad != profesor)
            {
                universidad.Instructores.Add(profesor);
            }
            return universidad;
        }

        #endregion
    }
}