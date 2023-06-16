using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_17
{
    internal class BarajaEspaniola:Baraja
    {
        private bool cartasExtra;
        private string[] paloss = Enum.GetNames(typeof(Carta.paloBarajaEspaniola));
        public BarajaEspaniola(bool cartasExtra): base() {
            this.cartasExtra = cartasExtra;
            int total = cartasExtra ? 13:10;
            for (int i = 0; i < paloss.Count();i++)
            {
                for (int j = i * total; j < Numeros.Length; j++) {
                    switch (j) {
                        case 1: Cartas.Add(new Carta("As")); break;
                        case 11: Cartas.Add(new Carta("Jota")); break;
                        case 12: Cartas.Add(new Carta("Reina")); break;
                        case 13: Cartas.Add(new Carta("Rey")); break;
                        default: Cartas.Add(new Carta(j + " de " + paloss[i]));break;
                    }
                }
            }
        }

    }
}
