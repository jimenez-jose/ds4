using System;

namespace Laboratorio88
{
    abstract class Figura
    {
        public abstract double Area();
    }

    class Circulo : Figura
    {
        public double Radio { get; set; }
        public Circulo(double radio) { Radio = radio; }

        public override double Area()
        {
            return Math.PI * Radio * Radio;
        }
    }

    class Cuadrado : Figura
    {
        public double Lado { get; set; }
        public Cuadrado(double lado) { Lado = lado; }

        public override double Area()
        {
            return Lado * Lado;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Figura f1 = new Circulo(5);
            Figura f2 = new Cuadrado(4);

            Console.WriteLine("Área círculo: " + f1.Area());
            Console.WriteLine("Área cuadrado: " + f2.Area());
        }
    }
}
