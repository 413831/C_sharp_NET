using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Abstract : InterfazUno // Clase abstracta implementa interfaz
    {
        public int Abrir() // Implementacion implicita
        {
            throw new NotImplementedException();
        }

        int InterfazUno.Cerrar() // Implementacion explicita
        {
            throw new NotImplementedException();
        }

        public abstract string MetodoAbstracto();

        public string Saludar()
        {
            return "Hola";
        }

    }
}
