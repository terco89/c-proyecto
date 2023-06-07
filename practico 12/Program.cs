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
        static void esperar()
        {
            while(true)
            {
                if(Console.ReadKey().Key == ConsoleKey.Enter) break;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Bienvenido a la ruleta rusa\nIngrese la cantidad de jugadores");
            int cantParticipantes;
            while(true)
            {
                if (Int32.TryParse(Console.ReadLine(), out cantParticipantes))
                    break;
            }
            Juego juego = new Juego(cantParticipantes);

            for(int i = 0;true;i++)
            {
                Console.Clear();
                Console.WriteLine("Ronda {0}, presiona s para iniciarla");
                esperar();
            }
        }
    }
}
