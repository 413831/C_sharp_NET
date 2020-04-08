using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Hija : Padre
    {

        public Hija()
        {
            Console.WriteLine("Construido objeto Hijo");
        }

        ~Hija() // Destructor
        {
            Console.WriteLine("Destruido objeto Hijo");
            Console.ReadKey();
        }

        public override string MetodoAbstracto()
        {
            throw new NotImplementedException();
        }

        public int Sumar(int a,int b)
        {
            return a + b;
        }

        public double Sumar(int b, float a)
        {
            return a + b;
        }

        public double Sumar(int b, float a, int c)
        {
            return a + b + c;
        }

        public double Sumar(int b, int c,float a)
        {
            return a + b + c;
        }

        public void MiMetodo()
        {
            base.Método();
            this.Método();
        }

        public static int operator ==(Hija elemento1, Hija elemento2)
        {
            return 1;
        }

        public static int operator !=(Hija elemento1, Hija elemento2)
        {
            return 0;
        }


    }
}
