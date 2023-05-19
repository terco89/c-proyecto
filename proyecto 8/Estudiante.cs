using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_8
{
    internal class Estudiante:Entidad
    {
        //esta lista guarda las materias y calificaciones como se declara en la clase
        private Calificacion calificacion;
        private static Random rd;

        public Estudiante(string nombre,int edad, string genero, Calificacion calificacion) : base(nombre, edad, genero)
        {
            rd = new Random(10);
            this.calificacion = calificacion;
        }
        public Calificacion Calificacion
        {
            get { return this.calificacion; }
        }
        
        public bool seEncuentra()
        {
            int al = rd.Next(0, 9);
            if(al >= 4)
                return true;
            return false;
        }
    }
}
