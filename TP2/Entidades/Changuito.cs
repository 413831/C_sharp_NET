using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    /// <summary>
    /// Clase sellada. No podrá tener clases heredadas.
    /// </summary>
    public sealed class Changuito
    {
        private List<Producto> productos;
        private int espacioDisponible;

        public enum ETipoProducto
        {
            Dulce,
            Leche,
            Snacks,
            Todos
        };

        #region "Constructores"

        /// <summary>
        /// Constructor privado de Changuito, se inicializa la lista de productos
        /// </summary>
        private Changuito()
        {
            this.productos = new List<Producto>();
        }

        /// <summary>
        /// Constructor público de Changuito, se inicializa atributo de espacioDisponible
        /// </summary>
        /// <param name="espacioDisponible"></param>
        public Changuito(int espacioDisponible) : this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestro los datos de Changuito y todos los productos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Changuito.Mostrar(this, ETipoProducto.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="changuito">Elemento a exponer</param>
        /// <param name="tipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public static string Mostrar(Changuito changuito, ETipoProducto tipo)
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", changuito.productos.Count, changuito.espacioDisponible);
            datos.AppendLine("");
            foreach (Producto auxiliarProducto in changuito.productos)
            {
                switch (tipo)
                {
                    case ETipoProducto.Snacks:
                        if(auxiliarProducto is Snacks)
                        {
                            datos.AppendLine(auxiliarProducto.Mostrar());
                        }
                        break;
                    case ETipoProducto.Dulce:
                        if (auxiliarProducto is Dulce)
                        {
                            datos.AppendLine(auxiliarProducto.Mostrar());
                        }
                        break;
                    case ETipoProducto.Leche:
                        if (auxiliarProducto is Leche)
                        {
                            datos.AppendLine(auxiliarProducto.Mostrar());
                        }
                        break;
                    default:
                        datos.AppendLine(auxiliarProducto.Mostrar());
                        break;
                }
            }

            return datos.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="changuito">Objeto donde se agregará el elemento</param>
        /// <param name="producto">Objeto a agregar</param>
        /// <returns>Retorna el changuito</returns>
        public static Changuito operator +(Changuito changuito, Producto producto)
        {
            foreach (Producto auxiliarProducto in changuito.productos)
            {
                if (auxiliarProducto == producto)
                {
                    return changuito;
                }
            }

            if(changuito.productos.Count < changuito.espacioDisponible)
            {
                changuito.productos.Add(producto);
            }

            return changuito;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="changuito">Objeto donde se quitará el elemento</param>
        /// <param name="producto">Objeto a quitar</param>
        /// <returns>Retorna el changuito</returns>
        public static Changuito operator -(Changuito changuito, Producto producto)
        {
            foreach (Producto auxiliarProducto in changuito.productos)
            {
                if (auxiliarProducto == producto)
                {
                    changuito.productos.Remove(auxiliarProducto);
                    break;
                }
            }

            return changuito;
        }
        #endregion
    }
}
