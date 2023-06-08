using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico__13
{
    abstract internal class Empleado
    {
        public string nombre;
        public int salario, edad;
        public const int PLUS = 300;
        public Empleado(string nombre, int salario, int edad) {
            this.edad = edad;
            this.nombre = nombre;
            this.salario = salario;
        }

        public string Nombre
        {
            get { return nombre; }
        }
        public int Salario
        {
            get { return salario; }
        }
        public int Edad
        {
            get { return edad; }
        }

        public virtual void plus()
        {

        }
    }
}
