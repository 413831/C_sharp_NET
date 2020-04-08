using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CuentaCorriente : Cuenta
    {
        double limiteDescubierto;
        TipoCuenta tipo; 

        public CuentaCorriente(int numero, int sucursal, Cliente cliente, double limite, string nombre) : base(nombre, numero, sucursal, cliente)
        {
            this.limiteDescubierto = limite * -1;
            this.tipo = TipoCuenta.CuentaCorriente;
        }

        public override bool Depositar(int monto)
        {
            this.saldo += monto;
            return true;
        }

        public override bool Extraer(int monto)
        {
            if(this.saldo > 0 || (this.saldo - monto) > this.limiteDescubierto)
            {
                this.saldo -= monto;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendFormat("{0}", this.tipo.ToString());
            datos.AppendFormat(" {0}", base.ToString());

            return datos.ToString();
        }
    }
}
