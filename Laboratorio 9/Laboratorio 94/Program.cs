class Program
{
    static void Main(string[] args)
    {
        Aleatorios ale = new Aleatorios();
        Console.WriteLine("Número aleatorio: " + ale.GenerarNumero(1, 10));

        int[] arr = ale.GenerarArreglo(5, 1, 20);
        Console.WriteLine("Arreglo aleatorio:");
        foreach (int n in arr)
            Console.Write(n + " ");
    }
}