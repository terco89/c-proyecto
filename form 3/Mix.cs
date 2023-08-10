using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace form_3
{
    internal class Mix
    {
        public string nombre;
        public List<Cancion> audios;

        public Mix(string nombre)
        {
            this.nombre = nombre;
            this.audios = new List<Cancion>();
        }

    }
}
