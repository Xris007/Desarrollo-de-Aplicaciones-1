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
    public partial class Form1 : Form
    {
        private frmInicio frmI;
        public Form1(frmInicio frmI)
        {
            InitializeComponent();
            this.frmI = frmI;
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmI.enableButton();
        }
    }
}
