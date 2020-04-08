using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data.SqlClient;

namespace Entidades
{
    public class Paquete : IMostrar<Paquete>
    {
        public delegate void DelegadoEstado(object paquete, EventArgs e); 
        public event DelegadoEstado InformaEstado;

        public delegate void DelegadoEstadoException(object paquete, Exception exception);
        public event DelegadoEstadoException InformaException;

        /// <summary>
        /// Enumerado de estado del paquete
        /// </summary>
        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        };

        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;

        #region Propiedades

        /// <summary>
        /// Propiedad del atributo direccionEntrega
        /// </summary>
        public string DireccionEntrega
        {
            get
            {
                return this.direccionEntrega;
            }
            set
            {
                this.direccionEntrega = value;
            }
        }

        /// <summary>
        /// Propiedad del atributo estado
        /// </summary>
        public EEstado Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }

        /// <summary>
        /// Propiedad de atributo tracking ID
        /// </summary>
        public string TrackingID
        {
            get
            {
                return this.trackingID;
            }
            set
            {
                this.trackingID = value;
            }
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Constructor público que setea los atributos direccionEntrega y trackingId
        /// </summary>
        /// <param name="direccionEntrega">Valor para atributo direccionEntrega</param>
        /// <param name="trackingID">Valor para atributo trackingID</param>
        public Paquete(string direccionEntrega, string trackingID)
        {
            this.DireccionEntrega = direccionEntrega;
            this.TrackingID = trackingID;
            this.Estado = Paquete.EEstado.Ingresado;
        }

        /// <summary>
        /// Método para simular el cambio de estado de un paquete
        /// </summary>
        public void MockCicloDeVida()
        {
            try
            {
                do
                {
                    Thread.Sleep(4000); 
                    this.Estado++; 
                    this.InformaEstado(this, null);

                } while (this.Estado != EEstado.Entregado);

                PaqueteDAO.Insertar(this);
            }
            catch(SqlException exception) // Lanzo otra vez la exception
            {
                this.InformaException(this, exception);
            }
        }

        /// <summary>
        /// Muestra los datos de un paquete
        /// </summary>
        /// <param name="elemento">Paquete para mostrar los datos</param>
        /// <returns>Retorna un string con los datos del elemento</returns>
        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            return String.Format("{0} para {1}\n", ((Paquete)elemento).TrackingID, ((Paquete)elemento).DireccionEntrega);
        }
       
        /// <summary>
        /// Sobrecarga de método ToString() que retorna todos los datos de un objeto Paquete
        /// </summary>
        /// <returns>Se retorna un string con todos los datos del paquete</returns>
        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine(this.MostrarDatos(this));

            return datos.ToString();
        }

        #endregion

        #region Operadores

        /// <summary>
        /// Sobrecarga del operador distinto que compara los tracking ID de dos paquetes
        /// </summary>
        /// <param name="paqueteUno">Primer paquete para comparar</param>
        /// <param name="paqueteDos">Segundo paquete para comparar</param>
        /// <returns>Retorna true si los paquetes son diferentes sino retorna false</returns>
        public static bool operator !=(Paquete paqueteUno, Paquete paqueteDos)
        {
            return !(paqueteUno == paqueteDos);
        }

        /// <summary>
        /// Sobrecarga del operador igual que compara los tracking ID de dos paquetes
        /// </summary>
        /// <param name="paqueteUno">Primer paquete para comparar</param>
        /// <param name="paqueteDos">Segundo paquete para comparar</param>
        /// <returns>Retorna true si los paquetes son iguales sino retorna false</returns>
        public static bool operator ==(Paquete paqueteUno, Paquete paqueteDos)
        {
            if(paqueteUno.TrackingID == paqueteDos.TrackingID)
            {
                return true;
            }
            return false;
        }

        #endregion

    }
}
