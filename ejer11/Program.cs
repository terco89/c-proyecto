using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ejer11
{
    class Persona
    {
        public string name;
        public string dni;

        public Persona()
        {
        }

        public Persona(string name, string dni)
        {
            this.name = name;
            this.dni = dni;
        }
        public string mostrarTodo()
        {
            return name + ", " + dni;
        }
    }

    internal class Program
    {

        static bool buscar(List<Persona> list, string dni)
        {
            bool b = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].dni == dni)
                {
                    b = true;
                    break;
                }
            }
            if (b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static Persona bobjeto(List<Persona> list, string dni)
        { 
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].dni == dni)
                {
                    return list[i];
                }
            }
            return null;
        }
        static Persona eliminar(List<Persona> list, string dni)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].dni == dni)
                {
                    Persona persona = list[i];
                    list.RemoveAt(i);
                    return persona;
                }
            }
            return null;
        }
        static void Main(string[] args)
        {
            List<Persona> list = new List<Persona>();

            list.Add(new Persona("Sergio", "47324123"));
            list.Add(new Persona("Pablo", "45019282"));
            list.Add(new Persona("Florencia", "50212412"));

            while (true) {
                bool encontro = false;
                ConsoleKeyInfo opcion;

                Console.Clear();
                Console.WriteLine("1. Saber si una persona existe por DNI");
                Console.WriteLine("2. Buscar una persona por DNI");
                Console.WriteLine("3. Eliminar una persona por DNI");
                opcion = Console.ReadKey();

                if (opcion.Key == ConsoleKey.D1)
                {
                    string dni;
                    Console.Clear();
                    Console.Write("Ingrese el DNI: ");
                    dni = Console.ReadLine();
                    if (buscar(list, dni))
                    {
                        Console.WriteLine("Se encontro");
                    }
                    else
                    {
                        Console.WriteLine("No existe");
                    }


                } else if (opcion.Key == ConsoleKey.D2)
                {
                    string dni;
                    Console.Clear();
                    Console.Write("Ingrese el DNI: ");
                    dni = Console.ReadLine();
                    Persona persona = bobjeto(list, dni);
                    if (persona != null)
                    {
                        Console.WriteLine("La persona con ese dni es " + persona.name);
                    }
                    else
                    {
                        Console.WriteLine("No existe");
                    }
                } else if (opcion.Key == ConsoleKey.D3)
                {
                    string dni;
                    Console.Clear();
                    Console.Write("Ingrese el DNI: ");
                    dni = Console.ReadLine();
                    Persona n = eliminar(list, dni);
                    if (n != null)
                    {
                        Console.WriteLine("Fue eliminada/o " + n.name);
                    }
                    else
                    {
                        Console.WriteLine("No se elimino a nadie, compruebe que el dni ingresado sea correcto");
                    }
                    
                }
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
