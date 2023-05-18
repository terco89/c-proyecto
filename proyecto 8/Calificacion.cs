using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_8
{
    internal class Calificacion
    {
        private string materia;
        private int nota;

        public Calificacion(string materia, int nota)
        {
            if (nota >= 0 && nota <= 10)
                this.nota = nota;
            else
                this.nota = nota;
            if (materia.ToUpper() == "MATEMÁTICAS" || materia.ToUpper() == "FILOSOFÍA" || materia.ToUpper() == "FÍSICA")
                this.materia = materia.ToLower();
            else
                this.materia = "desconocido";
        }

        public int Nota
        {
            get { return nota; }
            set { nota = value; }
        }
        public string Materia
        {
            get { return materia; }
        }
    }
}