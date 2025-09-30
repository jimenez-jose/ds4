class Program
{
    static void Main(string[] args)
    {
        Aleatorios ale = new Aleatorios();
        int[] arr = ale.GenerarNoRepetidos(10, 1, 50);

        Console.WriteLine("Arreglo sin repetidos:");
        foreach (int n in arr)
            Console.Write(n + " ");
    }
}