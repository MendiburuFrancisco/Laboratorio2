using System;

namespace LabSintaxis4
{
    class Program
    {
        static void Main(string[] args)
        {
         //   problema1();
            problema2();
        }
        
        private static void problema1()
        {
            //aplicación que sume dos números y proporcione el resultado con el
            //formato siguiente: El resultado de la suma de < número uno > y < número dos > es
            //< resultado >.

            Console.WriteLine("Ingrese el primero nro");
            int nro1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo nro"); 
            int nro2 = int.Parse(Console.ReadLine());

            // ^ pedimos los numeros por consola ^

            int resultado = nro1 + nro2;

            Console.WriteLine($"El resultado de la suma de {nro1} y {nro2} es {resultado}");

            Console.ReadLine();




        }
        private static void problema2()
        {
            Console.WriteLine("Ingrese el anio");
            int anio = int.Parse(Console.ReadLine());
            if (EsBisiesto(anio))
            {
                Console.WriteLine($"{anio} es bisiesto");
            }
            else
            {
                Console.WriteLine($"{anio} NO es bisiesto");
            }

            Console.ReadLine();
        }

        private static bool EsBisiesto(int anioIngresado)
        {
            if (anioIngresado % 4 == 0 && anioIngresado % 100 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
