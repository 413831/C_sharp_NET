using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CajaAhorro : Cuenta
    {
        double interes;
        TipoCuenta tipo;

        public CajaAhorro(int numero, int sucursal, Cliente cliente, double interes, string nombre) : base(nombre,numero, sucursal, cliente)
        {
            this.interes = interes;
            this.tipo = TipoCuenta.CajaAhorro;
        }

        public override bool Depositar(int monto)
        {
            this.saldo += monto;
            return true;
        }

        public override bool Extraer(int monto)
        {
           if(this.saldo > monto)
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
