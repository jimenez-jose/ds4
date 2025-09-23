using System;

public class Banco
{
    private Cliente cliente1;
    private Cliente cliente2;
    private Cliente cliente3;

    public Banco()
    {
        cliente1 = new Cliente("Ana");
        cliente2 = new Cliente("Luis");
        cliente3 = new Cliente("Marta");
    }

    public void Operar()
    {
        cliente1.Depositar(1000);
        cliente2.Depositar(2000);
        cliente3.Depositar(1500);

        cliente1.Extraer(500);
        cliente3.Extraer(200);
    }

    public void DepositosTotales()
    {
        double total = cliente1.RetornarMonto() +
                       cliente2.RetornarMonto() +
                       cliente3.RetornarMonto();

        cliente1.Imprimir();
        cliente2.Imprimir();
        cliente3.Imprimir();

        Console.WriteLine($"\nEl total de dinero en el banco es: {total}");
    }
}
