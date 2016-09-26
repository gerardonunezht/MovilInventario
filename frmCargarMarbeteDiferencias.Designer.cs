namespace InventarioCL
{
    partial class frmCargarMarbeteDiferencias
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
            this.lblTotMarbetes = new System.Windows.Forms.Label();
            this.lblLote = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_continuar = new System.Windows.Forms.Button();
            this.lbl_pasillo = new System.Windows.Forms.Label();
            this.lbl_loc = new System.Windows.Forms.Label();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.lbl_clave = new System.Windows.Forms.Label();
            this.lbl_marbete = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotConteos = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer();
            this.timer2 = new System.Windows.Forms.Timer();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.timer3 = new System.Windows.Forms.Timer();
            this.txtVerifCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTotMarbetes
            // 
            this.lblTotMarbetes.BackColor = System.Drawing.Color.Black;
            this.lblTotMarbetes.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotMarbetes.ForeColor = System.Drawing.Color.White;
            this.lblTotMarbetes.Location = new System.Drawing.Point(171, 8);
            this.lblTotMarbetes.Name = "lblTotMarbetes";
            this.lblTotMarbetes.Size = new System.Drawing.Size(32, 20);
            this.lblTotMarbetes.Text = "0";
            this.lblTotMarbetes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLote
            // 
            this.lblLote.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.lblLote.Location = new System.Drawing.Point(47, 92);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(129, 15);
            this.lblLote.Visible = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(8, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.Text = "Lote:";
            this.label3.Visible = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(12, 126);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(60, 23);
            this.txtCantidad.TabIndex = 51;
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(8, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.Text = "Cantidad:";
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Maroon;
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(76, 192);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(60, 30);
            this.btn_salir.TabIndex = 50;
            this.btn_salir.Text = "Salir";
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_continuar
            // 
            this.btn_continuar.BackColor = System.Drawing.Color.Lime;
            this.btn_continuar.Location = new System.Drawing.Point(48, 156);
            this.btn_continuar.Name = "btn_continuar";
            this.btn_continuar.Size = new System.Drawing.Size(116, 30);
            this.btn_continuar.TabIndex = 49;
            this.btn_continuar.Text = "Guardar";
            this.btn_continuar.Click += new System.EventHandler(this.btn_continuar_Click);
            // 
            // lbl_pasillo
            // 
            this.lbl_pasillo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_pasillo.Location = new System.Drawing.Point(140, 28);
            this.lbl_pasillo.Name = "lbl_pasillo";
            this.lbl_pasillo.Size = new System.Drawing.Size(63, 17);
            this.lbl_pasillo.Text = "Pasillo";
            // 
            // lbl_loc
            // 
            this.lbl_loc.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_loc.Location = new System.Drawing.Point(73, 8);
            this.lbl_loc.Name = "lbl_loc";
            this.lbl_loc.Size = new System.Drawing.Size(99, 19);
            this.lbl_loc.Text = "Loc.";
            // 
            // lblUnidad
            // 
            this.lblUnidad.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblUnidad.ForeColor = System.Drawing.Color.Red;
            this.lblUnidad.Location = new System.Drawing.Point(11, 89);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(122, 23);
            this.lblUnidad.Text = "unidad";
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(10, 45);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.ReadOnly = true;
            this.txt_desc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_desc.Size = new System.Drawing.Size(193, 44);
            this.txt_desc.TabIndex = 48;
            // 
            // lbl_clave
            // 
            this.lbl_clave.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_clave.Location = new System.Drawing.Point(12, 29);
            this.lbl_clave.Name = "lbl_clave";
            this.lbl_clave.Size = new System.Drawing.Size(104, 16);
            this.lbl_clave.Text = "Clave";
            // 
            // lbl_marbete
            // 
            this.lbl_marbete.BackColor = System.Drawing.Color.Black;
            this.lbl_marbete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_marbete.ForeColor = System.Drawing.Color.Lime;
            this.lbl_marbete.Location = new System.Drawing.Point(11, 7);
            this.lbl_marbete.Name = "lbl_marbete";
            this.lbl_marbete.Size = new System.Drawing.Size(61, 20);
            this.lbl_marbete.Text = "0";
            this.lbl_marbete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(122, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 14);
            this.label4.Text = "Conteos:";
            // 
            // lblTotConteos
            // 
            this.lblTotConteos.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotConteos.ForeColor = System.Drawing.Color.Red;
            this.lblTotConteos.Location = new System.Drawing.Point(185, 93);
            this.lblTotConteos.Name = "lblTotConteos";
            this.lblTotConteos.Size = new System.Drawing.Size(28, 16);
            this.lblTotConteos.Text = "0";
            this.lblTotConteos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 2000;
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 456);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(640, 24);
            // 
            // timer3
            // 
            this.timer3.Interval = 2000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick_1);
            // 
            // txtVerifCantidad
            // 
            this.txtVerifCantidad.Location = new System.Drawing.Point(122, 126);
            this.txtVerifCantidad.Name = "txtVerifCantidad";
            this.txtVerifCantidad.Size = new System.Drawing.Size(64, 23);
            this.txtVerifCantidad.TabIndex = 58;
            this.txtVerifCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVerifCantidad_KeyDown);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(87, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.Text = "Verificar Cantidad:";
            // 
            // frmCargarMarbeteDiferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVerifCantidad);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.lblTotConteos);
            this.Controls.Add(this.lblTotMarbetes);
            this.Controls.Add(this.lblLote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_continuar);
            this.Controls.Add(this.lbl_pasillo);
            this.Controls.Add(this.lbl_loc);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.lbl_clave);
            this.Controls.Add(this.lbl_marbete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCargarMarbeteDiferencias";
            this.Text = "Contar Marbetes Con Diferencias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCargarMarbeteDiferencias_Load);
            this.Closed += new System.EventHandler(this.frmCargarMarbeteDiferencias_Closed);
            this.GotFocus += new System.EventHandler(this.frmCargarMarbeteDiferencias_GotFocus);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtVerifCantidad;
        private System.Windows.Forms.StatusBar statusBar1;
        public System.Windows.Forms.Label lblTotConteos;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblTotMarbetes;
        public System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_salir;
        public System.Windows.Forms.Button btn_continuar;
        public System.Windows.Forms.Label lbl_pasillo;
        public System.Windows.Forms.Label lbl_loc;
        public System.Windows.Forms.Label lblUnidad;
        public System.Windows.Forms.TextBox txt_desc;
        public System.Windows.Forms.Label lbl_clave;
        public System.Windows.Forms.Label lbl_marbete;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;

    }
}