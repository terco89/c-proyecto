using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer19
{
    /*1. Crear un programa que calcule el promedio de un conjunto de números ingresados por el usuario.
2. Crear un programa que simule un cajero automático, permitiendo al usuario hacer depósitos, retiros y consultar su saldo.
3. Crear un programa que simule un juego de adivinanza de números, en el que el usuario debe adivinar un número generado aleatoriamente por el programa.
4. Crear un programa que genere una lista de números primos hasta un número ingresado por el usuario.
5. Crear un programa que simule un juego de ahorcado, en el que el usuario debe adivinar una palabra oculta letra por letra.
6. Crear un programa que permita al usuario ingresar una lista de tareas y organizarlas por orden de prioridad.
7. Crear un programa que permita al usuario ingresar una serie de números y determine cuál es el número más grande y cuál es el número más pequeño.
8. Crear un programa que simule una biblioteca, permitiendo al usuario buscar y prestar libros, y llevando un registro de los préstamos y devoluciones.
9. Crear un programa que permita al usuario calcular la distancia entre dos puntos en un plano cartesiano.
10. Crear un programa que permita al usuario convertir una cantidad de una unidad de medida a otra, por ejemplo, de metros a pies.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] menu = {
                "            Promedio de un conjunto         ",
                "            Cajero automatico               ",
                "            Juego de adivinanza             ",
                "            Numeros primos                  ",
                "            Juego de ahorcado               ",
                "            Lista de tareas                 ",
                "            Mas grande y pequeño            ",
                "            Biblioteca                      ",
                "            Plano cartesiano                ",
                "            Convertidor de medidas          ",
                "            Salir                           "
            };
            bool api = false;
            ConsoleKeyInfo tecla;
            Console.CursorVisible = false;
            
            while (true)
            {
                if (api == true)
                {
                    break;
                }
                int posMenu = 0;
                Console.Clear();
                for (int i = 0; i < menu.Count(); i++)
                {
                    Console.SetCursorPosition(30, i + 10);
                    if (i == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Write(menu[i]);
                }

                while (true)
                {
                    tecla = Console.ReadKey(true);
                    if (tecla.Key == ConsoleKey.DownArrow)
                    {
                        if (posMenu < menu.Count() - 1)
                        {
                            Console.SetCursorPosition(30, posMenu + 10);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(menu[posMenu]);
                            posMenu++;
                            Console.SetCursorPosition(30, posMenu + 10);
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(menu[posMenu]);
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(30, posMenu + 10);
                            Console.Write(menu[posMenu]);
                            posMenu = 0;
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(30, posMenu + 10);
                            Console.Write(menu[posMenu]);
                        }
                    }
                    if (tecla.Key == ConsoleKey.UpArrow)
                    {
                        if (posMenu > 0)
                        {
                            Console.SetCursorPosition(30, posMenu + 10);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(menu[posMenu]);
                            posMenu--;
                            Console.SetCursorPosition(30, posMenu + 10);
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(menu[posMenu]);
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(30, posMenu + 10);
                            Console.Write(menu[posMenu]);
                            posMenu = menu.Count()-1;
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(30, posMenu + 10);
                            Console.Write(menu[posMenu]);
                        }
                    }
                    if(tecla.Key == ConsoleKey.Enter)
                    {
                        if(posMenu == 0) {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.SetCursorPosition(30, 10);
                            Console.WriteLine("Ingrese la cantidad de numeros que contendra el conjunto (max 20 y min 5):");
                            Console.CursorVisible = true;
                            int valor = 0;
                            string esp = "";
                            while (true)
                            {
                                Console.SetCursorPosition(30, 12);
                                if(esp == " ") {
                                    esp = "";
                                    for (int i = 0; i < valor.ToString().Length; i++)
                                    {
                                        esp += " ";
                                    }
                                }
                                valor = Convert.ToInt32(Console.ReadLine());
                                if (valor < 5 || valor > 20)
                                {
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.SetCursorPosition(30, 15);
                                    Console.WriteLine("Error: la cantidad ingresada es mayor o menor a los limites");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.ForegroundColor = ConsoleColor.White;
                                    esp = " ";
                                }
                            }
                            int sum = 0;
                            for(int i = 0; i < valor; i++)
                            {
                                Console.Clear();
                                Console.SetCursorPosition(30, 10);
                                Console.WriteLine("Ingrese un numero (rango: -999999 a 999999):");
                                Console.SetCursorPosition(30, 12);
                                int num = Convert.ToInt32(Console.ReadLine());
                                sum += num;
                            }
                            Console.Clear();
                            Console.SetCursorPosition(30, 10);
                            Console.WriteLine("El promedio es: {0}",sum/valor);
                            Console.ReadKey();
                        }
                    }
                
                }
            }
        }
    }
}
