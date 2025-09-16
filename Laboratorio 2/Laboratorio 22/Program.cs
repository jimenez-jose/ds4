using System;

namespace Laboratorio2
{
    class Persona
    {
        // Variables de instancia (atributos de la clase)
        public string nombre;
        public int edad;

        public void MostrarDatos()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            p1.nombre = "Carlos";
            p1.edad = 25;

            p1.MostrarDatos();
        }
    }
}
