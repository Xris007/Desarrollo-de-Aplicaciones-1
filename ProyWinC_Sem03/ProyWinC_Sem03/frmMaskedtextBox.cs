using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyWinC_Sem03
{
    public partial class frmMaskedtextBox : Form
    {
        public frmMaskedtextBox()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            // si se rompe la mascara el texto se pone en rojo
            MaskedTextBox mimask = (MaskedTextBox)sender;
            mimask.ForeColor = Color.Red;
        }

        private void maskedTextBox1_Validated(object sender, EventArgs e)
        {
           // si se ha validado el dato , vuelve a su color normal
            MaskedTextBox mimask = (MaskedTextBox)sender;
            mimask.ForeColor = Color.Black;
        }


        private void maskedTextBox2_Validating(object sender, CancelEventArgs e)
        {
           // obliga a que se llene la mascara
            if (maskedTextBox2.MaskFull == false)
            {
                e.Cancel = true;
            }
          
        
        }

        private void frmMaskedtextBox_Load(object sender, EventArgs e)
        {

        }

        

       
    }
}
