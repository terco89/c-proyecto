using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_17
{
    abstract internal class Baraja
    {
        static private Random rd = new Random();
        private int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 10, 11, 12 };
        private int[] numerosExtra = { 8,9};
        private List<Carta> cartas = new List<Carta>() { }, cartasL = new List<Carta>() { };

        public Baraja() {
        }

        public int[] NumerosExtra
        {
            get { return numerosExtra; }
        }
        public int[] Numeros
        {
            get { return numeros; }
        }
        public List<Carta> Cartas
        {
            get { return cartas; }
        }
        public List<Carta> CartasL
        {
            get { return cartasL; }
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

        public Carta siguienteCarta()
        {
            if (cartas.Count() == 0)
                return null;
            Carta carta = cartas[0];
            cartasL.Add(cartas[0]);
            cartas.RemoveAt(0);
            return carta;
        }

        public int cartasDisponibles()
        {
            return cartas.Count();
        }

        public List<Carta> darCartas(int cant)
        {
            if (cartas.Count() < cant)
                return null;
            List<Carta> cartasN = new List<Carta>() { };
            for (int i  = cant; i > 0; i--) {
                cartasN.Add(cartas[i]);
                cartasL.Add(cartas[i]);
                cartas.RemoveAt(i);
            }
            return cartasN;
        }
        public void cartasMonton()
        {
            if (cartasL.Count() == 0)
            {
                Console.WriteLine("\n\nVacío");
                return;
            }
            int x = 0, y = 0;
            for (int i = 0; i < cartasL.Count(); i++)
            {
                y++;
                if (i % 25 == 0)
                {
                    x++;
                    y = 0;
                }
                Console.SetCursorPosition(x * 30, y + 2);
                Console.WriteLine(cartasL[i].Palo);
            }
        }
        public virtual void mostrarBaraja()
        {
            int x = 0, y = 0;
            for (int i = 0; i < cartas.Count(); i++)
            {
                y++;
                if (i % 25 == 0)
                {
                    x++;
                    y = 0;
                }
                Console.SetCursorPosition(x * 30, y + 2);
                Console.WriteLine(cartas[i].Palo);
            }
        }
    }
}