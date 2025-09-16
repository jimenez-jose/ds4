using System;

namespace Laboratorio33
{
    class CalculosMatematicos
    {
        public int CalcularPerimetro(int lado1, int lado2)
        {
            return 2 * (lado1 + lado2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el valor del lado 1: ");
            int lado1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el valor del lado 2: ");
            int lado2 = Convert.ToInt32(Console.ReadLine());

            CalculosMatematicos calc = new CalculosMatematicos();
            int perimetro = calc.CalcularPerimetro(lado1, lado2);

            Console.WriteLine($"El perímetro del rectángulo es: {perimetro}");
        }
    }
}
