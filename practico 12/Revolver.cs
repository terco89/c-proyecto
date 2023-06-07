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

        public Revolver()
        {
            posicionActual = rd.Next(0, 5);
            posicionBala = rd.Next(0, 5);
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
            if(posicionActual == posicionBala)
                return true;
            return false;
        }
        public void siguienteBala()
        {
            posicionActual++;
        }
    }
}
