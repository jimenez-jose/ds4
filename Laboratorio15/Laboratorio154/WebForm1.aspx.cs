using System;
using System.Web.UI;

namespace Laboratorio154
{
    public partial class WebForm1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(TextBox1.Text);
                double num2 = Convert.ToDouble(TextBox2.Text);
                double suma = num1 + num2;

                LabelResultado.Text = "La suma es: " + suma.ToString();
            }
            catch
            {
                LabelResultado.Text = "Por favor, ingrese números válidos.";
            }
        }
    }
}
