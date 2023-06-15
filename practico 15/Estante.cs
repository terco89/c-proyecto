using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_15
{
    class Estante
    {
        private Bebida bebida;
        public Estante() { }
        public Estante(Bebida bebida) { this.bebida = bebida; }

        public Bebida Bebida
        {
            get { return bebida; }
            set { bebida = value; }
        }
    }
}
