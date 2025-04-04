using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programa realizado por Fatima Ortez
            Console.WindowHeight = 40;
            Console.WindowWidth = 70;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            //declarcion de variables 
            double num1, num2, suma, resta, multiplicacion, division;
            int opcion;
            //entrada de datos
            Console.Write("\n\tDigite el primer numero : ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("\tDigite el segundo numero : ");
            num2 = double.Parse(Console.ReadLine());
            Console.Write("\n");

            
           
         
            bool continuar = true;
            while (continuar)
            {
                //menu
                Console.WriteLine("\tOPERACIONES MATEMATICAS");
                Console.WriteLine("\t 1. sumar");
                Console.WriteLine("\t 2. restar");
                Console.WriteLine("\t 3. multiplicar");
                Console.WriteLine("\t 4. dividir");
                Console.WriteLine("\t 5. salir");
                Console.Write("\n");
                Console.Write("\tElija una opcion del [1 al 5 ]: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        suma = num1 + num2;
                        Console.WriteLine("\tLa suma de los numero es : " + suma);
                        break;
                    case 2:
                        resta = num1 - num2;
                        Console.WriteLine("\tla resta de los numeros es : " + resta);
                        break;
                    case 3:
                        multiplicacion = num1 * num2;
                        Console.WriteLine("\tLa multiplicacion de los numeros es : " + multiplicacion);
                        break;
                    case 4:
                        if (num2 != 0 && num1 != 0)              
                        {
                            division = num1 / num2;
                            Console.WriteLine("\tLa division de los numeros es : " + Math.Round(division,2));

                        }
                        else
                        {
                            Console.WriteLine("\tNo se puede dividir entre cero. ");
                        }
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
                
                Console.WriteLine("\n\tdesea continuar con el programa ? (si/no)");
                  continuar =Console.ReadLine().ToLower() == "si"; //Tolower sirve para conversir si en minuscula o mayuscula
            }
        }
    }
}
