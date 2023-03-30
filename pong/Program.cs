using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace pong
{
    class Pong
    {
        public int x, y;

        public Pong(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void crear()
        {
            for (int j = y; j < y+3; j++)
            {
                for (int i = x; i < x+10; i++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.WriteLine("█");
                }
            }
        }
    }

    class Ficha 
    {
        public int x = 60, y = 15;
        
        public void crear()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("■");
        }
        public void mover()
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Pong p1 = new Pong(0,9);
            p1.crear();
            Pong p2 = new Pong(117,9);
            p2.crear();
            Ficha f1 = new Ficha();
            f1.crear();

            Console.ReadKey();
        }
    }
}
