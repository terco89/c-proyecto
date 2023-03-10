using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej05
{
    internal class Program
    {
        static int[,] t = new int[,] { { 0, 0, 0, 0, 1, 1, 0, 0, 0, 0 }, { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, { 1, 1, 0, 1, 1, 1, 1, 0, 1, 1 }, { 1, 1, 0, 1, 1, 1, 1, 0, 1, 1 }, { 0, 0, 0, 1, 0, 0, 1, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0, 1, 0, 0, 0 }, { 0, 0, 1, 1, 0, 0, 1, 1, 0, 0 } };
        static Random r = new Random();
        static void pintar(int x,int y)
        {
            for (int i = 0; i < 7; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    if(t[i,j] == 1)
                    {
                        int z = x - (5 - j);
                        int c = y - (4 - i);
                        Console.SetCursorPosition(z , c);
                        Console.Write("█");
                    }
                }
            }
        }

        static void borrar(int x, int y)
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (t[i, j] == 1)
                    {
                        int z = x - (5 - j);
                        int c = y - (4 - i);
                        Console.SetCursorPosition(z, c);
                        Console.Write(" ");
                    }
                }
            }
        }
        static int[] colision(int x, int y, int x1, int y2)
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    int z = x - (5 - j);
                    int c = y - (4 - i);
                    if (z == x1 && c == y2)
                    {
                        Console.SetCursorPosition(x1, y2);
                        Console.Write(" ");
                        int s = r.Next(0, 60);
                        int d = r.Next(0, 120);
                        Console.SetCursorPosition(s, d);
                        int[] a = { s, d };
                        return a;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo tecla;
            int row = 10, col = 10, rowi = 20, coli = 20;

            Console.SetCursorPosition(col, row);
            pintar(col,row);

            Console.SetCursorPosition(coli,rowi);
            Console.Write("█");
            Console.CursorVisible = false;
            while (true)
            {
                tecla = Console.ReadKey();
                if (tecla.Key == ConsoleKey.UpArrow)
                {
                    if ((row-4) > 0) {
                        borrar(col, row);
                        row--;
                        Console.SetCursorPosition(col, row);
                        pintar(col, row);
                    }
                }
                if (tecla.Key == ConsoleKey.DownArrow)
                {
                    borrar(col, row);
                    row++;
                    Console.SetCursorPosition(col, row);
                    pintar(col, row);
                }
                if (tecla.Key == ConsoleKey.LeftArrow)
                {
                    if ((col-5) > 0) {
                        borrar(col, row);
                        col--;
                        Console.SetCursorPosition(col, row);
                        pintar(col, row);
                    }
                }
                if (tecla.Key == ConsoleKey.RightArrow)
                {
                    if ((col+5)< 120) {
                        borrar(col, row);
                        col++;
                        Console.SetCursorPosition(col, row);
                        pintar(col, row);
                    }
                }
                if (tecla.Key == ConsoleKey.Escape)
                    break;
            }
            Console.CursorVisible = true;


        }
    }
}
