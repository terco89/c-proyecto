using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_17
{
    internal class BarajaFrancesa : Baraja
    {
        private string[] paloss = Enum.GetNames(typeof(Carta.paloBarajaFrancesa));


        public BarajaFrancesa() : base()
        {
            for (int i = 0; i < paloss.Count(); i++)
            {
                string color = paloss[i] == "Diamantes" || paloss[i] == "Corazones" ? "Rojos" : "Negros";
                for (int j = 0; j < 13; j++)
                {
                    switch (j+1)
                    {
                        case 1: Cartas.Add(new Carta("As de " + paloss[i] + " " + color)); break;
                        case 11: Cartas.Add(new Carta("Sota de " + paloss[i] + " " + color)); break;
                        case 12: Cartas.Add(new Carta("Caballo de " + paloss[i] + " " + color)); break;
                        case 13: Cartas.Add(new Carta("Rey de " + paloss[i] + " " + color)); break;
                        default: Cartas.Add(new Carta(j+1 + " de " + paloss[i] + " " + color)); break;
                    }
                }
            }
        }

        public bool cartaRoja(Carta c)
        {
            return c.Palo.Split(new string[] { "Diamantes", "Corazones" }, StringSplitOptions.None).Length > 1 ? true : false;
        }
        public bool cartaNegra(Carta c)
        {
            return c.Palo.Split(new string[] { "Picas", "Treboles" }, StringSplitOptions.None).Length > 1 ? true : false;
        }
    }
}