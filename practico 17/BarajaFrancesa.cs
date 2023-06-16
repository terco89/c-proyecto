using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_17
{
    internal class BarajaFrancesa:Baraja
    {
        private string[] paloss = Enum.GetNames(typeof(Carta.paloBarajaFrancesa));


        public BarajaFrancesa(): base() {
            for (int i = 0; i < paloss.Count(); i++)
            {
                for (int j = i * 10; j < Numeros.Length; j++)
                {
                    switch (j)
                    {
                        case 1: Cartas.Add(new Carta("As")); break;
                        case 11: Cartas.Add(new Carta("Sota")); break;
                        case 12: Cartas.Add(new Carta("Caballo")); break;
                        case 13: Cartas.Add(new Carta("Rey")); break;
                        default: Cartas.Add(new Carta(j + " de " + paloss[i])); break;
                    }
                }
            }
        }

        public void aniadirCartasExtra()
        {
            for (int i = 0; i < palos.Count(); i++)
            {
                for (int j = 0; j < numeros.Length; j++)
                {
                    cartas.Add(new Carta(numeros[j], palos[i]));
                }
            }
        }
    }
}
