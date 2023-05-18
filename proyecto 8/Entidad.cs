using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_8
{
    internal class Entidad
    {
        private string nombre;
        private int edad;
        private bool genero;
        private bool presente;

        public Entidad(string nombre, int edad, string genero)
        {
            this.nombre = nombre;
            this.edad = edad;
            if (genero.ToUpper() == "FEMENINO")
                this.genero = true;
            else
                this.genero = false;
        }

        public string Nombre
        {
            get { return this.nombre; }
        }
        public int Edad
        {
            get { return this.edad; }
        }
        public bool Genero
        {
            get { return this.genero; }
        }
        public bool Presente
        {
            get { return this.presente; }
            set { this.presente = value; }
        }
    }
}
