using System;

namespace Laboratorio81
{
    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Nif { get; set; }

        public Persona(string nombre, int edad, string nif)
        {
            Nombre = nombre;
            Edad = edad;
            Nif = nif;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, NIF: {Nif}");
        }
    }

    class Trabajador : Persona
    {
        public int Sueldo { get; set; }

        public Trabajador(string nombre, int edad, string nif, int sueldo)
            : base(nombre, edad, nif)
        {
            Sueldo = sueldo;
        }

        public void MostrarTrabajador()
        {
            MostrarInfo();
            Console.WriteLine($"Sueldo: {Sueldo}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Trabajador t1 = new Trabajador("Carlos", 30, "8-123-456", 1200);
            t1.MostrarTrabajador();
        }
    }
}
