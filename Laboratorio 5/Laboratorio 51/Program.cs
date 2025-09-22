using System;

class Program
{
    static void Main()
    {
        double[] sueldos = new double[5];

        for (int i = 0; i < sueldos.Length; i++)
        {
            Console.Write($"Ingrese el sueldo del operario {i + 1}: ");
            sueldos[i] = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("\nSueldos ingresados:");
        for (int i = 0; i < sueldos.Length; i++)
        {
            Console.WriteLine($"Operario {i + 1}: {sueldos[i]}");
        }
    }
}
