using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_17
{
    internal class Carta
    {
        public enum paloBarajaEspaniola
        {
            Oros,
            Bastos,
            Copas,
            Espadas
        }
        public enum paloBarajaFrancesa
        {
            Diamantes,
            Picas,
            Corazones,
            Treboles
        }

        private string palo;

        public Carta(string palo) {
            this.palo = palo;
        }
        public string Palo
        {
            get { return palo; }
            set { palo = value; }
        }
    }
}
