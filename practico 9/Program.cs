using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace practico_9
{
    class Program
    {
        static Random rd = new Random();
        static void limpiarDatos(int min, int max)
        {
            for(int i = min; i <= max; i++)
            {
                Console.SetCursorPosition(0,i);
                Console.Write("                                                                       ");
            }
        }
        static void Main(string[] args)
        {
            string[] nombres = new string[] { "Juan", "Pedro", "Luis", "Carlos", "Miguel", "Alejandro", "Jorge", "José", "Francisco", "Antonio", "María", "Ana", "Laura", "Carolina", "Sofía", "Isabella", "Valentina", "Gabriela", "Paola", "Fernanda" };
            List<Pelicula> peliculas = new List<Pelicula>(){new Pelicula("Spirit",1.28,"Elaine Bogan",13), new Pelicula("Capitan America: Civil War",2.28,"Anthony Russo",16),new Pelicula("Corazón Valiente",2.58,"Mel Gibson",18)};
            Sala sala = new Sala(peliculas[rd.Next(0,peliculas.Count())],rd.Next(1000,2400),8,8);
            List<Espectador> espectadores = new List<Espectador>();
            Console.CursorVisible = false;

            for(int i = 0; i < rd.Next(20,100); i++)
            {
                espectadores.Add(new Espectador(nombres[rd.Next(0,nombres.Count())],rd.Next(1,99),rd.Next(1000,10000)));
            }

            Console.Write("Bienvenido a la sala del cine!!");

            Console.SetCursorPosition(0,3);
            Console.WriteLine("Asientos disponibles:");
            for(int i = 0; i < sala.Columnas; i++){
                Console.SetCursorPosition(75,i+5);
                for (int j = 0; j < sala.Filas; j++) {
                    Console.SetCursorPosition(j*3+75, i + 5);
                    Console.Write(sala.Asientos[8*i+j].Fila + sala.Asientos[8*i+j].Columna.ToString() + " ");
                }
            }

            Console.SetCursorPosition(75,20);
            Console.Write("Pelicula: "+sala.Actual.Titulo);
            Console.SetCursorPosition(75, 21);
            Console.Write("Duración: " + sala.Actual.Duracion);
            Console.SetCursorPosition(75, 22);
            Console.Write("Director: " + sala.Actual.Director);
            Console.SetCursorPosition(75, 23);
            Console.Write("Publico: para mayores de " + sala.Actual.EdadMinima + " años");

            bool bandera = false;
            for(int i = 0; i < espectadores.Count; i++) {
                limpiarDatos(7,14);
                Espectador red = espectadores[rd.Next(0, espectadores.Count())];
                Console.SetCursorPosition(0, 7);
                Console.WriteLine("Datos del espectador:");
                Console.WriteLine("Nombre: " + red.Nombre);
                Console.WriteLine("Edad: "+ red.Edad + " años");
                Console.WriteLine("Cantidad de dinero: "+red.Dinero +" pesos");
                Console.WriteLine("Analizando si el espectador puede entrar...");
                Thread.Sleep(100);
                if (sala.puedeEntrar(red.Edad, red.Dinero))
                    Console.WriteLine("El espectador tiene el suficiente dinero y edad para entrar!!");
                else
                {
                    Console.WriteLine("El espectador no puede entrar porque "+sala.razon(red.Edad,red.Dinero));
                    Thread.Sleep(100);
                    continue;
                }
                Console.SetCursorPosition(0,13);
                Console.Write("                                                ");
                Console.SetCursorPosition(0, 13);
                Console.WriteLine("Buscando un asiento...");
                Console.Write("                                                ");
                Thread.Sleep(100);
                if (sala.hayAsientos())
                {
                    Asiento ahora = sala.ocuparAsiento();
                    Console.SetCursorPosition(sala.buscarColumna(ahora.Columna) * 3+75,ahora.Fila+4);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("  ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(0,14);
                    Console.Write("El espectador se sento en el asiento " + ahora.Fila+ahora.Columna);
                }
                else
                {
                    Console.SetCursorPosition (0,14);
                    Console.Write("Ya no hay asientos");
                    bandera = true;
                    break;
                }
                Thread.Sleep(100);
            }
            if (!bandera)
            {
                Console.SetCursorPosition(0,15);
                Console.WriteLine("Ya no hay mas personas que sentar");
            }
            Console.ReadKey();
        }
    }
}
