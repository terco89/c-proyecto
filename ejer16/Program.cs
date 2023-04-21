using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer16
{
    /*Ejercicio 1En argentina tenemos personas que nacen cada 30 segundos y personas que fallecen cada 60 segundos. 
1. Crear personas con nombres y apellidos random;
2. Mostrar la lista de personas cada 10 segundos para que se pueda refrescar la informacion que tenemos
3. Informar siempre cuantas personas tiene Argentina.

Ejercicio 2

Mismo caso anterior pero ahora tenemos 3 paises, Argentina, Paraguay y Brasil. 
Sumado a esto tenemos que tenemos cada pais van a nacer personas pero el tiempo para cada pais va a ser random
1. Mostrar la informacion anterior pero ordenada por apellido y dividida por pais
2. Informar cuantas personas hay en cada pais
*/
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
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();
            List<string> nombres = new List<string> { "Antonio", "Manuel", "José", "Francisco", "David", "Juan", "José Antonio", "Javier", "Daniel", "José Luis", "Francisco Javier", "Carlos", "Jesús", "Alejandro", "Miguel", "José Manuel", "Rafael", "Miguel Ángel", "Pedro", "Pablo", "Ángel", "Sérgio", "José Maria", "Fernando", "Jorge", "Luís", "Alberto", "Juan Carlos", "Álvaro", "Adrián", "Juan José", "Diego", "Raúl", "Iván", "Juan Antonio", "Rubén", "Enrique", "Oscar", "Ramón", "Vicente", "Andrés", "Juan Manuel", "Joaquín", "Santiago", "Víctor", "Eduardo", "Mario", "Roberto", "Jaime", "Francisco José", "Marcos", "Ignacio", "Alfonso", "Jordi", "Hugo", "Ricardo", "Salvador", "Guillermo", "Emilio", "Gabriel", "Marc", "Gonzalo", "Julio", "Julian", "Mohamed", "Jose Miguel", "Tomas", "Martin", "Agustin", "Jose Ramon", "Nicolás", "Ismael", "Joan", "Félix", "Samuel", "Cristian", "Aitor", "Lucas", "Héctor", "Juan Francisco", "Iker", "Josep", "José Carlos", "Alex", "Mariano", "Domingo", "Sebastián", "Alfredo", "Cesar", "José Ángel", "Felipe", "José Ignacio", "Víctor Manuel", "Rodrigo", "Luis Miguel", "Mateo", "José Francisco", "Juan Luis", "Xavier", "Albert", "Gregorio", "Pau", "Lorenzo", "Antonio José", "Esteban", "Borja", "Cristóbal", "Aarón", "Arturo", "Eric", "José Javier", "Izan", "Eugénio", "Isaac", "Juan Miguel", "António Jesus", "Mohammed", "Joel", "Jesus Maria", "Francisco Manuel", "Asier", "Jaume", "German", "Abel", "Jonathan", "Darío", "Pedro José", "Valentin", "José Vicente", "Unai", "Mikel", "Bruno", "Moises", "Sergi", "Ahmed", "Christian", "Juan Ramón", "Marco", "Adolfo", "Juan Pedro", "Íñigo", "Manuel Jesus", "Gerard", "Jon", "Pol", "Omar", "Ernesto", "Isidro", "Arnau", "Miquel", "Benito", "Israel", "Oriol", "Leo", "António Manuel", "Bernardo", "Gerardo", "Eloy", "Jónatan", "Carmelo", "Federico", "Adam", "Francesc", "Pascual", "José Alberto", "Jesus Manuel", "Luís Alberto", "Juan Jesus", "Adria", "Roger", "Alonso", "Josep Maria", "Bartolomé", "Iñaki", "Kevin", "Elías", "Oliver", "Benjamín", "Saúl", "Carles", "Matías", "Marcelino", "Pere", "Juan Pablo", "Fermín", "Martí", "Pedro Antonio", "Lluís", "Guillem", "Antoni", "Ander", "Marco Antonio", "Youssef", "José Enrique", "Erik", "Alexander", "Carlos Alberto", "Ángel Luis", "Aurelio", "Juan Ignacio", "Abraham", "Francisco Jesús", "Xabier", "Said", "Aleix", "Gorka", "Jerónimo", "Julen", "Jacinto", "Román", "Ferrán", "Eusebio", "Gustavo", "José Juan", "Luis Fernando", "Manuel Ángel", "Victoriano", "Damián", "Luis Manuel", "Leonardo", "Carlos Javier", "Yeray", "Rachid", "Isidoro", "Enric", "Pedro Luis", "Enzo", "Jan", "Juan Bautista", "Armando", "José David", "Blas", "Teodoro" };
            List<string> apellidos = new List<string> { "García", "Rodríguez", "González", "Fernández", "López", "Martínez", "Sánchez", "Pérez", "Gómez", "Martin", "Jiménez", "Ruiz", "Hernández", "Díaz", "Moreno", "Muñoz", "Álvarez", "Romero", "Alonso", "Gutiérrez", "Navarro", "Torres", "Domínguez", "Vázquez", "Ramos", "Gil", "Ramírez", "Serrano", "Blanco", "Molina", "Morales", "Suarez", "Ortega", "Delgado", "Castro", "Ortiz", "Marín", "Rubio", "Sanz", "Núñez", "Medina", "Iglesias", "Cortes", "Castillo", "Garrido", "Santos", "Lozano", "Guerrero", "Cano", "Prieto", "Méndez", "Cruz", "Flores", "Herrera", "Gallego", "Márquez", "León", "Peña", "Calvo", "Cabrera", "Vidal", "Campos", "Vega", "Fuentes", "Carrasco", "Reyes", "Diez", "Caballero", "Nieto", "Aguilar", "Santana", "Pascual", "Herrero", "Montero", "Hidalgo", "Giménez", "Lorenzo", "Ibáñez", "Vargas", "Santiago", "Duran", "Ferrer", "Benítez", "Mora", "Arias", "Vicente", "Carmona", "Crespo", "Román", "Soto", "Pastor", "Velasco", "Sáez", "Rojas", "Moya", "Parra", "Soler", "Bravo", "Gallardo", "Esteban", "Pardo", "Rivera", "Franco", "Merino", "Rivas", "Lara", "Silva", "Espinosa", "Izquierdo", "Camacho", "Vera", "Arroyo", "Casado", "Ríos", "Redondo", "Mendoza", "Luque", "Galán", "Rey", "Sierra", "Montes", "Otero", "Segura", "Carrillo", "Marcos", "Soriano", "Bernal", "Martí", "Heredia", "Robles", "Valero", "Vila", "Palacios", "Macías", "Expósito", "Contreras", "Guerra", "Varela", "Benito", "Roldan", "Pereira", "Mateo", "Bueno", "Andrés", "Miranda", "Villar", "Guillen", "Aguilera", "Mateos", "Escudero", "Casas", "Rivero", "Padilla", "Aparicio", "Calderón", "Acosta", "Estévez", "Beltrán", "Salazar", "Gálvez", "Menéndez", "Salas", "Rico", "Guzmán", "Jurado", "Conde", "Bermúdez", "Gracia", "Quintana", "Abad", "Aranda", "Plaza", "Blázquez", "Santamaría", "Ávila", "Roca", "Manzano", "Trujillo", "Costa", "Hurtado", "Villanueva", "Pacheco", "Miguel", "Serra", "Rueda", "Cuesta", "Escobar", "Tomas", "Mesa", "de la Fuente", "Simón", "Del Rio", "Luna", "Lázaro", "Pons", "Alarcón", "Sancho", "Millán", "Zamora", "Castaño", "Maldonado", "Chen", "Blasco", "Paredes", "Salvador", "Bermejo", "Bautista"};

            Random rd = new Random();
            Console.CursorVisible = false;

            personas.Add(new Persona("Juan", "Pérez"));
            personas.Add(new Persona("María", "Gonzalez"));
            personas.Add(new Persona("Paulo", "Martinez"));
            personas.Add(new Persona("Julio", "Varela"));
            personas.Add(new Persona("Gabriel", "Messi"));
            personas.Add(new Persona("Nahuel", "Gaspar"));
            personas.Add(new Persona("Lautaro", "Polo"));
            personas.Add(new Persona("Julian", "Pardo"));
            personas.Add(new Persona("Leonel", "Barco"));

            DateTime hora = DateTime.Now, hora1 = DateTime.Now, hora2 = DateTime.Now;
            DateTime horaActual = DateTime.Now, horaActual1 = DateTime.Now, horaActual2 = DateTime.Now;
            TimeSpan tiempoTrasncurrido, tiempoTrasncurrido1, tiempoTrasncurrido2;

            foreach (Persona persona in personas)
            {
                Console.WriteLine(persona.NombreCompleto);
            }
            Console.SetCursorPosition(56,5);
            Console.Write("Cantidad de personas: {0}",personas.Count);

            while (true)
            {
                horaActual = DateTime.Now;
                tiempoTrasncurrido = horaActual - hora;
                horaActual1 = DateTime.Now;
                tiempoTrasncurrido1 = horaActual1 - hora1;
                horaActual2 = DateTime.Now;
                tiempoTrasncurrido2 = horaActual2 - hora2;
                if (tiempoTrasncurrido1.Seconds == 60)
                {
                    hora1 = DateTime.Now;
                    int r = rd.Next(0,personas.Count-1);
                    personas.RemoveAt(r);
                }
                if (tiempoTrasncurrido2.Seconds == 30)
                {
                    hora2 = DateTime.Now;
                    int r1 = rd.Next(0,nombres.Count-1);
                    int r2 = rd.Next(0,apellidos.Count - 1);
                    personas.Add(new Persona(nombres[r1], apellidos[r2]));
                }
                if (tiempoTrasncurrido.Seconds == 10)
                {
                    hora = DateTime.Now;
                    Console.Clear();
                    foreach (Persona persona in personas)
                    {
                        Console.WriteLine(persona.NombreCompleto);
                    }
                }
                Console.SetCursorPosition(56,5);
                Console.Write("Cantidad de personas: {0}", personas.Count);
            }
        }
    }
}
