using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer4
{
    class Program
    {
        static Int32 suma(Int16 num1,Int16 num2)
        {
            return num1 + num2;
        }
        static Int32 mayor(Int32 num1,Int32 num2,Int32 num3)
        {
            if(num1 > num2 && num1 > num3)
            {
                return 1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }
        static void Main(string[] args)
        {
            Int16 n1 = 20, n2 = 10;
            Int32 r,t,y,a;
            r = suma(n1, n2);
            t = suma(73,13);
            y = suma(15,60);
            a = mayor(r, t, y);
            Console.WriteLine("La mayor suma es la numero " + a);
            Console.ReadKey();
        }
    }
}
