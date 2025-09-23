using System;

public class JuegoDeDados
{
    private Dado dado1;
    private Dado dado2;
    private Dado dado3;

    public JuegoDeDados()
    {
        dado1 = new Dado();
        dado2 = new Dado();
        dado3 = new Dado();
    }

    public void Jugar()
    {
        dado1.Tirar();
        dado2.Tirar();
        dado3.Tirar();

        Console.Write("Valores obtenidos: ");
        dado1.Imprimir();
        dado2.Imprimir();
        dado3.Imprimir();
        Console.WriteLine();

        if (dado1.RetornarValor() == dado2.RetornarValor() &&
            dado2.RetornarValor() == dado3.RetornarValor())
        {
            Console.WriteLine("¡Ganó!");
        }
        else
        {
            Console.WriteLine("Perdió.");
        }
    }
}

