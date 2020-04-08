using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    /// <summary>
    /// La clase Producto no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Producto
    {
        public enum EMarca
        {
            Serenisima,
            Campagnola,
            Arcor,
            Ilolay,
            Sancor,
            Pepsico
        };

        private EMarca marca;
        private string codigoDeBarras;
        private ConsoleColor colorPrimarioEmpaque;

        /// <summary>
        /// Constructor de Producto
        /// </summary>
        /// <param name="codigoDeBarras">Es el valor para el atributo codigo de barras</param>
        /// <param name="marca">Es el valor para el atributo marca</param>
        /// <param name="color">Es el valor para el atributo color</param>
        protected Producto(string codigoDeBarras, EMarca marca, ConsoleColor color)
        {
            this.codigoDeBarras = codigoDeBarras;
            this.marca = marca;
            this.colorPrimarioEmpaque = color;
        }

        /// <summary>
        /// Propiedad que retornará la cantidad de calorías
        /// </summary>
        protected abstract short CantidadCalorias { get; }
        
        /// <summary>
        /// Publica todos los datos del Producto.
        /// </summary>
        /// <returns>Retorna los datos en un string</returns>
        public virtual string Mostrar()
        {
            return (string)(this);
        }

        /// <summary>
        /// Retorna todos los datos del producto en un solo string
        /// </summary>
        /// <param name="producto">Producto para tomar los datos</param>
        /// <returns></returns>
        public static explicit operator string(Producto producto)
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendFormat("CODIGO DE BARRAS: {0}\r\n", producto.codigoDeBarras);
            datos.AppendFormat("MARCA          : {0}\r\n", producto.marca.ToString());
            datos.AppendFormat("COLOR EMPAQUE  : {0}\r\n", producto.colorPrimarioEmpaque.ToString());
            datos.AppendLine("---------------------");

            return datos.ToString();
        }

        /// <summary>
        /// Dos productos son iguales si comparten el mismo código de barras
        /// </summary>
        /// <param name="productoUno">Primer producto a comparar</param>
        /// <param name="productoDos">Segundo producto a comparar</param>
        /// <returns>Retorna true si son iguales</returns>
        public static bool operator ==(Producto productoUno, Producto productoDos)
        {
            return (productoUno.codigoDeBarras == productoDos.codigoDeBarras);
        }
        /// <summary>
        /// Dos productos son distintos si su código de barras es distinto
        /// </summary>
        /// <param name="productoUno">Primer producto a comparar</param>
        /// <param name="productoDos">Segundo producto a comparar</param>
        /// <returns>Retorna true si son diferentes</returns>
        public static bool operator !=(Producto productoUno, Producto productoDos)
        {
            return (productoUno.codigoDeBarras == productoDos.codigoDeBarras);
        }
    }
}
