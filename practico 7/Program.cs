using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace practico_7
{
    /*7) Vamos a realizar una clase llamada Raíces, donde representaremos los valores de una ecuación de 2º grado.
Tendremos los 3 coeficientes como atributos, llamémosles a, b y c.
Hay que insertar estos 3 valores para construir el objeto.
Las operaciones que se podrán hacer son las siguientes:
obtenerRaices(): imprime las 2 posibles soluciones
obtenerRaiz(): imprime una única raíz, que será cuando solo tenga una solución posible.
getDiscriminante(): devuelve el valor del discriminante (double), el discriminante tiene la siguiente fórmula, (b^2)-4*a*c
tieneRaices(): devuelve un booleano indicando si tiene dos soluciones, para que esto ocurra, el discriminante debe ser mayor o igual que 0.
tieneRaiz(): devuelve un booleano indicando si tiene una única solución, para que esto ocurra, el discriminante debe ser igual que 0.
calcular(): mostrará por consola las posibles soluciones que tiene nuestra ecuación, en caso de no existir solución, mostrarlo también.
Fórmula ecuación 2º grado: (-b±√((b^2)-(4*a*c)))/(2*a)
Solo varía el signo delante de -b
*/
    class Raices
    {
        double a, b, c;
        public Raices(double a, double b, double c) { 
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double[] obtenerRaices()
        {
            return new double[]{
                -b + Math.Sqrt(getDiscriminante()) / (2 * a),
                -b - Math.Sqrt(getDiscriminante()) / (2 * a)
                    };
        }
        public double obtenerRaiz()
        {
            return -b + Math.Sqrt(getDiscriminante()) / (2 * a);
        }
        public double getDiscriminante()
        {
            return (b * b) - (4 * a * c);
        }
        public bool tieneRaices()
        {
            if(getDiscriminante() <= 0)
                return false;
            else
                return true;
        }
        public bool tieneRaiz()
        {
            if(getDiscriminante() == 0)
                return true;
            else
                return false;
        }
        public string calcular()
        {
            if (getDiscriminante() < 0)
                return "ninguna";
            else if (getDiscriminante() == 0)
                return (-b + Math.Sqrt(getDiscriminante()) / (2 * a)).ToString();
            else
                return -b + Math.Sqrt(getDiscriminante()) / (2 * a)+" y "+( -b - Math.Sqrt(getDiscriminante()) / (2 * a));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Raices ra;
            double a, b, c;
            Console.WriteLine("Ingrese el coeficiente de a:");
            a =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el coeficiente de b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el coeficiente de c:");
            c = Convert.ToDouble(Console.ReadLine());
            ra = new Raices(a,b,c);

            Console.Clear();
            if(ra.tieneRaices())
                Console.WriteLine("Las dos posibles soluciones son {0} y {1}", ra.obtenerRaices()[0], ra.obtenerRaices()[1]);
            else if (ra.tieneRaiz())
                Console.WriteLine("La posible solución es {0}", ra.obtenerRaiz());
            else
                Console.WriteLine("La ecuación cuadratica dada por los coeficientes no tiene ninguna solución");
            Console.WriteLine("El discriminante es {0}",ra.getDiscriminante());
            Console.WriteLine("Las posibles soluciones son: {0}",ra.calcular());
            Console.ReadKey();
        }
    }
}
