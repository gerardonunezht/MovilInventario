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
    public partial class frmListaMarbetesConDiferencia : Form
    {
        public frmListaMarbetesConDiferencia()
        {
            InitializeComponent();
        }

        Global mod = new Global();
        void ListaMarbetesConDiferencias()
        {

        //CLAVE=
        //DESC=
        //PASILLO=
            string clave = "";
            string desc = "";
            string pasillo = "";
            if (cboBusqueda.Text.Trim() == "CLAVE=" && txtBusqueda.Text !="" )
            {
                clave = txtBusqueda.Text.Trim().ToUpper();
            }

            if (cboBusqueda.Text.Trim() == "DESC=" && txtBusqueda.Text != "")
            {
                desc = txtBusqueda.Text.Trim().ToUpper();
            }

            if (cboBusqueda.Text.Trim() == "PASILLO=" && txtBusqueda.Text != "")
            {
                pasillo= txtBusqueda.Text.Trim().ToUpper();
            }

            DataSet dt = mod.ListaMarbetesConDiferencias(Global.piid, Global.id_pareja,clave,desc,pasillo  );

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


       

        

       

        private void txtBusqueda_GotFocus(object sender, EventArgs e)
        {
            txtBusqueda.BackColor = Color.Yellow;   
        }

        private void txtBusqueda_LostFocus(object sender, EventArgs e)
        {
            txtBusqueda.BackColor = Color.White;   
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListaMarbetesConDiferencia_Load(object sender, EventArgs e)
        {
            ListaMarbetesConDiferencias(); 
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = ""; 
            ListaMarbetesConDiferencias();
        }

        private void cboBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBusqueda.Focus();
        }
    }
}