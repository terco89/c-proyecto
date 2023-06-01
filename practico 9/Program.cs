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
        static void Main(string[] args)
        {
            Random rd = new Random();
            string[] nombres = new string[] { "Juan", "Pedro", "Luis", "Carlos", "Miguel", "Alejandro", "Jorge", "José", "Francisco", "Antonio", "María", "Ana", "Laura", "Carolina", "Sofía", "Isabella", "Valentina", "Gabriela", "Paola", "Fernanda" };
            List<Pelicula> peliculas = new List<Pelicula>(){new Pelicula("Spirit",1.28,"Elaine Bogan",13), new Pelicula("Capitan America: Civil War",2.28,"Anthony Russo",16),new Pelicula("Corazón Valiente",2.58,"Mel Gibson",18)};
            Sala sala = new Sala(peliculas[rd.Next(0,peliculas.Count())],rd.Next(1000,2400),8,8);
            List<Espectador> espectadores = new List<Espectador>();

            for(int i = 0; i < rd.Next(20,100); i++)
            {
                espectadores.Add(new Espectador(nombres[rd.Next(0,nombres.Count())],rd.Next(1,99),rd.Next(1000,10000)));
            }

            Console.Write("Bienvenido a la sala del cine!!");

            Console.SetCursorPosition(0,3);
            Console.WriteLine("Asientos disponibles:");
            foreach(Asiento a in sala.Asientos){
                Console.Write(a.Fila+a.Columna+" ");
            }
            while (true) {
                Espectador red = espectadores[rd.Next(0, espectadores.Count())];
                Console.SetCursorPosition(0, 7);
                Console.WriteLine("Datos del espectador:");
                Console.WriteLine("Nombre: " + red.Nombre);
                Console.WriteLine("Edad: "+ red.Edad + " años");
                Console.WriteLine("Cantidad de dinero: "+red.Dinero +" pesos");
                Console.WriteLine("Analizando si el espectador puede entrar...");
                Thread.Sleep(1000);
                if (sala.puedeEntrar(red.Edad, red.Dinero))
                    Console.WriteLine("El espectador tiene el suficiente dinero y edad para entrar!!");
                else
                {
                    Console.WriteLine("El espectador no puede entrar porque "+sala.razon(red.Edad,red.Dinero));
                    continue;
                }
                Console.SetCursorPosition(0,11);
                Console.Write("                                                ");
                Console.SetCursorPosition(0, 11);
                Console.WriteLine("Buscando un asiento...");
                Console.Write("                                                ");
                Console.SetCursorPosition(0, 12);
                Thread.Sleep(1000);
                if (sala.hayAsientos())
                {
                    Asiento ahora = sala.ocuparAsiento();
                    Console.Write("El espectador se sento en el asiento " + ahora.Fila+ahora.Columna);
                }
                else
                {
                    Console.Write("Ya no hay asientos");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
