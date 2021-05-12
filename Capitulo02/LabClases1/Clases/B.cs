using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    class B : A
    {
        public B(A inst) => Console.WriteLine("Instancia de B");
        public void M4() => Console.WriteLine("Metodo del hijo invocado");

    }
}


