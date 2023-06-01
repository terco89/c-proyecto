using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_9
{
    class Sala
    {
        static private Random rd = new Random();
        private Pelicula actual;
        private int columnas, filas;
        private double precio;
        private List<Asiento> asientos = new List<Asiento>(){};
        private char[] letras = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        public Sala(Pelicula actual, double precio, int filas, int columnas)
        {
            this.actual = actual;
            this.precio = precio;
            if (columnas > letras.Count())
            {
                columnas = letras.Count();
            }
            this.columnas = columnas;
            this.filas = filas;
            for (int i = 0; i < columnas; i++)
            {
                for(int j = 0; j < filas; j++)
                {
                    asientos.Add(new Asiento(letras[i],j+1));
                }
            }
        }

        public Pelicula Actual
        {
            get
            {
                return actual;
            }
            set
            {
                actual = value;
            }
        }
        public double Precio
        {
            get
            {
                return precio;
            }
            set
            {
                precio = value;
            }
        }
        public List<Asiento> Asientos
        {
            get
            {
                return asientos;
            }
        }
        public int Filas
        {
            get
            {
                return filas;
            }
        }
        public int Columnas
        {
            get
            {
                return columnas;
            }
        }

        public string razon(int edad,int dinero)
        {
            if (edad < actual.EdadMinima)
                return "no tiene la edad suficiente";
            else
                return "no tiene suficiente dinero";
        }
        public bool puedeEntrar(int edad, int dinero)
        {
            if (edad < actual.EdadMinima)
                return false;
            else if (dinero < precio)
                return false;
            return true;
        }
        public Asiento ocuparAsiento()
        {
            int a;
            while (true)
            {
                a = rd.Next(0, asientos.Count());
                if (!asientos[a].Ocupado)
                {
                    asientos[a].Ocupado = true;
                    return asientos[a];
                }
            }
        }
        public bool hayAsientos()
        {
            foreach(Asiento a in asientos)
            {
                if (!a.Ocupado)
                {
                    return true;
                }
            }
            return false;
        }
        public int buscarColumna(char col)
        {
            int cont = 0;
            foreach(char c in letras)
            {
                if(c == col)
                {
                    return cont;
                }
                cont++;
            }
            return 0;
        }
    }
}
