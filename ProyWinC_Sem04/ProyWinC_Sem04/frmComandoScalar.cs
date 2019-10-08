using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyWinC_Sem04
{
    

    public partial class frmComandoScalar : Form
    {
        
        SqlConnection cnx = new SqlConnection
            ("server=.;Database=VentasLeon; Integrated Security=SSPI");
        SqlCommand cmd = new SqlCommand();
        String vsql;


        public frmComandoScalar()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = cnx;
                // Obtiene la cantidad de Clientes
                vsql = "Select count(*) from Tb_Cliente";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = vsql;
                cnx.Open();
                MessageBox.Show("El Total de Clientes es :" + cmd.ExecuteScalar(), 
                    "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = cnx;

                vsql = "Select max(pre_pro) from Tb_Producto";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = vsql;
                cnx.Open();
                MessageBox.Show("El Máximo Precio de los Productos es :" + cmd.ExecuteScalar(),
                    "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = cnx;

                vsql = "select SUM(Total) from vw_VistaFacturas where YEAR(Fec_fac) = @year and Est_fac = 2";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = vsql;
                cmd.Parameters.AddWithValue("@year", txtAnio.Text.Trim());
                cnx.Open();
                String resultado = cmd.ExecuteScalar().ToString();
                if (resultado != "")
                {
                    MessageBox.Show("El Total de Ventas en el Año " + txtAnio.Text.Trim() + " es: " + cmd.ExecuteScalar(),
                    "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Año no existe en registro",
                    "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                // Se limpian los parametros para la siguiente ejecucion de la consulta
                cmd.Parameters.Clear();
            }

        }
    }
}
