using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_8
{
    internal class Aula
    {
        private int id, maxEstudiantes;
        private string materia;

        public Aula(int id, int maxEstudiantes, string materia)
        {
            this.id = id;
            this.maxEstudiantes = maxEstudiantes;
            if (materia.ToUpper() == "MATEMÁTICAS" || materia.ToUpper() == "FILOSOFÍA" || materia.ToUpper() == "FÍSICA")
                this.materia = materia.ToLower();
            else
                this.materia = "desconocido";
        }

        public int Id
        {
            get { return id; }
        }
        public int MaxEstudiantes
        {
            get { return maxEstudiantes; }
        }
        public string Materia
        {
            get { return materia; }
        }

        public string puedeDarClases(List<Estudiante> estudiantes, List<Profesor> profesores)
        {
            //contador de estudiantes
            int aE = 0;
            bool aP;

            foreach (Estudiante e in estudiantes)
            {
                if (e.seEncuentra() && e.tieneMateria(materia))
                    aE++;
            }
            foreach (Profesor p in profesores)
            {
                if (p.seEncuentra() && p.Materia == materia)
                {
                    aP = true;
                    break;
                }
            }
            if(aE/estudiantes.Count() < 50)
        }
    }
}
