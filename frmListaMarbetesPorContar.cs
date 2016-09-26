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
    public partial class frmListaMarbetesPorContar : Form
    {
        public frmListaMarbetesPorContar()
        {
            InitializeComponent();
        }
        Global mod = new Global();

        void listamarbetes()
        {
            //CLAVE=
            //DESC=
            //LOC=
            //MARBETE=
            string clave = "";
            string desc = "";
            string loc = "";

            if (cboBusqueda.Text.Trim() == "CLAVE=" && txtBusqueda.Text != "")
            {
                clave = txtBusqueda.Text.Trim().ToUpper();
            }

            if (cboBusqueda.Text.Trim() == "DESC=" && txtBusqueda.Text != "")
            {
                desc = txtBusqueda.Text.Trim().ToUpper();
            }

            if (cboBusqueda.Text.Trim() == "LOC=" && txtBusqueda.Text != "")
            {
                loc = txtBusqueda.Text.Trim().ToUpper();
            }

            DataSet dt = mod.ListaMarbetesPorcontar(Global.piid, Global.id_pareja, clave, desc, loc);
            if (dt != null)
            {
                if (dt.Tables.Count > 0)
                {
                    dataGrid1.DataSource = dt.Tables[0];
                }
            }
            else
            {
                dataGrid1.DataSource = null;
            }
           
        
        }
               
        

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = ""; 
            listamarbetes();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            listamarbetes();
        }

        private void frmListaMarbetesPorContar_Load(object sender, EventArgs e)
        {
            listamarbetes();
        }

        private void cboBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBusqueda.Focus();
        }

        private void txtBusqueda_GotFocus(object sender, EventArgs e)
        {
            txtBusqueda.BackColor = Color.Yellow;   
        }

        private void txtBusqueda_LostFocus(object sender, EventArgs e)
        {
            txtBusqueda.BackColor = Color.White ;
        }

    }
}