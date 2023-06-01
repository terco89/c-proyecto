using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_10
{
    internal class Baraja
    {
        static private Random rd = new Random();
        private int actual = 0;
        private string[] palos = { "espada", "basto", "oro", "copa" };
        private int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 10, 11, 12 };
        private List<Carta> cartas = new List<Carta>();

        public Baraja() {
            for (int i = 0; i < palos.Count(); i++)
            {
                for (int j = 0; j < numeros.Length; j++)
                {
                    cartas.Add(new Carta(numeros[j], palos[i]));
                }
            }
        }

        public List<Carta> Cartas
        {
            get { return cartas; }
        }

        public int Actual
        {
            get { return actual; }
        }

        public void barajar()
        {
            List<Carta> cartas1 = new List<Carta>();
            int cont = 0;
            while (cont < cartas.Count())
            {
                int index = rd.Next(0, cartas.Count());
                if (cartas1.Find(x => x == cartas[index]) == null)
                {
                    cont++;
                    cartas1.Add(cartas[index]);
                }
            }
            cartas = cartas1;
        }

        public string siguienteCarta()
        {
            if (actual == cartas.Count())
                actual = -1;
            actual++;
            return cartas[actual];
        }
    }
}