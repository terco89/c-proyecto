using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_9
{
    class Asiento
    {
        private char columna;
        private int fila;
        private bool ocupado;

        public Asiento(char columna, int fila)
        {
            this.columna = columna;
            this.fila = fila;
        }

        public char Columna
        {
            get
            {
                return columna;
            }
        }
        public int Fila
        {
            get
            {
                return fila;
            }
        }
        public bool Ocupado
        {
            get
            {
                return ocupado;
            }
            set
            {
                ocupado = value;
            }
        }
    }
}
