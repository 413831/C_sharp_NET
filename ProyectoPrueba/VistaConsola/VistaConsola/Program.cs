using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace VistaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Hija objeto = new Hija();
            Abstract abstracto = new Hija();
            ClaseGenericaDos ejemplo = new ClaseGenericaDos();
            Padre papa = new Padre();
            

            papa.eventoMio += Program.Manejador;
            papa.MetodoAbstracto();

            Console.WriteLine("{0,10:#.##}{1,10}", 10.474, 15.355);
            Console.WriteLine(ClaseEstatica<string>.MetodoStatico("Hola soy un método estático"));
            Console.ReadKey();
        }


        public static void Manejador(Object objeto)
        {
            Console.WriteLine("Soy un manejador de eventos");

        }
    }
}
