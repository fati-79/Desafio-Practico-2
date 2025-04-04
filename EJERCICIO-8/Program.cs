using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // realizado por Fatima Ortez
            Console.WindowHeight = 40;//alto
            Console.WindowWidth = 75;//ancho
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

           int i, numeroUsuario;
                Random random = new Random();//numero aleatorio
                int numeroAleatorio = random.Next(1, 101);
            string respuesta;

            Console.WriteLine("Bienevenido al juego");

            for (i = 10; i > 0; i--)
                {
                    Console.WriteLine("le quuedan [" + i + "] intentos  : ");

                    Console.WriteLine("ingrese un numero entre 1 y 100: ");              
                numeroUsuario = int.Parse(Console.ReadLine());
               
                    if (numeroUsuario < numeroAleatorio)
                    {
                        Console.WriteLine("el  numero ingresado es menor que el numero generado por el programa ");
                    }
                    else if (numeroUsuario > numeroAleatorio)
                    {
                        Console.WriteLine("el numero que ingreso es mayor que el numero generado por el programa");
                    }

                    else
                    {

                        Console.WriteLine("FELICIDADES GANASTE");
                        break;
                    }


                    if (i == 1)
                    {
                        Console.WriteLine("perdiste el  numero era: " + numeroAleatorio);
                    }



                    Console.WriteLine("Desea continuar con el juego? (si/no)");
                    respuesta = Console.ReadLine().ToLower();
                if (respuesta == "no")
                {

                    Console.WriteLine("Gracias por jugar");
                    Environment.Exit(0);
                }
                  
            }
            
 
            Console.ReadKey();
        }
    }
}





                


        
    


    

