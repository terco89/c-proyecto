using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer20
{
    class Empleado
    {
        public string nombre;
        public string apellido;

        public Empleado(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Empleado() { }
    }
    class Diseñador : Empleado
    {
        Int16 sueldo = 1000;

        public Diseñador(string nom, string ape) : base(nom, ape)
        {

        }
        public Int16 Sueldo
        {
            get { return sueldo; }
        }
    }
    class Backend : Empleado
    {
        Int16 sueldo = 1400;
        public Int16 Sueldo
        {
            get { return sueldo; }
        }
        public Backend(string nom, string ape) : base(nom, ape)
        {

        }

        public Backend()
        {

        }

    }
    class FullStack : Empleado
    {
        Int16 sueldo = 1800;
        public FullStack(string nom, string ape) : base(nom, ape)
        {

        }
        public Int16 Sueldo
        {
            get { return sueldo; }
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Diseñador d = new Diseñador("Pablo", "Fiscella");

            Console.WriteLine("{0}, {1} cobra U$S{2}", d.nombre, d.apellido, d.Sueldo);
            Console.ReadKey();

            Backend b = new Backend();

            
        }
    }
}
