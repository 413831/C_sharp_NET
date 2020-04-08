using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum TipoCuenta
    {
        CajaAhorro,
        CuentaCorriente
    }

    public delegate bool Criterio(Cuenta cuenta);
    public delegate bool Filtro(Cliente cliente);

    public class Banco
    {
        private static int idCuenta;
        public string nombre;
        public int sucursal;
        public string direccion;
        private double interesAhorro;
        private double limiteDescubierto;
        private List<Cuenta> cuentas;
        private List<Cliente> clientes;

        public List<Cuenta> Cuentas { get => cuentas; set => cuentas = value; }
        public List<Cliente> Clientes { get => clientes; set => clientes = value; }

        public Banco(string nombre, int sucursal, string direccion, double interes, double limite)
        {
            this.nombre = nombre;
            this.sucursal = sucursal;
            this.direccion = direccion;
            this.Cuentas = new List<Cuenta>();
            this.Clientes = new List<Cliente>();
            this.interesAhorro = interes;
            this.limiteDescubierto = limite;
            idCuenta = 10000;
        }
        
        public bool AltaCliente(Cliente cliente)
        {
            if(this.Clientes.Find(x => x.Dni == cliente.Dni) != null)
            {
                return false;
            }
            cliente.IdCliente = this.sucursal + cliente.Dni.ToString() + cliente.Localidad; 
            this.Clientes.Add(cliente);

            return true;
        }

        public Cuenta AltaCuenta(Cliente cliente,TipoCuenta tipoCuenta)
        {
           // Alta de cuenta
            if(BuscarCliente(cliente.IdCliente))
            {
                idCuenta++;
                switch (tipoCuenta)
                {
                    case TipoCuenta.CajaAhorro:
                        CajaAhorro cajaAhorro = new CajaAhorro(idCuenta, this.sucursal, cliente, this.interesAhorro, this.nombre);
                        this.Cuentas.Add(cajaAhorro);
                        return cajaAhorro;
                    case TipoCuenta.CuentaCorriente:
                        CuentaCorriente cuentaCorriente = new CuentaCorriente(idCuenta, this.sucursal, cliente, this.limiteDescubierto, this.nombre);
                        this.Cuentas.Add(cuentaCorriente);
                        return cuentaCorriente;
                }
            }
            return null;
        }

        public bool BajaCuenta(int idCuenta)
        {
            Cuenta cuenta = this.Cuentas.Find(x => x.Numero == idCuenta);
            // Baja de cuenta
            if (cuenta != null)
            {
                this.Cuentas.Remove(cuenta);
                return true;
            }
            return false;
        }

        public string MostrarCuentas(Criterio funcionCriterio)
        {
            StringBuilder datosCuentas = new StringBuilder();

            foreach(Cuenta cuenta in this.Cuentas)
            {
                if(funcionCriterio(cuenta))
                {
                    datosCuentas.AppendLine(cuenta.ToString());
                }
            }
            return datosCuentas.ToString();
        }

        public string MostrarClientes(Filtro funcionCriterio)
        {
            StringBuilder datosClientes = new StringBuilder();

            foreach (Cliente cliente in this.Clientes)
            {
                if (funcionCriterio(cliente))
                {
                    datosClientes.AppendLine(cliente.ToString());
                }
            }
            return datosClientes.ToString();
        }

        public bool CuentasActivas(Cuenta cuenta)
        {
            if(cuenta.Estado == Estado.Activa)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CuentasInactivas(Cuenta cuenta)
        {
            if (cuenta.Estado == Estado.Inactiva)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CuentasDeudores(Cuenta cuenta)
        {
            if (cuenta.Estado == Estado.Deudor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool BuscarCliente(string idCliente)
        {
            foreach(Cliente cliente in this.Clientes)
            {
                if(cliente.IdCliente == idCliente)
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendFormat("{0} {1} {2}", this.nombre, this.sucursal, this.direccion);

            return datos.ToString();
        }
    }
}
