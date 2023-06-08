using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_14
{
    internal class NoPerecedero:Producto
    {
        private string tipo;

        public NoPerecedero(string tipo, string nombre,int precio):base(nombre,precio)
        {
            this.tipo = tipo;
        }

        public string Tipo {
            get { return tipo; }
        }
    }
}
