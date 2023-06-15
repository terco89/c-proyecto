using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_16
{
    class Agenda
    {
        private List<Contacto> contactos;
        private int maxCon;

        public Agenda()
        {
            maxCon = 10;
            this.contactos = new List<Contacto>();
        }
        public Agenda(int cant)
        {
            maxCon = cant;
            this.contactos = new List<Contacto>();
        }

        public bool aniadirContacto(Contacto c)
        {
            if (existeContacto(c) || agendaLlena()) return false;
            contactos.Add(c);
            return true;
        }
        public bool existeContacto(Contacto c) {
            return contactos.Exists(v=>v.Nombre==c.Nombre) ? true : false;
        }
        public string listarContactos()
        {
            string conc = "Agenda";
            foreach(Contacto c in contactos)
            {
                conc += "\n\nNombre: "+c.Nombre+"\nTelefono: "+c.Telefono;
            }
            return contactos.Count() == 0 ? conc+"\n\nVacia":conc;
        }
        public int buscarContacto(string nombre)
        {
            return contactos.Exists(v=>v.Nombre==nombre) ? contactos.Find(v=>v.Nombre==nombre).Telefono:0;
        }
        public bool eliminarContacto(string nombre)
        {
            return contactos.Remove(contactos.Find(v=>v.Nombre==nombre));
        }
        public bool agendaLlena()
        {
            return contactos.Count() == maxCon ? true:false;
        }
        public int huecosLibres()
        {
            return maxCon-contactos.Count();
        }
    }
}
