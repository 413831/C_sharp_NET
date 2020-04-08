using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades_2018
{
    public class Leche : Producto
    {
        /// <summary>
        /// Enumerados de Tipo de Leche
        /// </summary>
        public enum ETipoLeche
        {
            Entera,
            Descremada
        };

        private ETipoLeche tipo;

        /// <summary>
        /// Constructor de Leche con valor por defecto en tipo : entera, utiliza constructor de clase base Producto
        /// </summary>
        /// <param name="marca">Es el valor para el atributo marca</param>
        /// <param name="codigoDeBarras">Es el valor para el atributo codigo de barras</param>
        /// <param name="color">Es el valor para el atributo color</param>
        public Leche(EMarca marca, string codigoDeBarras, ConsoleColor color)
            : base(codigoDeBarras, marca, color)
        {
            this.tipo = ETipoLeche.Entera;
        }

        public Leche(EMarca marca, string codigoDeBarras, ConsoleColor color, ETipoLeche tipoLeche)
            : base(codigoDeBarras, marca, color)
        {
            this.tipo = tipoLeche;
        }

        /// <summary>
        /// Propiedad de sólo lectura, valor por defecto 20
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 20;
            }
        }

        /// <summary>
        /// Método que retorna todos los datos de un objeto Leche
        /// </summary>
        /// <returns>Retorna todos los datos en un string</returns>
        public override string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine("LECHE");
            datos.AppendLine(base.Mostrar());
            datos.AppendLine("");
            datos.AppendFormat("CALORIAS : {0}", this.CantidadCalorias);
            datos.AppendLine("TIPO : " + this.tipo);
            datos.AppendLine("---------------------");

            return datos.ToString();
        }
    }
}
