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
    public partial class frmValidaLocalizacionArticulo : Form
    {
        Global mod = new Global();

        public frmValidaLocalizacionArticulo()
        {
            InitializeComponent();
        }


        public void frmValidaLocalizacionArticulo_Load(object sender, EventArgs e)
        {
            txtArt.Focus();
            btnMarbeteManual.Visible = false;
        }

        public void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void txtArt_GotFocus(object sender, EventArgs e)
        {
            txtArt.BackColor = Color.Yellow;  
        }

        public void txtArt_LostFocus(object sender, EventArgs e)
        {
            txtArt.BackColor = Color.White;  

        }

        public void txtArt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtArt.Text.Trim() != "")
            {
                if (mod.ValidaLocalizacionInventarioArticulo(txtLoc.Text.Trim().ToUpper(), Global.piid, txtArt.Text.Trim()))
                {
                    if (txtLoc.Text.Trim() != "")
                    {

                        //obtener los datos del marbete asignado a la localizacion por articulo
                        DataSet dt = mod.ObtenerMarbeteLocalizacion(txtLoc.Text.Trim().ToUpper(), Global.piid, txtArt.Text.Trim());
                        int marbete = 0;
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

                                    marbete = int.Parse(dr["Etiqueta"].ToString());

                                    if (!string.IsNullOrEmpty(dr["Conteo1"].ToString()))
                                    {
                                        if (!string.IsNullOrEmpty(dr["Diferencias"].ToString()))
                                        {
                                            if (bool.Parse(dr["Diferencias"].ToString()))
                                            {
                                                MessageBox.Show("Marbete con diferencias ya fue capturado");
                                                this.Close();

                                                return;
                                                

                                            }
                                        }
                                    }
                                    //Pasillo, 
                                    //Etiqueta, 
                                    //Clave, 
                                    //Localizacion, Cant_Fisica, Unidad, Costo, Conteo1, Conteo2, Observaciones, Variacion_Conteo, Diferencias, Conteos, IdPareja, 
                                    //Descr, LotSerNbr

                                    frm_marbete f = new frm_marbete();
                                    frmDatosMarbete f2 = new frmDatosMarbete();
                                    f.marbete = marbete;
                                    f.lbl_marbete.Text = marbete.ToString();
                                    f.lbl_clave.Text = dr["Clave"].ToString().Trim();
                                    f.lbl_loc.Text = dr["Localizacion"].ToString().Trim();
                                    f.txt_desc.Text = dr["Descr"].ToString().Trim();
                                    f.lblUnidad.Text = dr["Unidad"].ToString().Trim();
                                    f.CantFisica = decimal.Parse(dr["Cant_Fisica"].ToString().Trim());
                                    f.lbl_pasillo.Text = dr["Pasillo"].ToString().Trim();
                                    if (!string.IsNullOrEmpty(dr["LotSerNbr"].ToString().Trim()))
                                    {
                                        f.lblLote.Text = dr["LotSerNbr"].ToString().Trim();
                                        f.lblTotMarbetes.Text = mod.TotMarbetesLocalizacion(f2.txtMarbete.Text.Trim(), dr["Clave"].ToString().Trim(), dr["Localizacion"].ToString().Trim()).ToString();
                                        f.totmarbetes = mod.TotMarbetesLocalizacion(f2.txtMarbete.Text.Trim(), dr["Clave"].ToString().Trim(), dr["Localizacion"].ToString().Trim());
                                    }
                                    else
                                    {
                                        f.lblLote.Text = "";
                                        f.lblTotMarbetes.Text = "1";
                                        f.totmarbetes = 1;
                                    }

                                    this.Close();
                                    f.Show();

                                }
                                else
                                {
                                    MessageBox.Show("Articulo ya capturado.");
                                    this.Close();
                                    frmDatosMarbete f = new frmDatosMarbete();
                                    f.Show();

                                    
                                    
                                    
                                }// if (dt.Tables[0].Rows.Count > 0)

                                //try

                            }
                            else
                            {
                                MessageBox.Show("Error al obtener marbetes en la localizacion");
                                this.Close();

                                txtLoc.Text = "";
                                txtLoc.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error al obtener marbetes en la localizacion");
                            txtLoc.Text = "";
                            txtLoc.Focus();

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Localizacion no coincide con articulo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    btnMarbeteManual.Visible = true;
                    /*
                    this.Close();
                    frm_Menu f = new ();
                    f.txtLoc.Text = "";
                    f.txtLoc.Focus();
                    f.Show();
                    */

                }
               
            }
        }


        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            frm_Menu f = new frm_Menu();
            f.Show();
            this.Close();
           

        }

        private void btnMarbeteManual_Click(object sender, EventArgs e)
        {
            frmMarbeteManual f = new frmMarbeteManual();
            f.Show();
            this.Close();
        }
    }
}