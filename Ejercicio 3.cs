using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double[] valores = new double[100];
        private int cantidad = 0;

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cantidad < 100)
            {
                if (double.TryParse(tbValor.Text, out double valor))
                {
                    valores[cantidad] = valor;
                    cantidad++;

                    tbResultado.AppendText(valor.ToString() + Environment.NewLine);

                    tbValor.Clear();
                    tbValor.Focus();
                }

                else
                {
                    MessageBox.Show("Ingresa un valor numerico valido");
                }
            }

            else
            {
                MessageBox.Show("Ya se alcanzo el maximo de 100 valores");
            }
        }

        private void btnCalcularProm_Click(object sender, EventArgs e)
        {
            if (cantidad > 0)
            {
                double suma = 0;
                for (int i = 0; i < cantidad; i++)
                {
                    suma += valores[i];
                }

                double promedio = suma / cantidad;

                lbResultado.Text = promedio.ToString();
                tbResultado.AppendText("Promedio: " + promedio.ToString("0.00") + Environment.NewLine);
            }

            else
            {
                MessageBox.Show("No hay valores registrados");
            }
        }
    }
}
