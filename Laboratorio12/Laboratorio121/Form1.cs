using System;
using System.Windows.Forms;

namespace Laboratorio121
{
    public partial class Form1 : Form
    {
        CalculosDistancia calculo = new CalculosDistancia();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Calcular
        {
            try
            {
                double velocidad = double.Parse(textBox1.Text);
                double tiempo = double.Parse(textBox2.Text);

                double distancia = calculo.CalcularDistancia(velocidad, tiempo);
                label3.Text = $"Distancia recorrida: {distancia} metros";
            }
            catch
            {
                MessageBox.Show("Ingrese valores numéricos válidos.", "Error");
            }
        }

        private void button2_Click(object sender, EventArgs e) // Limpiar
        {
            textBox1.Clear();
            textBox2.Clear();
            label3.Text = "";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e) // Salir
        {
            Application.Exit();
        }
    }
}
