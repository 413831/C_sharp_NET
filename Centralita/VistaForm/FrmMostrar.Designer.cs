namespace VistaForm
{
  partial class FrmMostrar
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.rtbFacturacion = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbFacturacion
            // 
            this.rtbFacturacion.Location = new System.Drawing.Point(13, 13);
            this.rtbFacturacion.Name = "rtbFacturacion";
            this.rtbFacturacion.Size = new System.Drawing.Size(336, 334);
            this.rtbFacturacion.TabIndex = 0;
            this.rtbFacturacion.Text = "";
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 359);
            this.Controls.Add(this.rtbFacturacion);
            this.MaximizeBox = false;
            this.Name = "FrmMostrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMostrar";
            this.Load += new System.EventHandler(this.FrmMostrar_Load);
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.RichTextBox rtbFacturacion;
  }
}
