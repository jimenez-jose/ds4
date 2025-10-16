using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laboratorio122
{
    public partial class Form1 : Form
    {
        PromedioNotas promedio = new PromedioNotas();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Calcular
        {
            try
            {
                double n1 = double.Parse(textBox1.Text);
                double n2 = double.Parse(textBox2.Text);
                double n3 = double.Parse(textBox3.Text);

                double resultado = promedio.CalcularPromedio(n1, n2, n3);
                label5.Text = $"Promedio: {resultado:F2}";
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
            textBox3.Clear();
            label5.Text = "";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e) // Salir
        {
            Application.Exit();
        }
    }
}
