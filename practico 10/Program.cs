using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Baraja baraja = new Baraja();
            string[] opciones = {
                "            Barajar            ",
                "            Siguiente carta    ",
                "            Cartas disponibles ",
                "            Dar cartas         ",
                "            Cartas descartadas ",
                "            Mostrar baraja     "
            };
            Menu menup = new Menu(opciones);
            while (true)
            {
                menup.pintar();
                while (true)
                {
                    ConsoleKeyInfo opcion = Console.ReadKey();
                    if (opcion.Key == ConsoleKey.DownArrow)
                        menup.bajar();
                    else if (opcion.Key == ConsoleKey.UpArrow)
                        menup.subir();
                    else if (opcion.Key == ConsoleKey.Enter)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        bool bandera = false;
                        if (menup.PosMenu == 0)
                        {
                            baraja.barajar();
                            Console.SetCursorPosition(30, 0);
                            Console.Write("Se barajo las cartas");
                            bandera = true;
                        }
                        else if (menup.PosMenu == 5)
                        {
                            Console.Clear();
                            List<Carta> cartas = baraja.mostrarBaraja();
                            Console.Write("Baraja actual");
                            int x = 0, y = 0;
                            for (int i = 0; i < cartas.Count; i++)
                            {
                                y++;
                                if (i % 25 == 0)
                                {
                                    x++;
                                    y = 0;
                                }
                                Console.SetCursorPosition(x*20, y + 2);
                                Console.WriteLine(cartas[i].Numero + " de " + cartas[i].Palo);
                            }
                        }
                        if (!bandera)
                        {
                            Console.SetCursorPosition(0,27);
                            Console.Write("\nPresione esc para volver");
                            ConsoleKeyInfo opcionA;
                            do
                            {
                                opcionA = Console.ReadKey();
                            } while (opcionA.Key != ConsoleKey.Escape);
                            Console.Clear();
                            break;
                        }
                    }
                }
            }
            
        }
    }
}
