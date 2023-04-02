using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ejer13
{
    class Persona
    {
        public string nombre;
        public Int32 dni;
        public Persona(string name, Int32 dni)
        {
            this.nombre = name;
            this.dni = dni;
        }
    }
    internal class Program
    {
        static Persona buscar(string dato,List<Persona> list)
        {
            foreach (Persona persona in list)
            {
                if(persona.nombre.ToUpper() == dato.ToUpper() || persona.dni.ToString() == dato)
                {
                    return persona;
                }
            }
            return null;
        }

        static string eliminar(string dato, List<Persona> list)
        {
            Persona persona = buscar(dato, list);
            if (persona != null) { 
                list.Remove(persona);
                return persona.nombre;
            }
            return null;
        }
        static void modificar(string name, Persona per, List<Persona> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                {
                    if (list[i].dni == per.dni)
                    {
                        list[i].nombre = name;
                    }
                }
            }
        }
        static void modificar(Int32 dni, Persona per, List<Persona> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                {
                    if (list[i].dni == per.dni)
                    {
                        list[i].dni = dni;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            bool api = false;
            List<Persona> list = new List<Persona>();
            
            list.Add(new Persona("Sergio", 47324123));
            list.Add(new Persona("Pablo", 45019282));
            list.Add(new Persona("Florencia", 50212412));
            ConsoleKeyInfo tecla;
            string[] menu = {
                "            Alta Usuario                    ",
                "            Modificacion Usuario            ",
                "            Baja Usuario                    ",
                "            Listar Usuarios                 ",
                "            Salir                           "
            };
            Console.CursorVisible = false;
            while (true)
            {
                if(api == true)
                {
                    break;
                }
                int posMenu = 0;
                Console.Clear();
                for (int i = 0; i < menu.Count(); i++)
                {
                    Console.SetCursorPosition(30, i + 10);
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
                    Console.Write(menu[i]);
                }

                while (true)
                {
                    tecla = Console.ReadKey(true);
                    if (tecla.Key == ConsoleKey.DownArrow)
                    {
                        if (posMenu < 4)
                        {
                            Console.SetCursorPosition(30, posMenu + 10);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(menu[posMenu]);
                            posMenu++;
                            Console.SetCursorPosition(30, posMenu + 10);
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(menu[posMenu]);
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(30, posMenu + 10);
                            Console.Write(menu[posMenu]);
                            posMenu = 0;
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(30, posMenu + 10);
                            Console.Write(menu[posMenu]);
                        }
                    }
                    if (tecla.Key == ConsoleKey.UpArrow)
                    {
                        if (posMenu > 0)
                        {
                            Console.SetCursorPosition(30, posMenu + 10);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(menu[posMenu]);
                            posMenu--;
                            Console.SetCursorPosition(30, posMenu + 10);
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(menu[posMenu]);
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(30, posMenu + 10);
                            Console.Write(menu[posMenu]);
                            posMenu = 4;
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(30, posMenu + 10);
                            Console.Write(menu[posMenu]);
                        }
                    }
                    if (tecla.Key == ConsoleKey.Enter)
                    {
                        if (posMenu == 0)
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("Ingrese el nombre del nuevo usuario: ");
                            string nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese el DNI del nuevo usuario: ");
                            Int32 dni = Convert.ToInt32(Console.ReadLine());
                            list.Add(new Persona(nombre, dni));
                            Console.WriteLine("Carga exitosa");
                            Console.WriteLine("Presione cualquier letra para volver al menu...");
                            Console.ReadKey();
                            break;
                        }
                        else if (posMenu == 1)
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("Ingrese el nombre o dni del usuario a modificar: ");
                            string dato = Console.ReadLine();
                            Persona per = buscar(dato, list);
                            if(per == null)
                            {
                                Console.WriteLine("No existe el usuario solicitado");
                                Console.WriteLine("Presione cualquier letra para volver al menu...");
                                Console.ReadKey();
                                break;
                            }
                            string puente = per.nombre;
                            Console.WriteLine("Se encontro a "+puente+" de DNI "+per.dni.ToString());
                            bool pro = false, p1 = false, p2 = false;
                            while (true)
                            {
                                if (pro == false && p1 == false)
                                {
                                    Console.WriteLine("Desea modificar el nombre Y/N ?");
                                    p1 = true;
                                }
                                else if(pro == true && p2 == false)
                                {
                                    Console.WriteLine("Desea modificar el DNI Y/N ?");
                                    p2 = true;
                                }
                                ConsoleKeyInfo op = Console.ReadKey();
                                if (op.Key == ConsoleKey.Y && pro == false)
                                {
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Ingrese el nuevo nombre del usuario: ");
                                    string nombre = Console.ReadLine();
                                    modificar(nombre, per, list);
                                    Console.WriteLine(puente + " ahora se llama " + nombre);
                                    pro = true;
                                }
                                else if(op.Key == ConsoleKey.N && pro == false){
                                    Console.WriteLine(" ");
                                    pro = true;
                                }
                                else if (op.Key == ConsoleKey.Y && pro == true)
                                {
                                    Console.WriteLine("Ingrese el nuevo dni del usuario: ");
                                    Int32 dni = Convert.ToInt32(Console.ReadLine());
                                    modificar(dni, per, list);
                                    Console.WriteLine(puente + " ahora tiene de dni " + dni);
                                    Console.WriteLine("Presione cualquier letra para volver al menu...");
                                    Console.ReadKey();
                                    break;
                                }
                                else if(op.Key == ConsoleKey.N && pro == true)
                                {
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Presione cualquier letra para volver al menu...");
                                    Console.ReadKey();
                                    break;
                                }
                            }
                            break;
                        } else if(posMenu == 2)
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("Ingrese el nombre o dni del usuario a eliminar: ");
                            string dato = Console.ReadLine();
                            string nombre = eliminar(dato,list);
                            if (nombre == null)
                            {
                                Console.Write("No existe el usuario solicitado");
                                Console.WriteLine("Presione cualquier letra para volver al menu...");
                                Console.ReadKey();
                                break;
                            }
                            Console.WriteLine(nombre+" ha sido eliminado");
                            Console.WriteLine("Presione cualquier letra para volver al menu...");
                            Console.ReadKey();
                            break;
                        } else if (posMenu == 3)
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("Listado de todos los usuarios");
                            Console.WriteLine("Nombre                    DNI");
                            for (int i = 0; i < list.Count; i++) {
                                string n = list[i].nombre;
                                int calc = 26 - n.Length;
                                for (int j = 0; j < calc; j++) {
                                    n += " ";
                                }
                                Console.WriteLine(n + list[i].dni);
                            }
                            Console.WriteLine(" ");
                            Console.WriteLine("Presione cualquier letra para volver al menu...");
                            Console.ReadKey();
                            break;
                        } else if (posMenu == 4)
                        {
                            api = true;
                            break;
                        }
                    }
                }
            }
        }
    }
}
