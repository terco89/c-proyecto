using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo a;
            Console.WriteLine("1 Lista");
            Console.WriteLine("2 Ingresar numero");
            a = Console.ReadKey();
            if (a.Key == ConsoleKey.D1)
            {
                Console.WriteLine("Voce apretaste 1");
            }
            else if (a.Key == ConsoleKey.D2)
            {
                Console.WriteLine("Pusiste el 2 :O");
            }
            Console.ReadKey();
        }
    }
}
