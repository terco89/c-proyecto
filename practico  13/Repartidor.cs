using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico__13
{
    internal class Repartidor : Empleado
    {
        private string zona;
        public Repartidor(string zona,string nombre,int edad, int salario) : base(nombre,edad,salario) {
            this.zona = zona;
        }

        public string Zona {
            get { return zona; }
        }

        public override void plus()
        {
            salario = edad < 25 && zona == "zona 3" ? salario + PLUS:salario ;
        }
    }
}
