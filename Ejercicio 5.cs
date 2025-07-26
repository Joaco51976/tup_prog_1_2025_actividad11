using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] valores = new int[100];
        int cantidad = 0;


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) // Boton Calcular Minimo
        {
            if (cantidad == 0)
            {
                MessageBox.Show("No hay valores");
                return;
            }

            int min = valores[0];
            for (int i = 1; i < cantidad; i++)
            {
                if (valores[i] < min)
                {
                    min = valores[i];
                }
            }

            lbMinimo.Text = $"Minimo: {min}";
        }

        private void button5_Click(object sender, EventArgs e) // boton superior al promedio
        {
            if (cantidad == 0)
            {
                MessageBox.Show("No hay valores");
                return;
            }

            int suma = 0;
            for (int i = 0; i < cantidad; i++)
                suma += valores[i];

            double promedio = (double)suma / cantidad;

            tbResultado.Clear();
            tbResultado.AppendText($"Valores mayores al promedio ({promedio:F2}):\r\n");
            for (int i = 0; i < cantidad; i++)
            {
                if (valores[i] > promedio)
                {
                    tbResultado.AppendText(valores[i] + "\r\n");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) // boton listar ordenado
        {
            if (cantidad == 0)
            {
                MessageBox.Show("No hay valores registrados");
                return;
            }

            int[] copia = new int[cantidad];
            Array.Copy(valores, copia, cantidad);
            Array.Sort(copia);

            tbResultado.Clear();
            tbResultado.AppendText("Valores ordenados:\r\n");
            for (int i = 0; i < cantidad; i++)
                tbResultado.AppendText(copia[i] + "\r\n");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Se alcanzo el limite de valores");
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
                MessageBox.Show("No hay valores cargados");
                return;
            }

            int suma = 0;
            for (int i = 0; i < cantidad; i++)
                suma += valores[i];

            double promedio = (double)suma / cantidad;
            lbResultado.Text = $" {promedio:F2}";
        }

        private void btnMaximo_Click(object sender, EventArgs e)
        {
            if (cantidad == 0)
            {
                MessageBox.Show("No hay valores");
                return;
            }

            int max = valores[0];
            for (int i = 1; i < cantidad; i++)
            {
                if (valores[i] > max)
                {
                    max = valores[i];
                }
            }

            lbResultado.Text = $"Maximo: {max}";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbBuscar.Text, out int valorBuscado))
            {
                int indice = BuscarValor(valorBuscado);
                if (indice != -1)
                {
                    MessageBox.Show($"Valor encontrado en la posicion: {indice}");
                }

                else
                {
                    MessageBox.Show("Valor no encontrado");
                }
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
    }
}