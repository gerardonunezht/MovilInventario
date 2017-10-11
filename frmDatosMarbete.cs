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
    public partial class frmDatosMarbete : Form
    {

        public frmDatosMarbete()
        {
            InitializeComponent();
        }

        Global mod = new Global();
        public bool diferencias;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Menu f = new frm_Menu();
            f.Show();
            
            //this.Hide();

        }

        private void txtMarbete_GotFocus(object sender, EventArgs e)
        {
           txtMarbete.BackColor = Color.Yellow;  
        }

        private void txtMarbete_LostFocus(object sender, EventArgs e)
        {
           txtMarbete.BackColor = Color.White;  
        }

        bool ObtenerDatosMarbete()
        {
            try
            {
              return true; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos.." + ex.Message.ToString());
                return false; 
            }         
        }

        /*
         private void txtMarbete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtMarbete.Text.Trim()!=""  )
            { 
              DataSet dt=mod.ObtenerDatosMarbete(txtMarbete.Text.Trim(),Global.piid  );
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
                          {   if (!string.IsNullOrEmpty(dr["Diferencias"].ToString()))
                              {
                                  if (bool.Parse(dr["Diferencias"].ToString()))
                                  {
                                      MessageBox.Show("Marbete con diferencias ya fue capturado");
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
                          f.marbete = int.Parse(txtMarbete.Text.Trim());
                          f.lbl_marbete.Text = txtMarbete.Text.Trim();
                          f.lbl_clave.Text = dr["Clave"].ToString().Trim();
                          f.lbl_loc.Text = dr["Localizacion"].ToString().Trim();
                          f.txt_desc.Text = dr["Descr"].ToString().Trim();
                          f.lblUnidad.Text = dr["Unidad"].ToString().Trim();
                          f.CantFisica = decimal.Parse(dr["Cant_Fisica"].ToString().Trim());
                          f.lbl_pasillo.Text = dr["Pasillo"].ToString().Trim(); 
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
                          this.Close();
                          f.ShowDialog();
                          this.Visible = true;
                          txtMarbete.Text = "";
                          txtMarbete.Focus(); 


                            
                      }
                  }
              }

            }


        }
        */

        private void txtLoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtLoc.Text.Trim() != "")
            {
                if (diferencias==false)
                {
                    int tot = mod.ValidaLocalizacionInventario(txtLoc.Text.Trim().ToUpper(), Global.piid);
                    if (tot > 0)
                    {
                        frmValidaLocalizacionArticulo f = new frmValidaLocalizacionArticulo();
                        f.txtLoc.Text = txtLoc.Text.ToString().Trim();
                        this.Close();
                        f.Show();
                    }
                    else if (tot == 0)
                    {
                        MessageBox.Show("Usuario no asignado a esta localización.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        txtLoc.Text = "";
                    }
                    else if (tot == -1)
                    {
                        MessageBox.Show("Localización sin marbete.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        btnMarbeteManual.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Error...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    if (!mod.ValidaLocalizacionInventarioConDiferencias(txtLoc.Text.Trim().ToUpper(), Global.piid))
                    {
                        MessageBox.Show("La localización no tiene diferencia de conteo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        frmValidaLocalizacionArticulo f = new frmValidaLocalizacionArticulo();
                        f.txtLoc.Text = txtLoc.Text.ToString().Trim();
//                        MessageBox.Show(diferencias.ToString());
                        f.diferencias = true;
                        this.Close();
                        f.Show();
                        
                    }
                }
                

                //verificar que la localizacion sea valida
                //if (!mod.ValidaLocalizacionInventario(txtLoc.Text.Trim().ToUpper(), Global.piid))
                //{
                //    txtLoc.Text = "";
                //    txtLoc.Focus();
                //    return;
                //}
                //else
                //{
                //frmValidaLocalizacionArticulo f = new frmValidaLocalizacionArticulo();
                //f.txtLoc.Text = txtLoc.Text.ToString().Trim();
                //this.Close();
                //f.Show();

                //this.ShowDialog();
                   
                //}

                /*
                //obtener los datos del marbete asignado a la localizacion
                DataSet dt = mod.ObtenerMarbeteLocalizacion(txtLoc.Text.Trim().ToUpper(), Global.piid);
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
                                f.marbete = marbete;
                                f.lbl_marbete.Text = marbete.ToString()  ;
                                f.lbl_clave.Text = dr["Clave"].ToString().Trim();
                                f.lbl_loc.Text = dr["Localizacion"].ToString().Trim();
                                f.txt_desc.Text = dr["Descr"].ToString().Trim();
                                f.lblUnidad.Text = dr["Unidad"].ToString().Trim();
                                f.CantFisica = decimal.Parse(dr["Cant_Fisica"].ToString().Trim());
                                f.lbl_pasillo.Text = dr["Pasillo"].ToString().Trim();
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
                                txtLoc.Text = "";
                                txtLoc.Focus();
                        } // if (dt.Tables[0].Rows.Count > 0)
                        
                        //try

                    }
                    else
                    {
                        MessageBox.Show("Error al obtener marbetes en la localizacion");
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
*/
            }
                 
                 
        }

        private void frmDatosMarbete_Load(object sender, EventArgs e)
        {
            btnMarbeteManual.Visible = false;
            txtLoc.Focus();
            if (diferencias==true)
            {
                lblDif.Visible = true;
            }
            else
            {
                lblDif.Visible = false;

            }
        }

        private void btnMarbeteManual_Click(object sender, EventArgs e)
        {
            frmMarbeteManual formMarbeteManual = new frmMarbeteManual();
            btnMarbeteManual.Visible = false;
            this.Close();
            formMarbeteManual.Show();
        }

    }
}