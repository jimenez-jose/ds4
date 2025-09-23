using System;

public class Dado
{
    private int valor;
    private static Random rnd = new Random();

    public void Tirar()
    {
        valor = rnd.Next(1, 7); // valores del 1 al 6
    }

    public void Imprimir()
    {
        Console.Write($"{valor} ");
    }

    public int RetornarValor()
    {
        return valor;
    }
}
