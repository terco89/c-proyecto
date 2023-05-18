using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_8
{
    internal class Profesor : Entidad
    {
        private string materia;
        private int idAula;
        private Random rd = new Random();

        public Profesor(string nombre,int edad, string genero, string materia, int idAula) : base(nombre, edad, genero)
        {
            if (materia.ToUpper() == "MATEMÁTICAS" || materia.ToUpper() == "FILOSOFÍA" || materia.ToUpper() == "FÍSICA")
                this.materia = materia.ToLower();
            else
                this.materia = "desconocido";
            this.idAula = idAula;
        }

        public string Materia
        {
            get { return this.materia;}
        }
        public bool seEncuentra()
        {
            int al = rd.Next(0, 9);
            if (al >= 1)
                return true;
            return false;
        }
    }
}
