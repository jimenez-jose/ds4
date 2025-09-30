using System;

namespace Laboratorio85
{
    public partial class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }

    public partial class Persona
    {
        public void Mostrar()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona { Nombre = "Luis", Edad = 20 };
            p.Mostrar();
        }
    }
}
