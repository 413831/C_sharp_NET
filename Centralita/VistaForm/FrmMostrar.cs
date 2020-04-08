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
    public partial class FrmMostrar : Form
    {
        Llamada.TipoLlamada tipoLlamada;
        Centralita centralita;

        public FrmMostrar()
        {
            InitializeComponent();
        }

        public FrmMostrar(Centralita central) : this()
        {
            this.centralita = central;
        }

        public Centralita Centralita
        {
            get
            {
                return this.centralita;
            }
        }

        public Llamada.TipoLlamada TipoLlamada
        {
            set
            {
                this.tipoLlamada = value;
            }
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            var texto = new StringBuilder();

            switch(this.tipoLlamada)
            {
                case Llamada.TipoLlamada.Local:
                    texto.AppendFormat("Facturación de llamadas locales: ${0}",
                                        this.Centralita.GananciasPorLocal.ToString());
                    rtbFacturacion.Text += texto;
                    break;
                case Llamada.TipoLlamada.Provincial:
                    texto.AppendFormat("Facturación de llamadas provinciales: ${0}", 
                                        this.Centralita.GananciasPorProvincial.ToString());
                    rtbFacturacion.Text += texto;
                    break;
                case Llamada.TipoLlamada.Todas:
                    texto.AppendFormat("Facturación total: ${0}", this.Centralita.GananciasPorTotal.ToString());
                    rtbFacturacion.Text += texto;
                    break;
            }
        }
    }
}
