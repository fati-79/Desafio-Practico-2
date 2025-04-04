using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_12
{
    internal class Program
    {
        static void Main(string[] args) { 
       

                //programa realizado por Fatima Gonzalez

                Console.WindowHeight = 40;//alto de ventana
                Console.WindowWidth = 90;//ancho de ventana
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                // Lista de palabras secretas y sus pistas
                string[] palabras = { "lapicero", "conejo", "parque", "cuaderno", "ventilador", "celular" };
                string[,] pistas = {
                { "sirve para escrbir", "puede ser de diferentes colores", "tiene tapadera", "es facil de utilizar", "es muy util para los estudiantes" },
                { "es un animal", "Tiene cuatro patas", "son tiernos", "tienen cola redonda", "pueden ser domesticos" },
                { "es ul lugar", "se puede ir a pasear", "sirve para recreacion", "tiene muchos arboles", "suelen estar muchas personas" },
                { "tiene varias hojas", "pueden ser cuadriculados", "pueden ser rallados", "sirve para apuntes", "pueden ser de aspiral o cocidos" },
                { "hacen ruido", "nos dan brisa", "funcionan con energia", "tienen aspas", "pueden ser de pared o portatil" },
                { "lo usamos todo el tiempo", "son recargables ", "nos permiten comunicarnos", "funcionan con internet", "son tactiles" }
            };

                // Elegir palabra 
                Random random = new Random();
                int indicePalabra = random.Next(0, palabras.Length);
                string palabraSecreta = palabras[indicePalabra];

                // Inicializar variables
                int intentos = 6;
                char[] progreso = new char[palabraSecreta.Length];
                List<char> letrasUsadas = new List<char>();

                // Llenar el progreso con guiones bajos
                for (int i = 0; i < progreso.Length; i++)
                {
                    progreso[i] = '_';
                }

                // Iniciar el juego
                Console.WriteLine("=================================");
                Console.WriteLine("         JUEGO DEL AHORCADO      ");
                Console.WriteLine("=================================");
                Console.WriteLine("Adivina la palabra secreta. Tienes 6 intentos.");
                Console.WriteLine("Si fallas, recibirás una pista.");
                Console.WriteLine("=================================\n");

                while (intentos > 0)
                {
                    Console.WriteLine("Palabra: " + new string(progreso));
                    Console.Write("Letras usadas: ");
                    Console.WriteLine(string.Join(", ", letrasUsadas));
                    Console.Write("Ingresa una letra: ");
                    string entrada = Console.ReadLine().ToLower();

                    // Validar entrada
                    if (entrada.Length != 1 || !char.IsLetter(entrada[0]))
                    {
                        Console.WriteLine("Por favor, ingresa una sola letra válida.");
                        continue;
                    }

                    char letra = entrada[0];

                    // Verificar si ya se usó la letra
                    if (letrasUsadas.Contains(letra))
                    {
                        Console.WriteLine("Ya usaste esta letra. Intenta con otra.");
                        continue;
                    }

                    letrasUsadas.Add(letra);
                    bool acierto = false;

                    // Verificar si la letra está en la palabra
                    for (int i = 0; i < palabraSecreta.Length; i++)
                    {
                        if (palabraSecreta[i] == letra)
                        {
                            progreso[i] = letra;
                            acierto = true;
                        }
                    }

                    if (!acierto)
                    {
                        intentos--;
                        Console.WriteLine("\n¡Incorrecto! Te quedan " + intentos + " intentos.");
                        if (intentos > 0)
                        {
                            //  uso correcto de matriz bidimensional
                            Console.WriteLine("Pista: " + pistas[indicePalabra, 6 - intentos - 1]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n¡Bien hecho! La letra está en la palabra.");
                    }

                    // si ha ganado
                    if (new string(progreso) == palabraSecreta)
                    {
                        Console.WriteLine("\n¡Felicidades! Has adivinado la palabra: " + palabraSecreta);
                        return;
                    }

                }
                // si pierde
                Console.WriteLine("\nQue mal, te has quedado sin intentos. La palabra era: " + palabraSecreta);
                Console.ReadKey();

            }
        }
    }


