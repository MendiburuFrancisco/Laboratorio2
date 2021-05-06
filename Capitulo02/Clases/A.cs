using System;

namespace Clases
{
    public class A
    {
        public A() => nombreInstancia = "Nombre sin instancia";
        public A(string nombre) => nombreInstancia = nombre;

        public void mostrarNombre() => Console.WriteLine(this.nombreInstancia);
        public void M1() => Console.WriteLine("M1 invocado");
        public void M2() => Console.WriteLine("M2 invocado");
        public void M3() => Console.WriteLine("M3 invocado");

        private string nombreInstancia;






    }


}
