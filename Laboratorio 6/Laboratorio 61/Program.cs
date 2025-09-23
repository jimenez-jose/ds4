using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Ingrese un número entero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"El número ingresado es: {numero}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: El valor ingresado no es un número entero válido.");
        }
    }
}
