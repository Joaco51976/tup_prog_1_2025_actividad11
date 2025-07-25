using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
        }

        double acumulador = 0;
        int contador = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (contador > 0)
            {
                double promedio = acumulador / contador;

                lbResultado.Text = promedio.ToString();
                tbResultado.AppendText("Promedio: " + promedio.ToString("0.00") + Environment.NewLine);
            }

            else
            {
                MessageBox.Show("Ingrese un valor numerico valido");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbValor.Text, out double valor))
            {
                acumulador += valor;
                contador++;

                tbResultado.AppendText(valor.ToString() + Environment.NewLine);

                tbValor.Clear();
                tbValor.Focus();
            }

            else
            {
                MessageBox.Show("Ingrese un valor numerico valido");
            }
        }
    }
}
