using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico = null;
        private List<Jugador> jugadores;
        private string nombre;

        #region Propiedades

        /// <summary>
        /// Propiedad de solo escritura que setea un director técnico si no es null y si es apto
        /// </summary>
        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if(value != null && value.ValidarAptitud())
                {
                    this.DirectorTecnico = value;
                }
            }
        }

        /// <summary>
        /// Propiedad de solo lectura que devuelve el nombre del Equipo
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
        /// Constructor privado donde se instancia el listado de jugadores
        /// </summary>
        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        /// <summary>
        /// Constructor público del Equipo
        /// </summary>
        /// <param name="nombre">valor del atributo nombre</param>
        public Equipo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        /// <summary>
        /// Valida si un equipo tiene una cantidad coherente de jugadores
        /// </summary>
        /// <param name="equipo">Equipo para validar</param>
        /// <returns>Retorna true si es válido sino retorna false</returns>
        public static bool ValidarEquipo(Equipo equipo)
        {
            int arquero = 0;
            int defensor = 0;
            int central = 0;
            int delantero = 0;

            //Corregir lo del DT
            foreach (Jugador jugador in equipo.jugadores)
            {
                switch(jugador.Posicion)
                {
                    case Posicion.Arquero :
                        arquero++;
                        break;
                    case Posicion.Defensor :
                        defensor++;
                        break;
                    case Posicion.Central :
                        central++;
                        break;
                    case Posicion.Delantero :
                        delantero++;
                        break;
                }
            }

            if(arquero == 1 && defensor > 1 && central > 1 && delantero > 1 && 
                equipo.jugadores.Count == Equipo.cantidadMaximaJugadores && equipo.directorTecnico != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region Operadores

        /// <summary>
        /// Operador que devuelve un string con todos los datos de un Equipo
        /// </summary>
        /// <param name="equipo">Equipo para mostrar los datos</param>
        public static explicit operator string(Equipo equipo)
        {
            StringBuilder datos = new StringBuilder("");

            if (equipo.directorTecnico == null)
            {
                datos.AppendLine("Sin DT asignado");
            }
            else
            {
                datos.AppendLine(equipo.directorTecnico.Mostrar());
            }

            foreach(Jugador jugador in equipo.jugadores)
            {
                if(jugador != null)
                {
                    datos.AppendLine(jugador.Mostrar());
                }
            }
            return datos.ToString();
        }

        /// <summary>
        /// Operador que verifica si existe un jugador en el equipo
        /// </summary>
        /// <param name="equipo">Equipo para buscar el jugador</param>
        /// <param name="jugador">Jugador a buscar en el equipo</param>
        /// <returns></returns>
        public static bool operator !=(Equipo equipo, Jugador jugador)
        {
            return !(equipo == jugador);
        }

        public static bool operator ==(Equipo equipo, Jugador jugador)
        {
            return equipo.jugadores.Contains(jugador);
        }

        /// <summary>
        /// Operador para agregar un Jugador al Equipo
        /// </summary>
        /// <param name="equipo">Equipo donde se agrega el jugador</param>
        /// <param name="jugador">Jugador para agregar al equipo</param>
        /// <returns></returns>
        public static Equipo operator +(Equipo equipo, Jugador jugador)
        {
            if(equipo != jugador && equipo.jugadores.Count < Equipo.cantidadMaximaJugadores &&
                jugador.ValidarAptitud())
            {
                equipo.jugadores.Add(jugador);
                return equipo;
            }
            else
            {
                return equipo;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj != null || this.GetType() != obj.GetType())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return Tuple.Create(cantidadMaximaJugadores, directorTecnico, jugadores, nombre).GetHashCode();
        }

        #endregion
    }
}
