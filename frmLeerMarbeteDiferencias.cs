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
    public partial class frmLeerMarbeteDiferencias : Form
    {
        public frmLeerMarbeteDiferencias()
        {
            InitializeComponent();
        }
        Global mod = new Global();
        
        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void txtMarbete_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMarbete_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtMarbete.Text.Trim() != "")
            {
                DataSet dt = mod.ObtenerDatosMarbete(txtMarbete.Text.Trim(), Global.piid);
                if (dt != null)
                {
                    if (dt.Tables.Count > 0)
                    {
                        if (dt.Tables[0].Rows.Count > 0)
                        {
                            DataRow dr = dt.Tables[0].Rows[0];
                            //Conteo1
                            //Diferencias
                            //IdPareja
                            if (!string.IsNullOrEmpty(dr["Conteo1"].ToString()))
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
                            
                            }
                            //Pasillo, 
                            //Etiqueta, 
                            //Clave, 
                            //Localizacion, Cant_Fisica, Unidad, Costo, Conteo1, Conteo2, Observaciones, Variacion_Conteo, Diferencias, Conteos, IdPareja, 
                            //Descr, LotSerNbr
                            frmContarDiferencias f = new frmContarDiferencias();
                            f.lbl_marbete.Text = txtMarbete.Text.Trim();
                            f.marbete = int.Parse(txtMarbete.Text.Trim()); 
                            f.lbl_clave.Text = dr["Clave"].ToString().Trim();
                            f.lbl_loc.Text = dr["Localizacion"].ToString().Trim();
                            f.txt_desc.Text = dr["Descr"].ToString().Trim();
                            f.lblUnidad.Text = dr["Unidad"].ToString().Trim();
                            f.CantFisica = decimal.Parse(dr["Cant_Fisica"].ToString().Trim());
                            f.lbl_pasillo.Text = dr["Pasillo"].ToString().Trim();
                            f.lblTotConteos.Text = mod.TotConteosMarbete(Global.piid, txtMarbete.Text.Trim()).ToString().Trim();       
                            if (!string.IsNullOrEmpty(dr["LotSerNbr"].ToString().Trim()))
                            {
                                f.lblLote.Text = dr["LotSerNbr"].ToString().Trim();
                                f.lblTotMarbetes.Text = mod.TotMarbetesLocalizacion(txtMarbete.Text.Trim(), dr["Clave"].ToString().Trim(), dr["Localizacion"].ToString().Trim()).ToString();
                                f.totmarbetes = mod.TotMarbetesLocalizacion(txtMarbete.Text.Trim(), dr["Clave"].ToString().Trim(), dr["Localizacion"].ToString().Trim());
                            }
                            else
                            {
                                f.lblLote.Text = "";
                                f.lblTotMarbetes.Text = "1";
                                f.totmarbetes = 1;
                            }

                            this.Hide();
                            f.ShowDialog();
                            this.Visible = true;
                            txtMarbete.Text = "";
                            txtMarbete.Focus();



                        }
                    }
                }

            }


        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (txtMarbete.Text.Trim() != "")
            {
                DataSet dt = mod.SeleccionaMarbeteConDiferencia(Global.piid, Global.siteid, Global.pareja_no);
                if (dt != null)
                {
                    if (dt.Tables.Count > 0)
                    {
                        if (dt.Tables[0].Rows.Count > 0)
                        {
                            DataRow dr = dt.Tables[0].Rows[0];
                            //Conteo1
                            //Diferencias
                            //IdPareja
                            if (!string.IsNullOrEmpty(dr["Conteo1"].ToString()))
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

                            }
                            //Pasillo, 
                            //Etiqueta, 
                            //Clave, 
                            //Localizacion, Cant_Fisica, Unidad, Costo, Conteo1, Conteo2, Observaciones, Variacion_Conteo, Diferencias, Conteos, IdPareja, 
                            //Descr, LotSerNbr
                            frmContarDiferencias f = new frmContarDiferencias();
                            f.lbl_marbete.Text = txtMarbete.Text.Trim();
                            f.marbete = int.Parse(txtMarbete.Text.Trim());
                            f.lbl_clave.Text = dr["Clave"].ToString().Trim();
                            f.lbl_loc.Text = dr["Localizacion"].ToString().Trim();
                            f.txt_desc.Text = dr["Descr"].ToString().Trim();
                            f.lblUnidad.Text = dr["Unidad"].ToString().Trim();
                            f.CantFisica = decimal.Parse(dr["Cant_Fisica"].ToString().Trim());
                            f.lbl_pasillo.Text = dr["Pasillo"].ToString().Trim();
                            f.lblTotConteos.Text = mod.TotConteosMarbete(Global.piid, txtMarbete.Text.Trim()).ToString().Trim();
                            if (!string.IsNullOrEmpty(dr["LotSerNbr"].ToString().Trim()))
                            {
                                f.lblLote.Text = dr["LotSerNbr"].ToString().Trim();
                                f.lblTotMarbetes.Text = mod.TotMarbetesLocalizacion(txtMarbete.Text.Trim(), dr["Clave"].ToString().Trim(), dr["Localizacion"].ToString().Trim()).ToString();
                                f.totmarbetes = mod.TotMarbetesLocalizacion(txtMarbete.Text.Trim(), dr["Clave"].ToString().Trim(), dr["Localizacion"].ToString().Trim());
                            }
                            else
                            {
                                f.lblLote.Text = "";
                                f.lblTotMarbetes.Text = "1";
                                f.totmarbetes = 1;
                            }

                            this.Hide();
                            f.ShowDialog();
                            this.Visible = true;
                            txtMarbete.Text = "";
                            txtMarbete.Focus();
                        }
                    }
                }

            }
            else
            {
                frmContarDiferencias f = new frmContarDiferencias();
                //frmCargarMarbeteDiferencias f=new frmCargarMarbeteDiferencias();
                f.modoautomatico = true; 
                this.Hide();
                f.ShowDialog();
                this.Visible = true;
            }

           
        }

        private void frmLeerMarbeteDiferencias_Load(object sender, EventArgs e)
        {

        }
    }
}