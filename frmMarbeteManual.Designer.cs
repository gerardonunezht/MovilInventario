namespace InventarioCL
{
    partial class frmMarbeteManual
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad1 = new System.Windows.Forms.TextBox();
            this.txtCantidad2 = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(27, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.Text = "Clave:";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(4, 19);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(90, 23);
            this.txtClave.TabIndex = 1;
            this.txtClave.GotFocus += new System.EventHandler(this.txtClave_GotFocus);
            this.txtClave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtClave_KeyDown);
            this.txtClave.LostFocus += new System.EventHandler(this.txtClave_LostFocus);
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.White;
            this.txtDesc.Enabled = false;
            this.txtDesc.Location = new System.Drawing.Point(0, 64);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(217, 45);
            this.txtDesc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(66, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.Text = "Localizacion:";
            // 
            // txtLoc
            // 
            this.txtLoc.Enabled = false;
            this.txtLoc.Location = new System.Drawing.Point(41, 130);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(131, 23);
            this.txtLoc.TabIndex = 5;
            this.txtLoc.GotFocus += new System.EventHandler(this.txtLoc_GotFocus);
            this.txtLoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLoc_KeyDown);
            this.txtLoc.LostFocus += new System.EventHandler(this.txtLoc_LostFocus);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(144, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.Text = "Unidad:";
            // 
            // txtUnidad
            // 
            this.txtUnidad.BackColor = System.Drawing.Color.White;
            this.txtUnidad.Enabled = false;
            this.txtUnidad.Location = new System.Drawing.Point(124, 19);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(90, 23);
            this.txtUnidad.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(28, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.Text = "Cantidad:";
            // 
            // txtCantidad1
            // 
            this.txtCantidad1.Enabled = false;
            this.txtCantidad1.Location = new System.Drawing.Point(25, 173);
            this.txtCantidad1.Name = "txtCantidad1";
            this.txtCantidad1.Size = new System.Drawing.Size(66, 23);
            this.txtCantidad1.TabIndex = 11;
            this.txtCantidad1.GotFocus += new System.EventHandler(this.txtCantidad1_GotFocus);
            this.txtCantidad1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad1_KeyDown);
            // 
            // txtCantidad2
            // 
            this.txtCantidad2.Enabled = false;
            this.txtCantidad2.Location = new System.Drawing.Point(114, 173);
            this.txtCantidad2.Name = "txtCantidad2";
            this.txtCantidad2.Size = new System.Drawing.Size(78, 23);
            this.txtCantidad2.TabIndex = 12;
            this.txtCantidad2.GotFocus += new System.EventHandler(this.txtCantidad2_GotFocus);
            this.txtCantidad2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad2_KeyDown);
            this.txtCantidad2.LostFocus += new System.EventHandler(this.txtCantidad2_LostFocus);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardar.Location = new System.Drawing.Point(105, 202);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 29);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(28, 202);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(53, 29);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(97, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 15);
            this.label5.Text = "Verificar Cantidad:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Blue;
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(105, 202);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(87, 29);
            this.btnNuevo.TabIndex = 17;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Visible = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(71, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.Text = "Descripción:";
            // 
            // frmMarbeteManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtCantidad2);
            this.Controls.Add(this.txtCantidad1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUnidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label1);
            this.Name = "frmMarbeteManual";
            this.Text = "Marbete Manual";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidad1;
        private System.Windows.Forms.TextBox txtCantidad2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label6;
    }
}