using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_3
{
    /*
3) Haz una clase llamada Password que siga las siguientes condiciones:
Que tenga los atributos longitud y contraseña . Por defecto, la longitud sera de 8.
Los constructores serán los siguiente:
Un constructor por defecto.
Un constructor con la longitud que nosotros le pasemos. Generará una contraseña aleatoria con esa longitud.
Los métodos que implementa serán:
esFuerte(): devuelve un booleano si es fuerte o no, para que sea fuerte debe tener mas de 2 mayúsculas, mas de 1 minúscula y mas de 5 números.
generarPassword():  genera la contraseña del objeto con la longitud que tenga.
Método get para contraseña y longitud.
Método set para longitud.
Ahora, crea una clase clase ejecutable:
Crea un array de Passwords con el tamaño que tu le indiques por teclado.
Crea un bucle que cree un objeto para cada posición del array.
Indica también por teclado la longitud de los Passwords (antes de bucle).
Crea otro array de booleanos donde se almacene si el password del array de Password es o no fuerte (usa el bucle anterior).
Al final, muestra la contraseña y si es o no fuerte (usa el bucle anterior). Usa este simple formato:
contraseña1 valor_booleano1
contraseña2 valor_bololeano2
*/
    class Password
    {
        private string contraseña;
        private int longitud = 8;

        static private char[] mayusculas = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        static private char[] minusculas = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        static private char[] numeros = {'1','2','3','4','5','6','7','8','9','0'};
        private char[][] caracteres = {mayusculas,minusculas,numeros};

        public Password(Random rd)
        {
            contraseña = generarPassword(rd);
        }

        public Password(int longitud, Random rd)
        {
            this.longitud = longitud;
            contraseña = generarPassword(rd);
        }

        public string Contraseña
        {
            get
            {
                return contraseña;
            }
        }
        public int Longitud
        {
            get
            {
                return longitud;
            }
            set
            {
                longitud = value;
            }
        }

        public bool esFuerte()
        {
            int may = 2;
            int min = 1;
            int num = 5;

            foreach (char c in contraseña)
            {

                bool bandera = true;
                if (may != 0) {
                    foreach (char ma in mayusculas)
                    {
                        if (c == ma)
                        {
                            may--;
                            bandera = false;
                            break;
                        }
                    }
                }
                if (bandera && min != 0)
                {
                    foreach (char mi in minusculas)
                    {
                        if (c == mi)
                        {
                            min--;
                            bandera = false;
                            break;
                        }
                    }
                }

                if (bandera && num != 0)
                {
                    foreach (char n in numeros)
                    {
                        if (c == n)
                        {
                            num--;
                            break;
                        }
                    }
                }
            }
            if (num == 0 && may == 0 && min == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private string generarPassword(Random rd)
        {
            string contraseña = "";
            for (int i = 0; i < longitud; i++) {
                int ind = rd.Next(0,caracteres.Count());
                contraseña += caracteres[ind][rd.Next(0, caracteres[ind].Count())];
            }
            return contraseña;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();

            Console.WriteLine("Ingrese la cantidad de contraseñas que desee:");
            int cant = Convert.ToInt32(Console.ReadLine());

            List<Password> contras = new List<Password>();
            List<bool> fuertes = new List<bool>();

            Console.WriteLine("\nAhora ingrese la lonigtud de las contraseñas:");
            int longi = Convert.ToInt32(Console.ReadLine());

            if (longi > 0)
            {
                for (int i = 0; i < cant; i++)
                {
                    contras.Add(new Password(longi,rd));
                    fuertes.Add(contras[contras.Count()-1].esFuerte());
                }
            }
            else
            {
                for (int i = 0; i < cant; i++)
                {
                    contras.Add(new Password(rd));
                    fuertes.Add(contras[contras.Count() - 1].esFuerte());
                }
            }

            Console.Clear();

            for(int i = 0; i < contras.Count();i++)
            {
                Console.WriteLine(contras[i].Contraseña+" "+fuertes[i]);
            }
            Console.ReadKey();
        }
    }
}
