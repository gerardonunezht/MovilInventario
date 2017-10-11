namespace InventarioCL
{
    partial class frm_marbete
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
            this.lbl_marbete = new System.Windows.Forms.Label();
            this.lbl_clave = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.lbl_loc = new System.Windows.Forms.Label();
            this.lbl_pasillo = new System.Windows.Forms.Label();
            this.btn_continuar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLote = new System.Windows.Forms.Label();
            this.lblTotMarbetes = new System.Windows.Forms.Label();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVerificarCant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_marbete
            // 
            this.lbl_marbete.BackColor = System.Drawing.Color.Black;
            this.lbl_marbete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_marbete.ForeColor = System.Drawing.Color.Lime;
            this.lbl_marbete.Location = new System.Drawing.Point(5, 8);
            this.lbl_marbete.Name = "lbl_marbete";
            this.lbl_marbete.Size = new System.Drawing.Size(70, 20);
            this.lbl_marbete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_clave
            // 
            this.lbl_clave.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_clave.Location = new System.Drawing.Point(7, 29);
            this.lbl_clave.Name = "lbl_clave";
            this.lbl_clave.Size = new System.Drawing.Size(115, 20);
            this.lbl_clave.Text = "Clave";
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(5, 51);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.ReadOnly = true;
            this.txt_desc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_desc.Size = new System.Drawing.Size(217, 45);
            this.txt_desc.TabIndex = 11;
            // 
            // lblUnidad
            // 
            this.lblUnidad.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblUnidad.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblUnidad.ForeColor = System.Drawing.Color.Red;
            this.lblUnidad.Location = new System.Drawing.Point(148, 100);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(74, 24);
            this.lblUnidad.Text = "unidad";
            this.lblUnidad.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_loc
            // 
            this.lbl_loc.BackColor = System.Drawing.Color.Black;
            this.lbl_loc.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_loc.ForeColor = System.Drawing.Color.Lime;
            this.lbl_loc.Location = new System.Drawing.Point(5, 100);
            this.lbl_loc.Name = "lbl_loc";
            this.lbl_loc.Size = new System.Drawing.Size(137, 24);
            this.lbl_loc.Text = "Loc.";
            // 
            // lbl_pasillo
            // 
            this.lbl_pasillo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_pasillo.Location = new System.Drawing.Point(139, 32);
            this.lbl_pasillo.Name = "lbl_pasillo";
            this.lbl_pasillo.Size = new System.Drawing.Size(83, 17);
            this.lbl_pasillo.Text = "Pasillo";
            // 
            // btn_continuar
            // 
            this.btn_continuar.BackColor = System.Drawing.Color.Lime;
            this.btn_continuar.Location = new System.Drawing.Point(110, 173);
            this.btn_continuar.Name = "btn_continuar";
            this.btn_continuar.Size = new System.Drawing.Size(111, 31);
            this.btn_continuar.TabIndex = 22;
            this.btn_continuar.Text = "Guardar";
            this.btn_continuar.Click += new System.EventHandler(this.btn_continuar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Maroon;
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(4, 173);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(70, 30);
            this.btn_salir.TabIndex = 23;
            this.btn_salir.Text = "Salir";
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(7, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(4, 143);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(70, 23);
            this.txtCantidad.TabIndex = 36;
            this.txtCantidad.GotFocus += new System.EventHandler(this.txtCantidad_GotFocus);
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
            this.txtCantidad.LostFocus += new System.EventHandler(this.txtCantidad_LostFocus);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(5, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.Text = "Lote:";
            // 
            // lblLote
            // 
            this.lblLote.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.lblLote.Location = new System.Drawing.Point(212, 100);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(10, 20);
            // 
            // lblTotMarbetes
            // 
            this.lblTotMarbetes.BackColor = System.Drawing.Color.Black;
            this.lblTotMarbetes.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotMarbetes.ForeColor = System.Drawing.Color.White;
            this.lblTotMarbetes.Location = new System.Drawing.Point(189, 9);
            this.lblTotMarbetes.Name = "lblTotMarbetes";
            this.lblTotMarbetes.Size = new System.Drawing.Size(33, 16);
            this.lblTotMarbetes.Text = "0";
            this.lblTotMarbetes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 456);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(640, 24);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(87, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 14);
            this.label1.Text = "Verificar Cantidad:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtVerificarCant
            // 
            this.txtVerificarCant.Location = new System.Drawing.Point(147, 143);
            this.txtVerificarCant.Name = "txtVerificarCant";
            this.txtVerificarCant.Size = new System.Drawing.Size(74, 23);
            this.txtVerificarCant.TabIndex = 47;
            this.txtVerificarCant.GotFocus += new System.EventHandler(this.txtVerificarCant_GotFocus);
            this.txtVerificarCant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVerificarCant_KeyDown);
            this.txtVerificarCant.LostFocus += new System.EventHandler(this.txtVerificarCant_LostFocus);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(119, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.Text = "Marbetes";
            // 
            // frm_marbete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_loc);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.txtVerificarCant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.lblTotMarbetes);
            this.Controls.Add(this.lblLote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_continuar);
            this.Controls.Add(this.lbl_pasillo);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.lbl_clave);
            this.Controls.Add(this.lbl_marbete);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_marbete";
            this.Text = "frm_pasillos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_marbete_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frm_marbete_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lbl_marbete;
        public System.Windows.Forms.Label lbl_clave;
        public System.Windows.Forms.TextBox txt_desc;
        public System.Windows.Forms.Label lblUnidad;
        public System.Windows.Forms.Label lbl_loc;
        public System.Windows.Forms.Label lbl_pasillo;
        private System.Windows.Forms.Button btn_continuar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblLote;
        public System.Windows.Forms.Label lblTotMarbetes;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtVerificarCant;
        public System.Windows.Forms.Label label4;
    }
}