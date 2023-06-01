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
            Baraja baraja = new Baraja();

            foreach (Carta c in baraja.Cartas)
            {
                Console.WriteLine(c.Numero+c.Palo);
            }
            Console.WriteLine("\n\n");
            baraja.barajar();
            foreach (Carta c in baraja.Cartas)
            {
                Console.WriteLine(c.Numero + c.Palo);
            }
            Console.ReadKey();
        }
    }
}
