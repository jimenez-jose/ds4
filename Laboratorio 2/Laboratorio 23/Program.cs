using System;

namespace Laboratorio2
{
    class Configuracion
    {
        public static string appName = "Laboratorio 2 - C#";
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Accediendo a la variable estática desde la clase
            Console.WriteLine("Bienvenido a " + Configuracion.appName);
        }
    }
}
