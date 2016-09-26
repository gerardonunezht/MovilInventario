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
    public partial class frm_marbete : Form
    {
        public frm_marbete()
        {
            InitializeComponent();
        }
        public int totmarbetes = 0;
        public decimal CantFisica = 0;
        public int marbete = 0;
        Global mod = new Global();

        void GuardarDatos()
        {
            if (lbl_marbete.Text.Trim() != "")
            {
                try
                {                    
                    if (lblLote.Text.Trim() != "")
                    {
                        if (totmarbetes > 1)
                        {
                            //guardar la cantidad distribuyendola de manera proporcional en los marbetes
                            if (mod.GuardarMarbetePedimento(lbl_marbete.Text.Trim(), Global.pareja_no, Global.piid, lbl_clave.Text.Trim(), lbl_loc.Text.Trim().ToUpper(), decimal.Parse(txtCantidad.Text.Trim()), ""))
                            {
                                System.Media.SystemSounds.Beep.Play();
                                this.Close();
                                return;
                            }
                        }
                        else //if (tot_marbetes > 1)
                        {
                            //si solo es un marbete en la localizacion
                            //guardar los datos del marbete normal
                            if (mod.guardar_marbete(lbl_marbete.Text.Trim(), Global.pareja_no, Global.piid, txtCantidad.Text.Trim(), ""))
                            {
                                this.Close();
                                return;
                            }

                        }

                    }
                    else
                    {  //guardar los datos del marbete normal
                        if (mod.guardar_marbete(lbl_marbete.Text.Trim(), Global.pareja_no, Global.piid, txtCantidad.Text.Trim(), ""))
                        {
                            System.Media.SystemSounds.Beep.Play();
                            this.Close();
                            return;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Al Guardar Datos.." + ex.Message.ToString());


                }

               
            }
           
        }
        
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDatosMarbete f = new frmDatosMarbete();
            f.ShowDialog();
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            if (lbl_marbete.Text.Trim() != "")
            {
                try
                {
                    if (txtCantidad.Text.Trim() != "")
                    {
                        if (!mod.IsNumeric(txtCantidad.Text.Trim()))
                        {
                            MessageBox.Show("Cantidad No Valida");
                            txtCantidad.Text = "";
                            txtCantidad.Focus();
                            return;
                        }

                        if (txtVerificarCant.Text.Trim() != "")
                        {
                            if (!mod.IsNumeric(txtVerificarCant.Text.Trim()))
                            {
                                MessageBox.Show("Cantidad No Valida...Favor de verificarla");
                                txtVerificarCant.Text = "";
                                txtVerificarCant.Focus();
                                return;
                            }
                        }

                        if (decimal.Parse(txtCantidad.Text.Trim()) != decimal.Parse(txtVerificarCant.Text.Trim()))
                        {
                            MessageBox.Show("Cantidad No Valida...Favor de verificarla");
                            txtVerificarCant.Text = "";
                            txtCantidad.Text = "";
                            txtCantidad.Focus();
                            return;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Cantidad No Valida...");
                        txtCantidad.Text = "";
                        txtCantidad.Focus();
                        return;
                    }

                    
                        if (lblLote.Text.Trim() != "")
                        {
                            if (totmarbetes  > 1)
                            {
                                //guardar la cantidad distribuyendola de manera proporcional en los marbetes
                                if (mod.GuardarMarbetePedimento(lbl_marbete.Text.Trim() , Global.pareja_no  , Global.piid  , lbl_clave.Text.Trim(), lbl_loc.Text.Trim().ToUpper() , decimal.Parse(txtCantidad.Text.Trim()), "" ))
                                {
                                    System.Media.SystemSounds.Beep.Play(); 
                                   
                                                                      
                                    this.Close();
                                    frmDatosMarbete f = new frmDatosMarbete();
                                    f.Show();                                    
                                    return;
                                }                                
                            }
                            else //if (tot_marbetes > 1)
                            {
                                //si solo es un marbete en la localizacion
                                //guardar los datos del marbete normal
                                if (mod.guardar_marbete(lbl_marbete.Text.Trim()  , Global.pareja_no  , Global.piid  , txtCantidad.Text.Trim()   , ""))
                                {                                 
                                    this.Close();
                                    frmDatosMarbete f = new frmDatosMarbete();
                                    f.Show();
                                    return;
                                }

                            }

                        }
                        else
                        {  //guardar los datos del marbete normal
                            if (mod.guardar_marbete(lbl_marbete.Text.Trim(), Global.pareja_no  , Global.piid  , txtCantidad.Text.Trim()   , ""))
                            {                               
                              System.Media.SystemSounds.Beep.Play();
                              this.Close();
                              frmDatosMarbete f = new frmDatosMarbete();
                              f.Show();
                              return;  
                            }
                        }

                }
                catch (Exception ex)
                {
                   

                    MessageBox.Show("Error Al Guardar Datos.." + ex.Message.ToString());
                    return;

                }

                //MessageBox.Show("Los Datos Se Guardaron Correctamente..");
                //limpiardatos();
                //txt_no.Focus();
            }
            else
            {
                //MessageBox.Show("Introduzca El numero De Marbete..");
                //txt_no.Focus();

            }

            
        }

        private void frm_marbete_Load(object sender, EventArgs e)
        {
            txtCantidad.Focus();
            if (marbete > 0)
            {
                timer1.Enabled = true;
            }
        }

        private void txtCantidad_GotFocus(object sender, EventArgs e)
        {
            txtCantidad.BackColor = Color.Yellow;    
        }

        private void txtCantidad_LostFocus(object sender, EventArgs e)
        {
            txtCantidad.BackColor = Color.White ;  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (statusBar1.Text == "")
            {
                statusBar1.Text = "Introduzca la cantidad...";
                System.Media.SystemSounds.Hand.Play();
            }
            else
            {
                statusBar1.Text = "";
            }
        }

        private void txtVerificarCant_GotFocus(object sender, EventArgs e)
        {
            txtVerificarCant.BackColor = Color.Yellow;   
        }

        private void txtVerificarCant_LostFocus(object sender, EventArgs e)
        {
            txtVerificarCant.BackColor = Color.White;
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtCantidad.Text.Trim() != "")
            {
                if (mod.IsNumeric(txtCantidad.Text))
                {
                    txtVerificarCant.Text = "";
                    txtVerificarCant.Focus();
                }
                else
                {
                    MessageBox.Show("Cantidad No Valida..");
                    txtCantidad.Text = "";
                    txtCantidad.Focus();
                }
            }
            else
            {
                txtCantidad.Focus();

            }
        }

        private void txtVerificarCant_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtVerificarCant.Text !="" )
            {
                if (txtCantidad.Text.Trim() != "")
                {
                    if (mod.IsNumeric(txtCantidad.Text.Trim()))
                    {
                        if (mod.IsNumeric(txtVerificarCant.Text))
                        {
                            if (int.Parse(txtCantidad.Text) == int.Parse(txtVerificarCant.Text))
                            {
                                btn_continuar_Click(this, EventArgs.Empty);
                            }
                            else
                            {
                                MessageBox.Show("Verificar correctamente la cantidad");
                                txtVerificarCant.Text = "";
                                txtVerificarCant.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cantidad No Valida..");
                            txtVerificarCant.Text = "";
                            txtVerificarCant.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cantidad No Valida..");
                        txtCantidad.Text   = "";
                       txtCantidad.Focus();                    
                    }
                }
                else
                {
                    txtVerificarCant.Text = ""; 
                    MessageBox.Show("Introduzca al cantidad");
                    txtCantidad.Focus();
                
                }
            }

        }

        private void frm_marbete_Closing(object sender, CancelEventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}