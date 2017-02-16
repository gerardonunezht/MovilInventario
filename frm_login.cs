using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection; 

namespace InventarioCL
{
    public partial class frm_login : Form 
    {
        public frm_login()
        {
            InitializeComponent();
        }
        //SqlConnection cn = new SqlConnection(Properties.Resources.connectionstring);
        Global mod = new Global();
        public bool acceso = false;

        private void Ingresar()
        {
            if (cbo_almacen.SelectedIndex != -1)
            {
                if (cbo_inventario.SelectedIndex != -1)
                {
                    if (txtPareja.Text.Trim() != "")
                    {
                        //IDPareja
                        //Pareja_No
                        DataSet dt = new DataSet();
                        DataRow dr;
                        dt = mod.Datos_Pareja(cbo_almacen.Text.Trim(), cbo_inventario.Text.Trim(), txtPareja.Text.Trim());
                        if (dt != null)
                        {
                            if (dt.Tables.Count > 0)
                            {
                                if (dt.Tables[0].Rows.Count > 0)
                                {
                                    dr = dt.Tables[0].Rows[0];
                                    if (!string.IsNullOrEmpty(dr["IDPareja"].ToString()))
                                    {
                                        Global.id_pareja = dr["IDPareja"].ToString().Trim();
                                    }
                                    if (!string.IsNullOrEmpty(dr["Pareja_No"].ToString()))
                                    {
                                        Global.pareja_no = dr["Pareja_No"].ToString().Trim();
                                    }
                                    Global.siteid = cbo_almacen.Text.Trim();
                                    Global.piid = cbo_inventario.Text.Trim();


                                    frm_Menu f = new frm_Menu();
                                    f.Show();
                                    mod.ActualizaStatus(Global.pareja_no,Global.piid, Global.siteid);
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Número de empleado no encontrado o ya tiene una sesión abierta."); ;
                                    txtPareja.Text = "";
                                    txtPareja.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Número de empleado no encontrado"); ;
                                txtPareja.Text = "";
                                txtPareja.Focus();

                            }
                        }
                        else
                        {
                            MessageBox.Show("Número de empleado no encontrado"); ;
                            txtPareja.Text = "";
                            txtPareja.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Introduzca número de empleado correctamente.."); ;
                        txtPareja.Text = "";
                        txtPareja.Focus();
                    }
                    Global.siteid = cbo_almacen.Text.Trim();
                    Global.piid = cbo_inventario.Text.Trim();

                }
                else
                {
                    MessageBox.Show("Seleccione el inventario correctamente");

                }
            }
            else
            {
                MessageBox.Show("Seleccione el almacen correctamente..");
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            Application.Exit();  
        }

        void lista_almacenes()
        {
            DataSet dt = new DataSet();
            dt = mod.lista_almacenes();
            cbo_almacen.Items.Clear();
            if (dt != null)
            {
                if (dt.Tables.Count > 0)
                {
                    foreach (DataRow dr in dt.Tables[0].Rows)
                    {
                        cbo_almacen.Items.Add(dr["SiteID"].ToString().Trim());
                    }
                }
            }
        }

        void lista_inventarios(string siteid)
        {
            if (siteid == "")
            {
                return;
            }
            DataSet dt = new DataSet();
            dt = mod.lista_inventarios(siteid);
            cbo_inventario.Items.Clear();
            if (dt != null)
            {
                if (dt.Tables.Count > 0)
                {
                    foreach (DataRow dr in dt.Tables[0].Rows)
                    {

                        cbo_inventario.Items.Add(dr["PIID"].ToString().Trim());
                    }


                }
            }
        }

        public string GetCurrentPublishVersion()
        {
            return Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            if (Properties.Resources.cn.ToString().Trim().Contains("produccion"))
            {
                lblServidor.ForeColor = Color.Red;
                lblServidor.Text = "Servidor: Produccion";
            }
            else
            {
                lblServidor.ForeColor = Color.Green;
                lblServidor.Text = "Servidor: Pruebas";
            }


    
            lblCompilacion.Text = "Versión:  " + GetCurrentPublishVersion();
            lista_almacenes();
            if (cbo_almacen.Items.Count != 0)
            {
                string siteid = mod.defualt_siteid();
                if (siteid != "")
                {
                    cbo_almacen.Text = siteid;
                }
            }
        }

        private void cbo_almacen_SelectedValueChanged(object sender, EventArgs e)
        {
            lista_inventarios(cbo_almacen.Text.Trim()); 
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        private void txtPareja_GotFocus(object sender, EventArgs e)
        {
            txtPareja.BackColor = Color.Yellow;
        }

        private void txtPareja_LostFocus(object sender, EventArgs e)
        {
            txtPareja.BackColor = Color.White ;
        }

        private void txtPareja_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                // Lo que hará al presionarse Enter
                //btnAceptar.Focus();
            } */

        }

        private void txtPareja_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Enter)
            {
                Ingresar();
            }

        }
    }
}