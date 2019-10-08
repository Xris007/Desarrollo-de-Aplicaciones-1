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
    public partial class frmConsultaCliente : Form
    {
        SqlConnection cnx = new 
            SqlConnection("server=.;Database=VentasLeon; Integrated Security=SSPI");
        SqlCommand cmdCliente = new SqlCommand();
               public frmConsultaCliente()
        {
            InitializeComponent();
        }

        private void txtcod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==13)
            {
	        try
            {
		    cmdCliente.Connection = cnx;
		    cmdCliente.CommandType = CommandType.StoredProcedure;
		    cmdCliente.CommandText = "usp_ConsultarCliente";
		    //Agregamos el parametro para el SP
		    cmdCliente.Parameters.Add(new SqlParameter("@vcod", txtcod.Text));
		    cnx.Open();
            SqlDataReader dtr = cmdCliente.ExecuteReader();
		    if (dtr.HasRows == false) 
            {
			    MessageBox.Show("Cliente No existe");
		    } 
            else
            {
			    dtr.Read();
			    lblRaz.Text = dtr.GetValue (dtr.GetOrdinal ("raz_soc_cli")).ToString ();
			    lblRuc.Text = dtr.GetValue (dtr.GetOrdinal ("ruc_cli")).ToString ();
                lblDir.Text = dtr.GetValue(dtr.GetOrdinal("dir_cli")).ToString();
                if ((dtr.GetValue(dtr.GetOrdinal ("tel_cli")) == DBNull.Value ))
                {
                    lblTel.Text = "No tiene";
                }
                else
                {
                 lblTel.Text = dtr.GetValue(dtr.GetOrdinal("tel_cli")).ToString();
                }
            dtr.Close();
            // Ejecutamos USP_DeudaCliente 
            // OJO : Ya no se requiere pasar el parametro de entrada @vcod, porque el comando
            // ya lo tiene por la ejecucion de la consulta anterior, por eso solo se le agrega el parametro de salida
            // que se requiere para el store procedure Usp_DeudaCliente
            cmdCliente.CommandText = "usp_DeudaCliente";
            cmdCliente.Parameters.Add(new SqlParameter("@vdeuda", SqlDbType.Money));
            cmdCliente.Parameters["@vdeuda"].Direction = ParameterDirection.Output;
             cmdCliente.ExecuteScalar();
             lblDeuda.Text = cmdCliente.Parameters["@vdeuda"].Value.ToString();
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
        cmdCliente.Parameters.Clear();
    }
            }

        }
    }
}
