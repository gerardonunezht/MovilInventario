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
    public partial class frmCargarMarbeteDiferencias : Form
    {
        public int tipo;

        public frmCargarMarbeteDiferencias()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            
                timer3.Enabled = false;
                string res = MessageBox.Show("Tiene un marbete pendiente de CONTEO, Desea Salir? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2).ToString();
                if (res == "Yes")
                {
                    mod.ActualizaContador(0, lbl_clave.Text.ToString().Trim(), Global.piid.ToString().Trim(), Global.siteid.ToString().Trim(), lbl_loc.Text);
                    
                    /*if (mod.LiberarMarbeteConteoDiferencias(lbl_marbete.Text.Trim()))
                    {
                        timer3.Enabled = false;
                        timer2.Enabled = false;
                        timer1.Enabled = false;
                        lbl_marbete.Text = "";
                        
                        this.Close();
                    }
                    else
                    {
                        timer3.Enabled = true;
                        txtCantidad.Focus();
                    }*/

                    timer3.Enabled = false;
                    timer2.Enabled = false;
                    timer1.Enabled = false;
                    this.Close();
                    

            }
            else
            {
                return;
            }
        }
        
        public int marbete = 0;
        public int totmarbetes = 0;
        public decimal CantFisica = 0;
        Global mod = new Global();
        public bool modoautomatico = true;

        public string LocActual = "";
        public string ClaveActual = "";

        /// <summary>
        /// Obtiene los datos del marbete asignado para conteo
        /// </summary>
        /// <param name="Etiqueta"></param>
        /// <returns></returns>
        bool ObtenerDatosMarbete(string Etiqueta)
        {
            timer3.Enabled = true;

            if (Etiqueta == "")
            {
                return false;
            }
            DataSet dt = mod.ObtenerDatosMarbete(Etiqueta, Global.piid);
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
                                    //txtMarbete.Text = "";
                                    //txtMarbete.Focus();
                                    return false;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Marbete pendiente de contar CONTEO1");
                            //txtMarbete.Text = "";
                            //txtMarbete.Focus();
                            return false;

                        }
                        //Pasillo, 
                        //Etiqueta, 
                        //Clave, 
                        //Localizacion, Cant_Fisica, Unidad, Costo, Conteo1, Conteo2, Observaciones, Variacion_Conteo, Diferencias, Conteos, IdPareja, 
                        //Descr, LotSerNbr  
                        marbete = int.Parse(Etiqueta);
                        lbl_marbete.Text = Etiqueta;
                        lbl_clave.Text = dr["Clave"].ToString().Trim();
                        ClaveActual = dr["Clave"].ToString().Trim();
                        lbl_loc.Text = dr["Localizacion"].ToString().Trim();
                        mod.LocActual = dr["Localizacion"].ToString().Trim();
                        LocActual = dr["Localizacion"].ToString().Trim();
                        txt_desc.Text = dr["Descr"].ToString().Trim();
                        lblUnidad.Text = dr["Unidad"].ToString().Trim();
                        CantFisica = decimal.Parse(dr["Cant_Fisica"].ToString().Trim());
                        lbl_pasillo.Text = dr["Pasillo"].ToString().Trim();
                        lblTotConteos.Text = mod.TotConteosMarbete(Global.piid, Etiqueta).ToString().Trim();
                        if (!string.IsNullOrEmpty(dr["LotSerNbr"].ToString().Trim()))
                        {
                            lblLote.Text = dr["LotSerNbr"].ToString().Trim();
                            lblTotMarbetes.Text = mod.TotMarbetesLocalizacion(Etiqueta, dr["Clave"].ToString().Trim(), dr["Localizacion"].ToString().Trim()).ToString();
                            totmarbetes = mod.TotMarbetesLocalizacion(Etiqueta, dr["Clave"].ToString().Trim(), dr["Localizacion"].ToString().Trim());
                        }
                        else
                        {
                            lblLote.Text = "";
                            lblTotMarbetes.Text = "1";
                            totmarbetes = 1;
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Obtiene de forma automatica el marbete para contar
        /// </summary>
        /// <returns></returns>
        bool ObtenerMarbete()
        {
            try
            {
                string Etiqueta = "";
                marbete = 0;
                if (mod.ObetenerMarbeteConteoDiferencias(out Etiqueta))
                {
                    if (ObtenerDatosMarbete(Etiqueta))
                    {
                        txtCantidad.Enabled = true;
                        txtVerifCantidad.Enabled = true;
                        btn_continuar.Enabled = true;
                        txtCantidad.Focus();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }

        }

        void LimpiarDatos()
        {
            lbl_marbete.Text = "";
            lblUnidad.Text = "";
            lbl_loc.Text = "";
            lbl_clave.Text = "";
            lbl_pasillo.Text = "";
            lblLote.Text = "";
            lblTotConteos.Text = "0";
            lblTotMarbetes.Text = "0";
            txt_desc.Text = "";
            totmarbetes = 0;
            CantFisica = 0;
            txtCantidad.Text = "";
            marbete = 0;
            btn_continuar.Enabled = false;
            txtCantidad.Text = "";
            txtCantidad.Enabled = false;
            txtVerifCantidad.Text = "";
            txtVerifCantidad.Enabled = false;
            
            
            this.Close();
            
        }

        void GuardarDatos()
        {

            try
            {
                timer3.Enabled = false;
                if (lblLote.Text.Trim() != "")
                {
                    if (totmarbetes > 1)
                    {
                        //guardar la cantidad distribuyendola de manera proporcional en los marbetes
                        if (mod.GuardarMarbetePedimentoConDiferencias(lbl_marbete.Text.Trim(), Global.pareja_no, Global.piid, lbl_clave.Text.Trim(), lbl_loc.Text.Trim().ToUpper(), decimal.Parse(txtCantidad.Text.Trim()), ""))
                        {
                            timer3.Enabled = false;
                            System.Media.SystemSounds.Beep.Play();
                            statusBar1.Text = "";
                            LimpiarDatos();
                            timer1.Enabled = true;
                            timer2.Enabled = true;

                            return;
                        }
                    }
                    else //if (tot_marbetes > 1)
                    {
                        //si solo es un marbete en la localizacion
                        //guardar los datos del marbete normal
                        if (mod.GuardarMarbeteConteo2(lbl_marbete.Text.Trim(), Global.pareja_no, Global.piid, txtCantidad.Text.Trim(), ""))
                        {
                            System.Media.SystemSounds.Beep.Play();
                            LimpiarDatos();
                            
                            timer1.Enabled = true;
                            timer3.Enabled = false;
                            return;
                        }
                    }
                }
                else
                {  //guardar los datos del marbete normal
                    if (mod.GuardarMarbeteConteo2(lbl_marbete.Text.Trim(), Global.pareja_no, Global.piid, txtCantidad.Text.Trim(), ""))
                    {
                        System.Media.SystemSounds.Beep.Play();
                        LimpiarDatos();
                        
                        timer1.Enabled = true;
                        timer3.Enabled = false;
                        return;
                    }
                }
                this.Hide();
                this.Close();
                frmDatosMarbete f = new frmDatosMarbete();
                f.ShowDialog();

            }
            catch (Exception ex)
            {
                timer3.Enabled = true;
                MessageBox.Show("Error Al Guardar Datos.." + ex.Message.ToString());
                LimpiarDatos();

            }
            this.Hide();
            this.Close();
            //frmDatosMarbete f = new frmDatosMarbete();
            //f.ShowDialog();
        }

        private void txtCantidad_GotFocus(object sender, EventArgs e)
        {
            txtCantidad.BackColor = Color.Yellow;
        }

        private void txtCantidad_LostFocus(object sender, EventArgs e)
        {
            txtCantidad.BackColor = Color.White;
        }


        private void frmContarDiferencias_Load(object sender, EventArgs e)
        {
            
            if (modoautomatico)
            {
                timer1.Enabled = true;
            }
            if (marbete > 0)
            {
                btn_continuar.Enabled = true;
                timer3.Enabled = true;
                txtCantidad.Enabled = true;
                txtVerifCantidad.Enabled = true;
                txtCantidad.Focus();

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (statusBar1.Text.Trim() == "")
            {
                statusBar1.Text = "Esperando Marbete Para Conteo...............";
            }
            else
            {
                statusBar1.Text = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
            timer1.Enabled = false;
            //obtener el marbete para contar
            if (ObtenerMarbete())
            {
                statusBar1.Text = "";
                System.Media.SystemSounds.Exclamation.Play();
                timer2.Enabled = false;
                timer3.Enabled = true;
                txtCantidad.Text = "";
                txtCantidad.Focus();
                btn_continuar.Enabled = true;

            }
            else
            {
                timer1.Enabled = true;
            }
             */

        }


        private void txtCantidad_GotFocus_1(object sender, EventArgs e)
        {
            txtCantidad.BackColor = Color.Yellow;
        }

        private void txtCantidad_LostFocus_1(object sender, EventArgs e)
        {
            txtCantidad.BackColor = Color.White;
        }

        

        private void txtVerifCantidad_GotFocus(object sender, EventArgs e)
        {
            txtVerifCantidad.BackColor = Color.Yellow;
        }

        private void txtVerifCantidad_LostFocus(object sender, EventArgs e)
        {
            txtVerifCantidad.BackColor = Color.White;
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtCantidad.Text.Trim() != "")
            {
                if (!mod.IsNumeric(txtCantidad.Text))
                {
                    MessageBox.Show("Cantidad No Valida..");
                    txtCantidad.Text = "";
                    txtCantidad.Focus();
                    return;
                }
                txtVerifCantidad.Text = "";
                txtVerifCantidad.Focus();

            }
            else
            {
                txtCantidad.Focus();
            }
        }

        private void txtVerifCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtVerifCantidad.Text.Trim() != "")
            {
                if (txtCantidad.Text.Trim() == "")
                {
                    MessageBox.Show("Introduzca la cantidad correctamente...");
                    txtVerifCantidad.Text = "";
                    txtCantidad.Focus();
                    return;
                }
                if (!mod.IsNumeric(txtCantidad.Text.Trim()))
                {
                    MessageBox.Show("Introduzca la cantidad correctamente...");
                    txtVerifCantidad.Text = "";
                    txtCantidad.Focus();
                    return;
                }

                if (decimal.Parse(txtCantidad.Text.Trim()) == decimal.Parse(txtVerifCantidad.Text.Trim()))
                {
                    GuardarDatos();
                    return;
                }
                else
                {
                    MessageBox.Show("Favor de verificar la cantidad correctamente...");
                    txtVerifCantidad.Text = "";
                    txtVerifCantidad.Focus();
                    return;
                }

            }
            else
            {
                txtVerifCantidad.Focus();
            }

        }

        private void frmCargarMarbeteDiferencias_Load(object sender, EventArgs e)
        {
            
            txtCantidad.Focus();
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            if (lbl_marbete.Text.Trim() != "")
            {
                try
                {
                    timer3.Enabled = false;
                    if (txtCantidad.Text.Trim() == "")
                    {
                        MessageBox.Show("Introduzca la cantidad correctamente...");
                        txtVerifCantidad.Text = "";
                        txtCantidad.Focus();
                        return;
                    }

                    if (!mod.IsNumeric(txtCantidad.Text.Trim()))
                    {
                        MessageBox.Show("Cantidad No Valida");
                        txtCantidad.Text = "";
                        txtVerifCantidad.Text = "";
                        txtCantidad.Focus();
                        timer3.Enabled = true;
                        return;
                    }

                    if (txtVerifCantidad.Text.Trim() == "")
                    {
                        MessageBox.Show("Cantidad No Valida");
                        txtVerifCantidad.Focus();
                        timer3.Enabled = true;
                        return;
                    }

                    if (decimal.Parse(txtCantidad.Text.Trim()) == decimal.Parse(txtVerifCantidad.Text.Trim()))
                    {
                        GuardarDatos();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Cantidad No Valida, Favor de verificar");
                        txtVerifCantidad.Text = "";
                        txtVerifCantidad.Focus();
                        timer3.Enabled = true;
                        return;

                    }

                }
                catch (Exception ex)
                {
                    timer3.Enabled = true;
                    MessageBox.Show("Error Al Guardar Datos.." + ex.Message.ToString());
                }

            }
            else
            {

            }
        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
            
            if (statusBar1.Text.Trim() == "")
            {
                statusBar1.Text = "Introduzca la Cantidad...";
                System.Media.SystemSounds.Asterisk.Play();
            }
            else
            {
                statusBar1.Text = "";
            }
        }

        private void frmCargarMarbeteDiferencias_Closed(object sender, EventArgs e)
        {
            timer3.Enabled = false;
            timer2.Enabled = false;
            timer1.Enabled = false;
        }

        private void frmCargarMarbeteDiferencias_GotFocus(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Exclamation.Play();
            timer3.Enabled = true;

        }
        
    }
}
