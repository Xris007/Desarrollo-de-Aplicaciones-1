using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyWinC_Sem01
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
             
        private void btnCalcular_Click(object sender, EventArgs e)
        {
                        try
            {
                Single[] notas = new Single[5];
                Single promedio = 0;
                // Se almacenan las notas en un arreglo
                notas[0] = Convert.ToSingle(txtN1.Text);
                notas[1] = Convert.ToSingle(txtN2.Text);
                notas[2] = Convert.ToSingle(txtN3.Text);
                notas[3] = Convert.ToSingle(txtN4.Text);
                notas[4] = Convert.ToSingle(txtN5.Text);
                // Se ordena el arreglo
                Array.Sort(notas);

                // se pregunta por el tipo de curso
                if (optTeoria.Checked)
                {
                    // promedio simple....
                    promedio = (notas[0] + notas[1] + notas[2] + notas[3] + notas[4]) / 5;
                }
                else
                { // Se imprime la nota eliminada (la mas  baja) ,,,,
                    MessageBox.Show("Se elimino la nota" +
                     notas[0] + " y " + notas[1], "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    promedio = (notas[2] + notas[3] + notas[4]) / 3;
                }
                // Se calcula y muestra el promedio
                lblPromedio.Text = promedio.ToString();

                // se pinta de azul o rojo el label, dependiendo si esta aprobado o no
                if (promedio >= 13)
                {
                    lblPromedio.ForeColor = Color.Blue;
                }
                else
                {
                    lblPromedio.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

      // 5 notas si  es teoria eliminar la mas baja si es de practica eliminar las 2 mas bajas

       
    }
}
