using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[3, 4];

        for (int fila = 0; fila < 3; fila++)
        {
            for (int col = 0; col < 4; col++)
            {
                Console.Write($"Ingrese el valor en posición [{fila},{col}]: ");
                matriz[fila, col] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\nValores en la matriz:");
        for (int fila = 0; fila < 3; fila++)
        {
            for (int col = 0; col < 4; col++)
            {
                Console.Write($"{matriz[fila, col]} \t");
            }
            Console.WriteLine();
        }
    }
}
