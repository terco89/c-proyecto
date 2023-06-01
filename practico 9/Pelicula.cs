using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_9
{
    class Pelicula
    {
        private string titulo,director;
        private double duracion;
        private int edadMinima;

        public Pelicula(string titulo, double duracion, string director, int edadMinima)
        {
            this.director = director;
            this.duracion = duracion;
            this.titulo = titulo;
            this.edadMinima = edadMinima;
        }

        public int EdadMinima
        {
            get
            {
                return edadMinima;
            }
        }
        public string Titulo
        {
            get
            {
                return titulo;
            }
        }
        public string Duracion
        {
            get
            {
                int hora = Convert.ToInt32(Math.Floor(duracion));
                int minutos = Convert.ToInt32((duracion - hora) * 100);
                return hora+" horas y "+minutos+" minutos";
            }
        }
        public string Director
        {
            get
            {
                return director;
            }
        }
    }
}
