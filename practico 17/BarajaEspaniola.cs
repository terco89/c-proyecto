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
                for (int j = 0; j < total; j++) {
                    switch (j+1) {
                        case 1: Cartas.Add(new Carta("As de " + paloss[i])); break;
                        case 11: Cartas.Add(new Carta("Jota de " + paloss[i])); break;
                        case 12: Cartas.Add(new Carta("Reina de " + paloss[i])); break;
                        case 13: Cartas.Add(new Carta("Rey de " + paloss[i])); break;
                        default: Cartas.Add(new Carta(j+1 + " de " + paloss[i]));break;
                    }
                }
            }
        }

    }
}
