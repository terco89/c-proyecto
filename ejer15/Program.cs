using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer15
{
    class Persona
    {
        string nombre;
        string apellido;
        int edad;
        public string email;

        public string NombreCompleto
        {
            get
            {
                return nombre + ' ' + apellido;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
        }


        public Persona(string nombre, string apellido, int edad, string email)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.email = email;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();


            personas.Add(new Persona("Juan", "Pérez", 25, "juanperez@gmail.com"));
            personas.Add(new Persona("María", "García", 30, "mariagarcia@gmail.com"));
            personas.Add(new Persona("Pedro", "López", 20, "pedrolopez@gmail.com"));

            // Eliminar una persona de la lista
            //personas.Remove(personas.Find(p => p.Nombre == "María" && p.Apellido == "García"));

            // Buscar una persona en la lista
            /*Persona personaEncontrada = personas.Find(p => p.email == "juanperez@gmail.com");
            if (personaEncontrada != null)
            {
                Console.WriteLine("La persona encontrada es: " + personaEncontrada.NombreCompleto);
            }
            else
            {
                Console.WriteLine("La persona no se encontró en la lista");
            }*/
            foreach(Persona p in personas) {
                Console.WriteLine(p.Apellido);
            }
            Console.WriteLine(" ");
            personas.Sort(delegate (Persona x, Persona y)
            {
                return x.Apellido.CompareTo(y.Apellido); 
            });
            foreach (Persona p in personas)
            {
                Console.WriteLine(p.Apellido);
            }
            Console.ReadKey();

            foreach (Persona persona in personas)
            {
                Console.WriteLine(persona.Nombre);
            }
            Console.ReadKey();
        }
    }

}
