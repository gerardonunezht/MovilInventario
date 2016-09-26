using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventarioCL
{
    public partial class frmListaLocalizacionesPorContar : Form
    {
        public frmListaLocalizacionesPorContar()
        {
            InitializeComponent();
        }

        Global mod = new Global();
        void ListaLocalizaciones()
        {
            string loc = "";
            if (cboBusqueda.Text.Trim() != "" && txtBusqueda.Text != "")
            {
                loc = txtBusqueda.Text.Trim().ToUpper();
            }

            DataSet dt = mod.ListaLocalizacionesPorContar(Global.piid, Global.id_pareja, loc);

            if (dt != null)
            {
                if (dt.Tables.Count > 0)
                {
                    dataGrid1.DataSource = dt.Tables[0];
                }
                else
                {
                    dataGrid1.DataSource = null;
                }
            }
            else
            {
                dataGrid1.DataSource = null;
            }
        
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {                         
            
  
        }

       

        
        private void frmListaLocalizacionesPorContar_Load(object sender, EventArgs e)
        {
            ListaLocalizaciones();
        }

       

        

        private void button1_Click(object sender, EventArgs e)
        {
            ListaLocalizaciones();
        }

        private void txtBusqueda_GotFocus(object sender, EventArgs e)
        {
            txtBusqueda.BackColor = Color.Yellow;  
        }

        private void txtBusqueda_LostFocus(object sender, EventArgs e)
        {
            txtBusqueda.BackColor = Color.White;
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            ListaLocalizaciones();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}