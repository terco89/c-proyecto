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
        private List<Estudiante> estudiantes;
        private Profesor profesor;
        private string materia;

        public Aula(int id, int maxEstudiantes, string materia, Profesor profesor, List<Estudiante> estudiantes)
        {
            this.id = id;
            this.maxEstudiantes = maxEstudiantes;
            if (materia.ToUpper() == "MATEMÁTICAS" || materia.ToUpper() == "FILOSOFÍA" || materia.ToUpper() == "FÍSICA")
                this.materia = materia.ToLower();
            else
                this.materia = "desconocido";
            this.profesor = profesor;
            this.estudiantes = estudiantes;
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
        public List<Estudiante> Estudiantes
        {
            get { return estudiantes; }
        }
        public Profesor Profesor
        {
            get { return profesor; }
        }

        public int tomarAsistencia()
        {
            //contador de estudiantes
            int aE = 0;

            foreach (Estudiante e in estudiantes)
            {
                if (e.seEncuentra())
                    aE++;
            }
            return aE;
        }
        public int aprobadosChicos()
        {
            //contador aprobados
            int cA = 0;
            foreach(Estudiante e in estudiantes)
            {
                if (e.Calificacion.Nota > 5 && !e.Genero)
                {
                    cA++;
                }
            }
            return cA;
        }
        public int aprobadosChicas()
        {
            //contador aprobados
            int cA = 0;
            foreach (Estudiante e in estudiantes)
            {
                if (e.Calificacion.Nota > 5 && e.Genero)
                {
                    cA++;
                }
            }
            return cA;
        }
    }
}
