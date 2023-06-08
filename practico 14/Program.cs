using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Producto> list = new List<Producto>() { new Perecedero(3, "Pollo", 1500), new NoPerecedero("nose", "Bicicleta", 20000), new Perecedero(1, "Huevo", 200), new NoPerecedero("tampoco", "Computadora", 100000)};
            foreach (Producto item in list)
            {
                Console.Write("Producto: "+item.Nombre+", Precio: "+item.Precio);
                item.calcular(5);
                Console.WriteLine(", Precio si compro 5: "+item.Precio);
            }
            Console.ReadKey();
        }
    }
}
