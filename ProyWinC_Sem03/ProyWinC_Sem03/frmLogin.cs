using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyWinC_Sem04
{
    public partial class frmLogin : Form
    {
        int intentos = 0;
        int tiempo = 10;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtLogin .Text.Trim() != "" & txtPassword.Text.Trim() != "")
             {
                if (txtLogin.Text == "ISIL" & txtPassword.Text == "12345")
                {
                    //Codifique
                 }
                else
                { 
                    MessageBox.Show ("Usuario o Password incorrectos", 
                    "Mensaje",MessageBoxButtons .OK ,MessageBoxIcon .Error );
                    intentos +=1;
                    if (intentos == 3)
                    { 
                       this.Close();
                    }
              }
            }
            else
            {
                MessageBox.Show("Usuario o Password obligatorios",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
               intentos +=1;
            }
            if (intentos == 3)
            {
                MessageBox.Show("Lo sentimos,  sobrepaso el numero de intentos",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             //Codifique
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
            Application.Exit();

        }
    }
}
