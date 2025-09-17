using System;

namespace Laboratorio47
{
    class Operaciones
    {
        public int Sumar(int a, int b = 10) // b es opcional
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Operaciones op = new Operaciones();

            Console.WriteLine("Suma con 1 parámetro (usa valor por defecto): " + op.Sumar(5));
            Console.WriteLine("Suma con 2 parámetros: " + op.Sumar(5, 20));
        }
    }
}
