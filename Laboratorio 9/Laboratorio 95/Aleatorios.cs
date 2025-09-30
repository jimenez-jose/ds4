class Aleatorios
{
    private Random rnd = new Random();

    public int[] GenerarNoRepetidos(int cantidad, int min, int max)
    {
        if (cantidad > (max - min + 1))
            throw new ArgumentException("El rango no permite generar esa cantidad sin repetir.");

        HashSet<int> numeros = new HashSet<int>();
        while (numeros.Count < cantidad)
        {
            numeros.Add(rnd.Next(min, max + 1));
        }
        return new List<int>(numeros).ToArray();
    }
}