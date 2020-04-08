using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    interface IGuardar<T>
    {
        string RutaArchivo { get; set; }

        bool Guardar();

        T Leer();
    }
}
