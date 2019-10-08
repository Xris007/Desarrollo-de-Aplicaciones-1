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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnModal_Click(object sender, EventArgs e)
        {
            frmDatos frm1 = new frmDatos();
            frm1.ShowDialog(); // Modal
        }

        private void btnNoModal_Click(object sender, EventArgs e)
        {
            Form1 frmPP = new Form1(this);
            frmPP.Show(); // No Modal
            btnNoModal.Enabled = false;

        }
        public void enableButton()
        {
            btnNoModal.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
