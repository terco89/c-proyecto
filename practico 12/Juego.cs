using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace practico_12
{
    internal class Juego
    {
        private List<Jugador> jugadores;
        private Revolver revolver;

        public Juego(int cantjugadores) {
            jugadores = new List<Jugador>();
            cantjugadores = cantjugadores > 0 && cantjugadores < 7 ? cantjugadores : 6;
            for(int i = 0; i < cantjugadores; i++)
            {
                jugadores.Add(new Jugador("Jugador"+(i+1)));
            }
            revolver = new Revolver();
        }

        public bool finJuego()
        {
            return jugadores.Exists(j => !j.Vivo);
        }
        public string ronda()
        {
            string informe = "";
            foreach(Jugador j in jugadores)
            {
                j.disparar(revolver);
                informe += j.Vivo ? j.Nombre+" se disparo, no ha muerto\n":j.Nombre+" se disparo, ha muerto\n";
                if (!j.Vivo)
                    break;
            }
            return informe;
        }
    }
}
