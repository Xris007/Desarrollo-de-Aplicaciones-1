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
    public partial class frmCombos : Form
    {
        List<string> buenos = new List<string>();
        DataSet midts = new DataSet();
         String [] MisCargos = {
    	"Gerente",
	    "Supervisor",
	    "Administrativo",
	    "Asistente",
    	"Auxiliar",
	    "Obrero",
	    "Practicante"
        };

        public frmCombos()
        {
            InitializeComponent();
        }

        private void frmCombos_Load(object sender, EventArgs e)
        {
        //'Agregamos a la coleccion buenos
        buenos.Add("U");
        buenos.Add("Real Madrid");
        buenos.Add("Inter Milan");
        buenos.Add("Manchester United");
         //Leemos clientes
            DataSet midts = new DataSet();
            midts.ReadXml("MisClientes.xml");
       //Asignamos los datasource a cada combo
            cboCargos.DataSource = MisCargos;
        cboBuenos.DataSource = buenos;
        cboClientes.DataSource = midts.Tables [0];
           
        cboClientes.ValueMember ="cod_cli";
        cboClientes.DisplayMember = "raz_soc_cli";
        }


        private void cboBuenos_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblequipo.Text = cboBuenos.Text;
        }
        private void cboCargos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Desarrolle la rutina para mostrar el sueldo del trabajador
            //segun su cargo:
            //Gerente: 5000
            //Supervisor: 3500
            //Administrativo: 2000
            //Asistente : 1600
            //Auxiliar: 1200
            //Obrero: 900
            //Practicante : 500
            {
                Single vsueldo = 0;
                switch (cboCargos.SelectedIndex)
                {
                    case 0:
                        vsueldo = 5000;
                        break;
                    case 1:
                        vsueldo = 3500;
                        break;
                    case 2:
                        vsueldo = 2000;
                        break;
                    case 3:
                        vsueldo = 1600;
                        break;
                    case 4:
                        vsueldo = 1200;
                        break;
                    case 5:
                        vsueldo = 900;
                        break;
                    case 6:
                        vsueldo = 500;
                        break;
                }
                lblSueldo.Text = vsueldo.ToString ("###,##0.00 soles");
            }

        }

      

        private void cboClientes_SelectionChangeCommitted(object sender, EventArgs e)
        {
                lblRS.Text = cboClientes.Text;
                lblCod.Text = cboClientes.SelectedValue.ToString();
        }

       
    }
}
