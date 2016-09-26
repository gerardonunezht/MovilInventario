namespace InventarioCL
{
    partial class frmLeerMarbeteDiferencias
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtMarbete = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(172, 128);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(118, 33);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // txtMarbete
            // 
            this.txtMarbete.BackColor = System.Drawing.Color.Black;
            this.txtMarbete.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular);
            this.txtMarbete.ForeColor = System.Drawing.Color.Lime;
            this.txtMarbete.Location = new System.Drawing.Point(3, 37);
            this.txtMarbete.Name = "txtMarbete";
            this.txtMarbete.Size = new System.Drawing.Size(287, 39);
            this.txtMarbete.TabIndex = 5;
            this.txtMarbete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMarbete_KeyDown_1);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.Text = "Numero De Marbete:";
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(3, 128);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(118, 33);
            this.btnContinuar.TabIndex = 8;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // frmLeerMarbeteDiferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtMarbete);
            this.Controls.Add(this.label1);
            this.Name = "frmLeerMarbeteDiferencias";
            this.Text = "Leer Marbete Con Diferencias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLeerMarbeteDiferencias_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtMarbete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnContinuar;
    }
}