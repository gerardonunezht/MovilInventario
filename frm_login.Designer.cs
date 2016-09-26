namespace InventarioCL
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_almacen = new System.Windows.Forms.ComboBox();
            this.cbo_inventario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPareja = new System.Windows.Forms.TextBox();
            this.pic_LogoHT = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(32, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.Text = "Almacen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbo_almacen
            // 
            this.cbo_almacen.Location = new System.Drawing.Point(98, 72);
            this.cbo_almacen.Name = "cbo_almacen";
            this.cbo_almacen.Size = new System.Drawing.Size(111, 23);
            this.cbo_almacen.TabIndex = 1;
            this.cbo_almacen.SelectedValueChanged += new System.EventHandler(this.cbo_almacen_SelectedValueChanged);
            // 
            // cbo_inventario
            // 
            this.cbo_inventario.Location = new System.Drawing.Point(98, 100);
            this.cbo_inventario.Name = "cbo_inventario";
            this.cbo_inventario.Size = new System.Drawing.Size(111, 23);
            this.cbo_inventario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(23, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.Text = "Inventario";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Green;
            this.btnAceptar.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btnAceptar.Location = new System.Drawing.Point(131, 154);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(78, 33);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Ingresar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DarkRed;
            this.btnSalir.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.btnSalir.Location = new System.Drawing.Point(23, 154);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(78, 33);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.label3.Location = new System.Drawing.Point(9, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.Text = "# Empleado";
            // 
            // txtPareja
            // 
            this.txtPareja.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtPareja.Location = new System.Drawing.Point(98, 127);
            this.txtPareja.Name = "txtPareja";
            this.txtPareja.Size = new System.Drawing.Size(111, 23);
            this.txtPareja.TabIndex = 3;
            this.txtPareja.GotFocus += new System.EventHandler(this.txtPareja_GotFocus);
            this.txtPareja.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPareja_KeyUp);
            this.txtPareja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPareja_KeyPress);
            this.txtPareja.LostFocus += new System.EventHandler(this.txtPareja_LostFocus);
            // 
            // pic_LogoHT
            // 
            this.pic_LogoHT.Image = ((System.Drawing.Image)(resources.GetObject("pic_LogoHT.Image")));
            this.pic_LogoHT.Location = new System.Drawing.Point(70, 5);
            this.pic_LogoHT.Name = "pic_LogoHT";
            this.pic_LogoHT.Size = new System.Drawing.Size(72, 63);
            this.pic_LogoHT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.ControlBox = false;
            this.Controls.Add(this.pic_LogoHT);
            this.Controls.Add(this.txtPareja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cbo_inventario);
            this.Controls.Add(this.cbo_almacen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frm_login";
            this.Text = "Seleccionar Almacen e Inventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_almacen;
        private System.Windows.Forms.ComboBox cbo_inventario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPareja;
        private System.Windows.Forms.PictureBox pic_LogoHT;

    }
}

