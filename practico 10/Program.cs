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
            menup.pintar();
            while (true)
            {
                ConsoleKeyInfo opcion = Console.ReadKey();
                if (opcion.Key == ConsoleKey.DownArrow)
                    menup.bajar();
                else if (opcion.Key == ConsoleKey.UpArrow)
                    menup.subir();
                else if(opcion.Key == ConsoleKey.Enter)
                {
                    if(menup.PosMenu == 0)
                    {
                        Console.Clear();
                    }
                }
            }
            
            Console.ReadKey();
        }
    }
}
