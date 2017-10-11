namespace InventarioCL
{
    partial class frm_Menu
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
            this.btn_ini = new System.Windows.Forms.Button();
            this.btn_dif = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSiteID = new System.Windows.Forms.Label();
            this.lblPIID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDiferencias = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotLoc = new System.Windows.Forms.LinkLabel();
            this.txtTotMarbetes = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer();
            this.btnManual = new System.Windows.Forms.Button();
            this.btn_Dif_3_Mas = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ini
            // 
            this.btn_ini.BackColor = System.Drawing.Color.Lime;
            this.btn_ini.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.btn_ini.Location = new System.Drawing.Point(143, 39);
            this.btn_ini.Name = "btn_ini";
            this.btn_ini.Size = new System.Drawing.Size(92, 33);
            this.btn_ini.TabIndex = 0;
            this.btn_ini.Text = "1er Conteo";
            this.btn_ini.Click += new System.EventHandler(this.btn_ini_Click);
            // 
            // btn_dif
            // 
            this.btn_dif.BackColor = System.Drawing.Color.Yellow;
            this.btn_dif.Location = new System.Drawing.Point(143, 78);
            this.btn_dif.Name = "btn_dif";
            this.btn_dif.Size = new System.Drawing.Size(92, 33);
            this.btn_dif.TabIndex = 1;
            this.btn_dif.Text = "Diferencias";
            this.btn_dif.Click += new System.EventHandler(this.btn_dif_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Red;
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(30, 156);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(88, 33);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.Text = "Cerrar Sesión";
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.Text = "Almacen:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(81, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.Text = "Inventario:";
            // 
            // lblSiteID
            // 
            this.lblSiteID.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblSiteID.ForeColor = System.Drawing.Color.Yellow;
            this.lblSiteID.Location = new System.Drawing.Point(3, 18);
            this.lblSiteID.Name = "lblSiteID";
            this.lblSiteID.Size = new System.Drawing.Size(63, 18);
            this.lblSiteID.Text = "--";
            this.lblSiteID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPIID
            // 
            this.lblPIID.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblPIID.ForeColor = System.Drawing.Color.Yellow;
            this.lblPIID.Location = new System.Drawing.Point(83, 18);
            this.lblPIID.Name = "lblPIID";
            this.lblPIID.Size = new System.Drawing.Size(72, 18);
            this.lblPIID.Text = "--";
            this.lblPIID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblSiteID);
            this.panel1.Controls.Add(this.lblPIID);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 38);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(174, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 18);
            this.label7.Text = "--";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(174, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.Text = "Usuario:";
            // 
            // statusBar1
            // 
            this.statusBar1.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.statusBar1.Location = new System.Drawing.Point(0, 462);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(640, 18);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtDiferencias);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtTotLoc);
            this.panel2.Controls.Add(this.txtTotMarbetes);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(1, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(136, 88);
            // 
            // txtDiferencias
            // 
            this.txtDiferencias.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.txtDiferencias.Location = new System.Drawing.Point(93, 57);
            this.txtDiferencias.Name = "txtDiferencias";
            this.txtDiferencias.Size = new System.Drawing.Size(43, 20);
            this.txtDiferencias.TabIndex = 14;
            this.txtDiferencias.Text = "0";
            this.txtDiferencias.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtDiferencias.Click += new System.EventHandler(this.txtDiferencias_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.label6.Location = new System.Drawing.Point(20, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.Text = "Diferencias:";
            // 
            // txtTotLoc
            // 
            this.txtTotLoc.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.txtTotLoc.Location = new System.Drawing.Point(93, 5);
            this.txtTotLoc.Name = "txtTotLoc";
            this.txtTotLoc.Size = new System.Drawing.Size(43, 20);
            this.txtTotLoc.TabIndex = 11;
            this.txtTotLoc.Text = "0";
            this.txtTotLoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtTotLoc.Click += new System.EventHandler(this.txtTotLoc_Click);
            // 
            // txtTotMarbetes
            // 
            this.txtTotMarbetes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.txtTotMarbetes.Location = new System.Drawing.Point(92, 31);
            this.txtTotMarbetes.Name = "txtTotMarbetes";
            this.txtTotMarbetes.Size = new System.Drawing.Size(44, 20);
            this.txtTotMarbetes.TabIndex = 10;
            this.txtTotMarbetes.Text = "0";
            this.txtTotMarbetes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtTotMarbetes.Click += new System.EventHandler(this.txtTotMarbetes_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.Text = "Localizaciones:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.label3.Location = new System.Drawing.Point(35, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.Text = "Marbetes:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(2, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.Text = "Pendientes Conteo:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnManual
            // 
            this.btnManual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnManual.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.btnManual.Location = new System.Drawing.Point(143, 156);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(92, 33);
            this.btnManual.TabIndex = 5;
            this.btnManual.Text = "Marbete Manual";
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // btn_Dif_3_Mas
            // 
            this.btn_Dif_3_Mas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Dif_3_Mas.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.btn_Dif_3_Mas.Location = new System.Drawing.Point(143, 117);
            this.btn_Dif_3_Mas.Name = "btn_Dif_3_Mas";
            this.btn_Dif_3_Mas.Size = new System.Drawing.Size(92, 33);
            this.btn_Dif_3_Mas.TabIndex = 10;
            this.btn_Dif_3_Mas.Text = "Diferencias 3";
            this.btn_Dif_3_Mas.Click += new System.EventHandler(this.btn_Dif_3_Mas_Click);
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Dif_3_Mas);
            this.Controls.Add(this.btnManual);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_dif);
            this.Controls.Add(this.btn_ini);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_Menu";
            this.Text = "INVENTARIO CL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Menu_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frm_Menu_Closing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ini;
        private System.Windows.Forms.Button btn_dif;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSiteID;
        private System.Windows.Forms.Label lblPIID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel txtTotLoc;
        private System.Windows.Forms.LinkLabel txtTotMarbetes;
        private System.Windows.Forms.LinkLabel txtDiferencias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Button btn_Dif_3_Mas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}