using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_11
{
    internal class Program
    {
        static Random rd = new Random();
        static void esperar()
        {
            ConsoleKeyInfo opcion;
            do
            {
                opcion = Console.ReadKey(true);
            } while (opcion.Key != ConsoleKey.Enter);
        }
        static void Main(string[] args)
        {
            List<Jugador> jugadores = new List<Jugador>();
            Apuesta apuesta;
            int cant,jornadas;
            while (true)
            {
                Console.WriteLine("¿Cuantos jugadores van a ser?");
                string pCant = Console.ReadLine();
                if (Int32.TryParse(pCant, out cant) && cant > 0)
                    break;
                Console.Clear();
            }
            Console.Clear();
            while (true)
            {
                Console.WriteLine("¿Cuantos jornadas van a ser?");
                string pCant = Console.ReadLine();
                if (Int32.TryParse(pCant, out jornadas) && jornadas > 0)
                    break;
                Console.Clear();
            }
            for (int i = 0; i < cant; i++)
            {
                jugadores.Add(new Jugador(rd.Next(20, 40), i));
            }
            apuesta = new Apuesta(jugadores);

            while (true)
            {
                Console.Clear();
                if (!apuesta.iniciarJornada())
                    break;
                Console.WriteLine("Empezo la apuesta, e inicio la jornada numero {0}", apuesta.CantJornadas);
                Console.WriteLine("Presione Enter para empezar el partido");
                esperar();
                int[] resultado = apuesta.empezarPartido();
                if (resultado == null)
                    break;
                Console.WriteLine("El partido salio {0} a {1}", resultado[0], resultado[1]);
                Console.WriteLine("Presione Enter para terminar la jornada");
                esperar();
                int ganador = apuesta.terminarJornada();
                if (ganador == -1)
                    Console.WriteLine("Nadie gano esta jornada");
                else
                    Console.WriteLine("Gano Jugador {0} la apuesta", apuesta.Jugadores[ganador].Id);
                if (apuesta.CantJornadas == jornadas)
                {
                    Console.WriteLine("Se acabaron las jornadas, presione enter para volver");
                    esperar();
                    break;
                }
                Console.WriteLine("Presione Enter para comenzar una nueva jornada");
                esperar();
            }
            Console.Clear();
            foreach(Jugador j in apuesta.Jugadores)
            {
                Console.WriteLine("Jugador {0} tiene {1} pesos y gano {2} veces",j.Id,j.Dinero,j.ContGanadas);
            }
            Console.WriteLine("\n Presione Enter para terminar el programa");
            esperar();
        }
    }
}
