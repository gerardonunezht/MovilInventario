namespace InventarioCL
{
    partial class frmListaMarbetesPorContar
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
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.Location = new System.Drawing.Point(3, 8);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(234, 177);
            this.dataGrid1.TabIndex = 0;
            // 
            // cboBusqueda
            // 
            this.cboBusqueda.Items.Add("CLAVE=");
            this.cboBusqueda.Items.Add("DESC=");
            this.cboBusqueda.Items.Add("LOC=");
            this.cboBusqueda.Location = new System.Drawing.Point(3, 8);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(100, 23);
            this.cboBusqueda.TabIndex = 1;
            this.cboBusqueda.Visible = false;
            this.cboBusqueda.SelectedIndexChanged += new System.EventHandler(this.cboBusqueda_SelectedIndexChanged);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(123, 8);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(114, 23);
            this.txtBusqueda.TabIndex = 2;
            this.txtBusqueda.Visible = false;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            this.txtBusqueda.GotFocus += new System.EventHandler(this.txtBusqueda_GotFocus);
            this.txtBusqueda.LostFocus += new System.EventHandler(this.txtBusqueda_LostFocus);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.ForeColor = System.Drawing.Color.Snow;
            this.btnSalir.Location = new System.Drawing.Point(14, 196);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 40);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Lime;
            this.btnActualizar.Location = new System.Drawing.Point(145, 196);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(80, 40);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // frmListaMarbetesPorContar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cboBusqueda);
            this.Controls.Add(this.dataGrid1);
            this.Name = "frmListaMarbetesPorContar";
            this.Text = "Marbetes Por Contar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListaMarbetesPorContar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.ComboBox cboBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
    }
}