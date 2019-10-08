using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyWinC_Sem02
{
    public partial class frmNumero : Form
    {
        public frmNumero()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            clsNumero objNumero = new clsNumero();
            try
            {
                objNumero.Valor = Convert.ToDouble(txtValor.Text);

                MessageBox.Show("El factorial del número es..." + Convert.ToString(objNumero.Factorial()));

                if (objNumero.EsPrimo() == true)
                {
                    MessageBox.Show("EL número es primo");
                }
                else
                {
                    MessageBox.Show("El número NO es primo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message , "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtValor.SelectAll();
                txtValor.Focus();
            }
            
        }
    }
}
