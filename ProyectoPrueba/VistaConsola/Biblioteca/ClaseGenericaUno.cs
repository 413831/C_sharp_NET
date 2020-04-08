using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class ClaseGenericaUno<T> : Abstract, InterfaceDos // Heredo una clase abstracta e implemento una interfaz
    {
        void Swap<T>(List<T> list1, List<T> list2) // Método con parámetros genéricos abiertos
        {
            //code to swap items
        }
        // Se considera una sobrecarga de metodo
        void Swap(List<int> list1, List<int> list2) // Método con parámetros genéricos cerrados
        {
            //code to swap items
        }

        public override string MetodoAbstracto() // Implementación de método de clase abstracta padre
        {
            return "String";
        }

        public int MetodoNoAbstracto() // Método NO abstracto
        {
            this.Abrir(); // Heredo implementación implícita del método de la interfaz de la clase abstracta
            return 0;
        }

        string InterfaceDos.Comer() // Implementacion explicita de InterfaceDos
        {
            return "";
        }

        public string Dormir()
        {
            return "";
        }

    }
}
