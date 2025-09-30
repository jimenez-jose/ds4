using System;

namespace Laboratorio91
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el precio del producto: ");
            double precio;
            while (!double.TryParse(Console.ReadLine(), out precio) || precio <= 0)
            {
                Console.Write("Precio inválido. Ingrese un valor positivo: ");
            }

            Console.Write("Forma de pago (efectivo/tarjeta): ");
            string forma = Console.ReadLine().ToLower();

            if (forma == "tarjeta")
            {
                Console.Write("Ingrese el número de cuenta (16 dígitos): ");
                string cuenta = Console.ReadLine();

                while (cuenta.Length != 16 || !long.TryParse(cuenta, out _))
                {
                    Console.Write("Número inválido. Ingrese un número de 16 dígitos: ");
                    cuenta = Console.ReadLine();
                }

                Console.WriteLine($"Pago con tarjeta aceptado. Precio: {precio}, Cuenta: {cuenta}");
            }
            else if (forma == "efectivo")
            {
                Console.WriteLine($"Pago en efectivo aceptado. Precio: {precio}");
            }
            else
            {
                Console.WriteLine("Forma de pago no válida.");
            }
        }
    }
}
