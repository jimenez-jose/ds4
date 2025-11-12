using System;
using System.Web.UI;

namespace Laboratorio161
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnMensaje_Click(object sender, EventArgs e)
        {
            string texto = TextBox1.Text;
            Page.ClientScript.RegisterClientScriptBlock(
                typeof(Page),
                "MessageBox",
                "window.alert('Hola: " + texto + "');",
                true
            );
        }
    }
}
