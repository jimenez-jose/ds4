using System;

namespace Laboratorio42
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número entero: ");
            int n = Convert.ToInt32(Console.ReadLine());

            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"El factorial de {n} es: {factorial}");
        }
    }
}
