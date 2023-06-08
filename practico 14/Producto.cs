using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_14
{
    abstract internal class Producto
    {
        public string nombre;
        public int precio;
        public Producto(string nombre, int precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }
        public string Nombre
        {
            get { return nombre; }
        }
        public int Precio
        {
            get { return precio; }
        }

        public void calcular(int cantidad)
        {
            precio *= cantidad;
        }
    }
}
