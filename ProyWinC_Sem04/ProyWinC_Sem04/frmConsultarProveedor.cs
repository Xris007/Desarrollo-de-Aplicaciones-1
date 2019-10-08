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
    public partial class frmConsultarProveedor : Form
    {
        SqlConnection cnx = new 
        SqlConnection("server=.;Database=VentasLeon; Integrated Security=SSPI");
        SqlCommand cmd = new SqlCommand();
        public frmConsultarProveedor()
        {
            InitializeComponent();
        }

        private void txtcod_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (e.KeyChar ==13)
            {
    	        try 
                {
		        cmd.Connection = cnx;
		        cmd.CommandType = CommandType.StoredProcedure;
		        cmd.CommandText = "usp_ConsultarProveedor";
                    //Agregamos el parametro para el SP
                    cmd.Parameters.AddWithValue("@vcod", txtcod.Text);
		        cnx.Open();
                SqlDataReader dtr = cmd.ExecuteReader();
		        if (dtr.HasRows == false) 
                {
			        MessageBox.Show("Proveedor No existe");
                    lblRaz.Text = "";
                    lblDir.Text = "";
                    lblTel.Text = "";
                    lblRepVen.Text = "";
                    txtcod.SelectAll();
                    txtcod.Focus();
		        } 
                else
                {
			        dtr.Read();
			        lblRaz.Text = dtr["raz_soc_prv"].ToString ();
			        lblDir.Text = dtr["dir_prv"].ToString ();
                    if (dtr["tel_prv"] ==DBNull.Value)
                     {
                        lblTel.Text = "No tiene";
                       }
                    else
                    {
                        lblTel.Text = dtr.GetValue(dtr.GetOrdinal("tel_prv")).ToString();
                    }
                    lblRepVen.Text = dtr.GetValue(dtr.GetOrdinal("rep_ven")).ToString();
                    dtr.Close();
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
                cmd.Parameters.Clear();
            }
           }
         }
        }
}
