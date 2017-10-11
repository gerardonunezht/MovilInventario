namespace InventarioCL
{
    partial class frmValidaLocalizacionArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmValidaLocalizacionArticulo));
            this.txtArt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMarbeteManual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtArt
            // 
            this.txtArt.BackColor = System.Drawing.Color.Black;
            this.txtArt.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.txtArt.ForeColor = System.Drawing.Color.Lime;
            this.txtArt.Location = new System.Drawing.Point(40, 43);
            this.txtArt.Name = "txtArt";
            this.txtArt.Size = new System.Drawing.Size(167, 39);
            this.txtArt.TabIndex = 2;
            this.txtArt.GotFocus += new System.EventHandler(this.txtArt_GotFocus);
            this.txtArt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArt_KeyDown);
            this.txtArt.LostFocus += new System.EventHandler(this.txtArt_LostFocus);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(18, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 31);
            this.label2.Text = "Codigo de Barras / Clave";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(40, 125);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(167, 33);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Regresar";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // txtLoc
            // 
            this.txtLoc.BackColor = System.Drawing.Color.Black;
            this.txtLoc.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.txtLoc.ForeColor = System.Drawing.Color.Lime;
            this.txtLoc.Location = new System.Drawing.Point(40, 44);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.ReadOnly = true;
            this.txtLoc.Size = new System.Drawing.Size(167, 39);
            this.txtLoc.TabIndex = 6;
            this.txtLoc.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(89, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.Text = "Localizacion #";
            this.label1.Visible = false;
            // 
            // btnMarbeteManual
            // 
            this.btnMarbeteManual.Location = new System.Drawing.Point(40, 88);
            this.btnMarbeteManual.Name = "btnMarbeteManual";
            this.btnMarbeteManual.Size = new System.Drawing.Size(167, 31);
            this.btnMarbeteManual.TabIndex = 8;
            this.btnMarbeteManual.Text = "Marbete Manual";
            this.btnMarbeteManual.Visible = false;
            this.btnMarbeteManual.Click += new System.EventHandler(this.btnMarbeteManual_Click);
            // 
            // frmValidaLocalizacionArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.ControlBox = false;
            this.Controls.Add(this.btnMarbeteManual);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtArt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLoc);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmValidaLocalizacionArticulo";
            this.Text = "Validar la Localización y Articulo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmValidaLocalizacionArticulo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtArt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtLoc;
        private System.Windows.Forms.Button btnMarbeteManual;
    }
}