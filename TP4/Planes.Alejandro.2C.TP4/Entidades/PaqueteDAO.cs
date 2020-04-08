using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public static class PaqueteDAO
    {
        static SqlCommand comando;
        static SqlConnection conexion;

        /// <summary>
        /// Se inserta los datos de un paquete a la base de datos
        /// </summary>
        /// <param name="paquete">Paquete para insertar los datos</param>
        /// <returns>Retorna true siempre y cuando no lance una excepción</returns>
        public static bool Insertar(Paquete paquete)
        {
            StringBuilder consulta = new StringBuilder("INSERT INTO Paquetes VALUES ");

            consulta.AppendFormat("('{0}','{1}','{2}');", paquete.DireccionEntrega, paquete.TrackingID, "Alejandro Planes");

            try
            {
                comando.CommandText = consulta.ToString();
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch(SqlException exception) // Lanzo la excepción
            {
                throw exception; 
            }
            finally
            {
                conexion.Close();
            }
            return true;
        }

        /// <summary>
        /// Constructor estático que inicializa la conexión y el comando de Sql
        /// </summary>
        static PaqueteDAO()
        {
            string configuracionConexion  = @"Data Source= .\SQLEXPRESS;" +
                " Initial Catalog = correo-sp-2018; Integrated Security = True";
            conexion = new SqlConnection(configuracionConexion);
            comando = new SqlCommand();

            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }
    }
}
