using System;

namespace LabSintaxis4
{
    class Program
    {
        static void Main(string[] args)
        {
            //   problema1();
            //   problema2();
            //   problema3();
            //   problema4()
            //  problema5();
            // problema6();
            // problema7(); 
            // problema8();
            //problema9();
             
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

        private static void problema3()
        {
            Console.WriteLine("Proporcionador de numeros pares");

            for (int numero = 0; numero <= 50; numero++)
            {
                Console.WriteLine(numero * 2);
            }
        }

        private static void problema4()
        {
            int Cant = 10;
            int[] Serie = new int[Cant];
            Serie[0] = 0;
            Serie[1] = 1;

            for (int i = 2; i < Cant; i++)
            {
                Serie[i] = Serie[i - 1] + Serie[i - 2];
            }


            for (int i = 0; i < Cant; i++)
            {
                Console.WriteLine((i + 1) + ") " + Serie[i]);
            }
            Console.ReadKey();
        }

        private static void problema5()
        {
            Console.WriteLine("Ingresar nombre del mes: (ej: Febrero)");
            Console.WriteLine(numeroDelAnio(Console.ReadLine()));
        }

        private static int numeroDelAnio(string mes)

        {
            int numeroDelMes = 0;
            switch (mes)
            {
                case "Enero": numeroDelMes = 1; break;
                case "Febrero": numeroDelMes = 2; break;
                case "Marzo": numeroDelMes = 3; break;
                case "Abril": numeroDelMes = 4; break;
                case "Mayo": numeroDelMes = 5; break;
                case "Junio": numeroDelMes = 6; break;
                case "Julio": numeroDelMes = 7; break;
                case "Agosto": numeroDelMes = 8; break;
                case "Septiembre": numeroDelMes = 9; break;
                case "Octubre": numeroDelMes = 10; break;
                case "Noviembre": numeroDelMes = 11; break;
                case "Diciembre": numeroDelMes = 12; break;

            }

            return numeroDelMes;


        }

        private static void problema6()
        {
            Console.WriteLine("Ingrese el numero");
            int numero = int.Parse(Console.ReadLine());

            int[] num = descomponerNumero(numero);
            Console.Write($"{numero} = ");
            mostrarNroRomano(num[0], num[1], num[2], num[3]);

            Console.WriteLine();
             

        }

        private static void problema7()
        {
            int[] numerosPrimos = nrosPrimos(); 

            for(int posNumero = 1; posNumero < numerosPrimos.Length; posNumero++)
            {
                int numeroAnterior = numerosPrimos[posNumero-1];
                int numero = numerosPrimos[posNumero];
                int resta = numero - numeroAnterior; 
                if(resta == 2)
                {
                    Console.WriteLine($"{numero} y {numeroAnterior} son nros Primos gemelos");
                }
            }
        }

        private static int[] nrosPrimos()
        {
            int[] numerosPrimos = new int[25];
            int numero = 2;
            int total = 1;
            int contador = 0;

            while (total <= 25)
            {
                bool esPrimo = true;
                for (int numeroAnterior = 2; numeroAnterior < numero; numeroAnterior++)
                {
                    if (numero % numeroAnterior == 0)
                    {
                        esPrimo = false;
                        break;
                    }

                }
                 if (esPrimo)
                {
                    

                    numerosPrimos[contador] = numero;
                    contador += 1;
                    // Console.WriteLine(numero);
                    total++;
                }

                numero++;
            }

            return numerosPrimos;
        }
        private static void problema8()
        {
            //  
            int intentos = 0;
            while(intentos < 4)
            {
                intentos++;

                Console.WriteLine("Introduzca Clave");
                string clave = Console.ReadLine();

                if (clave == "1234")
                {
                    intentos = 4;
                    Console.WriteLine("Clave correcta");
                } 
            }
        }

        private static void problema9()
        {
            int cantEspacio = 0;
            for (int cantidad = 0; cantidad < 10; cantidad++)
                {
                     
                     if ((cantidad % 2) != 0)
                    {
                        cantEspacio += 1;
                    
                    // for (int espacio = 0; espacio < (5 - (4 - cantidad  )); espacio++)
                    for (int espacio = 0; espacio < (5 - cantEspacio); espacio++)
                    {
                        Console.Write(" ");
                    }
                    for (int asterisco = 0; asterisco < cantidad; asterisco++)
                    {
                     
                        Console.Write("*");
                    }
                    Console.WriteLine();
                     
                     }
                

            }
                
             
        }


        private static int[] descomponerNumero(int numero)
        {
            int unidad, decena, centena, millar;

            unidad = numero % 10; numero /= 10;
            decena = numero % 10; numero /= 10;
            centena = numero % 10; numero /= 10;
            millar = numero % 10; numero /= 10;
            int[] numeroDescompuesto = { millar, centena, decena, unidad };

            return numeroDescompuesto;
        }
        private static void mostrarNroRomano(int millar, int centena, int decena, int unidad)
        {
            switch (millar)
            {
                case 1: Console.Write("M"); break;
                case 2: Console.Write("MM"); break;
                case 3: Console.Write("MMM"); break;
            }

            switch (centena)
            {
                case 1: Console.Write("C"); break;
                case 2: Console.Write("CC"); break;
                case 3: Console.Write("CCC"); break;
                case 4: Console.Write("CD"); break;
                case 5: Console.Write("D"); break;
                case 6: Console.Write("DC"); break;
                case 7: Console.Write("DCC"); break;
                case 8: Console.Write("DCCC"); break;
                case 9: Console.Write("CM"); break;
            }

            switch (decena)
            {
                case 1: Console.Write("X"); break;
                case 2: Console.Write("XX"); break;
                case 3: Console.Write("XXX"); break;
                case 4: Console.Write("XL"); break;
                case 5: Console.Write("L"); break;
                case 6: Console.Write("LX"); break;
                case 7: Console.Write("LXX"); break;
                case 8: Console.Write("LXXX"); break;
                case 9: Console.Write("CL"); break;
            }

            switch (unidad)
            {
                case 1: Console.Write("I"); break;
                case 2: Console.Write("II"); break;
                case 3: Console.Write("III"); break;
                case 4: Console.Write("IV"); break;
                case 5: Console.Write("V"); break;
                case 6: Console.Write("VI"); break;
                case 7: Console.Write("VII"); break;
                case 8: Console.Write("VIII"); break;
                case 9: Console.Write("IX"); break;
            }

        }


    }
} 
