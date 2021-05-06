using System;
using Clases;

namespace LabClases1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            A instancia = new A();
            instancia.mostrarNombre();

            B instancia2 = new B(instancia);

            instancia2.mostrarNombre();
            instancia2.M3();


        }
    }

 
}