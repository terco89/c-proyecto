using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_12
{
    internal class Jugador
    {
        private int id;
        private string nombre;
        private bool vivo = true;

        public Jugador(string nombre)
        {
            this.nombre = nombre;
        }

        public bool Vivo
        {
            get { return vivo; }
        }
        public string Nombre {
            get { return nombre; }
        }

        public void disparar(Revolver r)
        {
            vivo = r.disparar() ? false : true;
        }
    }
}