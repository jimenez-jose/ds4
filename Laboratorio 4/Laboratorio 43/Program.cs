using System;

namespace Laboratorio43
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            do
            {
                Console.Write("Ingrese un número mayor que 0 (0 para salir): ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero > 0)
                {
                    Console.WriteLine($"Ingresaste: {numero}");
                }

            } while (numero != 0);

            Console.WriteLine("Programa finalizado.");
        }
    }
}
