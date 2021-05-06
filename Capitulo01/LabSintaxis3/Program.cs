using System;

namespace LabSintaxis3
{
    class Program
    {
        const int cantIteraciones = 5;
        
        static void Main(string[] args)
        {
            string[] listaTexto = new string[cantIteraciones];
            ingresarTexto(listaTexto, cantIteraciones);
            mostrarTexto(listaTexto,cantIteraciones);

        }

        private static void mostrarTexto(string[] listaTexto, int cantIteraciones)
        {
            for (int posArreglo = cantIteraciones-1; posArreglo >=0; posArreglo--)
            {
                Console.WriteLine($"Texto: {posArreglo}");
                Console.WriteLine(listaTexto[posArreglo]); 
            }
        }

        private static void ingresarTexto(string[] listaTexto, int cantIteraciones)
        {
            Console.WriteLine("Ingresar texto");
                for(int posArreglo = 0; posArreglo < cantIteraciones; posArreglo++)
            {
                listaTexto[posArreglo] = Console.ReadLine();
            }
            Console.WriteLine("--------");
        }
    }
}
