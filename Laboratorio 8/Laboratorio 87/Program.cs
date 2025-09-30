using System;

namespace Laboratorio87
{
    sealed class Padre
    {
        public void Metodo()
        {
            Console.WriteLine("Clase Final - no se puede heredar");
        }
    }

    // class Hijo : Padre { } ❌ Error, no se puede heredar de una clase sealed

    class Program
    {
        static void Main(string[] args)
        {
            Padre p = new Padre();
            p.Metodo();
        }
    }
}
