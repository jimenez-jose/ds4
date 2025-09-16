using System;

namespace Laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tipos de valor
            int valor1 = 28;
            int valor2 = valor1; // Copia el valor
            valor2 = 30;

            Console.WriteLine("valor1 = " + valor1); // 28
            Console.WriteLine("valor2 = " + valor2); // 30

            // Tipos de referencia
            Persona p1 = new Persona();
            p1.nombre = "Ana";

            Persona p2 = p1; // Apunta al mismo objeto en memoria
            p2.nombre = "Laura";

            Console.WriteLine("p1.nombre = " + p1.nombre); // Laura
            Console.WriteLine("p2.nombre = " + p2.nombre); // Laura
        }
    }

    class Persona
    {
        public string nombre;
    }
}
