using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_11
{
    internal class Jornada
    {
        private int pozo = 0;

        public Jornada() {
            
        }

        public int Pozo
        {
            get { return pozo; }
            set { pozo = value; }
        }
    }
}
