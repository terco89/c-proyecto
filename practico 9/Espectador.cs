using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_9
{
    class Espectador
    {
        private string nombre;
        private int edad,dinero;

        public Espectador(string nombre, int edad, int dinero)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dinero = dinero;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }
        public int Edad
        {
            get
            {
                return edad;
            }
        }
        public int Dinero
        {
            get
            {
                return dinero;
            }
        }
    }
}
