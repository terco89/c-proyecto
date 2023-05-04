using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_1
{
    /*1) Crea una clase llamada Cuenta que tendrá los siguientes atributos: titular y cantidad (puede tener decimales).
El titular será obligatorio y la cantidad es opcional. Crea dos constructores que cumplan lo anterior.
Tendrá dos métodos especiales:
ingresar(double cantidad): se ingresa una cantidad a la cuenta, si la cantidad introducida es negativa, no se hará nada.
retirar(double cantidad): se retira una cantidad a la cuenta, si restando la cantidad actual a la que nos pasan es negativa, la cantidad de la cuenta pasa a ser 0.
*/
    class Cuenta
    {
        public string titular;
        public double cantidad = 0;

        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;   
            this.cantidad = cantidad;
        }
        public Cuenta(string titular)
        {
            this.titular = titular;
        }

        public void ingresar(double cantidad)
        {
            if (cantidad > 0)
            {
                this.cantidad += cantidad;
            }
        }
        public void retirar(double cantidad)
        {
            if (cantidad > 0)
            {
                this.cantidad -= cantidad;
                if(this.cantidad < 0)
                {
                    this.cantidad = 0;
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta;
            double cant;
            Console.WriteLine("Bienvenido\n\nIngrese el titular de su cuenta:");
            string titular = Console.ReadLine();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Bienvenido {0}!",titular);
                Console.WriteLine("¿Desea ingresar una cantidad inicial a su cuenta? Y/N");
                ConsoleKeyInfo opcion = Console.ReadKey();
                if (opcion.Key == ConsoleKey.Y)
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("\nIngrese la cantidad inicial de dinero en su cuenta:");
                        string cantidad = Console.ReadLine();
                        if (double.TryParse(cantidad, out cant))
                        {
                            cuenta = new Cuenta(titular, cant);
                            break;
                        }
                    }
                    break;
                }
                else if (opcion.Key == ConsoleKey.N)
                {
                    cuenta = new Cuenta(titular);
                    break;
                }
            }
            while (true)
            {
            Console.Clear() ;
            Console.WriteLine("{0}, actualmente tu cuenta posee {1}\n",cuenta.titular,cuenta.cantidad);
            Console.WriteLine("¿Cuanto dinero desea ingresar?");
            string canti = Console.ReadLine();
            if(double.TryParse(canti, out cant))
                {
                    cuenta.ingresar(cant);
                    Console.WriteLine("Se ingreso {0} a su cuenta",cant);
                    Console.WriteLine("{0}, actualmente tu cuenta posee {1}\n", cuenta.titular, cuenta.cantidad);
                    Console.WriteLine("\n Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;
                }
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine("{0}, actualmente tu cuenta posee {1}\n", cuenta.titular, cuenta.cantidad);
                Console.WriteLine("¿Cuanto dinero desea retirar?");
                string canti = Console.ReadLine();
                if (double.TryParse(canti, out cant))
                {
                    cuenta.retirar(cant);
                    Console.WriteLine("Se retiro {0} a su cuenta", cant);
                    Console.WriteLine("{0}, actualmente tu cuenta posee {1}\n", cuenta.titular, cuenta.cantidad);
                    Console.WriteLine("\n Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
