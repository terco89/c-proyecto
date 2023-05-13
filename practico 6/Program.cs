using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_6
{
    class Libro
    {
        private int num_pag = 0;
        private string titulo,autor,ISBN;

        public Libro(string ISBN, int num_pag, string titulo, string autor)
        {
            this.ISBN = ISBN;
            this.num_pag = num_pag;
            this.titulo = titulo;
            this.autor = autor;
        }
        public string isbn
        {
            get
            {
                return ISBN;
            }
            set
            {
                ISBN = value;
            }
        }
        public int Num_pag
        {
            get
            {
                return num_pag;
            }
            set
            {
                num_pag = value;
            }
        }
        public string Autor
        {
            get
            {
                return autor;
            }
            set
            {
                autor = value;
            }
        }
        public string Titulo
        {
            get
            {
                return titulo;
            }
            set
            {
                titulo = value;
            }
        }

        public string relativo()
        {
            return titulo+" con ISBN "+ISBN+" creado por "+autor+" tiene "+num_pag+" paginas";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("978-3-16-148410-0",20,"Caperucita roja","Desconocido");
            Libro libro2 = new Libro("928-3-26-819440-0",45,"La Republica","Platon");
            Console.WriteLine(libro1.relativo());
            Console.WriteLine(libro2.relativo());
            if(libro1.Num_pag > libro2.Num_pag)
            {
                Console.WriteLine("\n\n{0} tiene mas paginas",libro1.Titulo);
            }
            else
            {
                Console.WriteLine("\n\n{0} tiene mas paginas",libro2.Titulo);
            }
            Console.ReadKey();
        }
    }
}
