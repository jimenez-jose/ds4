using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Ingrese el dividendo: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el divisor: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int resultado = a / b;
            Console.WriteLine($"Resultado: {resultado}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: No se puede dividir entre cero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Debe ingresar solo números enteros.");
        }
    }
}
