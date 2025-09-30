class Aleatorios
{
    private Random rnd = new Random();

    // Generar un número entre dos números
    public int GenerarNumero(int min, int max)
    {
        return rnd.Next(min, max + 1);
    }

    // Generar un arreglo de números entre dos números aleatorios
    public int[] GenerarArreglo(int tamano, int min, int max)
    {
        int[] arreglo = new int[tamano];
        for (int i = 0; i < tamano; i++)
        {
            arreglo[i] = rnd.Next(min, max + 1);
        }
        return arreglo;
    }
}