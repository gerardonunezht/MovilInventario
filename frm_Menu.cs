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
        public string Nombre_Usuario = "";
        Global mod = new Global();

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
              
        private void btn_ini_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.Hide();
            frmDatosMarbete f = new frmDatosMarbete();
            f.diferencias = false;
               f.Show();
               ActualizaDatosMarbetes();
               timer1.Enabled = true;
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
            statusBar1.Text = DateTime.UtcNow.ToLocalTime().ToShortDateString().ToString() + " // " + DateTime.UtcNow.ToLocalTime().ToShortTimeString().ToString()+" // "+Global.nombre_usuario.ToUpper().Trim();
        }

        private void btn_dif_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.Hide();
            frmDatosMarbete f = new frmDatosMarbete();
            f.diferencias = true;
            f.Show();
            ActualizaDatosMarbetes();
            timer1.Enabled = true;

            //timer1.Enabled = false;
            //DataSet dt = mod.SeleccionaMarbeteConDiferencia(Global.piid, Global.siteid, Global.pareja_no);
            //if (dt != null)
            //{
            //    if (dt.Tables.Count > 0)
            //    {
            //        if (dt.Tables[0].Rows.Count > 0)
            //        {
            //            DataRow dr = dt.Tables[0].Rows[0];
            //            mod.ActualizaContador(int.Parse(Global.pareja_no), dr["Clave"].ToString().Trim(), Global.piid, Global.siteid, dr["Localizacion"].ToString().Trim());
            //            frmCargarMarbeteDiferencias f1 = new frmCargarMarbeteDiferencias();
            //            f1.lbl_marbete.Text = dr["Etiqueta"].ToString().Trim();
            //            f1.marbete = int.Parse(f1.lbl_marbete.Text);
            //            f1.lbl_clave.Text = dr["Clave"].ToString().Trim();
            //            f1.lbl_loc.Text = dr["Localizacion"].ToString().Trim();
            //            f1.txt_desc.Text = dr["Descr"].ToString().Trim();
            //            f1.lblUnidad.Text = dr["Unidad"].ToString().Trim();
            //            f1.CantFisica = decimal.Parse(dr["Cant_Fisica"].ToString().Trim());
            //            f1.lbl_pasillo.Text = dr["Pasillo"].ToString().Trim();
            //            f1.lblTotConteos.Text = mod.TotConteosMarbete(Global.piid, dr["Etiqueta"].ToString().Trim()).ToString().Trim();
            //            if (!string.IsNullOrEmpty(dr["LotSerNbr"].ToString().Trim()))
            //            {
            //                f1.lblTotMarbetes.Text = mod.TotMarbetesLocalizacion(dr["Etiqueta"].ToString().Trim(), dr["Clave"].ToString().Trim(), dr["Localizacion"].ToString().Trim()).ToString();
            //                f1.totmarbetes = mod.TotMarbetesLocalizacion(dr["Etiqueta"].ToString().Trim(), dr["Clave"].ToString().Trim(), dr["Localizacion"].ToString().Trim());
            //            }
            //            else
            //            {
            //                f1.lblTotMarbetes.Text = "1";
            //                f1.totmarbetes = 1;
            //            }

            //            this.Hide();
            //            timer1.Enabled = true; 
            //            f1.ShowDialog();
            //            this.Visible = true;

            //        }
            //        else
            //        {
            //            timer1.Enabled = false; 
            //        }
            //    }
            //}
            //else
            //{
            //    timer1.Enabled = false; 
            //}

            //this.Visible = true;
            //ActualizaDatosMarbetes();
            //timer1.Enabled = true;
        }

        private void txtTotMarbetes_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;   
            frmListaMarbetesPorContar f = new frmListaMarbetesPorContar();
            f.ShowDialog();
            txtTotMarbetes.Text = mod.TotMarbetesPorContar(Global.piid, Global.id_pareja).ToString();
            txtTotLoc.Text = mod.TotLocalizacionesPorContar(Global.piid, Global.id_pareja).ToString();
            txtDiferencias.Text = mod.TotMarbetesConDiferencias(Global.piid, Global.id_pareja).ToString();
            timer1.Enabled = true ;
        }

        private void txtTotLoc_Click(object sender, EventArgs e)
        {
            
            timer1.Enabled = false;
            frmListaLocalizacionesPorContar f = new frmListaLocalizacionesPorContar();
            f.ShowDialog();
            
            txtTotMarbetes.Text = mod.TotMarbetesPorContar(Global.piid, Global.id_pareja).ToString();
            txtTotLoc.Text = mod.TotLocalizacionesPorContar(Global.piid, Global.id_pareja).ToString();
            txtDiferencias.Text = mod.TotMarbetesConDiferencias(Global.piid, Global.id_pareja).ToString();
             
            ActualizaDatosMarbetes();
            timer1.Enabled = true;
              
        }

        private void txtDiferencias_Click(object sender, EventArgs e)
        {
            /*
            timer1.Enabled = false;
            frmListaMarbetesConDiferencia f = new frmListaMarbetesConDiferencia();
            f.ShowDialog();
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
            this.Hide();
            frmMarbeteManual f = new frmMarbeteManual();
            f.Show();
            timer1.Enabled = true;
            ActualizaDatosMarbetes();

        }


        private void btn_Dif_3_Mas_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            frmCargarMarbeteDiferencias f1 = new frmCargarMarbeteDiferencias();

            DataSet dt = mod.SeleccionaMarbeteConDiferenciaAsignado(Global.piid, Global.siteid, int.Parse(Global.pareja_no));

            if (dt != null)
            {
                if (dt.Tables.Count > 0)
                {
                    if (dt.Tables[0].Rows.Count > 0)
                    {
                        DataRow dr = dt.Tables[0].Rows[0];
                        f1.lbl_marbete.Text = dr["Etiqueta"].ToString().Trim();
                        f1.marbete = int.Parse(f1.lbl_marbete.Text);
                        f1.lbl_clave.Text = dr["Clave"].ToString().Trim();
                        f1.lbl_loc.Text = dr["Localizacion"].ToString().Trim();
                        f1.txt_desc.Text = dr["Descr"].ToString().Trim();
                        f1.lblUnidad.Text = dr["Unidad"].ToString().Trim();
                        f1.CantFisica = decimal.Parse(dr["Cant_Fisica"].ToString().Trim());
                        f1.lbl_pasillo.Text = dr["Pasillo"].ToString().Trim();
                        f1.lblTotConteos.Text = mod.TotConteosMarbete(Global.piid, dr["Etiqueta"].ToString().Trim()).ToString().Trim();
                        if (!string.IsNullOrEmpty(dr["LotSerNbr"].ToString().Trim()))
                        {
                            f1.lblTotMarbetes.Text = mod.TotMarbetesLocalizacion(dr["Etiqueta"].ToString().Trim(), dr["Clave"].ToString().Trim(), dr["Localizacion"].ToString().Trim()).ToString();
                            f1.totmarbetes = mod.TotMarbetesLocalizacion(dr["Etiqueta"].ToString().Trim(), dr["Clave"].ToString().Trim(), dr["Localizacion"].ToString().Trim());
                        }
                        else
                        {
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