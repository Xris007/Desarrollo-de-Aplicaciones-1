using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyWinC_Sem02
{
    public partial class frmDatos : Form
    {
        public frmDatos()
        {
            InitializeComponent();
        }

        

        private void frmDatos_KeyUp(object sender, KeyEventArgs e)
        {
           
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        if (c.Text == string.Empty)
                        {
                            btnGrabar.Enabled = false;
                            return;
                        }
                    }
                }
                btnGrabar.Enabled = true;
            
        }

        private void txtRUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            // No fue BackSpace
            if (e.KeyChar != 8)
            {
                if (char.IsDigit(e.KeyChar) == false) // char -> clase 1|
                {
                    // Ni tampoco numero se atrapa el caracter y no  se imprime
                    e.Handled = true;
                }
            }
        }

        private void txtRUC_Validating(object sender, CancelEventArgs e)
        {
            if (txtRUC.Text.Trim().Length != 11 & txtRUC.Text.Trim().Length != 0)
            {
                //Se Cancela el ingreso
                e.Cancel = true;
                MessageBox.Show("El RUC consta de 11 digitos", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRUC.SelectAll();
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            // tras grabar en la bd respectiva
            btnLimpiar.PerformClick();
            txtCod.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = string.Empty;
                }
            }
            btnGrabar.Enabled = false;
            txtCod.Focus();
        }

        private void txtRUC_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Accion Invalida");
                
            }
        }

        private void txtPunt1_Validating(object sender, CancelEventArgs e)
        {
            TextBox mitxt = (TextBox)sender;
            if (mitxt.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Nota es obligatoria");
                e.Cancel = true; // no saca el cursor de la caja
            }
            else
            {
                Single nota = Convert.ToSingle(mitxt.Text);
                if (nota < 0 | nota > 20)
                {
                    MessageBox.Show("Nota fuera de rango");
                    e.Cancel = true;

                }
            }

        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e) // e es el argumento del evento que da la info del evento
        {
            // No fue BackSpace
            if (e.KeyChar != 8 && e.KeyChar != 32)
            {
                if (char.IsLetter(e.KeyChar) == false) // char -> clase 1|
                {
                    // Ni tampoco numero se atrapa el caracter y no  se imprime
                    e.Handled = true;
                }
            }
        }
    }
}
