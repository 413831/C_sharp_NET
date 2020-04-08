using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Estado
    {
        Activa,
        Inactiva,
        Deudor
    }

    public abstract class Cuenta
    {
        protected string nombreBanco;
        protected int numero;
        protected int sucursal;
        protected double saldo;
        protected Estado estado;
        protected Cliente cliente;

        public Cuenta(string nombreBanco,int numero, int sucursal, Cliente cliente)
        {
            this.nombreBanco = nombreBanco;
            this.numero = numero;
            this.sucursal = sucursal;
            this.Cliente = cliente;
            this.saldo = 0;
            this.Estado = Estado.Activa;
        }

        public int Numero { get => numero ; set => numero = value; }

        public Estado Estado { get => estado; set => estado = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }

        public abstract bool Depositar(int monto);

        public abstract bool Extraer(int monto);
        
        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendFormat("Banco : {0}", this.nombreBanco);
            datos.AppendFormat(" N°: {0}", this.numero);
            datos.AppendFormat(" Sucursal: {0}", this.sucursal);
            datos.AppendFormat(" Saldo : ${0}", this.saldo);
            datos.AppendFormat(" Estado : {0}", this.Estado);

            return datos.ToString();
        }
    }
}
