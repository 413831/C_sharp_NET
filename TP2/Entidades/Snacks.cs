using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    public class Snacks : Producto
    {
        /// <summary>
        /// Constructor de Snacks, utiliza constructor de clase base Producto
        /// </summary>
        /// <param name="marca">Es el valor para el atributo marca</param>
        /// <param name="codigoDeBarras">Es el valor para el atributo codigo de barras</param>
        /// <param name="color">Es el valor para el atributo color</param>
        public Snacks(EMarca marca, string codigoDeBarras, ConsoleColor color)
            : base(codigoDeBarras, marca, color)
        {
        }
        /// <summary>
        /// Propiedad de sólo lectura, valor por defecto 104
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 104;
            }
        }

        public override string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine("SNACKS");
            datos.AppendLine(base.Mostrar());
            datos.AppendLine("");
            datos.AppendFormat("CALORIAS : {0}\n", this.CantidadCalorias);
            datos.AppendLine("---------------------");

            return datos.ToString();
        }
    }
}
