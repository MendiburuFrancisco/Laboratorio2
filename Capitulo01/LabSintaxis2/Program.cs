using System;

namespace LabSintaxis2
{
    class Program
    {
        

        static void Main(string[] args)
        {

           // Ejercicio1();
           // Ejercicio2();
 
    }
        private static void Ejercicio1()
        {
            bool verificar = false;
            string inputText;


            do
            {
                inputText = ingresarTexto();
                verificar = verificarTexto(inputText);
            } while (verificar == false);

            menu();
             SeleccionarOpcionIF( inputText, Console.ReadKey());
        }

        private static void Ejercicio2()
        {
            bool verificar = false;
            string inputText;


            do
            {
                inputText = ingresarTexto();
                verificar = verificarTexto(inputText);
            } while (verificar == false);

            menu();
            SeleccionarOpcionCASE(inputText, Console.ReadKey());
            Console.WriteLine();
        }

       


        private static void SeleccionarOpcionCASE(string inputText, ConsoleKeyInfo op)
        {
            switch (op.Key)
            {
                case ConsoleKey.D1: Console.WriteLine(inputText.ToUpper()); break;
                case ConsoleKey.D2: Console.WriteLine(inputText.ToLower()); break;
                case ConsoleKey.D3: Console.WriteLine(inputText.Length); break;
                    
            }
        }

        private static string ingresarTexto()
        {
            string inputText;

            Console.WriteLine("Ingresar Texto");
            inputText = Console.ReadLine();

            return inputText;

        }

        private static bool verificarTexto(string textoIngresado) 
        {

            if (textoIngresado == "")
            {
                Console.WriteLine("El texto ingresado es incorrecto, ingrese nuevamente");
                return false;
            }
            else 
            {
               
                return true;
            }

           
        }

        private static void menu()
        {

            Console.WriteLine("1 - A mayusculas");
            Console.WriteLine("2 - A minusculas");
            Console.WriteLine("3 - cantidad de caracteres");
        }

        private static void SeleccionarOpcionIF(string inputText, ConsoleKeyInfo opcion)
        {
            if (opcion.Key == ConsoleKey.D1)
            {
                Console.WriteLine(inputText.ToUpper());
            } else if (opcion.Key.Equals(ConsoleKey.D2))
            {
                Console.WriteLine(inputText.ToLower());
            } else
            {
                Console.WriteLine(inputText.Length);
            }

        }

    }
}


//Pasos:
//1) Crear una nueva solución con un proyecto en modo consola llamado LabSintaxis2.

//2) Pedir al usuario que ingrese un texto. Asignar el texto ingresado a una variable que se
//llame inputTexto, utilizando Console.ReadLine().

//3) Validar que se haya ingresado texto en inputTexto, de lo contrario, mostrar mensaje
//y terminar la aplicación.

//4) Mostrar un menú que de opciones de mostrar la frase ingresada en mayúsculas
//(usando .ToUpper() del string), en minúsculas(usando.ToLower()), o mostrar la cantidad de caracteres que tiene (usando en Lenght). Permitir que el usuario pueda seleccionar la opción 1, 2 o 3 solamente. Asignarla a la variable opción, de la siguiente manera:
//ConsoleKeyInfo opcion = Console.ReadKey();
//ReadKey devuelve información sobre el input del usuario. Esta información debe ser
//utilizada para descubrir cual fue la opción.

//5) Armar un if anidado, que muestre los resultados esperados en función de la opción.
//Si no se eligió ninguna de las opciones esperadas, deberá mostrar un mensaje y salir
//de la aplicación. Para crear las condiciones del if, utilizar opcion.Key para obtener
//la tecla presionada por el usuario y ConsoleKey.D1, ConsoleKey.D2, y ConsoleKey.D3, que
//son los números 1, 2 y 3. Observar que .NET provee en ConsoleKey cada una de las teclas,
//como un enumerado, lo que resulta mas fácil las comparaciones, y evita confusiones entre
//el uso del char, del valor ASCII, etc. Siempre se compararán elementos del tipo ConsoleKey.


//6) Ejecutar la aplicación y observar que los resultados sean los esperados.