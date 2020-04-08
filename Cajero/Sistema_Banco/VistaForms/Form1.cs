using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForms
{
    public partial class Form1 : Form
    {
        public List<Banco> bancos;
        public List<Cliente> clientes;
        public List<Cuenta> cuentas;
        

        public Form1()
        {
            InitializeComponent();
            this.bancos = new List<Banco>();
            this.clientes = new List<Cliente>();
            this.cuentas = new List<Cuenta>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        
        private void btnAltaBanco_Click(object sender, EventArgs e)
        {
            try
            {
                Banco nuevoBanco = new Banco(this.txtNombreBanco.Text, Convert.ToInt32(this.txtBancoSucursal.Text),
                                            this.txtBancoDireccion.Text,Convert.ToDouble(this.txtInteresBanco.Text),
                                            Convert.ToDouble(this.txtBancoLimite.Text));
                this.bancos.Add(nuevoBanco);
                this.listBancos.Items.Add(nuevoBanco);
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message + exception.StackTrace.ToString());
            }
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Banco banco = this.bancos.Find(x => x.nombre == ((Banco)this.listBancos.SelectedItem).nombre &&
                                        x.sucursal == ((Banco)this.listBancos.SelectedItem).sucursal);
                Cliente cliente = new Cliente(this.txtNombreCliente.Text, this.txtApellido.Text,Convert.ToInt32(this.txtEdad.Text),
                                               Convert.ToInt32(this.txtDniCliente.Text), this.txtLocalidad.Text);
                if (banco.AltaCliente(cliente))
                {
                    this.bancos[this.bancos.IndexOf(banco)] = banco;
                    this.listClientes.Items.Add(cliente);
                    this.clientes.Add(cliente);
                }

            }
            catch(Exception)
            {
                MessageBox.Show("Complete todos los campos y seleccione un campo de la lista");
            }
        }


        private void chkCuentaCorriente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listClientes_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                Banco banco = this.bancos.Find(x => x.nombre == ((Banco)this.listBancos.SelectedItem).nombre &&
                                            x.sucursal == ((Banco)this.listBancos.SelectedItem).sucursal);
                List<Cuenta> lista = banco.Cuentas.FindAll(x => x.Cliente == ((Cliente)this.listClientes.SelectedItem));
                this.listCuentas.Items.Clear();
                foreach(Cuenta cuenta in lista)
                {
                    this.listCuentas.Items.Add(cuenta);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Seleccione un banco y un cliente");
            }
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                Banco banco = this.bancos.Find(x => x.nombre == ((Banco)this.listBancos.SelectedItem).nombre &&
                                                x.sucursal == ((Banco)this.listBancos.SelectedItem).sucursal);
                Cliente cliente = this.clientes.Find(x => x.IdCliente == ((Cliente)this.listClientes.SelectedItem).IdCliente);


                Cuenta cuenta = banco.AltaCuenta(cliente, TipoCuenta.CuentaCorriente);
                this.bancos[this.bancos.IndexOf(banco)] = banco;
                this.listCuentas.Items.Add(cuenta);
                this.cuentas.Add(cuenta);
            }
            catch(Exception)
            {
                MessageBox.Show("Seleccione una cuenta");
            }
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            try
            {
                Banco banco = this.bancos.Find(x => x.nombre == ((Banco)this.listBancos.SelectedItem).nombre &&
                                               x.sucursal == ((Banco)this.listBancos.SelectedItem).sucursal);
                Cliente cliente = this.clientes.Find(x => x.IdCliente == ((Cliente)this.listClientes.SelectedItem).IdCliente);
                Cuenta cuenta = this.cuentas.Find(x => x.Numero == ((Cuenta)this.listCuentas.SelectedItem).Numero);
                int monto = Convert.ToInt32(this.txtMonto.Text);

                if (cuenta.Depositar(monto))
                {
                    banco.Cuentas[banco.Cuentas.FindIndex(x => x.Numero == cuenta.Numero)] = cuenta;
                    List<Cuenta> lista = banco.Cuentas.FindAll(x => x.Cliente.IdCliente == cliente.IdCliente);
                    this.listCuentas.Items.Clear();
                    foreach (Cuenta cuentaAux in lista)
                    {
                        this.listCuentas.Items.Add(cuentaAux);
                    }
                    MessageBox.Show(String.Format("Se depositaron {0} en la cuenta {1}", monto.ToString(), cuenta.Numero.ToString()));
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("Selecciones una cuenta");
            }
        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            try
            {
                Banco banco = this.bancos.Find(x => x.nombre == ((Banco)this.listBancos.SelectedItem).nombre &&
                                               x.sucursal == ((Banco)this.listBancos.SelectedItem).sucursal);
                Cliente cliente = this.clientes.Find(x => x.IdCliente == ((Cliente)this.listClientes.SelectedItem).IdCliente);
                Cuenta cuenta = this.cuentas.Find(x => x.Numero == ((Cuenta)this.listCuentas.SelectedItem).Numero);
                int monto = Convert.ToInt32(this.txtMonto.Text);

                if (cuenta.Extraer(monto))
                {
                    banco.Cuentas[banco.Cuentas.FindIndex(x => x.Numero == cuenta.Numero)] = cuenta;
                    List<Cuenta> lista = banco.Cuentas.FindAll(x => x.Cliente.IdCliente == cliente.IdCliente);
                    this.listCuentas.Items.Clear();
                    foreach (Cuenta cuentaAux in lista)
                    {
                        this.listCuentas.Items.Add(cuentaAux);
                    }
                    MessageBox.Show(String.Format("Se extrajeron {0} en la cuenta {1}", monto.ToString(), cuenta.Numero.ToString()));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error.");
            }
        }

        private void chkCajaAhorro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminarCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                Banco banco = this.bancos.Find(x => x.nombre == ((Banco)this.listBancos.SelectedItem).nombre &&
                                               x.sucursal == ((Banco)this.listBancos.SelectedItem).sucursal);
                Cliente cliente = this.clientes.Find(x => x.IdCliente == ((Cliente)this.listClientes.SelectedItem).IdCliente);
                Cuenta cuenta = this.cuentas.Find(x => x.Numero == ((Cuenta)this.listCuentas.SelectedItem).Numero);
                List<Cuenta> lista = banco.Cuentas.FindAll(x => x.Numero == cuenta.Numero && x.Cliente.IdCliente == cliente.IdCliente);

                if(MessageBox.Show("¿Estas seguro de querer eliminar?","Eliminar cuenta",MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    banco.BajaCuenta(cuenta.Numero);
                    this.bancos[this.bancos.IndexOf(banco)] = banco;
                    this.cuentas.Remove(cuenta);
                    this.listCuentas.Items.Remove(cuenta);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error.");
            }
        }

        private void btnCrearCajaAhorro_Click(object sender, EventArgs e)
        {
            try
            {
                Banco banco = this.bancos.Find(x => x.nombre == ((Banco)this.listBancos.SelectedItem).nombre &&
                                                x.sucursal == ((Banco)this.listBancos.SelectedItem).sucursal);
                Cliente cliente = this.clientes.Find(x => x.IdCliente == ((Cliente)this.listClientes.SelectedItem).IdCliente);

                Cuenta cuenta = banco.AltaCuenta(cliente, TipoCuenta.CajaAhorro);
                this.bancos[this.bancos.IndexOf(banco)] = banco;
                this.cuentas.Add(cuenta);
                this.listCuentas.Items.Add(cuenta);
            }
            catch (Exception)
            {
                MessageBox.Show("Error.");
            }
        }

        private void btnListarTodo_Click(object sender, EventArgs e)
        {
            try
            {
                List<Cuenta> lista = this.cuentas.FindAll(x => x.Cliente == ((Cliente)this.listClientes.SelectedItem));
                this.listCuentas.Items.Clear();
                foreach (Cuenta cuenta in lista)
                {
                    this.listCuentas.Items.Add(cuenta);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione un banco y un cliente");
            }
        }
    }
}
