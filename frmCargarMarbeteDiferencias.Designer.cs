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
            this.timer1 = new System.Windows.Forms.Timer();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.timer3 = new System.Windows.Forms.Timer();
            this.lbl_clave = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotConteos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_loc = new System.Windows.Forms.TextBox();
            this.lbl_marbete = new System.Windows.Forms.Label();
            this.lbl_loc = new System.Windows.Forms.Label();
            this.lbl_pasillo = new System.Windows.Forms.Label();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.btn_continuar = new System.Windows.Forms.Button();
            this.txtVerifCantidad = new System.Windows.Forms.TextBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotMarbetes = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 456);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(640, 24);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 2000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick_1);
            // 
            // lbl_clave
            // 
            this.lbl_clave.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_clave.Location = new System.Drawing.Point(4, 16);
            this.lbl_clave.Name = "lbl_clave";
            this.lbl_clave.Size = new System.Drawing.Size(107, 18);
            this.lbl_clave.Text = "Clave";
            this.lbl_clave.Visible = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(104, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.Text = "Marbetes";
            this.label4.Visible = false;
            // 
            // lblTotConteos
            // 
            this.lblTotConteos.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotConteos.ForeColor = System.Drawing.Color.Red;
            this.lblTotConteos.Location = new System.Drawing.Point(71, 0);
            this.lblTotConteos.Name = "lblTotConteos";
            this.lblTotConteos.Size = new System.Drawing.Size(27, 16);
            this.lblTotConteos.Text = "#";
            this.lblTotConteos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTotConteos.Visible = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.Text = "Conteos:";
            this.label5.Visible = false;
            // 
            // txt_loc
            // 
            this.txt_loc.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_loc.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.txt_loc.ForeColor = System.Drawing.Color.LimeGreen;
            this.txt_loc.Location = new System.Drawing.Point(1, 32);
            this.txt_loc.Name = "txt_loc";
            this.txt_loc.Size = new System.Drawing.Size(217, 37);
            this.txt_loc.TabIndex = 93;
            this.txt_loc.Text = "Confirmar Loc.";
            this.txt_loc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_loc_KeyDown);
            // 
            // lbl_marbete
            // 
            this.lbl_marbete.BackColor = System.Drawing.Color.Black;
            this.lbl_marbete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_marbete.ForeColor = System.Drawing.Color.Lime;
            this.lbl_marbete.Location = new System.Drawing.Point(1, 0);
            this.lbl_marbete.Name = "lbl_marbete";
            this.lbl_marbete.Size = new System.Drawing.Size(70, 20);
            this.lbl_marbete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_marbete.Visible = false;
            // 
            // lbl_loc
            // 
            this.lbl_loc.BackColor = System.Drawing.Color.Black;
            this.lbl_loc.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_loc.ForeColor = System.Drawing.Color.Red;
            this.lbl_loc.Location = new System.Drawing.Point(1, 78);
            this.lbl_loc.Name = "lbl_loc";
            this.lbl_loc.Size = new System.Drawing.Size(217, 33);
            this.lbl_loc.Text = "Loc.";
            this.lbl_loc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_pasillo
            // 
            this.lbl_pasillo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_pasillo.Location = new System.Drawing.Point(129, 20);
            this.lbl_pasillo.Name = "lbl_pasillo";
            this.lbl_pasillo.Size = new System.Drawing.Size(89, 17);
            this.lbl_pasillo.Text = "Pasillo";
            this.lbl_pasillo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_pasillo.Visible = false;
            // 
            // lblUnidad
            // 
            this.lblUnidad.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblUnidad.ForeColor = System.Drawing.Color.Red;
            this.lblUnidad.Location = new System.Drawing.Point(76, 129);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(62, 24);
            this.lblUnidad.Text = "UNI";
            this.lblUnidad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblUnidad.Visible = false;
            // 
            // btn_continuar
            // 
            this.btn_continuar.BackColor = System.Drawing.Color.Lime;
            this.btn_continuar.Location = new System.Drawing.Point(107, 154);
            this.btn_continuar.Name = "btn_continuar";
            this.btn_continuar.Size = new System.Drawing.Size(111, 31);
            this.btn_continuar.TabIndex = 89;
            this.btn_continuar.Text = "Guardar";
            this.btn_continuar.Visible = false;
            this.btn_continuar.Click += new System.EventHandler(this.btn_continuar_Click);
            // 
            // txtVerifCantidad
            // 
            this.txtVerifCantidad.Enabled = false;
            this.txtVerifCantidad.Location = new System.Drawing.Point(144, 128);
            this.txtVerifCantidad.Name = "txtVerifCantidad";
            this.txtVerifCantidad.Size = new System.Drawing.Size(74, 23);
            this.txtVerifCantidad.TabIndex = 92;
            this.txtVerifCantidad.Visible = false;
            this.txtVerifCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVerifCantidad_KeyDown);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Maroon;
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(2, 155);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(70, 30);
            this.btn_salir.TabIndex = 90;
            this.btn_salir.Text = "Salir";
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(119, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.Text = "Verif. Cant.:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(0, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.Text = "Cantidad:";
            this.label2.Visible = false;
            // 
            // lblTotMarbetes
            // 
            this.lblTotMarbetes.BackColor = System.Drawing.Color.Black;
            this.lblTotMarbetes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotMarbetes.ForeColor = System.Drawing.Color.Lime;
            this.lblTotMarbetes.Location = new System.Drawing.Point(174, 0);
            this.lblTotMarbetes.Name = "lblTotMarbetes";
            this.lblTotMarbetes.Size = new System.Drawing.Size(44, 20);
            this.lblTotMarbetes.Text = "0";
            this.lblTotMarbetes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTotMarbetes.Visible = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Location = new System.Drawing.Point(1, 128);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(70, 23);
            this.txtCantidad.TabIndex = 91;
            this.txtCantidad.Visible = false;
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(1, 37);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.ReadOnly = true;
            this.txt_desc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_desc.Size = new System.Drawing.Size(217, 38);
            this.txt_desc.TabIndex = 88;
            this.txt_desc.Visible = false;
            // 
            // frmCargarMarbeteDiferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_clave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotConteos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_loc);
            this.Controls.Add(this.lbl_marbete);
            this.Controls.Add(this.lbl_loc);
            this.Controls.Add(this.lbl_pasillo);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.btn_continuar);
            this.Controls.Add(this.txtVerifCantidad);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotMarbetes);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.statusBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCargarMarbeteDiferencias";
            this.Text = "Contar Marbetes Con Diferencias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCargarMarbeteDiferencias_Load);
            this.GotFocus += new System.EventHandler(this.frmCargarMarbeteDiferencias_GotFocus);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmCargarMarbeteDiferencias_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer3;
        public System.Windows.Forms.Label lbl_clave;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblTotConteos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_loc;
        public System.Windows.Forms.Label lbl_marbete;
        public System.Windows.Forms.Label lbl_loc;
        public System.Windows.Forms.Label lbl_pasillo;
        public System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.Button btn_continuar;
        public System.Windows.Forms.TextBox txtVerifCantidad;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblTotMarbetes;
        public System.Windows.Forms.TextBox txtCantidad;
        public System.Windows.Forms.TextBox txt_desc;

    }
}