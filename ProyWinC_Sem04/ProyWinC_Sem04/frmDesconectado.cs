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
    public partial class frmDesconectado : Form
    {
        SqlConnection cnx = new 
                SqlConnection("server=.;Database=VentasLeon; Integrated Security=SSPI");
        SqlCommand cmd = new SqlCommand();
        DataSet dts = new DataSet();
        SqlDataAdapter ada = new SqlDataAdapter();

        public frmDesconectado()
        {
            InitializeComponent();
        }

        private void btnLlenar_Click(object sender, EventArgs e)
        {
            try
            {
                dts.Tables.Clear();
                //Se configura el comando
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = txtSQL.Text;
                //Se configura el adaptador con el comando
                ada = new SqlDataAdapter(cmd);
                // Llenamos un datatable en el dataset por medio del adaptador
                ada.Fill(dts, "MisDatos");
                // Llenar el Grid con el datatable
                DataGridView1.DataSource = dts.Tables["MisDatos"];
                // Llenar el Combo con el datatable
                ComboBox1.DataSource = dts.Tables["MisDatos"];
                ComboBox1.ValueMember = dts.Tables["MisDatos"].Columns[0].ToString();
                ComboBox1.DisplayMember = dts.Tables["MisDatos"].Columns[1].ToString();
             }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblValor.Text = ComboBox1.SelectedValue.ToString();
        }
    }
}
