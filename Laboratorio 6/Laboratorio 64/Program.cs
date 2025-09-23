using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Ingrese su edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            if (edad < 0)
            {
                throw new ArgumentException("La edad no puede ser negativa.");
            }
            else if (edad < 18)
            {
                throw new Exception("Debe ser mayor de edad para continuar.");
            }

            Console.WriteLine("Edad válida. Puede continuar.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
