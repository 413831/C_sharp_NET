namespace VistaForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInteresBanco = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAltaBanco = new System.Windows.Forms.Button();
            this.txtBancoLimite = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreBanco = new System.Windows.Forms.TextBox();
            this.txtBancoSucursal = new System.Windows.Forms.TextBox();
            this.txtBancoDireccion = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAltaCliente = new System.Windows.Forms.Button();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBancos = new System.Windows.Forms.ListBox();
            this.listClientes = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCrearCajaAhorro = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnExtraer = new System.Windows.Forms.Button();
            this.btnEliminarCuenta = new System.Windows.Forms.Button();
            this.listCuentas = new System.Windows.Forms.ListBox();
            this.btnCrearCuentaCorriente = new System.Windows.Forms.Button();
            this.btnListarTodo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "N° Sucursal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Interes para cajas de ahorro";
            // 
            // txtInteresBanco
            // 
            this.txtInteresBanco.Location = new System.Drawing.Point(176, 92);
            this.txtInteresBanco.Name = "txtInteresBanco";
            this.txtInteresBanco.Size = new System.Drawing.Size(163, 20);
            this.txtInteresBanco.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAltaBanco);
            this.groupBox1.Controls.Add(this.txtBancoLimite);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNombreBanco);
            this.groupBox1.Controls.Add(this.txtBancoSucursal);
            this.groupBox1.Controls.Add(this.txtBancoDireccion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtInteresBanco);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta Banco";
            // 
            // btnAltaBanco
            // 
            this.btnAltaBanco.Location = new System.Drawing.Point(8, 173);
            this.btnAltaBanco.Name = "btnAltaBanco";
            this.btnAltaBanco.Size = new System.Drawing.Size(152, 38);
            this.btnAltaBanco.TabIndex = 6;
            this.btnAltaBanco.Text = "Crear Banco";
            this.btnAltaBanco.UseVisualStyleBackColor = true;
            this.btnAltaBanco.Click += new System.EventHandler(this.btnAltaBanco_Click);
            // 
            // txtBancoLimite
            // 
            this.txtBancoLimite.Location = new System.Drawing.Point(176, 118);
            this.txtBancoLimite.Name = "txtBancoLimite";
            this.txtBancoLimite.Size = new System.Drawing.Size(163, 20);
            this.txtBancoLimite.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Limite para retiro descubierto";
            // 
            // txtNombreBanco
            // 
            this.txtNombreBanco.Location = new System.Drawing.Point(176, 14);
            this.txtNombreBanco.Name = "txtNombreBanco";
            this.txtNombreBanco.Size = new System.Drawing.Size(163, 20);
            this.txtNombreBanco.TabIndex = 0;
            // 
            // txtBancoSucursal
            // 
            this.txtBancoSucursal.Location = new System.Drawing.Point(176, 40);
            this.txtBancoSucursal.Name = "txtBancoSucursal";
            this.txtBancoSucursal.Size = new System.Drawing.Size(163, 20);
            this.txtBancoSucursal.TabIndex = 1;
            // 
            // txtBancoDireccion
            // 
            this.txtBancoDireccion.Location = new System.Drawing.Point(176, 66);
            this.txtBancoDireccion.Name = "txtBancoDireccion";
            this.txtBancoDireccion.Size = new System.Drawing.Size(163, 20);
            this.txtBancoDireccion.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAltaCliente);
            this.groupBox2.Controls.Add(this.txtLocalidad);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtNombreCliente);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtApellido);
            this.groupBox2.Controls.Add(this.txtDniCliente);
            this.groupBox2.Controls.Add(this.txtEdad);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(369, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 216);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alta Cliente";
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.Location = new System.Drawing.Point(9, 172);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Size = new System.Drawing.Size(152, 38);
            this.btnAltaCliente.TabIndex = 7;
            this.btnAltaCliente.Text = "Alta Cliente";
            this.btnAltaCliente.UseVisualStyleBackColor = true;
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAltaCliente_Click);
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(113, 121);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(214, 20);
            this.txtLocalidad.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Localidad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "D.N.I.";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(113, 17);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(214, 20);
            this.txtNombreCliente.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Edad";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(113, 43);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(214, 20);
            this.txtApellido.TabIndex = 8;
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Location = new System.Drawing.Point(113, 95);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(214, 20);
            this.txtDniCliente.TabIndex = 11;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(113, 69);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(214, 20);
            this.txtEdad.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nombre";
            // 
            // listBancos
            // 
            this.listBancos.FormattingEnabled = true;
            this.listBancos.Location = new System.Drawing.Point(12, 235);
            this.listBancos.Name = "listBancos";
            this.listBancos.Size = new System.Drawing.Size(351, 199);
            this.listBancos.TabIndex = 3;
            // 
            // listClientes
            // 
            this.listClientes.FormattingEnabled = true;
            this.listClientes.Location = new System.Drawing.Point(369, 235);
            this.listClientes.Name = "listClientes";
            this.listClientes.Size = new System.Drawing.Size(333, 199);
            this.listClientes.TabIndex = 4;
            this.listClientes.SelectedValueChanged += new System.EventHandler(this.listClientes_SelectedValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnListarTodo);
            this.groupBox3.Controls.Add(this.btnCrearCajaAhorro);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtMonto);
            this.groupBox3.Controls.Add(this.btnDepositar);
            this.groupBox3.Controls.Add(this.btnExtraer);
            this.groupBox3.Controls.Add(this.btnEliminarCuenta);
            this.groupBox3.Controls.Add(this.listCuentas);
            this.groupBox3.Controls.Add(this.btnCrearCuentaCorriente);
            this.groupBox3.Location = new System.Drawing.Point(708, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(494, 425);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cuentas del cliente";
            // 
            // btnCrearCajaAhorro
            // 
            this.btnCrearCajaAhorro.Location = new System.Drawing.Point(133, 368);
            this.btnCrearCajaAhorro.Name = "btnCrearCajaAhorro";
            this.btnCrearCajaAhorro.Size = new System.Drawing.Size(107, 38);
            this.btnCrearCajaAhorro.TabIndex = 26;
            this.btnCrearCajaAhorro.Text = "Crear Caja de Ahorro";
            this.btnCrearCajaAhorro.UseVisualStyleBackColor = true;
            this.btnCrearCajaAhorro.Click += new System.EventHandler(this.btnCrearCajaAhorro_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Ingrese monto: ";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(92, 24);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(222, 20);
            this.txtMonto.TabIndex = 24;
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(153, 50);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(151, 46);
            this.btnDepositar.TabIndex = 23;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnExtraer
            // 
            this.btnExtraer.Location = new System.Drawing.Point(6, 50);
            this.btnExtraer.Name = "btnExtraer";
            this.btnExtraer.Size = new System.Drawing.Size(141, 46);
            this.btnExtraer.TabIndex = 22;
            this.btnExtraer.Text = "Extraer";
            this.btnExtraer.UseVisualStyleBackColor = true;
            this.btnExtraer.Click += new System.EventHandler(this.btnExtraer_Click);
            // 
            // btnEliminarCuenta
            // 
            this.btnEliminarCuenta.Location = new System.Drawing.Point(246, 368);
            this.btnEliminarCuenta.Name = "btnEliminarCuenta";
            this.btnEliminarCuenta.Size = new System.Drawing.Size(111, 38);
            this.btnEliminarCuenta.TabIndex = 19;
            this.btnEliminarCuenta.Text = "Baja Cuenta";
            this.btnEliminarCuenta.UseVisualStyleBackColor = true;
            this.btnEliminarCuenta.Click += new System.EventHandler(this.btnEliminarCuenta_Click);
            // 
            // listCuentas
            // 
            this.listCuentas.FormattingEnabled = true;
            this.listCuentas.Location = new System.Drawing.Point(6, 111);
            this.listCuentas.Name = "listCuentas";
            this.listCuentas.Size = new System.Drawing.Size(482, 238);
            this.listCuentas.TabIndex = 18;
            // 
            // btnCrearCuentaCorriente
            // 
            this.btnCrearCuentaCorriente.Location = new System.Drawing.Point(6, 368);
            this.btnCrearCuentaCorriente.Name = "btnCrearCuentaCorriente";
            this.btnCrearCuentaCorriente.Size = new System.Drawing.Size(121, 38);
            this.btnCrearCuentaCorriente.TabIndex = 7;
            this.btnCrearCuentaCorriente.Text = "Crear Cuenta Corriente";
            this.btnCrearCuentaCorriente.UseVisualStyleBackColor = true;
            this.btnCrearCuentaCorriente.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // btnListarTodo
            // 
            this.btnListarTodo.Location = new System.Drawing.Point(363, 368);
            this.btnListarTodo.Name = "btnListarTodo";
            this.btnListarTodo.Size = new System.Drawing.Size(111, 38);
            this.btnListarTodo.TabIndex = 27;
            this.btnListarTodo.Text = "Listar Cuentas";
            this.btnListarTodo.UseVisualStyleBackColor = true;
            this.btnListarTodo.Click += new System.EventHandler(this.btnListarTodo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1214, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.listClientes);
            this.Controls.Add(this.listBancos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de alta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInteresBanco;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombreBanco;
        private System.Windows.Forms.TextBox txtBancoSucursal;
        private System.Windows.Forms.TextBox txtBancoDireccion;
        private System.Windows.Forms.TextBox txtBancoLimite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAltaBanco;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAltaCliente;
        private System.Windows.Forms.ListBox listBancos;
        private System.Windows.Forms.ListBox listClientes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listCuentas;
        private System.Windows.Forms.Button btnCrearCuentaCorriente;
        private System.Windows.Forms.Button btnEliminarCuenta;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnExtraer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCrearCajaAhorro;
        private System.Windows.Forms.Button btnListarTodo;
    }
}

