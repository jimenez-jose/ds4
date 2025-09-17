using System;

namespace Laboratorio44
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("El número es positivo.");
            }
            else if (num < 0)
            {
                Console.WriteLine("El número es negativo.");
            }
            else
            {
                Console.WriteLine("El número es cero.");
            }
        }
    }
}
