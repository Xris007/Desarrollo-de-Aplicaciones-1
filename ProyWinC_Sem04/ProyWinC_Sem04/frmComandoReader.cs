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
    public partial class frmComandoReader : Form
    {
        SqlConnection cnx = new SqlConnection
                               ("server=.;Database=VentasLeon; Integrated Security=SSPI");
        SqlCommand cmd = new SqlCommand();
        String vsql = null;
        public frmComandoReader()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = cnx;
                vsql = "Select des_pro from tb_producto order by des_pro";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = vsql;
                cnx.Open();
                  SqlDataReader dtr = cmd.ExecuteReader();
                //Llenamos  la lista
                ListBox1.Items.Clear();
                while (dtr.Read())
                {
                    ListBox1.Items.Add(dtr["des_pro"].ToString());
                }
                dtr.Close();
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

        private void btnVendedores_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Connection = cnx;

                if (optApe.Checked)
                {
                    vsql = "Select nom_ven, ape_ven, cod_ven from tb_vendedor order by ape_ven";
                }
                if (optCod.Checked)
                {
                    vsql = "Select nom_ven, ape_ven, cod_ven from tb_vendedor order by cod_ven";
                }
                
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = vsql;
                cnx.Open();
                SqlDataReader dtr = cmd.ExecuteReader();
                //Llenamos  la lista
                ListBox2.Items.Clear();
                String nombre;
                String apeliido;
                while (dtr.Read())
                {
                    nombre = dtr["nom_ven"].ToString();
                    apeliido = dtr["ape_ven"].ToString();
                    ListBox2.Items.Add(apeliido + ", " + nombre);
                }
                dtr.Close();
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

        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    cmd.Connection = cnx;
                    vsql = "SELECT Tb_Distrito.Cod_dis, Tb_Vendedor.nom_ven, Tb_Vendedor.ape_ven FROM Tb_Distrito INNER JOIN Tb_Vendedor ON Tb_Vendedor.cod_ven = Tb_Distrito.Cod_ven";
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = vsql;
                    cnx.Open();
                    SqlDataReader dtr = cmd.ExecuteReader();

                    String txtDist = txtCod.Text.Trim();
                    String resDist = "";
                    String nombre;
                    String ape;

                    lblNombre.Text = "";
                    lblVendedor.Text = "";


                    while (dtr.Read())
                    {
                        resDist = dtr["Cod_dis"].ToString();
                        if (txtDist == resDist)
                        {
                            lblNombre.Text = resDist;

                            nombre = dtr["nom_ven"].ToString();
                            ape = dtr["ape_ven"].ToString();
                            lblVendedor.Text = ape + ", " + nombre;
                        }
                    }
                    if (lblNombre.Text.Trim()=="")
                    {
                        MessageBox.Show("Código de distrito no existe en registro",
                        "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine("hello world");
                    }
                    dtr.Close();
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
