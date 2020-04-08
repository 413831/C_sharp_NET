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
  public partial class FrmMenu : Form
  {
    Centralita centralita = new Centralita("Pepito's Call Center");
    FrmLlamador formLlamador;
    FrmMostrar formMostrar;

    public FrmMenu()
    {
      InitializeComponent();
    }

    private void FrmCentral_Load(object sender, EventArgs e)
    {

    }

    private void btnGenerarLlamada_Click(object sender, EventArgs e)
    {
        formLlamador = new FrmLlamador(centralita);
        formLlamador.ShowDialog();
        centralita = formLlamador.Centralita;
    }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFactTotal_Click(object sender, EventArgs e)
        {
            formMostrar = new FrmMostrar(centralita);
            formMostrar.TipoLlamada = Llamada.TipoLlamada.Todas;
            formMostrar.ShowDialog();
        }

        private void btnFactProvincial_Click(object sender, EventArgs e)
        {
            formMostrar = new FrmMostrar(centralita);
            formMostrar.TipoLlamada = Llamada.TipoLlamada.Provincial;
            formMostrar.ShowDialog();
        }

        private void btnFactLocal_Click(object sender, EventArgs e)
        {
            formMostrar = new FrmMostrar(centralita);
            formMostrar.TipoLlamada = Llamada.TipoLlamada.Local;
            formMostrar.ShowDialog();
        }
    }
}
