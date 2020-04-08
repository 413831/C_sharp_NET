using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using IO;

namespace Notepad
{
    public partial class FormEditor : Form
    {
        string nombreArchivo;
        PuntoTxt archivoTxt = new PuntoTxt();
        PuntoDat archivoDat = new PuntoDat();
        PuntoXml archivoXml = new PuntoXml();

        public FormEditor()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ventana = new OpenFileDialog();

            ventana.Filter = "Archivos de texto(.txt)|*.txt|Archivos de datos (.dat)|*.dat|Archivos XML(.xml)|*.xml";

            if (ventana.ShowDialog() == DialogResult.OK)
            {
                nombreArchivo = ventana.FileName;
                MessageBox.Show(ventana.FilterIndex.ToString());

                switch (ventana.FilterIndex)
                {
                    case 1:
                        richTextBox1.Text = archivoTxt.Leer(ventana.FileName);
                        break;
                    case 2:
                        archivoDat = archivoDat.Leer(ventana.FileName); //REVISAR
                        richTextBox1.Text = archivoDat.Contenido;
                        break;
                    case 3:
                        richTextBox1.Text = archivoXml.Leer(ventana.FileName); //REVISAR
                        break;
                }
            }
            else
            {
                this.guardarComoToolStripMenuItem1_Click(sender, e);
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(File.Exists(nombreArchivo))
            {
               switch(Path.GetExtension(nombreArchivo))
                {
                    case ".txt":
                        archivoTxt.Guardar(nombreArchivo, richTextBox1.Text);
                        break;
                    case ".dat":
                        archivoDat.Contenido = richTextBox1.Text;
                        archivoDat.Guardar(nombreArchivo, archivoDat);
                        break;
                    case ".xml":
                        archivoXml.Guardar(nombreArchivo, richTextBox1.Text);
                        break;
                }
            }
            else
            {
                this.guardarComoToolStripMenuItem1_Click(sender, e);
            }
        }

        private void guardarComoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog ventana = new SaveFileDialog();

            ventana.Filter = "Archivos de texto(.txt)|*.txt|Archivos de datos (.dat)|*.dat|Archivos XML(.xml)|*.xml";

            if (ventana.ShowDialog() == DialogResult.OK)
            {
                switch(ventana.FilterIndex)
                {
                    case 1 :
                        archivoTxt.GuardarComo(ventana.FileName, richTextBox1.Text);
                        break;
                    case 2 :
                        archivoDat.Contenido = richTextBox1.Text;
                        archivoDat.GuardarComo(ventana.FileName, archivoDat); //REVISAR
                        break;
                    case 3:
                        archivoXml.GuardarComo(ventana.FileName, richTextBox1.Text);
                        break;
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Caracteres: " + richTextBox1.TextLength.ToString();
        }
    }
}
