using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_5
{
    interface Entregable
    {
        void entregar();
        void devolver();
        bool isEntregado();
    }
    class Serie : Entregable
    {
        private string titulo = "", creador = "", genero = "";
        private int num_temp = 3;
        private bool entregado;

        public Serie()
        {

        }

        public Serie(string titulo, string creador)
        {
            this.titulo = titulo;
            this.creador = creador;
        }

        public Serie(string titulo, string creador, string genero, int num_temp)
        {
            this.titulo = titulo;
            this.creador = creador;
            this.genero = genero;
            this.num_temp = num_temp;
        }

        public string Titulo
        {
            get
            {
                return titulo;
            }
            set
            {
                titulo = value;
            }
        }

        public string Creador
        {
            get
            {
                return creador;
            }
            set
            {
                creador = value;
            }
        }
        public string Genero
        {
            get
            {
                return genero;
            }
            set
            {
                genero = value;
            }
        }
        public int Num_temp
        {
            get
            {
                return num_temp;
            }
            set
            {
                num_temp = value;
            }
        }
        public bool Entregado
        {
            get
            {
                return entregado;
            }
        }

        public void entregar()
        {
            entregado = true;
        }
        public void devolver()
        {
            entregado = false;
        }
        public bool isEntregado()
        {
            return entregado;
        }
        public bool compareTo(Serie serie)
        {
            if(num_temp > serie.Num_temp)
            {
                return true;
            }
            return false;
        }
    }

    class Videojuego : Entregable
    {
        private string titulo="",genero="",compañia="";
        private int horas_estimadas=10;
        private bool entregado;

        public Videojuego()
        {

        }
        public Videojuego(string titulo, int horas_estimadas)
        {
            this.titulo = titulo;
            this.horas_estimadas = horas_estimadas;
        }
        public Videojuego(string titulo, string genero, string compañia, int horas_estimadas)
        {
            this.titulo = titulo;
            this.genero = genero;
            this.compañia = compañia;
            this.horas_estimadas = horas_estimadas;
        }

        public string Titulo
        {
            get
            {
                return titulo;
            }
            set
            {
                titulo = value;
            }
        }
        public string Genero
        {
            get
            {
                return genero;
            }
            set
            {
                genero = value;
            }
        }
        public string Compañia
        {
            get
            {
                return compañia;
            }
            set
            {
                compañia = value;
            }
        }
        public int Horas_estimadas
        {
            get
            {
                return horas_estimadas;
            }
            set
            {
                horas_estimadas = value;
            }
        }
        public bool Entregado
        {
            get
            {
                return entregado;
            }
        }
        public void entregar()
        {
            entregado = true;
        }
        public void devolver()
        {
            entregado = false;
        }
        public bool isEntregado()
        {
            return entregado;
        }
        public bool compareTo(Videojuego videojuego)
        {
            if (horas_estimadas > videojuego.Horas_estimadas)
            {
                return true;
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            Serie[] series = new Serie[5];
            Videojuego[] videojuegos = new Videojuego[5];
            series[0] = new Serie("Dragon Ball", "Akira Toriyama");
            series[1] = new Serie();
            series[2] = new Serie("Gabo la serie", "Gabriel Valera", "comedia", 72);
            series[3] = new Serie();
            series[4] = new Serie("Baki", "Itagaki");
            videojuegos[0] = new Videojuego();
            videojuegos[1] = new Videojuego("Plantas vs Zombies", 20);
            videojuegos[2] = new Videojuego("FIFA", "Deportivo", "Electronics Arts", 30);
            videojuegos[3] = new Videojuego();
            videojuegos[4] = new Videojuego("FNAF", 10);

            videojuegos[1].entregar();
            videojuegos[4].entregar();
            series[1].entregar();
            series[4].entregar();

            Serie maxs = series[rd.Next(0,series.Count())];
            Videojuego maxv = videojuegos[rd.Next(0,videojuegos.Count())];
            int conts = 0;
            foreach(Serie s in series)
            {
                if (s.compareTo(maxs))
                {
                    maxs = s;
                }
                if (s.Entregado)
                {
                    s.devolver();
                    conts++;
                }
            }
            int contv = 0;
            foreach (Videojuego v in videojuegos)
            {
                if (v.compareTo(maxv))
                {
                    maxv = v;
                }
                if (v.Entregado)
                {
                    v.devolver();
                    contv++;
                }
            }
            Console.WriteLine("Habían {0} videojuegos y {1} series entregadas. Luego se devolvieron todas\n\n", contv, conts);
            Console.WriteLine("Videojuego\n\nTitulo: {0}\nCompañia: {1}\nGenero: {2}\nHoras estimadas: {3}\nEntregado: {4}",maxv.Titulo,maxv.Compañia,maxv.Genero,maxv.Horas_estimadas,maxv.Entregado);
            Console.WriteLine("\n\nSerie\n\nTitulo: {0}\nCreador: {1}\nGenero: {2}\nNumero de temporadas: {3}\nEntregado: {4}",maxs.Titulo,maxs.Creador,maxs.Genero,maxs.Num_temp,maxs.Entregado);
            Console.ReadKey();
        }
    }
}
