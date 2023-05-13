using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace practico_2
{
    /*2) Haz una clase llamada Persona que siga las siguientes condiciones:
Sus atributos son: nombre, edad, DNI, sexo (H hombre, M mujer), peso y altura. No queremos que se accedan directamente a ellos. Piensa que modificador de acceso es el más adecuado, también su tipo. Si quieres añadir algún atributo puedes hacerlo.
Por defecto, todos los atributos menos el DNI serán valores por defecto según su tipo (0 números, cadena vacía para String, etc.). Sexo sera hombre por defecto, usa una constante para ello.
Se implantaran varios constructores:
Un constructor por defecto.
Un constructor con el nombre, edad y sexo, el resto por defecto.
Un constructor con todos los atributos como parámetro.
Los métodos que se implementarán son:
calcularIMC(): calculará si la persona está en su peso ideal (peso en kg/(altura^2  en m)), si esta fórmula devuelve un valor menor que 20, la función devuelve un -1, si devuelve un número entre 20 y 25 (incluidos), significa que está por debajo de su peso ideal la función devuelve un 0  y si devuelve un valor mayor que 25 significa que tiene sobrepeso, la función devuelve un 1. Te recomiendo que uses constantes para devolver estos valores.
esMayorDeEdad(): indica si es mayor de edad, devuelve un booleano.
comprobarSexo(char sexo): comprueba que el sexo introducido es correcto. Si no es correcto, será H. No será visible al exterior.
generaDNI(): genera un número aleatorio de 8 cifras, genera a partir de este su número su letra correspondiente. Este método será invocado cuando se construya el objeto. Puedes dividir el método para que te sea más fácil. No será visible al exterior.
Métodos set de cada parámetro, excepto de DNI.
Ahora, crea una clase ejecutable que haga lo siguiente:
Pide por teclado el nombre, la edad, sexo, peso y altura.
Crea 3 objetos de la clase anterior, el primer objeto obtendrá las anteriores variables pedidas por teclado, el segundo objeto obtendrá todos los anteriores menos el peso y la altura y el último por defecto, para este último utiliza los métodos set para darle a los atributos un valor.
Para cada objeto, deberá comprobar si está en su peso ideal, tiene sobrepeso o por debajo de su peso ideal con un mensaje.
Indicar para cada objeto si es mayor de edad.
Por último, mostrar la información de cada objeto.
Puedes usar métodos en la clase ejecutable, para que os sea mas fácil.
*/
    class Person
    {
        private string nombre = "Desconocido";
        private int edad = 0, DNI;
        private char sexo;
        private double altura = 0, peso = 0;

        private const char dSexo = 'H';

        public Person()
        {
            sexo = dSexo;
            DNI = generarDNI();
        }

        public Person(string nombre, int edad, char sexo)
        {
            DNI = generarDNI();
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = comprobarSexo(sexo);
        }

        public Person(string nombre, int edad, char sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = comprobarSexo(sexo);
            this.altura = altura;
            DNI = generarDNI();
            this.peso = peso;
        }

        public int calcularIMC()
        {
            if (peso == 0 || altura == 0) {
                return -1;
            }
            double IMC = peso / (altura * altura);

            if (IMC < 20)
            {
                return -1;
            }
            else if (IMC >= 20 && IMC <= 25)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public bool esMayorDeEdad()
        {
            if (edad >= 18)
            {
                return true;
            }
            return false;
        }

        private char comprobarSexo(char sexo)
        {
            if (sexo == 'H' || sexo == 'M' || sexo == 'h' || sexo == 'm')
            {
                return sexo;
            }
            return dSexo;
        }

        private int generarDNI()
        {
            Random rd = new Random();
            int dni = rd.Next(10000000, 99999999);
            return dni;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }
            set 
            { 
                edad = value;
            }
        }
        public char Sexo
        {
            get
            {
                return sexo;
            }
            set
            {
                sexo = value;
            }
        }
        public double Peso
        {
            get
            {
                return peso;
            }
            set
            {
                peso = value;
            }
        }
        public double Altura
        {
            get
            {
                return altura;
            }
            set
            {
                altura = value;
            }
        }
        public int dni
        {
            get
            {
                return DNI;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string nombre = "";
            int edad = 0, DNI = 0;
            char sexo;
            double peso = 0, altura = 0 ;

            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su edad:");
            edad = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Ingrese su sexo: (M si es mujer y H si es hombre)");
            sexo = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Ingrese su altura en metros:");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese su peso en kilogramos:");
            peso = Convert.ToDouble(Console.ReadLine());

            people.AddRange(new List<Person>(){new Person(nombre, edad, sexo, peso, altura), new Person(nombre,edad,sexo), new Person()});
            Console.Clear();
            Console.WriteLine("Se crearon tres personas\n");

            int imc = 0;
            foreach (Person person in people)
            {
                imc = person.calcularIMC();
                if(imc == -1)
                {
                   Console.WriteLine("{0} esta por debajo de su peso ideal",person.Nombre);
                }
                else if (imc == 0)
                {
                    Console.WriteLine("{0} esta en su peso ideal",person.Nombre);
                }
                else
                {
                    Console.WriteLine("{0} tiene sobrepeso", person.Nombre);
                }
            }
            Console.WriteLine("\n");
            foreach (Person person in people)
            {
                if (person.esMayorDeEdad())
                {
                    Console.WriteLine("{0} es mayor de edad", person.Nombre);
                }
                else{
                    Console.WriteLine("{0} es menor de edad", person.Nombre);
                }
            }
            Console.WriteLine("\nInformación de las personas:\n");
            foreach(Person person in people)
            {
                Console.WriteLine("Nombre: {0}\nEdad: {1}\nSexo: {2}\nAltura: {3}m\nPeso: {4}kg\nDNI: {5}\n\n",person.Nombre,person.Edad,person.Sexo,person.Altura,person.Peso,person.dni);
            }
            Console.ReadKey();
        }
    }
}