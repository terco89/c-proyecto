using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.WriteLine("Bienvenido, escoja su baraja\n1. Baraja Española\n2. Baraja Francesa");
            Baraja baraja;
            while (true)
            {
                ConsoleKeyInfo opk = Console.ReadKey(true);
                if (opk.Key == ConsoleKey.D1)
                {
                    baraja = new BarajaEspaniola(true);
                    break;
                }
                if(opk.Key == ConsoleKey.D2)
                {
                    baraja = new BarajaFrancesa();
                    break;
                }
            }
            Console.Clear();
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
                    ConsoleKeyInfo opcion = Console.ReadKey(true);
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
                            Console.Write("Se barajo las cartas              ");
                            bandera = true;
                        }
                        else if (menup.PosMenu == 1)
                        {
                            Carta carta = baraja.siguienteCarta();
                            Console.SetCursorPosition(30, 0);
                            if (carta == null)
                                Console.Write("No hay mas cartas                 ");
                            else
                                Console.Write("Tu carta es: {0}                  ", carta.Palo);
                            bandera = true;
                        }
                        else if (menup.PosMenu == 2)
                        {
                            int cant = baraja.cartasDisponibles();
                            Console.SetCursorPosition(30, 0);
                            Console.Write("Quedan {0} cartas                 ", cant);
                            bandera = true;
                        }
                        else if (menup.PosMenu == 3)
                        {
                            int cant;
                            Console.CursorVisible = true;
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("¿Cuantas cartas desea de la baraja?");
                                string p = Console.ReadLine();
                                if (Int32.TryParse(p, out cant) && cant > 0 && cant <= baraja.cartasDisponibles())
                                    break;
                            }
                            Console.CursorVisible = false;
                            List<Carta> cartas = baraja.darCartas(cant);
                            if (cartas == null)
                                Console.WriteLine("No hay mas cartas             ");
                            else
                            {
                                Console.Write("Cartas solicitadas ({0})", cant);
                                int x = 1, y = 0;
                                for (int i = 0; i < cartas.Count; i++)
                                {
                                    y++;
                                    if (i % 25 == 0)
                                    {
                                        x++;
                                        y = 0;
                                    }
                                    Console.SetCursorPosition(x * 30, y + 2);
                                    Console.WriteLine(cartas[i].Palo);
                                }
                            }
                        }
                        else if (menup.PosMenu == 4)
                        {
                            Console.Clear();
                            Console.Write("Cartas que ya salieron");
                            baraja.cartasMonton();
                        }
                        else if (menup.PosMenu == 5)
                        {
                            Console.Clear();
                            Console.Write("Baraja actual");
                            baraja.mostrarBaraja();
                        }
                        if (!bandera)
                        {
                            Console.SetCursorPosition(0, 27);
                            Console.Write("\nPresione esc para volver");
                            ConsoleKeyInfo opcionA;
                            do
                            {
                                opcionA = Console.ReadKey(true);
                            } while (opcionA.Key != ConsoleKey.Escape);
                            Console.Clear();
                            menup.PosMenu = 0;
                            break;
                        }
                    }
                }
            }

        }
    }
}
