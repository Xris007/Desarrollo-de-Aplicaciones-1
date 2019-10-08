using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyWinC_Sem03
{
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void ejemplo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArchivos frm01 = new frmArchivos();
            frm01.MdiParent = this;
            frm01.Show();
        }

        private void ejemplo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaskedtextBox frm02 = new frmMaskedtextBox();
            frm02.MdiParent = this;
            frm02.Show();
        }

        private void ejemplo3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmVisorImagenes frm03 = new frmVisorImagenes();
            frm03.MdiParent = this;
            frm03.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = "Sistemas ISIL da la hora: " + DateTime.Now; // clase que apunta a todo tiempo de fecha
        }
    }
}
