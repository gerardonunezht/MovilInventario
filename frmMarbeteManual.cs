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
    public partial class frmMarbeteManual : Form
    {
        public frmMarbeteManual()
        {
            InitializeComponent();
        }

        Global mod = new Global();
        public decimal costo = 0;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Menu frmMenu = new frm_Menu();
            frmMenu.Show();
        }

        void limpiardatos()
        {
            textBox1.Focus();
            txtClave.Text = "";
            txtUnidad.Text = "";
            txtDesc.Text = "";
            txtLoc.Text = "";
            txtCantidad1.Text = "";
            txtLoc.Enabled = false;
            txtCantidad1.Enabled = false;
            txtLoc.Enabled = false;
            btnGuardar.Enabled = false;
        }
        bool ObtenerDatosArticulo(string pClave)
        {
            DataSet dt = new DataSet();
            dt = mod.ObtenerDatosArticuloParaMarbeteManual(txtClave.Text.Trim().ToUpper());
            if (dt != null)
            {
                if (dt.Tables.Count > 0)
                {
                    if (dt.Tables[0].Rows.Count > 0)
                    {
                        DataRow dr = dt.Tables[0].Rows[0];
                        if (dr["Descr"] != null)
                        {
                            txtDesc.Text = dr["Descr"].ToString();
                        }

                        if (dr["Unidad"] != null)
                        {
                            txtUnidad.Text = dr["Unidad"].ToString();
                        }

                        if (dr["Costo"] != null)
                        {
                          costo = decimal.Parse(dr["Costo"].ToString());
                         //costo = decimal.Parse(dr["Costo"].ToString());
                        }
                        else
                        {
                          costo = 0;
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

        private void txtCantidad1_GotFocus(object sender, EventArgs e)
        {
            txtCantidad1.BackColor = Color.Yellow;
        }

        private void txtLoc_GotFocus(object sender, EventArgs e)
        {
            txtLoc.BackColor = Color.Yellow;
        }

        private void txtClave_GotFocus(object sender, EventArgs e)
        {
            txtClave.BackColor = Color.Yellow;
        }

        private void txtClave_LostFocus(object sender, EventArgs e)
        {
            txtClave.BackColor = Color.White;
        }

        private void txtLoc_LostFocus(object sender, EventArgs e)
        {
            txtLoc.BackColor = Color.White;
        }

        private void txtCantidad2_LostFocus(object sender, EventArgs e)
        {
            //txtCantidad2.BackColor = Color.White;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiardatos();
        }

        private void txtClave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtClave.Text.Trim() != "")
            {

            }
        }

        private void txtLoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtLoc.Text != "")
            {
                if (!mod.verificar_localizacion(txtLoc.Text.Trim().ToUpper()))
                {
                    MessageBox.Show("Localizacion no valida");
                    txtLoc.Text = "";
                    txtLoc.Focus();
                }
                else
                {
                    txtCantidad1.Enabled = true;
                    //txtCantidad2.Enabled = true;
                    txtCantidad1.Focus();
                }
            }
            else
            {
                txtLoc.Focus();
            }
        }

        private void txtCantidad1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtCantidad1.Text != "")
            {
                if (!mod.IsNumeric(txtCantidad1.Text.Trim()))
                {
                    MessageBox.Show("Cantidad No Valida..");
                    txtCantidad1.Text = "";
                    txtCantidad1.Focus();
                    return;
                }
                else
                {
                    if (decimal.Parse(txtCantidad1.Text) <= 0)
                    {
                        MessageBox.Show("Cantidad No Valida..");
                        txtCantidad1.Text = "";
                        txtCantidad1.Focus();
                        return;
                    }
                    else
                    {
                        //txtCantidad2.Text = "";
                        //txtCantidad2.Focus();
                    }
                   
                }
                btnGuardarMarbeteManual();
            }
            else
            {
                btnGuardar.Enabled = true;
                
            }
        }

        private void txtCantidad2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                if (txtCantidad1.Text.Trim() == "")
                {
                    //txtCantidad2.Text = "";
                    txtCantidad1.Text = "";
                    MessageBox.Show("Introduzca la cantidad correctamente..");
                    txtCantidad1.Focus();
                    return;
                }

                if (!mod.IsNumeric(txtCantidad1.Text.Trim()))
                {
                    //txtCantidad2.Text = "";
                    txtCantidad1.Text = "";
                    MessageBox.Show("Introduzca la cantidad correctamente..");
                    txtCantidad1.Focus();
                    return;
                }

                if (decimal.Parse(txtCantidad1.Text.Trim()) <= 0)
                {
                    //txtCantidad2.Text = "";
                    txtCantidad1.Text = "";
                    MessageBox.Show("Cantidad No Valida...");
                    txtCantidad1.Focus();
                    return;
                }


                //if (!mod.IsNumeric(txtCantidad2.Text.Trim()))                               
                //{
                //    txtCantidad2.Text = "";                    
                //    MessageBox.Show("Introduzca la cantidad correctamente..");
                //    txtCantidad2.Focus(); 
                //    return;
                //}

                //if (int.Parse(txtCantidad1.Text.Trim()))
                //{
                //    btnGuardar.Enabled = true; 
                //    btnGuardar.Focus();
                //}
                //else
                //{
                //    txtCantidad2.Text = "";
                //    MessageBox.Show("Introduzca la cantidad correctamente..");
                //    txtCantidad2.Focus();
                //    return;
                //}

            }
            else
            {
                //txtCantidad2.Focus();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btnGuardarMarbeteManual();
        }

        private void btnGuardarMarbeteManual()
        {
            //if (costo <= 0)
            //{
            //    MessageBox.Show("No se puede generar un marbete manual con costo menor o igual a CERO");
            //    return;
            //}

            if (txtClave.Text.Trim() == "")
            {
                MessageBox.Show("Clave de articulo no valida");
                return;
            }

            if (txtLoc.Text.Trim() == "")
            {
                MessageBox.Show("Localizacion No Valida");
                txtLoc.Focus();
                return;
            }
            if (txtCantidad1.Text.Trim() == "")
            {
                MessageBox.Show("Cantidad No Valida");
                txtCantidad1.Focus();
                return;
            }

            if (!mod.IsNumeric(txtCantidad1.Text.Trim()))
            {
                MessageBox.Show("Cantidad No Valida");
                txtCantidad1.Text = "";
                txtCantidad1.Focus();
                return;
            }
            if (decimal.Parse(txtCantidad1.Text.Trim()) <= 0)
            {
                MessageBox.Show("Cantidad No Valida");
                txtCantidad1.Text = "";
                txtCantidad1.Focus();
                return;
            }

            //Verificar la Cantidad2
            //if (txtCantidad2.Text.Trim() == "")
            //{
            //    MessageBox.Show("Cantidad No Valida");
            //    txtCantidad2.Focus(); 
            //    return;            
            //}

            //if (!mod.IsNumeric(txtCantidad2.Text.Trim()))
            //{
            //    MessageBox.Show("Cantidad No Valida");
            //    txtCantidad2.Text = "";
            //    txtCantidad2.Focus();
            //    return;
            //}
            //if (decimal.Parse(txtCantidad2.Text.Trim()) <= 0)
            //{
            //    MessageBox.Show("Cantidad No Valida");
            //    //txtCantidad2.Text = "";
            //    //txtCantidad2.Focus();
            //    return;
            //}
            //Verificar que las dos cantidades sean iguales
            //if (decimal.Parse(txtCantidad2.Text.Trim()) != decimal.Parse(txtCantidad1.Text.Trim()))
            //{
            //    MessageBox.Show("Favor de Verificar La Cantidad..");
            //    return;
            //}

            //Verificar la localizacion            
            if (!mod.verificar_localizacion(txtLoc.Text.Trim().ToUpper()))
            {
                MessageBox.Show("Localizacion no encontrada, favor de verificarla");
                txtLoc.Text = "";
                txtLoc.Focus();
                return;

            }
            //Verificar que la clave del articulo pertenezca a la localizacion
            //string invtidloc = "";
            //if (mod.verificar_localizacion_articulo(txtLoc.Text.Trim().ToUpper(), out invtidloc))
            //{
            //    if (!string.IsNullOrEmpty(invtidloc))
            //    {
            //        if (txtClave.Text.Trim().ToUpper() != invtidloc.ToUpper())
            //        {
            //            MessageBox.Show("Este articulo no pertenece a esta localizacion,esta localizacion esta signada al articulo: " + invtidloc + " favor de verificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            //            limpiardatos();
            //            return;
            //        }
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("Error al verificar localizacion, intente otra vez");
            //    limpiardatos();
            //    return;
            //}

            //Verificar que no exista un marbete para la clave y localizacion especificado
            if (mod.valida_marbete(txtClave.Text.Trim().ToUpper(), txtLoc.Text.Trim().ToUpper()) == true)
            {
                //MessageBox.Show(this, "Error Al Agregar Marbete, ya existe un marbete con esta clave: Marbete No " + txt_no.Text  , "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (mod.GuardarMarbeteManual(txtClave.Text.Trim().ToUpper(), txtDesc.Text.Trim().ToUpper(), txtLoc.Text.Trim().ToUpper(), txtUnidad.Text.Trim(), costo, decimal.Parse(txtCantidad1.Text.Trim())))
                {
                    limpiardatos();
                    txtClave.Focus();
                    this.Close();
                    frm_Menu menu = new frm_Menu();
                    menu.Show();



                }

            }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                DataSet dt=new DataSet();
                dt=mod.ObtenerDatosArticuloCB(textBox1.Text.Trim());
                if (dt != null)
                {
                        if (dt.Tables.Count > 0)
                        {
                            if (dt.Tables[0].Rows.Count > 0)
                            {
                                DataRow dr = dt.Tables[0].Rows[0];
                                txtClave.Text = dr["ART"].ToString();
                                txtDesc.Text = dr["DESCR"].ToString();
                                txtUnidad.Text = dr["UNIDAD"].ToString();
                                txtLoc.Enabled = true;
                                txtLoc.Focus();
                        }
                    }
                }
                if (ObtenerDatosArticulo(txtClave.Text.Trim().ToUpper()))
                {
                    txtClave.Enabled = false;
                    txtLoc.Enabled = true;
                    txtLoc.Focus();
                }
                else
                {
                    MessageBox.Show("Datos No Encontrados");
                    txtClave.Text = "";
                    txtClave.Focus();

                }
            }

        }

        private void frmMarbeteManual_Load(object sender, EventArgs e)
        {
            limpiardatos();
        }

    }
}