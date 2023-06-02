using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_11
{
    internal class Apuesta
    {
        static private Random rd = new Random();
        private int primerEquipo, segundoEquipo, precio, pozo = 0, cantJornadas;
        private Jornada jornada;
        private List<Jugador> jugadores;

        public Apuesta(List<Jugador> jugadores)
        {
            this.jugadores = jugadores;
        }
        
        public int CantJornadas
        {
            get { return cantJornadas; }
        }
        public List<Jugador> Jugadores
        {
            get { return jugadores; }
        }

        public bool iniciarJornada()
        {
            if (jornada != null)
                return false;
            jornada = new Jornada();
            cantJornadas++;
            foreach (Jugador j in jugadores)
            {
                if (j.Dinero == 0)
                    continue;
                j.Dinero--;
                jornada.Pozo++;
                j.PrimerEquipo = rd.Next(0, 10);
                j.SegundoEquipo = rd.Next(0, 10);
            }
            primerEquipo = rd.Next(0,10);
            segundoEquipo = rd.Next(0,10);
            return true;
        }
        public int[] empezarPartido()
        {
            if (jornada == null)
                return null;
            primerEquipo = rd.Next(0, 10);
            segundoEquipo = rd.Next(0, 10);
            return new int[] {primerEquipo, segundoEquipo};
        }
        public int acerto(int index)
        {
            if (jugadores[index].PrimerEquipo == primerEquipo && jugadores[index].SegundoEquipo == segundoEquipo)
            {
                jugadores[index].ContGanadas++;
                if (jugadores[index].ContGanadas % 2 == 0)
                {
                    jugadores[index].Dinero += pozo;
                    return 1;
                }
                return 2;
            }
            return 3;
        }
        public int terminarJornada()
        {
            int a;
            for (int i = 0; i < jugadores.Count(); i++)
            {
                a = acerto(i);
                if (a == 1 || a == 2) {
                    if (a == 2)
                        pozo += jornada.Pozo;
                    jornada = null;
                    return i;
                }
            }
            pozo += jornada.Pozo;
            jornada = null;
            return -1;
        }
    }
}
