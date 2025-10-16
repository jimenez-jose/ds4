using System;
using System.Windows.Forms;

namespace Laboratorio12
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 👇 Aquí se indica con qué formulario iniciar la aplicación
            Application.Run(new Form1());
        }
    }
}