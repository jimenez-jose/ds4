using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laboratorio12
{
    public partial class Form1 : Form
    {
        Triangulo triangulo = new Triangulo();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Calcular
        {
            try
            {
                double ladoA = double.Parse(textBox1.Text);
                double ladoB = double.Parse(textBox2.Text);
                double ladoC = double.Parse(textBox3.Text);

                double s = triangulo.CalcularSemiperimetro(ladoA, ladoB, ladoC);
                double area = triangulo.CalcularArea(ladoA, ladoB, ladoC);

                label5.Text = $"Semiperímetro: {s:F2}\nÁrea: {area:F2}";
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
