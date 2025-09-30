using System;

namespace Laboratorio93
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el lado A: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el lado B: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el lado C: ");
            double c = double.Parse(Console.ReadLine());

            // Verificar si es un triángulo válido
            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("El triángulo es equilátero");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("El triángulo es isósceles");
                }
                else
                {
                    Console.WriteLine("El triángulo es escaleno");
                }
            }
            else
            {
                Console.WriteLine("Los lados no forman un triángulo válido");
            }
        }
    }
}
