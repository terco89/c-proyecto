using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_15
{
    class Program
    {
        static void esperar(string msg)
        {
            Console.WriteLine(msg);
            while (true)
            {
                if (Console.ReadKey().Key == ConsoleKey.Enter) break;
            }
        }
        static void Main(string[] args)
        {
            string[] Marcas = Enum.GetNames(typeof(Bebida.Marca));
            string[] Marcasa = Enum.GetNames(typeof(AguaMineral.MarcaAgua));
            string[] Marcasb = Enum.GetNames(typeof(BebidaAzucarada.MarcaGaseosa));
            List<List<Estante>> bebidas = new List<List<Estante>>() { new List<Estante>() {new Estante(new BebidaAzucarada(Bebida.Marca.Coca_Cola.ToString(), 500, 2, 1, 20, true)), new Estante(new AguaMineral(Bebida.Marca.Villavicencio.ToString(), 2, 200, 2, "Manantial de agua")), new Estante (new BebidaAzucarada(Bebida.Marca.Sprite.ToString(), 500, 2, 3, 10, true)) }, new List<Estante>() { new Estante(new AguaMineral(Bebida.Marca.Eco.ToString(), 2, 200, 4, "Manantial de H2O")), new Estante(new BebidaAzucarada(Bebida.Marca.Fanta.ToString(), 500, 2, 5, 10, false)), new Estante(new AguaMineral(Bebida.Marca.Glaciar.ToString(), 2, 200, 6, "Manantial de ¿agua?")),new Estante()} };
            Almacen almacen = new Almacen(bebidas);
            Console.WriteLine("Bienvenido/a al almacen, estos son los productos: " + almacen.mostrarInformacion());
            esperar("\nPresione enter para continuar...");
            int ide;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Ahora, ingrese el id de alguna bebida que quiera eliminar");
                string pa = Console.ReadLine();
                if (Int32.TryParse(pa, out ide)) break;
            }
            Console.WriteLine(almacen.eliminarBebida(ide));
            esperar("Presione enter para continuar...");
            int opcion = 1,litros,precio,azucar;
            bool promocion;
            string marca, origen;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Agregamos una nueva bebida\n¿Que tipo de bebida sera?\n1. Agua mineral\n2. Bebida azucarada");
                ConsoleKeyInfo op = Console.ReadKey();
                if (op.Key == ConsoleKey.D2)
                {
                    opcion = 2;
                    break;
                }
                else if (op.Key == ConsoleKey.D1) break;
            }
            while (true){
                Console.Clear();
                Console.WriteLine("¿Que marca sera?");
                if (opcion == 1)
                {
                    for (int i = 0; i < Marcasa.Count(); i++) Console.WriteLine(i + 1 + ". " + Marcasa[i]);
                    ConsoleKeyInfo op = Console.ReadKey();
                    int va = Convert.ToInt32(op.Key) - Convert.ToInt32(ConsoleKey.D0);
                    if (va - 1 < Marcasa.Count() && Marcasa.Contains(Marcasa[va - 1]))
                    {
                        marca = Marcasa[va - 1];
                        break;
                    }
                }
                else
                {
                    for (int i = 0; i < Marcasb.Count(); i++) Console.WriteLine(i + 1 + ". " + Marcasb[i]);
                    ConsoleKeyInfo op = Console.ReadKey();
                    int va = Convert.ToInt32(op.Key) - Convert.ToInt32(ConsoleKey.D0);
                    if (va - 1 < Marcasb.Count() && Marcasb.Contains(Marcasb[va - 1]))
                    {
                        marca = Marcasb[va - 1];
                        break;
                    }
                }
            }
            while (true)
            {
                Console.Clear();
                Console.WriteLine("¿Cual sera el precio?");
                string p = Console.ReadLine();
                if (Int32.TryParse(p, out precio)) break;
            }
            while(true)
            {
                Console.Clear();
                Console.WriteLine("¿Cuantos litros tendra?");
                string p = Console.ReadLine();
                if (Int32.TryParse(p, out litros)) break;
            }
            if (opcion == 1)
            {
                Console.Clear();
                Console.WriteLine("¿Cual es el origen de esta agua mineral?");
                origen = Console.ReadLine();
                Console.WriteLine(almacen.agregarBebida(new AguaMineral(marca,litros,precio,7,origen)));
            }
            else
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("¿Cuanto porcentaje de azucares tendra?");
                    string p = Console.ReadLine();
                    if (Int32.TryParse(p, out azucar)) break;
                }
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("¿Desea que su bebida azucarada tenga una promoción del 10% de descuento? Y o N");
                    ConsoleKeyInfo op = Console.ReadKey(true);
                    if (op.Key == ConsoleKey.Y)
                    {
                        promocion = true;
                        break;
                    }
                    else if (op.Key == ConsoleKey.N)
                    {
                        promocion = false;
                        break;
                    }
                }
                Console.WriteLine(almacen.agregarBebida(new BebidaAzucarada(marca, precio, litros, 7, azucar, promocion)));
            }
            esperar("Presione enter para continuar...");
            Console.Clear();
            Console.WriteLine("Seleccione alguna marca de la lista para ver el precio de las bebidas con esa marca");
            for (int i = 0; i < Marcas.Count(); i++) Console.WriteLine(i + 1 + ". " + Marcas[i]);
            ConsoleKeyInfo opa = Console.ReadKey(true);
            int vi = Convert.ToInt32(opa.Key) - Convert.ToInt32(ConsoleKey.D0);
            if (vi - 1 < Marcas.Count() && Marcas.Contains(Marcas[vi - 1])) Console.WriteLine("Las "+Marcas[vi-1]+" cuestan "+almacen.precioTotalPorMarca(Marcas[vi - 1])+" en total");
            esperar("Presione enter para ver el almacen actualizado...");
            Console.Clear();
            Console.WriteLine(almacen.mostrarInformacion());
            esperar("\nPresione enter para terminar el programa");
        }
    }
}
