using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyWinC_Sem02
{
    public partial class frmListas2 : Form
    {
        public frmListas2()
        {
            InitializeComponent();
            
        }

        //Metodos de los Botones Agregar, Remover Seleccionados y Limpiar
        //Agregar
        private void AgregarItems(ListBox lstMain, TextBox txtMain, Button btnMain)
        {
            if (string.IsNullOrEmpty(txtMain.Text.Trim()) | lstMain.Items.IndexOf(txtMain.Text) >= 0)
            {
                MessageBox.Show("Caja en  blanco o repetida");
            }
            else
            {
                btnMain.Enabled = true;
                lstMain.Items.Add(txtMain.Text);
                txtMain.Text = "";
                txtMain.Focus();
            }
        }
        //Remover Items Seleccionados
        private void RemoveSelectedItems(ListBox lstMain, Button btnMain)
        {
            if (lstMain.Items.Count == 0)
            {
                MessageBox.Show("No hay mas elementos en la lista");
                btnMain.Enabled = false;
            }
            else
            {
                foreach(string s in lstMain.SelectedItems.OfType<string>().ToList())
                {
                    lstMain.Items.Remove(s);
                }
            }
        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AgregarItems(lstItem, txtItem, btnRemove);
        }
        private void BtnAgregar2_Click(object sender, EventArgs e)
        {
            AgregarItems(lstItem2, txtItem2, btnRemove2);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            RemoveSelectedItems(lstItem,btnRemove);
        }
        private void BtnRemove2_Click(object sender, EventArgs e)
        {
            RemoveSelectedItems(lstItem2,btnRemove2);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            if(lstItem.Items.Count == 0)
            {
                MessageBox.Show("La lista está vacia");
            }
            else
            {
                lstItem.Items.Clear();
                MessageBox.Show("Se ha limpiado la  lista");
            }
            
        }
        private void BtnLimpiar2_Click(object sender, EventArgs e)
        {
            if (lstItem2.Items.Count == 0)
            {
                MessageBox.Show("La lista 2 está vacia");
            }
            else
            {
                lstItem2.Items.Clear();
                MessageBox.Show("Se ha limpiado la  lista 2");
            }
        }



        //Metodo Mover Item
        private void MoveItem(ListBox lst1, ListBox lst2)
        {
            if (lst1.SelectedIndex == -1)
            {
                MessageBox.Show("No hay items seleccionados");
            }
            else
            {
                lst2.Items.Add(lst1.SelectedItem);
                lst1.Items.Remove(lst1.SelectedItem);
            }
        }
        // Metodo Mover todos los Items
        private void MoveAllItems(ListBox lst1, ListBox lst2)
        {
            lst2.Items.AddRange(lst1.Items);
            lst1.Items.Clear();
        }
        


        //Mover Item seleccionado a la derecha
        private void BtnMoveRight_Click(object sender, EventArgs e)
        {
            if (lstItem.Items.Count == 0)
            {
                MessageBox.Show("No hay items en la lista");
            }
            else
            {
                MoveItem(lstItem, lstItem2);
            }
            
        }

        //Mover Todos los a la derecha
        private void BtnMoveRightAll_Click(object sender, EventArgs e)
        {
            if(lstItem.Items.Count == 0)
            {
                MessageBox.Show("No hay items en la lista");
            }
            else
            {
                MoveAllItems(lstItem, lstItem2);
            }
            
        }

        //Mover Item seleccionado a la izquierda
        private void BtnMoveLeft_Click(object sender, EventArgs e)
        {
            if (lstItem2.Items.Count == 0)
            {
                MessageBox.Show("No hay items en la lista");
            }
            else
            {
                MoveItem(lstItem2, lstItem);
            }
        }
        //Mover Todos Item a la izquierda

        private void BtnMoveLeftAll_Click(object sender, EventArgs e)
        {
            if (lstItem2.Items.Count == 0)
            {
                MessageBox.Show("No hay items en la lista");
            }
            else
            {
                MoveAllItems(lstItem2, lstItem);
            }
        }

       
    }
}
