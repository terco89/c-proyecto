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
        private List<Calificacion> calificaciones = new List<Calificacion>();
        private List<int> idAulas = new List<int>();
        private Random rd = new Random();

        public Estudiante(string nombre,int edad, string genero, List<Calificacion> calificaciones, List<int> idAulas) : base(nombre, edad, genero)
        {
            this.calificaciones.AddRange(calificaciones);
            this.idAulas = idAulas;
        }
        public List<Calificacion> Calificaciones
        {
            get { return this.calificaciones; }
        }
        
        public List<int> IdAulas
        {
            get { return this.idAulas; }
        }
        
        public bool seEncuentra()
        {
            int al = rd.Next(0,10);
            if(al >= 4)
                return true;
            return false;
        }
        public bool tieneMateria(string materia)
        {
            foreach(Calificacion c in calificaciones)
            {
                if(c.Materia == materia)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
