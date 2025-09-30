using System;

namespace Laboratorio89
{
    interface IFigura
    {
        double Area();
    }

    class Rectangulo : IFigura
    {
        public double Ancho { get; set; }
        public double Alto { get; set; }

        public Rectangulo(double ancho, double alto)
        {
            Ancho = ancho;
            Alto = alto;
        }

        public double Area()
        {
            return Ancho * Alto;
        }
    }

    class Circulo : IFigura
    {
        public double Radio { get; set; }
        public Circulo(double radio) { Radio = radio; }

        public double Area()
        {
            return Math.PI * Radio * Radio;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IFigura r = new Rectangulo(5, 3);
            IFigura c = new Circulo(4);

            Console.WriteLine("Área rectángulo: " + r.Area());
            Console.WriteLine("Área círculo: " + c.Area());
        }
    }
}
