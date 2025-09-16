using System;

namespace Laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Llamamos al método
            Sumar();
        }

        static void Sumar()
        {
            int variableLocal = 10;   // variable local
            int resultado = variableLocal + 5;
            Console.WriteLine("El resultado de la suma es: " + resultado);
        }
    }
}
