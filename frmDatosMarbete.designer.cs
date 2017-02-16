namespace InventarioCL
{
    partial class frmDatosMarbete
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
            this.txtMarbete = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(49, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.Text = " Marbete #:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Visible = false;
            // 
            // txtMarbete
            // 
            this.txtMarbete.BackColor = System.Drawing.Color.Black;
            this.txtMarbete.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.txtMarbete.ForeColor = System.Drawing.Color.Lime;
            this.txtMarbete.Location = new System.Drawing.Point(29, 52);
            this.txtMarbete.Name = "txtMarbete";
            this.txtMarbete.Size = new System.Drawing.Size(167, 39);
            this.txtMarbete.TabIndex = 1;
            this.txtMarbete.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.Location = new System.Drawing.Point(51, 105);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(118, 33);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(49, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.Text = "Localizacion #";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtLoc
            // 
            this.txtLoc.BackColor = System.Drawing.Color.Black;
            this.txtLoc.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.txtLoc.ForeColor = System.Drawing.Color.Lime;
            this.txtLoc.Location = new System.Drawing.Point(29, 47);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(167, 39);
            this.txtLoc.TabIndex = 0;
            this.txtLoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLoc_KeyDown);
            // 
            // frmDatosMarbete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.ControlBox = false;
            this.Controls.Add(this.txtLoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtMarbete);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmDatosMarbete";
            this.Text = "Seleccionar Localizacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDatosMarbete_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtMarbete;
        public System.Windows.Forms.TextBox txtLoc;
    }
}