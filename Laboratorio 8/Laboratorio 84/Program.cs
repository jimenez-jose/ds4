using System;

namespace Laboratorio84
{
    class Persona
    {
        private string nombre;
        private int edad;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set
            {
                if (value >= 0)
                    edad = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            p.Nombre = "Ana";
            p.Edad = 25;

            Console.WriteLine($"Nombre: {p.Nombre}, Edad: {p.Edad}");
        }
    }
}
