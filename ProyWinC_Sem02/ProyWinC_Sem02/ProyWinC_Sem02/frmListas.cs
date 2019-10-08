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
    public partial class frmListas : Form
    {
        public frmListas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGaseosa.Text.Trim()) | 
                             lstGaseosas.Items.IndexOf(txtGaseosa.Text) >= 0)
            {
                MessageBox.Show("Caja en  blanco o repetida");
            }
            else
            {
                btnEliminar.Enabled = true;
               lstGaseosas.Items.Add(txtGaseosa.Text);
                txtGaseosa.Text = "";
                txtGaseosa.Focus();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstGaseosas.Items.Count == 0)
            {
                MessageBox.Show("No hay mas elementos en la lista");
                btnEliminar.Enabled = false;
            }
            else
            {
                lstGaseosas.Items.Remove(lstGaseosas.SelectedItem);
                if (lstGaseosas.Items.Count == 0)
                {
                    btnEliminar.Enabled = false;
                }
            }
        }

         private void btnEliminarI_Click(object sender, EventArgs e)
        {
            // eliminar por Indice
                        
                if (lstGaseosas.SelectedIndex == -1)
                {
                    MessageBox.Show("Elija elemento a eliminar");
                }
                else
                {
                    lstGaseosas.Items.RemoveAt(lstGaseosas.SelectedIndex);
                    if (lstGaseosas.Items.Count == 0)
                    {
                        btnEliminar.Enabled = false;
                    }
                }
                txtGaseosa.Focus();

        }

        private void lstGaseosas_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete )
            {
                btnEliminar.PerformClick();
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstGaseosas.Items.Clear();
        }

        
        private void btnRecorrerTodos_Click(object sender, EventArgs e)
        {

          foreach (string x in lstGaseosas.Items)
            {
             
                MessageBox.Show(x);
            }

        }

        private void btnRecorrerSel_Click(object sender, EventArgs e)
        {
           
            foreach (string x in lstGaseosas.SelectedItems)
            {
                  MessageBox.Show(x);
            }
        }




        private void frmListas_Load(object sender, EventArgs e)
        {
            // Como cargar una lista desde un archivo XML
            try
            {
                DataSet midts = new DataSet();
                midts.ReadXml("MisClientes.xml");
                lstClientes.DataSource = midts.Tables [0];
                lstClientes.ValueMember = "cod_cli";
                lstClientes.DisplayMember = "raz_soc_cli";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
           
          }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
                lblRS.Text = lstClientes.Text;
                lblCod.Text = lstClientes.SelectedValue.ToString();
         

        }

        

        private void txtGaseosa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnAgregar.PerformClick();
            }
        }
    }
}
