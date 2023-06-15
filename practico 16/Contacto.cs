using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_16
{
    class Contacto
    {
        private string nombre;
        private int telefono;

        public Contacto(string nombre, int telefono)
        {
            this.nombre = nombre;
            this.telefono = telefono;
        }

        public string Nombre
        {
            get { return nombre; }
        }
        public int Telefono
        {
            get { return telefono; }
        }
    }
}
