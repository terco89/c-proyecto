using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer17
{
    /*Ejercicio 1En argentina tenemos personas que nacen cada 30 segundos y personas que fallecen cada 60 segundos. 
1. Crear personas con nombres y apellidos random;
2. Mostrar la lista de personas cada 10 segundos para que se pueda refrescar la informacion que tenemos
3. Informar siempre cuantas personas tiene Argentina.

Ejercicio 3

Mismo ejercicio pero cada 2 minutos uno de los paises reinician su poblacion a 0 personas

Todos los ejercicios van a correr sin intervencion del usuario por lo cual la informacion se tiene que actualizar sola
    
 PD: Es un archivo por ejercicio*/


    class Pais
    {
        string nombre;
        public List<Persona> personas;

        public Pais(string nombre, List<Persona> personas)
        {
            this.nombre = nombre;
            this.personas = personas;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }
    }



    class Persona
    {
        string nombre;
        string apellido;

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


        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
    }
    internal class Program
    {
        static string bpais(int p)
        {
            return "a";
        }

        static void addper(List<Pais> lista,List<string> nombres, List<string> apellidos, int opcion)
        {
            Random rd = new Random();
            int r1 = rd.Next(0, nombres.Count - 1);
            int r2 = rd.Next(0, apellidos.Count - 1);
            lista[opcion].personas.Add(new Persona(nombres[r1], apellidos[r2]));
        }
        static void delper(List<Pais> lista, int opcion)
        {
            int rd = new Random().Next(0, lista[opcion].personas.Count - 1);
            lista[opcion].personas.RemoveAt(rd);
        }
        static void Main(string[] args)
        {
            List<string> nombres = new List<string> { "Antonio", "Manuel", "José", "Francisco", "David", "Juan", "José Antonio", "Javier", "Daniel", "José Luis", "Francisco Javier", "Carlos", "Jesús", "Alejandro", "Miguel", "José Manuel", "Rafael", "Miguel Ángel", "Pedro", "Pablo", "Ángel", "Sérgio", "José Maria", "Fernando", "Jorge", "Luís", "Alberto", "Juan Carlos", "Álvaro", "Adrián", "Juan José", "Diego", "Raúl", "Iván", "Juan Antonio", "Rubén", "Enrique", "Oscar", "Ramón", "Vicente", "Andrés", "Juan Manuel", "Joaquín", "Santiago", "Víctor", "Eduardo", "Mario", "Roberto", "Jaime", "Francisco José", "Marcos", "Ignacio", "Alfonso", "Jordi", "Hugo", "Ricardo", "Salvador", "Guillermo", "Emilio", "Gabriel", "Marc", "Gonzalo", "Julio", "Julian", "Mohamed", "Jose Miguel", "Tomas", "Martin", "Agustin", "Jose Ramon", "Nicolás", "Ismael", "Joan", "Félix", "Samuel", "Cristian", "Aitor", "Lucas", "Héctor", "Juan Francisco", "Iker", "Josep", "José Carlos", "Alex", "Mariano", "Domingo", "Sebastián", "Alfredo", "Cesar", "José Ángel", "Felipe", "José Ignacio", "Víctor Manuel", "Rodrigo", "Luis Miguel", "Mateo", "José Francisco", "Juan Luis", "Xavier", "Albert", "Gregorio", "Pau", "Lorenzo", "Antonio José", "Esteban", "Borja", "Cristóbal", "Aarón", "Arturo", "Eric", "José Javier", "Izan", "Eugénio", "Isaac", "Juan Miguel", "António Jesus", "Mohammed", "Joel", "Jesus Maria", "Francisco Manuel", "Asier", "Jaume", "German", "Abel", "Jonathan", "Darío", "Pedro José", "Valentin", "José Vicente", "Unai", "Mikel", "Bruno", "Moises", "Sergi", "Ahmed", "Christian", "Juan Ramón", "Marco", "Adolfo", "Juan Pedro", "Íñigo", "Manuel Jesus", "Gerard", "Jon", "Pol", "Omar", "Ernesto", "Isidro", "Arnau", "Miquel", "Benito", "Israel", "Oriol", "Leo", "António Manuel", "Bernardo", "Gerardo", "Eloy", "Jónatan", "Carmelo", "Federico", "Adam", "Francesc", "Pascual", "José Alberto", "Jesus Manuel", "Luís Alberto", "Juan Jesus", "Adria", "Roger", "Alonso", "Josep Maria", "Bartolomé", "Iñaki", "Kevin", "Elías", "Oliver", "Benjamín", "Saúl", "Carles", "Matías", "Marcelino", "Pere", "Juan Pablo", "Fermín", "Martí", "Pedro Antonio", "Lluís", "Guillem", "Antoni", "Ander", "Marco Antonio", "Youssef", "José Enrique", "Erik", "Alexander", "Carlos Alberto", "Ángel Luis", "Aurelio", "Juan Ignacio", "Abraham", "Francisco Jesús", "Xabier", "Said", "Aleix", "Gorka", "Jerónimo", "Julen", "Jacinto", "Román", "Ferrán", "Eusebio", "Gustavo", "José Juan", "Luis Fernando", "Manuel Ángel", "Victoriano", "Damián", "Luis Manuel", "Leonardo", "Carlos Javier", "Yeray", "Rachid", "Isidoro", "Enric", "Pedro Luis", "Enzo", "Jan", "Juan Bautista", "Armando", "José David", "Blas", "Teodoro" };
            List<string> apellidos = new List<string> { "García", "Rodríguez", "González", "Fernández", "López", "Martínez", "Sánchez", "Pérez", "Gómez", "Martin", "Jiménez", "Ruiz", "Hernández", "Díaz", "Moreno", "Muñoz", "Álvarez", "Romero", "Alonso", "Gutiérrez", "Navarro", "Torres", "Domínguez", "Vázquez", "Ramos", "Gil", "Ramírez", "Serrano", "Blanco", "Molina", "Morales", "Suarez", "Ortega", "Delgado", "Castro", "Ortiz", "Marín", "Rubio", "Sanz", "Núñez", "Medina", "Iglesias", "Cortes", "Castillo", "Garrido", "Santos", "Lozano", "Guerrero", "Cano", "Prieto", "Méndez", "Cruz", "Flores", "Herrera", "Gallego", "Márquez", "León", "Peña", "Calvo", "Cabrera", "Vidal", "Campos", "Vega", "Fuentes", "Carrasco", "Reyes", "Diez", "Caballero", "Nieto", "Aguilar", "Santana", "Pascual", "Herrero", "Montero", "Hidalgo", "Giménez", "Lorenzo", "Ibáñez", "Vargas", "Santiago", "Duran", "Ferrer", "Benítez", "Mora", "Arias", "Vicente", "Carmona", "Crespo", "Román", "Soto", "Pastor", "Velasco", "Sáez", "Rojas", "Moya", "Parra", "Soler", "Bravo", "Gallardo", "Esteban", "Pardo", "Rivera", "Franco", "Merino", "Rivas", "Lara", "Silva", "Espinosa", "Izquierdo", "Camacho", "Vera", "Arroyo", "Casado", "Ríos", "Redondo", "Mendoza", "Luque", "Galán", "Rey", "Sierra", "Montes", "Otero", "Segura", "Carrillo", "Marcos", "Soriano", "Bernal", "Martí", "Heredia", "Robles", "Valero", "Vila", "Palacios", "Macías", "Expósito", "Contreras", "Guerra", "Varela", "Benito", "Roldan", "Pereira", "Mateo", "Bueno", "Andrés", "Miranda", "Villar", "Guillen", "Aguilera", "Mateos", "Escudero", "Casas", "Rivero", "Padilla", "Aparicio", "Calderón", "Acosta", "Estévez", "Beltrán", "Salazar", "Gálvez", "Menéndez", "Salas", "Rico", "Guzmán", "Jurado", "Conde", "Bermúdez", "Gracia", "Quintana", "Abad", "Aranda", "Plaza", "Blázquez", "Santamaría", "Ávila", "Roca", "Manzano", "Trujillo", "Costa", "Hurtado", "Villanueva", "Pacheco", "Miguel", "Serra", "Rueda", "Cuesta", "Escobar", "Tomas", "Mesa", "de la Fuente", "Simón", "Del Rio", "Luna", "Lázaro", "Pons", "Alarcón", "Sancho", "Millán", "Zamora", "Castaño", "Maldonado", "Chen", "Blasco", "Paredes", "Salvador", "Bermejo", "Bautista" };
            List<Pais> paises = new List<Pais> { new Pais("Argentina", new List<Persona>()), new Pais("Paraguay", new List<Persona>()), new Pais("Brasil", new List<Persona>()) };

            Console.CursorVisible = false;

            //personas.Add(new Persona("Juan", "Pérez"));
            Random rd = new Random();
            foreach (Pais p in paises)
            {
                for (int i = 0; i < 20; i++)
                {
                    Persona per = new Persona(nombres[rd.Next(0, nombres.Count - 1)], apellidos[rd.Next(0, apellidos.Count - 1)]);
                    p.personas.Add(per);
                }
            }

            DateTime hora = DateTime.Now;
            DateTime horaActual = DateTime.Now;
            TimeSpan tiempoTrasncurrido;
            List<int> tiempos = new List<int>() { rd.Next(4, 8) , rd.Next(4, 8) , rd.Next(4, 8) , rd.Next(8, 12) , rd.Next(8, 12) , rd.Next(8, 12) };
            List<bool> bn = new List<bool>() {false,false,false,false,false,false,false};

            foreach (Pais p in paises)
            {
                Console.WriteLine(p.Nombre + ":\n");
                foreach (Persona persona in p.personas)
                {
                    Console.WriteLine(persona.NombreCompleto);
                }

                Console.WriteLine("\nCantidad de personas: {0} \n\n", p.personas.Count);
            }


            while (true)
            {
                horaActual = DateTime.Now;
                tiempoTrasncurrido = horaActual - hora;
                for(int i = 0; i < 3; i++)
                {
                    if (tiempoTrasncurrido.Seconds % tiempos[i * 2] == 0 && tiempoTrasncurrido.Seconds != 0 && bn[i * 2] == false)
                    {
                        bn[i * 2] = true;
                        addper(paises, nombres, apellidos, i);
                        
                    }
                    else if(!(tiempoTrasncurrido.Seconds % tiempos[i * 2] == 0))
                    {
                        bn[i*2] = false;
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    if (tiempoTrasncurrido.Seconds % tiempos[i * 2 + 1] == 0 && tiempoTrasncurrido.Seconds != 0 && bn[i * 2 + 1] == false)
                    {
                            bn[i * 2 + 1] = true;
                            delper(paises,i);
                    }else if (!(tiempoTrasncurrido.Seconds % tiempos[i * 2 + 1] == 0))
                    {
                        bn[i * 2 + 1] = false;
                    }
                }
                if (tiempoTrasncurrido.Seconds % 5 == 0 && tiempoTrasncurrido.Seconds != 0 && bn[6] == false)
                {
                    bn[6] = true;
                    Console.Clear();
                    foreach (Pais p in paises)
                    {
                        Console.WriteLine(p.Nombre + ":\n");
                        foreach (Persona persona in p.personas)
                        {
                            Console.WriteLine(persona.NombreCompleto);
                        }

                        Console.WriteLine("\nCantidad de personas: {0} \n\n", p.personas.Count);
                    }
                }
                else if (!(tiempoTrasncurrido.Seconds % 5 == 0))
                {
                    bn[6] = false;
                }
            }

            Console.ReadKey();
        }
    }
}
