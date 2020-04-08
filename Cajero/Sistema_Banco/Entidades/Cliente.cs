using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private int edad;
        private int dni;
        private string localidad;
        private string idCliente;

        public Cliente(string nombre, string apellido, int edad, int dni, string localidad)
        {
            if(String.IsNullOrEmpty(nombre) || String.IsNullOrEmpty(apellido) || String.IsNullOrEmpty(localidad) ||
                dni.ToString().Length < 8 || edad < 0 || edad > 100)
            {
                throw new InvalidOperationException();
            }

            this.nombre = nombre;
            this.apellido = apellido;
            this.Edad = edad;
            this.Dni = dni;
            this.Localidad = localidad;
        }
        
        public string IdCliente { get => idCliente; set => idCliente = value; }
        public int Dni { get => dni; set => dni= value; }
        public int Edad
        {
            get => edad;
            set
            {
                if(value > 0 && value < 100)
                {
                    edad = value;
                }
            }
        }

        public string Localidad { get => localidad; set => localidad = value; }

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendFormat("Nombre : {0} {1}", this.nombre, this.apellido);
            datos.AppendFormat(" Edad : {0}", this.Edad);
            datos.AppendFormat(" Dni : {0}", this.Dni);
            datos.AppendFormat(" Localidad : {0}", this.Localidad);
            datos.AppendLine();

            return datos.ToString();
        }
    }
}
