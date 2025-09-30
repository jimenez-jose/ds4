using System;

namespace Laboratorio86
{
    class Padre
    {
        public virtual void Metodo()
        {
            Console.WriteLine("Metodo en Padre");
        }

        public virtual sealed void MetodoFinal()
        {
            Console.WriteLine("Metodo Final en Padre");
        }
    }

    class Hijo : Padre
    {
        // public override void MetodoFinal() { }  ❌ Error, no se puede sobrescribir
        public override void Metodo()
        {
            Console.WriteLine("Metodo sobreescrito en Hijo");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Hijo h = new Hijo();
            h.Metodo();
            h.MetodoFinal();
        }
    }
}
