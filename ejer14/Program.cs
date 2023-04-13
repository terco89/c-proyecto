using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ejer14
{
    class Persona
    {
        public string nombre, apellido;
        public Int32 dni;
        public Persona(string name, string apellido, Int32 dni)
        {
            this.nombre = name;
            this.dni = dni;
            this.apellido = apellido;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo tecla;
            bool api = false;

            List<Persona> lista = new List<Persona>();
            lista.Add(new Persona("Sergio","Gonzalez", 47324123));
            lista.Add(new Persona("Pablo","Martinez",45019282));
            lista.Add(new Persona("Florencia","Baez",50212412));
            Console.CursorVisible = false;
            while (true)
            {
                if (api == true)
                {
                    break;
                }
                int posMenu = 0;
                bool ap = false;
                Console.Clear();
                for (int i = 0; i < lista.Count(); i++)
                {
                    Console.SetCursorPosition(5, i+10);
                    if (i == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Write(lista[i].nombre);
                }

                while (true)
                {
                    tecla = Console.ReadKey(true);
                    if(ap == true)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(10 + lista[posMenu].nombre.Length, 10 + posMenu);
                        Console.Write("                   ");
                        Console.SetCursorPosition(10 + lista[posMenu].nombre.Length, 10 + posMenu + 1);
                        Console.Write("                     ");
                        Console.SetCursorPosition(10 + lista[posMenu].nombre.Length, 10 + posMenu + 2);
                        Console.Write("                 ");
                        api = false;
                    }
                    if (tecla.Key == ConsoleKey.DownArrow)
                    {
                        if (posMenu < lista.Count - 1)
                        {
                            Console.SetCursorPosition(5, posMenu + 10);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(lista[posMenu].nombre);
                            posMenu++;
                            Console.SetCursorPosition(5, posMenu + 10);
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(lista[posMenu].nombre);
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(5, posMenu + 10);
                            Console.Write(lista[posMenu].nombre);
                            posMenu = 0;
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(5, posMenu + 10);
                            Console.Write(lista[posMenu].nombre);
                        }
                    }
                    if (tecla.Key == ConsoleKey.UpArrow)
                    {
                        if (posMenu > 0)
                        {
                            Console.SetCursorPosition(5, posMenu + 10);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(lista[posMenu].nombre);
                            posMenu--;
                            Console.SetCursorPosition(5, posMenu + 10);
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(lista[posMenu].nombre);
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(5, posMenu + 10);
                            Console.Write(lista[posMenu].nombre);
                            posMenu = lista.Count - 1;
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(5, posMenu + 10);
                            Console.Write(lista[posMenu].nombre);
                        }
                    }
                    if (tecla.Key == ConsoleKey.Enter)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(10 + lista[posMenu].nombre.Length, 10 + posMenu);
                        Console.Write(lista[posMenu].nombre);
                        Console.SetCursorPosition(10 + lista[posMenu].nombre.Length, 10 + posMenu+1);
                        Console.Write(lista[posMenu].apellido);
                        Console.SetCursorPosition(10 + lista[posMenu].nombre.Length, 10 + posMenu+2);
                        Console.Write(lista[posMenu].dni);
                        ap = true;
                    }
                    if(tecla.Key == ConsoleKey.Delete)
                    {
                        lista.RemoveAt(posMenu);
                        break;
                    }
                }
            }
        }
    }
}
