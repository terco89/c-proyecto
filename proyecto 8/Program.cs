using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_8
{
    /*8) Queremos representar con programación orientada a objetos, un aula con estudiantes y un profesor.
Tanto de los estudiantes como de los profesores necesitamos saber su nombre, edad y sexo. De los estudiantes, queremos saber también su calificación actual (entre 0 y 10) y del profesor que materia da.
Las materias disponibles son matemáticas, filosofía y física.
Los estudiantes tendrán un 50% para no ir a clase, por lo que sí hacen faltazo no van a clase pero aunque no vayan quedará registrado en el aula (como que cada uno tiene su sitio).
El profesor tiene un 20% de no encontrarse disponible (reuniones, baja, etc.)
Las dos operaciones anteriores deben llamarse igual en Estudiante y Profesor (polimorfismo).
El aula debe tener un identificador numérico, el número máximo de estudiantes y para que está destinada (matemáticas, filosofía o física). Piensa que más atributos necesita.
Un aula para que se pueda dar clase necesita que el profesor esté disponible, que el profesor de la materia correspondiente esté en el aula correspondiente (un profesor de filosofía no puede dar en un aula de matemáticas) y que haya más del 50% de alumnos.
El objetivo es crear un aula de alumnos y un profesor y determinar si puede darse clase, teniendo en cuenta las condiciones antes dichas.
Si se puede dar clase mostrar cuántos alumnos y alumnas (por separado) están aprobados de momento (imaginad que les están entregando las notas).
NOTA: Los datos pueden ser aleatorios (nombres, edad, calificaciones, etc.) siempre y cuando tengan sentido (edad no puede ser 80 en un estudiante o calificación ser 12).
*/
    
    internal class Program
    {
        private static Random rd = new Random();
        static void Main(string[] args)
        {
            string[] fNombres = new string[] { "María", "Carmen", "Ana María", "Josefa", "Isabel", "María Pilar", "María Dolores", "Laura", "María Teresa", "Ana", "Cristina", "Marta", "María Angeles", "Francisca", "Lucia", "María Isabel", "María Jose", "Antonia", "Dolores", "Sara", "Paula", "Elena", "María Luisa", "Raquel", "Rosa María", "Pilar", "Concepcion", "Manuela", "María Jesús", "Mercedes", "Julia", "Beatriz", "Nuria", "Silvia", "Rosario", "Juana", "Alba", "Irene", "Teresa", "Encarnación", "Patricia", "Montserrat", "Andrea", "Rocío", "Mónica", "Rosa", "Alicia", "María Mar", "Sonia", "Sandra", "Ángela", "Marina", "Susana", "Natalia", "Yolanda", "Margarita", "María Josefa", "Claudia", "Eva", "María Rosario", "Inmaculada", "Sofía", "María Mercedes", "Carla", "Ana Isabel", "Esther", "Noelia", "Verónica", "Angeles", "Nerea", "Carolina", "María Victoria", "Eva María", "Inés", "Miriam", "María Rosa", "Daniela", "Lorena", "Ana Belén", "María Elena", "María Concepcion", "Victoria", "Amparo", "María Antonia", "Catalina", "Martina", "Lidia", "Alejandra", "Celia", "María Nieves", "Consuelo", "Olga", "Ainhoa", "Fátima", "Gloria", "Emilia", "María Soledad", "Clara", "María Cristina", "Luisa", "Aurora", "Esperanza", "Virginia", "Anna", "Vanesa", "Milagros", "Adriana", "Josefina", "María Luz", "Lourdes", "Blanca", "Purificación", "María Belén", "Isabel María", "Begoña", "Estefanía", "María Begoña", "Elisa", "Gema", "María Asunción", "Valeria", "Laia", "Emma", "Magdalena", "María Lourdes", "Belén", "María Paz", "Araceli", "María Esther", "Tamara", "Matilde", "Asunción", "Remedios", "Vicenta", "Elvira", "Noa", "Rebeca", "Soledad", "Paloma", "Gemma", "Trinidad", "Mireia", "Vanessa", "Almudena", "Ariadna" };
            string[] mNombres = new string[] { "Antonio", "Manuel", "José", "Francisco", "David", "Juan", "José Antonio", "Javier", "Daniel", "José Luis", "Francisco Javier", "Carlos", "Jesús", "Alejandro", "Miguel", "José Manuel", "Rafael", "Miguel Ángel", "Pedro", "Pablo", "Ángel", "Sérgio", "José Maria", "Fernando", "Jorge", "Luís", "Alberto", "Juan Carlos", "Álvaro", "Adrián", "Juan José", "Diego", "Raúl", "Iván", "Juan Antonio", "Rubén", "Enrique", "Oscar", "Ramón", "Vicente", "Andrés", "Juan Manuel", "Joaquín", "Santiago", "Víctor", "Eduardo", "Mario", "Roberto", "Jaime", "Francisco José", "Marcos", "Ignacio", "Alfonso", "Jordi", "Hugo", "Ricardo", "Salvador", "Guillermo", "Emilio", "Gabriel", "Marc", "Gonzalo", "Julio", "Julian", "Mohamed", "Jose Miguel", "Tomas", "Martin", "Agustin", "Jose Ramon", "Nicolás", "Ismael", "Joan", "Félix", "Samuel", "Cristian", "Aitor", "Lucas", "Héctor", "Juan Francisco", "Iker", "Josep", "José Carlos", "Alex" };
            string[] generos = new string[] {"Masculino","Femenino"};
            string[] materias = new string[]{"física","matemáticas","filosofía"};
            Profesor profesor = new Profesor("ElGabo",80,"masculino","Física");
            int maxEstudiantes = rd.Next(20,30);
            List<Estudiante> estudiantes = new List<Estudiante>();
            string materia = materias[rd.Next(0,materias.Count())];

            for(int i = 0; i < maxEstudiantes; i++)
            {
                string genero = generos[rd.Next(0,generos.Count())];
                Calificacion calificacion = new Calificacion(materia,rd.Next(1,10));
                string nombre;
                if (genero == "Femenino")
                    nombre = fNombres[rd.Next(0,fNombres.Count())];
                else
                    nombre = mNombres[rd.Next(0,mNombres.Count())];
                estudiantes.Add(new Estudiante(nombre,rd.Next(12,18),genero,calificacion));
            }
            Aula aula = new Aula(1,20,materia,profesor,estudiantes);
            while (true)
            {
                Console.Clear();
                bool profesorPresente = aula.Profesor.seEncuentra();
                int alumnosPresentes = aula.tomarAsistencia();
                if (alumnosPresentes > aula.MaxEstudiantes / 2 && profesorPresente)
                {
                    Console.WriteLine("Bienvenido, hay {0} alumnos presentes (mas del 50%) y el profesor esta presente, se puede iniciar la clase", alumnosPresentes);
                    break;
                }
                else if(alumnosPresentes > aula.MaxEstudiantes / 2)
                    Console.WriteLine("Bienvenido, hay {0} alumnos presentes (mas del 50%), pero el profesor no esta, y no se puede iniciar la clase",alumnosPresentes);
                else
                    Console.WriteLine("Bienvenido, hay {0} alumnos presentes (menos del 50%) y el profesor no esta, por lo tanto no se puede iniciar la clase", alumnosPresentes);
                Console.WriteLine("\n\nPresione cualquier letra para reiniciar el día...");
                Console.ReadKey();
            }
            Console.WriteLine("\nLa cantidad de chicos aprobados son {0} y las chicas aprobadas son {1}",aula.aprobadosChicos(),aula.aprobadosChicas());
            Console.WriteLine("\n\nPresione cualquier letra para terminar el día...");
            Console.ReadKey();
        }
    }
}
