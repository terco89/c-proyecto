using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace practico_12
{
    internal class Program
    {
        static void esperar(string msg)
        {
            Console.WriteLine(msg);
            while(true)
            {
                if(Console.ReadKey().Key == ConsoleKey.Enter) break;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la ruleta rusa\nIngrese la cantidad de jugadores");
            int cantParticipantes;
            while(true)
            {
                if (Int32.TryParse(Console.ReadLine(), out cantParticipantes))
                    break;
                Console.SetCursorPosition(0, 2);
                Console.Write("                                                                 ");
                Console.SetCursorPosition(0, 2);
            }
            Juego juego = new Juego(cantParticipantes);
            Console.CursorVisible = false;
            for(int i = 0;true;i++)
            {
                Console.Clear();
                esperar("Ronda "+i+", presiona enter para iniciarla\n\n");
                Console.WriteLine(juego.ronda());
                esperar("\nRonda " + i + " terminada, presione enter para continuar.");
                if (juego.finJuego())
                    break;
            }
            esperar("Termino el juego. Presione enter para continuar");
        }
    }
}
