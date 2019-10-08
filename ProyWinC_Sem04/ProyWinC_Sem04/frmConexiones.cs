using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace ProyWinC_Sem04
{
    public partial class frmConexiones : Form
    
     
    {
        SqlConnection cnxSql = new SqlConnection();
        OleDbConnection cnxAcc = new OleDbConnection();
        string connstr ;

        public frmConexiones()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            connstr = "server=.;Database=VentasLeon;Integrated Security=true";
            cnxSql.ConnectionString = connstr;
            // Otras formas de cadena de conexion
            // "Data source=localhost;Initial Catalog=ventas2005; Integrated Security=SSPI"
            // Para autenticacion SQL usar:
            // "server=localhost;Database=ventas2005; user id=sql;pwd=sql"
            try
            {
                cnxSql.Open();
                MessageBox.Show("Conexion SQL Abierta", "Mensaje", 
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                Button1.Enabled = false;
                Button2.Enabled = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error en Conexion : " + ex.Message, "Mensaje", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            cnxSql.Close();
           MessageBox.Show("Conexion SQL Cerrada", "Mensaje", 
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            Button1.Enabled = true;
            Button2.Enabled = false;

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string Ruta = Application.StartupPath + "\\Ventas2005.mdb";
            connstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Ruta;
            cnxAcc.ConnectionString = connstr;
            try
            {
                cnxAcc.Open();
                MessageBox.Show("Conexion Access Abierta", "Mensaje", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Button3.Enabled = false;
                Button4.Enabled = true;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Error en Conexion : " + ex.Message, "Mensaje", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            cnxAcc.Close();
            MessageBox.Show("Conexion Access Cerrada", "Mensaje", 
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            Button3.Enabled = true;
            Button4.Enabled = false;

        }
    }
}
