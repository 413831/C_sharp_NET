using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace VistaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco bancoPatagonia = new Banco("Patagonia", 0023, "Av.Cordoba 5234", 5.0, 10000);
            if (bancoPatagonia.AltaCliente("Pedrito", "Gonzalez", 26, 34123123, "CABA"))
            {
                Console.WriteLine("Alta Realizada");
            }
            else
            {
                Console.WriteLine("No se pudo realizar el alta");
            }

            if (bancoPatagonia.AltaCliente("Pepito", "Gomez", 31, 34111111, "CABA"))
            {
                Console.WriteLine("Alta Realizada");
            }
            else
            {
                Console.WriteLine("No se pudo realizar el alta");
            }

            if (bancoPatagonia.AltaCliente("Pepito", "Gomez", 31, 34111111, "CABA"))
            {
                Console.WriteLine("Alta Realizada");
            }
            else
            {
                Console.WriteLine("No se pudo realizar el alta");
            }

            if (bancoPatagonia.AltaCliente("Juancita", "Laprida", 22, 41123456, "La Matanza"))
            {
                Console.WriteLine("Alta Realizada");
            }
            else
            {
                Console.WriteLine("No se pudo realizar el alta");
            }
            Console.ReadKey();
        }
    }
}
