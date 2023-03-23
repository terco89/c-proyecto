using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer10
{
    class Copo
    {
        public int x, y;

        public Copo(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void mostrar()
        {
            Console.SetCursorPosition(x, y);
            Console.Write("*");
        }

        public void bajar()
        {
            if (y < 24)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(" ");
                y++;
                Console.SetCursorPosition(x, y);
                Console.Write("*");
            }
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Copo copo;
            List<Copo> list = new List<Copo>();
            Random rand = new Random();




            DateTime hora = DateTime.Now;
            DateTime horaActual = DateTime.Now;
            TimeSpan tiempoTrasncurrido;

            while (true)
            {
                horaActual = DateTime.Now;
                tiempoTrasncurrido = horaActual - hora;
                if (tiempoTrasncurrido.Milliseconds == 25)
                {
                    list.Add(new Copo(rand.Next(39), 0));
                    hora = DateTime.Now;
                    foreach (Copo copoLista in list)
                    {
                        bool bandera = false;
                        foreach (Copo copolista1 in list)
                        {
                            if (copoLista.y + 1 == copolista1.y && copoLista.x == copolista1.x)
                            {
                                bandera = true;
                                break;
                            }
                        }
                        if (bandera == false)
                        {
                            copoLista.bajar();
                            copoLista.mostrar();
                        }

                    }
                    int suma = 0;
                    List<Copo> lista = new List<Copo>();
                    foreach (Copo copoLista in list)
                    {
                        if (copoLista.y == 24)
                        {
                            suma++;
                        }
                    }

                     if (suma == 39)
                     {
                        for(int i = list.Count-1; i >= 0; i--)
                        {
                           if (list[i].y == 24)
                               list.RemoveAt(i);
                        }
                        for (int a = 0; a < 40; a++)
                        {
                            Console.SetCursorPosition(a, 24);
                            Console.Write(" ");
                        }
                    }
                }

            }
            Console.ReadKey();
        }
    }
}
