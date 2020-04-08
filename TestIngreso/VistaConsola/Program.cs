using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace VistaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = "hola, que buena ola Laomir";
            string B = "oal";

            Console.Write("La palabra {0} se aparece {1} veces",B,Anagrama.Solution(A, B));
            Console.ReadKey();
        }
    }
}
