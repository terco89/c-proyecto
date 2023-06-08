using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico__13
{
    internal class Comercial : Empleado
    {
        private double comision;
        public Comercial(double comision,string nombre, int salario, int edad) : base(nombre,salario,edad)
        {
            this.comision = comision;
        }

        public double Comision {
            get { return comision; }
        }
        public override void plus()
        {
            salario = edad > 30 && comision > 200 ? salario+PLUS:salario;
        }
    }
}
