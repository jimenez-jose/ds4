using System;

namespace Laboratorio82
{
    class Cuenta
    {
        public virtual double CalcularIntereses(double saldo)
        {
            return saldo * 0.01;
        }
    }

    class CuentaAhorro : Cuenta
    {
        public override double CalcularIntereses(double saldo)
        {
            return saldo * 0.03;
        }
    }

    class CuentaPlazoFijo : Cuenta
    {
        public override double CalcularIntereses(double saldo)
        {
            return saldo * 0.05;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cuenta c1 = new Cuenta();
            Cuenta c2 = new CuentaAhorro();
            Cuenta c3 = new CuentaPlazoFijo();

            Console.WriteLine("Cuenta Normal: " + c1.CalcularIntereses(1000));
            Console.WriteLine("Cuenta Ahorro: " + c2.CalcularIntereses(1000));
            Console.WriteLine("Cuenta Plazo Fijo: " + c3.CalcularIntereses(1000));
        }
    }
}
