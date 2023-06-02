using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_11
{
    internal class Jugador
    {
        private int id,dinero,primerEquipo,segundoEquipo,contGanadas = 0;

        public Jugador(int dinero, int id)
        {
            this.dinero = dinero;
            this.id = id;
        }

        public int Dinero
        {
            get { return dinero; }
            set { dinero = value; }
        }
        public int PrimerEquipo
        {
            get { return primerEquipo; }
            set { primerEquipo = value; }
        }
        public int SegundoEquipo
        {
            get { return segundoEquipo; }
            set { segundoEquipo = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int ContGanadas
        {
            get { return contGanadas; }
            set { contGanadas = value;}
        }
    }
}
