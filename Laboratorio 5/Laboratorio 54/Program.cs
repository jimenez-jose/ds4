using System;

class Program
{
    static void Main()
    {
        double[] notas = { 85.5, 90.0, 78.5, 92.0, 88.5 };
        double suma = 0;

        foreach (double nota in notas)
        {
            suma += nota;
        }

        double promedio = suma / notas.Length;
        Console.WriteLine($"Promedio de calificaciones: {promedio:F2}");
    }
}
