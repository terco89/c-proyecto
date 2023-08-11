using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form_3
{
    internal class Cancion
    {
        public string nombre;
        public string dir;
        public int iguales = 0;

        public Cancion(string nombre, string dir)
        {
            this.nombre = nombre;
            this.dir = dir;
        }
    }
}
