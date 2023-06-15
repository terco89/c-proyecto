using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_15
{
    class AguaMineral : Bebida
    {
        public enum MarcaAgua
        {
            Glaciar,
            Villavicencio,
            Eco
        }

        private string origen;
        public AguaMineral(string marca, int litros, int precio, int id, string origen) : base(marca, litros, precio, id)
        {
            this.origen = origen;
        }

        public string Origen
        {
            get { return origen; }
        }
    }
}
