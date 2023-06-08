using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_12
{
    internal class Revolver
    {
        private static Random rd = new Random();
        private int posicionActual;
        private int posicionBala;
        private int cant = 9;

        public Revolver()
        {
            posicionActual = rd.Next(0, cant);
            posicionBala = rd.Next(0, cant);
        }

        public int PosicionActual
        {
            get { return posicionActual; }
        }
        public int PosicionBala
        {
            get { return posicionBala; }
        }

        public bool disparar()
        {
            siguienteBala();
            if(posicionActual == posicionBala)
                return true;
            return false;
        }
        public void siguienteBala()
        {
            posicionActual = posicionActual != cant ? posicionActual + 1 : 0;
        }
    }
}
