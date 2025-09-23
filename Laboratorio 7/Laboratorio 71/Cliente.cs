using System;

public class Cliente
{
    private string nombre;
    private double monto;

    public Cliente(string nombre)
    {
        this.nombre = nombre;
        this.monto = 0;
    }

    public void Depositar(double cantidad)
    {
        monto += cantidad;
    }

    public void Extraer(double cantidad)
    {
        if (cantidad <= monto)
            monto -= cantidad;
        else
            Console.WriteLine($"{nombre} no tiene suficiente saldo para extraer {cantidad}");
    }

    public double RetornarMonto()
    {
        return monto;
    }

    public void Imprimir()
    {
        Console.WriteLine($"{nombre} tiene depositado: {monto}");
    }
}

