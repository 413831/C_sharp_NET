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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        static int flagConversion = 0;//Flag de control para conversion de decimal a binario y viceversa

        public FormCalculadora()
        {
            InitializeComponent();
        }

        //Se inicializan campos en 0 y comboBox en ""
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            txtNumero1.Text = "0";
            txtNumero2.Text = "0";
            cmbOperador.Text = "";
            lblResultado.Text = "0";
        }

        //Se limpian campos con valores iniciales y se resetea el flag de conversión
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "0";
            txtNumero2.Text = "0";
            cmbOperador.Text = "";
            lblResultado.Text = "0";
            flagConversion = 0; // Reset de variable estática
        }

        //Se realiza la operacion con valores ingresados
        private void btnOperar_Click(object sender, EventArgs e)
        {
            Numero primerNumero;
            Numero segundoNumero;
            String operador = cmbOperador.Text;
            flagConversion = 2;

            if(txtNumero1.Text != "" || txtNumero2.Text != "")
            {
                primerNumero = new Numero(txtNumero1.Text);
                segundoNumero = new Numero(txtNumero2.Text);
                lblResultado.Text = Convert.ToString(Calculadora.Operar(primerNumero, segundoNumero, operador));
            }
            else
            {
                lblResultado.Text = "Valor inválido.";
            }
        }

        //Se cierra el formulario
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Se realiza conversion de decimal a binario si no se realizó anteriormente y si es un valor válido
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero resultadoDecimal = new Numero();
            
            if(flagConversion != 1)
            {
                lblResultado.Text = resultadoDecimal.DecimalBinario(lblResultado.Text);
                flagConversion = 1;
            }
        }

        //Se realiza conversion de binario a decimal si no se realizó anteriormente y si es un valor válido
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero resultadoBinario = new Numero();

            if (flagConversion != 2)
            {
                lblResultado.Text = resultadoBinario.BinarioDecimal(lblResultado.Text);
                flagConversion = 2;
            }
        }
    }
}
