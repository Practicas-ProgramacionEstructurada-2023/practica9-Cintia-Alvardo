using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("\nMenú de Opciones");
                Console.WriteLine("1. Multiplicar números");
                Console.WriteLine("2. Restar números");
                Console.WriteLine("3. Concatenar cadenas");
                Console.Write("\nIngrese su opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("\nIngrese dos números enteros para multiplicar:");

                            Console.Write("\nNúmero 1: ");
                            int num1 = Convert.ToInt32(Console.ReadLine());

                            Console.Write("\nNúmero 2: ");
                            int num2 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\nResultado de la multiplicación (Entero): " + Multiplicar(num1, num2));

                            Console.WriteLine("\nIngrese dos números decimles para multiplicar:");

                            Console.Write("\nNúmero 1: ");
                            int num1double = Convert.ToInt32(Console.ReadLine());

                            Console.Write("\nNúmero 2: ");
                            int num2double = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\nResultado de la multiplicación (Decimal): " + Multiplicar(num1double, num2double));
                            break;
                        case 2:
                            Console.WriteLine("\nEl resultado es: " + RestarNumeros(20, 5, 3, 2));
                            break;
                        case 3:
                            Console.Write("\nIngrese su primer nombre: ");
                            string? cadena1 = Convert.ToString(Console.ReadLine());

                            Console.Write("\nIngrese su primer apellido: ");
                            string? cadena2 = Convert.ToString(Console.ReadLine());

                            Console.Write("\nIngrese el separdor: ");
                            string? separador1 = Convert.ToString(Console.ReadLine());

                            string resultadoConcatenado = ConcatenarCadenas(cadena1, cadena2, separador1);
                            Console.WriteLine("\nResultado de la concatenación: " + resultadoConcatenado);

                            
                            Console.Write("\nIngrese su segundo nombre: ");
                            string? cadena3 = Convert.ToString(Console.ReadLine());

                            Console.Write("\nIngrese su sedundo apellido: ");
                            string? cadena4 = Convert.ToString(Console.ReadLine());

                            Console.Write("\nIngrese su dirección: ");
                            string? cadena5 = Convert.ToString(Console.ReadLine());

                            Console.Write("\nIngrese el separdor: ");
                            string? separador2 = Convert.ToString(Console.ReadLine());

                            string resultadoConcatenado2 = ConcatenarCadenas(cadena3, cadena4, cadena5,  separador2);
                            Console.WriteLine("\nResultado de la concatenación: " + resultadoConcatenado);
                            break;
                        case 4:
                            Console.WriteLine(",\nSaliendo del programa...");
                            break;
                        default:
                            Console.WriteLine("\nOpción no váilida. Intente de nuevo");
                            break;
                    }


                }
                else
                {
                    Console.WriteLine("\nOpción no válida. Intente de nuevo");
                }

            } while (opcion != 4);
        }
        static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        static double Multiplicar(double a, double b)
        {
            return a * b;
        }

        static int RestarNumeros(params int[] numeros)
        {
            int resultado = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                resultado -= numeros[i];
            }

            return resultado;
        }

        static string ConcatenarCadenas(string? cadena1, string? cadena2, string? separador)
        {
            return cadena1 + separador + cadena2;
        }

        static string ConcatenarCadenas(string? cadena1, string? cadena2 , string? cadena3, string? separador1)
        {
            return cadena3 + separador1 + separador1 + cadena3;
        }
    }
}
