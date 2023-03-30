using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer12
{
    internal class Program
    {

        static void insertara(List<int> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i] == 10)
                {
                    list.Insert(i, 0);
                    i++;
                }
            }
        }
        static void insertard(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == 10)
                {
                    list.Insert(i+1, 0);
                    i++;
                }
            }
        }
        static void insertarm(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == 10)
                {
                    list.Insert(i+1, 0);
                    list.Insert(i, 0);
                    i++;
                }
            }
        }
        static void eliminar(List<int> list)
        {
            list.RemoveAt(list.Count - 1);
            list.RemoveAt(0);
        }
        static void eliminard(List<int> list)
        {
            list.RemoveAt(list.Count - 2);
            list.RemoveAt(1);
        }

        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for(int i  = 1; i <= 1000; i++)
            {
                list.Add(i);
            }
            while (true)
            {
                Console.Clear();
                for (int i = 0; i < list.Count; i++)
                {
                    Console.Write(list[i] + " ");
                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("1. Buscar los elementos que contengan el numero 10 e insertar antes el numero 0");
                Console.WriteLine("2. Buscar los elementos que contengan el numero 10 e insertar después el numero 0");
                Console.WriteLine("3. Buscar el elemento que contenga el numero 10 e insertar antes y después un 0");
                Console.WriteLine("4. Eliminar en primer y el ultimo elemento");
                Console.WriteLine("5. Eliminar en segundo y el ante ultimo elemento");
                ConsoleKeyInfo opcion = Console.ReadKey();

                if (opcion.Key == ConsoleKey.D1)
                {
                    insertara(list);
                }
                else if (opcion.Key == ConsoleKey.D2)
                {
                    insertard(list);
                }
                else if (opcion.Key == ConsoleKey.D3)
                {
                    insertarm(list);
                }
                else if (opcion.Key == ConsoleKey.D4)
                {
                    eliminar(list);
                }
                else if (opcion.Key == ConsoleKey.D5)
                {
                    eliminard(list);
                }
            }
        }
    }
}
