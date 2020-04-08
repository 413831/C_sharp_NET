using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    public class Dulce : Producto
    {
        /// <summary>
        /// Constructor de Dulce, utiliza constructor de clase base Producto
        /// </summary>
        /// <param name="marca">Es el valor para el atributo marca</param>
        /// <param name="codigoDeBarras">Es el valor para el atributo codigo de barras</param>
        /// <param name="color">Es el valor para el atributo color</param>
        public Dulce(EMarca marca, string codigoDeBarras, ConsoleColor color) : base(codigoDeBarras, marca, color)
        {
        }

        /// <summary>
        /// Propiedad de sólo lectura, valor por defecto 80
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 80;
            }
        }

        /// <summary>
        /// Método que retorna todos los datos de un objeto Dulce
        /// </summary>
        /// <returns>Retorna todos los datos en un string</returns>
        public override string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine("DULCE");
            datos.AppendLine(base.Mostrar());
            datos.AppendLine("");
            datos.AppendFormat("CALORIAS : {0}\n", this.CantidadCalorias);
            datos.AppendLine("---------------------");

            return datos.ToString();
        }
    }
}
