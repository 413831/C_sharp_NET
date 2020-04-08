using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mi central
            Centralita central = new Centralita("Fede Center");
            // Mis 4 llamadas
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);
            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            Simulador simulador = new Simulador(central);
            Thread asignarLlamadas = new Thread(simulador.AgregarLlamada);

            simulador.Llamadas.Add(l1);
            simulador.Llamadas.Add(l2);
            simulador.Llamadas.Add(l3);
            simulador.Llamadas.Add(l4);

            asignarLlamadas.Start();

            try
            { 
                //Revisar todo esto
                Console.WriteLine(simulador.Central.ToString());
                simulador.Central.OrdenarLlamadas();
                Console.WriteLine(simulador.Central.ToString());
                Console.WriteLine(simulador.Central.Leer());
            }            catch(CentralitaException exception)            {
                Console.Write(exception.Message);
            }            Console.ReadKey();
        }
    }
}
