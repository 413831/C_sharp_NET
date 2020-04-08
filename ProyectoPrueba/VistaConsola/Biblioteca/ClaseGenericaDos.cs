using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ClaseGenericaDos : ClaseGenericaUno<int> // La clase genérica debe definir el tipo
    {
        // La clase hereda los metodos genericos por eso mismo es necesario definir el tipo en la clase concreta
        public ClaseGenericaDos()
        {

        }
    }
}
