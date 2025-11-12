using System;
using System.Web.UI;

namespace Laboratorio161
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
                double n1 = Convert.ToDouble(TextBox1.Text);
                double n2 = Convert.ToDouble(TextBox2.Text);
                double suma = n1 + n2;

                LabelResultado.Text = "La suma es: " + suma.ToString();
            }
            catch
            {
                LabelResultado.Text = "Por favor, ingrese valores numéricos válidos.";
            }
        }
    }
}
