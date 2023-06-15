using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_15
{
    abstract class Bebida
    {
        public enum Marca
        {
            Coca_Cola = 1,
            Fanta=1,
            Sprite=1,
            Pepsi=1,
            Glaciar=2,
            Villavicencio=2,
            Eco=2
        }
        
        private int id,litros,precio;
        private string marca;
        public Bebida(string marca, int litros, int precio, int id)
        {
            this.marca = marca;
            this.litros = litros;
            this.precio = precio;
            this.id = id;
        }

        public int Precio
        {
            get { return precio; }
        }
        public string MarcaGet
        {
            get { return marca; }
        }
        public int Id
        {
            get { return id; }
        }
        public int Litros
        {
            get { return litros; }
        }
    }
}
