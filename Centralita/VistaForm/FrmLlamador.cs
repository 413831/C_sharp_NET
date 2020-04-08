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

namespace VistaForm
{
    public partial class FrmLlamador : Form
    {
         
        private Centralita centralita;
        private Llamada llamada;
        Provincial.Franja franja;
        Random duracion = new Random();
        Random costoLlamada = new Random();

        public Centralita Centralita
        {
            get
            {
                return this.centralita;
            }
        }

        public FrmLlamador()
        {
            InitializeComponent();
        }

        public FrmLlamador(Centralita central) : this()
        {
            this.centralita = central;
            this.cmbFranjaHoraria.DataSource = Enum.GetValues(typeof(Provincial.Franja));
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            txtOrigen.Text = "01147778169";
            txtOrigen.Enabled = false;
            txtDestino.Enabled = false;
        }

        private void FrmLlamador_Click(object sender, EventArgs e)
        {
            txtDestino.Text = "";
        }

        private void botonUno_Click(object sender, EventArgs e)
        {
            if(txtDestino.Text == "Nro Destino")
            {
                txtDestino.Text = "";
            }
            txtDestino.Text += "1";
        }

        private void botonDos_Click(object sender, EventArgs e)
        {
            if (txtDestino.Text == "Nro Destino")
            {
                txtDestino.Text = "";
            }
            txtDestino.Text += "2";
        }

        private void botonTres_Click(object sender, EventArgs e)
        {
            if (txtDestino.Text == "Nro Destino")
            {
                txtDestino.Text = "";
            }
            txtDestino.Text += "3";
        }

        private void botonCuatro_Click(object sender, EventArgs e)
        {
            if (txtDestino.Text == "Nro Destino")
            {
                txtDestino.Text = "";
            }
            txtDestino.Text += "4";
        }

        private void botonCinco_Click(object sender, EventArgs e)
        {
            if (txtDestino.Text == "Nro Destino")
            {
                txtDestino.Text = "";
            }
            txtDestino.Text += "5";
        }

        private void botonSeis_Click(object sender, EventArgs e)
        {
            if (txtDestino.Text == "Nro Destino")
            {
                txtDestino.Text = "";
            }
            txtDestino.Text += "6";
        }

        private void botonSiete_Click(object sender, EventArgs e)
        {
            if (txtDestino.Text == "Nro Destino")
            {
                txtDestino.Text = "";
            }
            txtDestino.Text += "7";
        }

        private void botonOcho_Click(object sender, EventArgs e)
        {
            if (txtDestino.Text == "Nro Destino")
            {
                txtDestino.Text = "";
            }
            txtDestino.Text += "8";
        }

        private void botonNueve_Click(object sender, EventArgs e)
        {
            if (txtDestino.Text == "Nro Destino")
            {
                txtDestino.Text = "";
            }
            txtDestino.Text += "9";
        }

        private void botonCero_Click(object sender, EventArgs e)
        {
            if (txtDestino.Text == "Nro Destino")
            {
                txtDestino.Text = "";
            }
            txtDestino.Text += "0";
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            if (txtDestino.Text == "Nro Destino")
            {
                txtDestino.Text = "";
            }
            txtDestino.Text += "*";
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            if (txtDestino.Text == "Nro Destino")
            {
                txtDestino.Text = "";
            }

            txtDestino.Text += "#";

            if (cmbFranjaHoraria.Enabled == false)
            {
                cmbFranjaHoraria.Enabled = true;
            }
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            txtDestino.Text = "";
            cmbFranjaHoraria.Enabled = true;
        }

        private void botonLlamar_Click(object sender, EventArgs e)
        {
            if (txtDestino.Text != "" && txtOrigen.Text != "")
            {
                try
                {
                    if(txtDestino.Text[0] == '#') // Es llamada provincial
                    {
                        Enum.TryParse<Provincial.Franja>(cmbFranjaHoraria.SelectedValue.ToString(), out franja);
                        llamada = new Provincial(txtOrigen.Text, franja, (float)(duracion.Next(1, 50)), txtDestino.Text);
                        this.centralita += llamada;
                        MessageBox.Show(llamada.ToString());
                    }
                    else
                    {
                        cmbFranjaHoraria.Enabled = false;
                        llamada = new Local(txtOrigen.Text, (float)(duracion.Next(1,50)), txtDestino.Text, (float)(costoLlamada.Next(5, 56)/10));
                        this.centralita += llamada;
                        MessageBox.Show(llamada.ToString());
                    }
                }
                catch(CentralitaException exception)
                {
                    MessageBox.Show(exception.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }

            }         
        }
    }
}
