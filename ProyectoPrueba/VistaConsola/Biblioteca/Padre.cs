using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public delegate void Delegado(Object objeto);

    public class Padre : Abstract
    {
        int edad;
        Queue<Hija> hijos;
        Queue cola;

        public event Delegado eventoMio;

        public Padre()
        {
            Console.WriteLine("Construido objeto Padre");
            
        }

        public Padre(int edad) // Constructor
        {
            this.edad = edad;
        }

        ~Padre() // Destructor
        {
            Console.WriteLine("Destruido objeto Padre");
            Console.ReadKey();
        }

        public override string MetodoAbstracto()
        {
            this.eventoMio(1000);
            return "MetodoAbstracto";
        }

        protected void Método()
        {
        }
    }
}
