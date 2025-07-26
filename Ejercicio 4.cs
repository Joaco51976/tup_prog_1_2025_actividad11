using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] valores = new int[100];
        int cantidad = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbValor.Text, out int valor))
            {
                if (cantidad < valores.Length)
                {
                    valores[cantidad] = valor;
                    cantidad++;
                    tbValor.Clear();
                    tbValor.Focus();
                }

                else
                {
                    MessageBox.Show("Se alcanzo el maximo de valores permitidos");
                }
            }

            else
            {
                MessageBox.Show("Ingrese un valor numerico valido");
            }
        }

        private void btnCalcularProm_Click(object sender, EventArgs e)
        {
            if (cantidad == 0)
            {
                MessageBox.Show("No hay valores registrados");
                return;
            }

            int suma = 0;
            for (int i = 0; i < cantidad; i++)
            {
                suma += valores[i];
            }

            double promedio = (double)suma / cantidad;
            lbResultado.Text = $"{promedio:F2}";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbBuscar.Text, out int valorBuscado))
            {
                int indice = BuscarValor(valorBuscado);
                if (indice != -1)
                {
                    tbResultado.Text = $"Valor encontrado en la posición: {indice}";
                }

                else
                {
                    tbResultado.Text = "Valor no encontrado";
                }
            }

            else
            {
                MessageBox.Show("Ingrese un numero valido para buscar");
            }
        }

        private int BuscarValor(int valorBuscado)
        {
            for (int i = 0; i < cantidad; i++)
            {
                if (valores[i] == valorBuscado)
                    return i;
            }
            return -1;
        }

        private void btnListarOrdenado_Click(object sender, EventArgs e)
        {
            if (cantidad == 0)
            {
                MessageBox.Show("No hay valores registrados.");
                return;
            }

            int[] copia = new int[cantidad];
            Array.Copy(valores, copia, cantidad);
            Array.Sort(copia);

            tbResultado.Clear();
            tbResultado.AppendText("Valores ordenados:\r\n");
            for (int i = 0; i < cantidad; i++)
            {
                tbResultado.AppendText(copia[i] + "\r\n");
            }
        }
    }
}