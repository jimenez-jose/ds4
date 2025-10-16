using System;

namespace Laboratorio12
{
    public class Triangulo
    {
        // Calcula el semiperímetro del triángulo
        public double CalcularSemiperimetro(double a, double b, double c)
        {
            return (a + b + c) / 2.0;
        }

        // Calcula el área del triángulo usando la fórmula de Herón
        public double CalcularArea(double a, double b, double c)
        {
            double s = CalcularSemiperimetro(a, b, c);
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }
}
