using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_15
{
    class BebidaAzucarada : Bebida
    {
        public enum MarcaGaseosa
        {
            Coca_Cola,
            Fanta,
            Sprite,
            Pepsi
        }
        private double azucar;
        private bool promocion;
        public BebidaAzucarada(string marca, int precio, int litros, int id, double azucar, bool promocion) : base(marca,litros,precio,id)
        {
            this.azucar = azucar;
            this.promocion = promocion;
        }

        public double Azucar
        {
            get { return azucar; }
        }
        public string Promocion
        {
            get
            {
                return promocion ? "10% de descuento":"No tiene";
            }
        }
    }
}
