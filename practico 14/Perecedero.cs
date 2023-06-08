using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_14
{
    internal class Perecedero:Producto
    {
        private int dias;
        public Perecedero(int dias,string nombre, int precio):base(nombre,precio)
        {
            this.dias = dias;
        }
        public int Dias
        {
            get { return dias; }
        }

        public void calcular(int cantidad)
        {
            base.calcular(cantidad);
            if(dias == 1) precio /= 4;
            else if(dias == 2) precio /= 3;
            else if(dias == 3) precio /= 2;
        }
    }
}
