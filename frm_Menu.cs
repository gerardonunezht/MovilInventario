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
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            mod.ActualizaStatus(Global.pareja_no, Global.piid, Global.siteid);
            this.Hide();
            frm_login f = new frm_login();
            f.Show();
        }

        public string Nombre_Usuario = "";
        Global mod = new Global();
      
        //Class1 mod = new Class1();

        private void btn_ini_Click(object sender, EventArgs e)
        {
            //if (mod.siteid == "" || mod.piid == "")
            //{
            //    frmAlmacen f = new frmAlmacen();
            //    this.Hide();
            //    f.ShowDialog();
            //    if (mod.siteid == "" || mod.piid == "")
            //    {
            //        frm_marbete f1 = new frm_marbete();
            //        f1.ShowDialog();
            //        this.Visible = true;

            //    }
            //    else
            //    {
            //        this.Visible = true;
            //    }
            //}
            //else
            timer1.Enabled = false;
            this.Hide();
            //this.Close();
            
            frmDatosMarbete f = new frmDatosMarbete();
               
               f.Show();
               ActualizaDatosMarbetes();
                /*
               txtTotMarbetes.Text = mod.TotMarbetesPorContar(Global.piid, Global.id_pareja).ToString();
               txtTotLoc.Text = mod.TotLocalizacionesPorContar(Global.piid, Global.id_pareja).ToString();
               txtDiferencias.Text = mod.TotMarbetesConDiferencias(Global.piid, Global.id_pareja).ToString();
                */
               timer1.Enabled = true;
                //this.Show();
      
        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label7.Text = Global.pareja_no;
            lblSiteID.Text  = Global.siteid;
            lblPIID.Text = Global.piid;
            DataSet dt = new DataSet();
            DataRow dr;
            dt = mod.Datos_Pareja(Global.siteid, Global.piid, Global.pareja_no);
            if (dt != null)
            {
                if (dt.Tables.Count > 0)
                {
                    if (dt.Tables[0].Rows.Count > 0)
                    {
                        dr = dt.Tables[0].Rows[0];
                        if (!string.IsNullOrEmpty(dr["Nombre1"].ToString()))
                        {

                            Global.nombre_usuario = dr["Nombre1"].ToString().Trim();
                        }
                        else
                        {
                            Global.nombre_usuario="";
                        }
                    }


                }

            }
            ActualizaDatosMarbetes();

            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ActualizaDatosMarbetes();
            //statusBar1.Text = "Bienvenido" + Nombre_Usuario.ToUpper().ToString().Trim() +", " + DateTime.Now.ToString().Trim();
            statusBar1.Text = DateTime.UtcNow.ToLocalTime().ToShortDateString().ToString() + " // " + DateTime.UtcNow.ToLocalTime().ToShortTimeString().ToString()+" // "+Global.nombre_usuario.ToUpper().Trim();
            

            /*
                ActualizaDatosMarbetes();
                DataSet dt = new DataSet();
                DataRow dr;
                dt = mod.Datos_Pareja(lblSiteID.Text.Trim(), lblPIID.Text.Trim(), Global.pareja_no.Trim());
                if (dt != null)
                {
                    if (dt.Tables.Count > 0)
                    {
                        if (dt.Tables[0].Rows.Count > 0)
                        {
                            dr = dt.Tables[0].Rows[0];
                            if (!string.IsNullOrEmpty(dr["Nombre1"].ToString()))
                            {

                                statusBar1.Text = "Bienvenido " + dr["Nombre1"].ToString().Trim() + ", "+i.ToString() +DateTime.Now.ToString();

                            }
                            else
                            {
                                statusBar1.Text = "Bienvenido al sistema de inventarios: " + DateTime.Now.ToString();
                            }


                        }
                    }
                }
             */


 
        }

        private void btn_dif_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            //frmLeerMarbeteDiferencias f = new frmLeerMarbeteDiferencias();
            frmCargarMarbeteDiferencias f1 = new frmCargarMarbeteDiferencias();

            DataSet dt = mod.SeleccionaMarbeteConDiferencia(Global.piid, Global.siteid, Global.pareja_no);

            if (dt != null)
            {
                if (dt.Tables.Count > 0)
                {
                    if (dt.Tables[0].Rows.Count > 0)
                    {
                        DataRow dr = dt.Tables[0].Rows[0];
                        mod.ActualizaContador(int.Parse(Global.pareja_no), dr["Clave"].ToString().Trim(), Global.piid, Global.siteid, dr["Localizacion"].ToString().Trim());
                       
                        //Conteo1
                        //Diferencias
                        //IdPareja
                        /*if (!string.IsNullOrEmpty(dr["Conteo1"].ToString()))
                        {
                            if (!string.IsNullOrEmpty(dr["Diferencias"].ToString()))
                            {
                                if (bool.Parse(dr["Diferencias"].ToString()) == false)
                                {
                                    MessageBox.Show("Marbete con diferencias ya fue capturado");
                                    txtMarbete.Text = "";
                                    txtMarbete.Focus();
                                    return;
                                }

                            }
                        }
                        else
                        {
                            MessageBox.Show("Marbete pendiente de contar CONTEO1");
                            txtMarbete.Text = "";
                            txtMarbete.Focus();
                            return;

                        }*/

                        //Pasillo, 
                        //Etiqueta, 
                        //Clave, 
                        //Localizacion, Cant_Fisica, Unidad, Costo, Conteo1, Conteo2, Observaciones, Variacion_Conteo, Diferencias, Conteos, IdPareja, 
                        //Descr, LotSerNbr
                        //frmContarDiferencias f = new frmContarDiferencias();


                        f1.lbl_marbete.Text = dr["Etiqueta"].ToString().Trim();
                        f1.marbete = int.Parse(f1.lbl_marbete.Text);

                        //f.marbete = int.Parse(txtMarbete.Text.Trim());
                        f1.lbl_clave.Text = dr["Clave"].ToString().Trim();
                        
                        f1.lbl_loc.Text = dr["Localizacion"].ToString().Trim();
                        f1.txt_desc.Text = dr["Descr"].ToString().Trim();
                        f1.lblUnidad.Text = dr["Unidad"].ToString().Trim();
                        f1.CantFisica = decimal.Parse(dr["Cant_Fisica"].ToString().Trim());
                        f1.lbl_pasillo.Text = dr["Pasillo"].ToString().Trim();
                        f1.lblTotConteos.Text = mod.TotConteosMarbete(Global.piid, dr["Etiqueta"].ToString().Trim()).ToString().Trim();
                        if (!string.IsNullOrEmpty(dr["LotSerNbr"].ToString().Trim()))
                        {
                            f1.lblLote.Text = dr["LotSerNbr"].ToString().Trim();
                            f1.lblTotMarbetes.Text = mod.TotMarbetesLocalizacion(dr["Etiqueta"].ToString().Trim(), dr["Clave"].ToString().Trim(), dr["Localizacion"].ToString().Trim()).ToString();
                            f1.totmarbetes = mod.TotMarbetesLocalizacion(dr["Etiqueta"].ToString().Trim(), dr["Clave"].ToString().Trim(), dr["Localizacion"].ToString().Trim());
                        }
                        else
                        {
                            f1.lblLote.Text = "";
                            f1.lblTotMarbetes.Text = "1";
                            f1.totmarbetes = 1;
                        }

                        this.Hide();
                        timer1.Enabled = true; 
                        f1.ShowDialog();
                        this.Visible = true;

                    }
                    else
                    {
                        timer1.Enabled = false; 
                    }
                }
            }
            else
            {
                timer1.Enabled = false; 
            }



            this.Visible = true;
            /*
            txtTotMarbetes.Text = mod.TotMarbetesPorContar(Global.piid, Global.id_pareja).ToString();
            txtTotLoc.Text = mod.TotLocalizacionesPorContar(Global.piid, Global.id_pareja).ToString();
            txtDiferencias.Text = mod.TotMarbetesConDiferencias(Global.piid, Global.id_pareja).ToString();
            */
            ActualizaDatosMarbetes(); 
        }

        private void txtTotMarbetes_Click(object sender, EventArgs e)
        {
            /*
            timer1.Enabled = false;   
            frmListaMarbetesPorContar f = new frmListaMarbetesPorContar();
            f.ShowDialog();
            txtTotMarbetes.Text = mod.TotMarbetesPorContar(Global.piid, Global.id_pareja).ToString();
            txtTotLoc.Text = mod.TotLocalizacionesPorContar(Global.piid, Global.id_pareja).ToString();
            txtDiferencias.Text = mod.TotMarbetesConDiferencias(Global.piid, Global.id_pareja).ToString();
            timer1.Enabled = true ;
            */

        }

        private void txtTotLoc_Click(object sender, EventArgs e)
        {
            /*
            timer1.Enabled = false;
            frmListaLocalizacionesPorContar f = new frmListaLocalizacionesPorContar();
            f.ShowDialog();
            
            txtTotMarbetes.Text = mod.TotMarbetesPorContar(Global.piid, Global.id_pareja).ToString();
            txtTotLoc.Text = mod.TotLocalizacionesPorContar(Global.piid, Global.id_pareja).ToString();
            txtDiferencias.Text = mod.TotMarbetesConDiferencias(Global.piid, Global.id_pareja).ToString();
             
            ActualizaDatosMarbetes();
            timer1.Enabled = true;
              */
        }

        private void txtDiferencias_Click(object sender, EventArgs e)
        {
            /*
            timer1.Enabled = false;
            frmListaMarbetesConDiferencia f = new frmListaMarbetesConDiferencia();
            f.ShowDialog();
            
            txtTotMarbetes.Text = mod.TotMarbetesPorContar(Global.piid, Global.id_pareja).ToString();
            txtTotLoc.Text = mod.TotLocalizacionesPorContar(Global.piid, Global.id_pareja).ToString();
            txtDiferencias.Text = mod.TotMarbetesConDiferencias(Global.piid, Global.id_pareja).ToString();
             
            ActualizaDatosMarbetes();
            timer1.Enabled = true;
             */
        }

        private void frm_Menu_Closing(object sender, CancelEventArgs e)
        {
            timer1.Enabled = false;

        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            frmMarbeteManual f = new frmMarbeteManual();
            f.ShowDialog();
            /*
            txtTotMarbetes.Text = mod.TotMarbetesPorContar(Global.piid, Global.id_pareja).ToString();
            txtTotLoc.Text = mod.TotLocalizacionesPorContar(Global.piid, Global.id_pareja).ToString();
            txtDiferencias.Text = mod.TotMarbetesConDiferencias(Global.piid, Global.id_pareja).ToString();
             */
            timer1.Enabled = true;
            ActualizaDatosMarbetes();

        }


        private void btn_Dif_3_Mas_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            //frmLeerMarbeteDiferencias f = new frmLeerMarbeteDiferencias();
            frmCargarMarbeteDiferencias f1 = new frmCargarMarbeteDiferencias();

            DataSet dt = mod.SeleccionaMarbeteConDiferenciaAsignado(Global.piid, Global.siteid, int.Parse(Global.pareja_no));

            if (dt != null)
            {
                if (dt.Tables.Count > 0)
                {
                    if (dt.Tables[0].Rows.Count > 0)
                    {
                        DataRow dr = dt.Tables[0].Rows[0];
                        //mod.ActualizaContador(int.Parse(Global.pareja_no.ToString().Trim()), dr["Clave"].ToString().Trim(), Global.piid, Global.siteid, dr["Localizacion"].ToString().Trim());

                        //Conteo1
                        //Diferencias
                        //IdPareja
                        /*if (!string.IsNullOrEmpty(dr["Conteo1"].ToString()))
                        {
                            if (!string.IsNullOrEmpty(dr["Diferencias"].ToString()))
                            {
                                if (bool.Parse(dr["Diferencias"].ToString()) == false)
                                {
                                    MessageBox.Show("Marbete con diferencias ya fue capturado");
                                    txtMarbete.Text = "";
                                    txtMarbete.Focus();
                                    return;
                                }

                            }
                        }
                        else
                        {
                            MessageBox.Show("Marbete pendiente de contar CONTEO1");
                            txtMarbete.Text = "";
                            txtMarbete.Focus();
                            return;

                        }*/

                        //Pasillo, 
                        //Etiqueta, 
                        //Clave, 
                        //Localizacion, Cant_Fisica, Unidad, Costo, Conteo1, Conteo2, Observaciones, Variacion_Conteo, Diferencias, Conteos, IdPareja, 
                        //Descr, LotSerNbr
                        //frmContarDiferencias f = new frmContarDiferencias();


                        f1.lbl_marbete.Text = dr["Etiqueta"].ToString().Trim();
                        f1.marbete = int.Parse(f1.lbl_marbete.Text);

                        //f.marbete = int.Parse(txtMarbete.Text.Trim());
                        f1.lbl_clave.Text = dr["Clave"].ToString().Trim();

                        f1.lbl_loc.Text = dr["Localizacion"].ToString().Trim();
                        f1.txt_desc.Text = dr["Descr"].ToString().Trim();
                        f1.lblUnidad.Text = dr["Unidad"].ToString().Trim();
                        f1.CantFisica = decimal.Parse(dr["Cant_Fisica"].ToString().Trim());
                        f1.lbl_pasillo.Text = dr["Pasillo"].ToString().Trim();
                        f1.lblTotConteos.Text = mod.TotConteosMarbete(Global.piid, dr["Etiqueta"].ToString().Trim()).ToString().Trim();
                        if (!string.IsNullOrEmpty(dr["LotSerNbr"].ToString().Trim()))
                        {
                            f1.lblLote.Text = dr["LotSerNbr"].ToString().Trim();
                            f1.lblTotMarbetes.Text = mod.TotMarbetesLocalizacion(dr["Etiqueta"].ToString().Trim(), dr["Clave"].ToString().Trim(), dr["Localizacion"].ToString().Trim()).ToString();
                            f1.totmarbetes = mod.TotMarbetesLocalizacion(dr["Etiqueta"].ToString().Trim(), dr["Clave"].ToString().Trim(), dr["Localizacion"].ToString().Trim());
                        }
                        else
                        {
                            f1.lblLote.Text = "";
                            f1.lblTotMarbetes.Text = "1";
                            f1.totmarbetes = 1;
                        }

                        this.Hide();
                        f1.ShowDialog();
                        timer1.Enabled = true;
                        this.Visible = true;

                    }
                    else
                    {
                        timer1.Enabled = false;
                    }
                }
            }
            else
            {
                timer1.Enabled = false;
            }



            this.Visible = true;
            
            /*
            txtTotMarbetes.Text = mod.TotMarbetesPorContar(Global.piid, Global.id_pareja).ToString();
            txtTotLoc.Text = mod.TotLocalizacionesPorContar(Global.piid, Global.id_pareja).ToString();
            txtDiferencias.Text = mod.TotMarbetesConDiferencias(Global.piid, Global.id_pareja).ToString();
             */
            ActualizaDatosMarbetes();
        }
        public void ActualizaDatosMarbetes()
        {

            txtTotMarbetes.Text = mod.TotMarbetesPorContar(Global.piid, Global.id_pareja).ToString();
            txtTotLoc.Text = mod.TotLocalizacionesPorContar(Global.piid, Global.id_pareja).ToString();
            txtDiferencias.Text = mod.TotMarbetesConDiferencias(Global.piid, Global.id_pareja).ToString();  
        }

    }
}