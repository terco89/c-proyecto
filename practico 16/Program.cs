using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Agenda agenda = new Agenda(20);
            string[] opciones = new string[]
            {
                "     Añadir un contacto                ",
                "     Eliminar un contacto              ",
                "     Buscar un telefono por nombre     ",
                "     Listar contactos                  ",
                "     Salir                             ",
            };
            Menu menu = new Menu(opciones);
            while (true) {
                Console.Clear();
                menu.pintar();
                bool bandera = false;
                while (true)
                {
                    if (bandera) break;
                    ConsoleKeyInfo opcion = Console.ReadKey(true);
                    if (opcion.Key == ConsoleKey.DownArrow) menu.bajar();
                    else if (opcion.Key == ConsoleKey.UpArrow) menu.subir();
                    else if (opcion.Key == ConsoleKey.Enter)
                    {
                        while (true)
                        {
                            if (bandera) break;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            if (menu.PosMenu == 0)
                            {
                                Console.WriteLine("Ingrese el nombre del nuevo contacto");
                                string nombre = Console.ReadLine();
                                Console.WriteLine("\nIngrese el telefono del nuevo contacto");
                                string telefono = Console.ReadLine();
                                if (telefono.Length == 10 && agenda.aniadirContacto(new Contacto(nombre, Int32.Parse(telefono)))) Console.WriteLine("\nSe agrego a " + nombre);
                                else Console.WriteLine("\nNo se pudo agregar el nuevo contacto (ya alcanzo su limite de contactos o el nombre/telefono ingresado esta repetido");
                            }
                            else if (menu.PosMenu == 1)
                            {
                                Console.WriteLine("Ingrese el nombre del contacto a eliminar");
                                if (agenda.eliminarContacto(Console.ReadLine())) Console.WriteLine("\r fue eliminado con exito");
                                else Console.WriteLine("\nNo se elimino a nadie, verifique que el nombre ingresado sea correcto");
                            }
                            else if (menu.PosMenu == 2)
                            {
                                Console.WriteLine("Ingrese el nombre del contacto para buscar su telefono");
                                int telefono = agenda.buscarContacto(Console.ReadLine());
                                if (telefono == 0) Console.WriteLine("\nNo se pudo encontrar el telefono, verifique que el nombre ingresado sea correcto");
                                else Console.WriteLine("\nTelefono: " + telefono);
                            }
                            else if (menu.PosMenu == 3) Console.WriteLine(agenda.listarContactos());
                            else if (menu.PosMenu == 4) Environment.Exit(1);
                            Console.Write("\n\nPresione enter para volver a usar la opción o escape para volver al menu");
                            while (true)
                            {
                                ConsoleKeyInfo op = Console.ReadKey(true);
                                if (op.Key == ConsoleKey.Enter) break;
                                if (op.Key == ConsoleKey.Escape)
                                {
                                    bandera = true;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
