using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_10
{
    internal class Carta
    {
        private int numero;
        private string palo;

        public Carta(int numero, string palo) {
            this.numero = numero;
            this.palo = palo;
        }
        public int Numero
        {
            get { return numero; }
        }
        public string Palo
        {
            get { return palo; }
        }
    }
}
