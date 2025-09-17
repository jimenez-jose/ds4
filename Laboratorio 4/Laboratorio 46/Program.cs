using System;

namespace Laboratorio46
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = Math.PI;

            Console.Write("Ingrese el radio de un círculo: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            double area = PI * Math.Pow(radio, 2);
            double circunferencia = 2 * PI * radio;

            Console.WriteLine($"Área del círculo: {area}");
            Console.WriteLine($"Circunferencia: {circunferencia}");
        }
    }
}
