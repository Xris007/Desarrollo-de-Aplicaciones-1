using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyWinC_Sem01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (lstItem.Items.IndexOf(txtItem.Text) >= 0 | txtItem.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Cadena ya existe o  en blanco", "Advertencia");
                txtItem.SelectAll();

            }
            else
            {
                lstItem.Items.Add(txtItem.Text);
                txtItem.Text = String.Empty;
            }

            txtItem.Focus();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rpta;
            rpta = MessageBox.Show("Seguro de salir", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rpta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            // No olvidar en el formulario asignar a la propiedad KeyPreview  el valor True
            // para que el form "perciba" la pulsacion de tecla y ejecute el evento KeyUp
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();

            }
        }
    }
}
