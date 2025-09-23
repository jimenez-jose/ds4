using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Ingrese un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Número ingresado: {numero}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Entrada inválida, se esperaba un número.");
        }
        finally
        {
            Console.WriteLine("Bloque finally ejecutado: Gracias por usar el programa.");
        }
    }
}
