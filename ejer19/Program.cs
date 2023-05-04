using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer19
{
    /*1. Crear un programa que calcule el promedio de un conjunto de números ingresados por el usuario.
2. Crear un programa que simule un cajero automático, permitiendo al usuario hacer depósitos, retiros y consultar su saldo.
3. Crear un programa que simule un juego de adivinanza de números, en el que el usuario debe adivinar un número generado aleatoriamente por el programa.
4. Crear un programa que genere una lista de números primos hasta un número ingresado por el usuario.
5. Crear un programa que simule un juego de ahorcado, en el que el usuario debe adivinar una palabra oculta letra por letra.
6. Crear un programa que permita al usuario ingresar una lista de tareas y organizarlas por orden de prioridad.
7. Crear un programa que permita al usuario ingresar una serie de números y determine cuál es el número más grande y cuál es el número más pequeño.
8. Crear un programa que simule una biblioteca, permitiendo al usuario buscar y prestar libros, y llevando un registro de los préstamos y devoluciones.
9. Crear un programa que permita al usuario calcular la distancia entre dos puntos en un plano cartesiano.
10. Crear un programa que permita al usuario convertir una cantidad de una unidad de medida a otra, por ejemplo, de metros a pies.*/
    class Menu
    {
        public string[] menu;
        public int posMenu = 0, der;
        public bool salir = false;
        public bool fin = false;
        public Menu(string[] menu, int der)
        {
            this.menu = menu;
            this.der = der;
        }
        public void pintarMenu()
        {
            Console.Clear();
            for (int i = 0; i < menu.Count(); i++)
            {
                Console.SetCursorPosition(der, i + 10);
                if (i == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write(menu[i]);
            }
        }
        public void bajarMenu()
        {
            if (posMenu < menu.Count() - 1)
            {
                Console.SetCursorPosition(der, posMenu + 10);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(menu[posMenu]);
                posMenu++;
                Console.SetCursorPosition(der, posMenu + 10);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(menu[posMenu]);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(der, posMenu + 10);
                Console.Write(menu[posMenu]);
                posMenu = 0;
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(der, posMenu + 10);
                Console.Write(menu[posMenu]);
            }
        }
        public void subirMenu()
        {
            if (posMenu > 0)
            {
                Console.SetCursorPosition(der, posMenu + 10);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(menu[posMenu]);
                posMenu--;
                Console.SetCursorPosition(der, posMenu + 10);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(menu[posMenu]);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(der, posMenu + 10);
                Console.Write(menu[posMenu]);
                posMenu = menu.Count() - 1;
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(der, posMenu + 10);
                Console.Write(menu[posMenu]);
            }
        }
    }
    class Libro
    {
        public string nombre = "";
        public bool estado = true;
        public Libro(string nombre)
        {
            this.nombre = nombre;
        }
    }
    internal class Program
    {
        static void errormsg(string msg, int x, int y)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void borrarline(string esp, string con)
        {
            esp = "";
            for (int i = 0; i < con.Length; i++)
            {
                esp += " ";
            }
            Console.SetCursorPosition(30, 12);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(esp);
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void Main(string[] args)
        {
            string[] menu = {
                "            Promedio de un conjunto         ",
                "            Cajero automatico               ",
                "            Juego de adivinanza             ",
                "            Numeros primos                  ",
                "            Juego de ahorcado               ",
                "            Lista de tareas                 ",
                "            Mas grande y pequeño            ",
                "            Biblioteca                      ",
                "            Plano cartesiano                ",
                "            Convertidor de medidas          ",
                "            Salir                           "
            };
            string[] cajero =
            {
                "            Depositar dinero                ",
                "            Retirar dinero                  ",
                "            Consultar saldo                 ",
                "            Volver al menu                  "
            };
            string[] biblioteca =
            {
                "            Libros disponibles              ",
                "            Pedir prestado un libro         ",
                "            Devolver un libro               ",
                "            Volver al menu                  "
            };
            string[] lista =
            {
                "            Ver tareas                      ",
                "            Nueva tarea                     ",
                "            Mover tarea                     ",
                "            Volver al menu                  "
            };
            string[] conversion =
            {
                "            Metros a pies                   ",
                "            Pies a metros                   ",
                "            Gramos a libras                 ",
                "            Libras a gramos                 ",
                "            Centimetros a pulgadas          ",
                "            Pulgadas a centimetros          ",
                "            Volver                          "
            };
            List<List<string>> palabras = new List<List<string>> { new List<string> { "c", "o", "m", "p", "u", "t", "a", "d", "o", "r", "a" }, new List<string> { "c", "e", "p", "i", "l", "l", "o" }, new List<string> { "s", "e", "r", "r", "u", "c", "h", "o" }, new List<string> { "d", "i", "o", "s" } };
            int saldo = 1000;
            bool api = false;
            ConsoleKeyInfo tecla;
            List<Menu> menus = new List<Menu> { new Menu(menu, 30), new Menu(cajero, 30), new Menu(conversion, 30), new Menu(biblioteca, 30), new Menu(lista, 30) };
            List<Libro> libros = new List<Libro> { new Libro("pinocho"), new Libro("rapunzel"), new Libro("aladin"), new Libro("cenicienta") };
            List<List<string>> tareas = new List<List<string>> { new List<string> { }, new List<string> { } };
            Random rd = new Random();

            while (true)
            {
                if (menus[0].fin == true)
                {
                    break;
                }
                Console.CursorVisible = false;
                menus[0].salir = false;
                menus[0].posMenu = 0;
                menus[0].pintarMenu();
                while (true)
                {
                    if (menus[0].salir == true)
                    {
                        break;
                    }
                    tecla = Console.ReadKey(true);
                    if (tecla.Key == ConsoleKey.DownArrow)
                    {
                        menus[0].bajarMenu();
                    }
                    if (tecla.Key == ConsoleKey.UpArrow)
                    {
                        menus[0].subirMenu();
                    }
                    if (tecla.Key == ConsoleKey.Enter)
                    {
                        while (true)
                        {
                            int valor = 0;
                            string esp = "", con = "";
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.SetCursorPosition(30, 10);
                            Console.CursorVisible = true;
                            if (menus[0].salir == true)
                            {
                                break;
                            }
                            if (menus[0].posMenu == 0)
                            {
                                Console.WriteLine("Ingrese la cantidad de numeros enteros que contendra el conjunto (max 20 y min 5):");
                                while (true)
                                {
                                    if (esp == " ")
                                    {
                                        borrarline(esp, con);
                                    }
                                    Console.SetCursorPosition(30, 12);
                                    con = Console.ReadLine();
                                    if (Int32.TryParse(con, out valor) == false || (valor < 5 || valor > 20))
                                    {
                                        errormsg("Error: el número ingresado es mayor o menor a los limites, o no es un entero", 30, 15);
                                        esp = " ";
                                    }
                                    else
                                    {
                                        esp = "";
                                        break;
                                    }
                                }
                                int sum = 0, num = 0;
                                Console.Clear();
                                Console.SetCursorPosition(30, 10);
                                Console.WriteLine("Ingrese un numero:");
                                for (int i = 0; i < valor; i++)
                                {
                                    while (true)
                                    {
                                        if (esp == " ")
                                        {
                                            borrarline(esp, con);
                                        }
                                        Console.SetCursorPosition(30, 12);
                                        con = Console.ReadLine();
                                        if (Int32.TryParse(con, out num) == false)
                                        {
                                            errormsg("Error: el número ingresado no es entero", 30, 15);
                                            esp = " ";
                                        }
                                        else
                                        {
                                            esp = "";
                                            for (int j = 0; j < con.Length; j++)
                                            {
                                                esp += " ";
                                            }
                                            Console.SetCursorPosition(30, 12);
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.Write(esp);
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.SetCursorPosition(30, 15);
                                            Console.Write("                                                           ");
                                            sum += num;
                                            break;
                                        }
                                    }
                                }
                                Console.Clear();
                                Console.SetCursorPosition(30, 10);
                                Console.WriteLine("El promedio es: {0}", sum / valor);
                            }
                            if (menus[0].posMenu == 1)
                            {
                                while (true)
                                {
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.ForegroundColor = ConsoleColor.White;
                                    menus[1].pintarMenu();
                                    menus[1].posMenu = 0;
                                    menus[1].salir = false;
                                    Console.CursorVisible = false;

                                    if (menus[1].fin == true)
                                    {
                                        break;
                                    }
                                    while (true)
                                    {
                                        if (menus[1].salir == true)
                                        {
                                            break;
                                        }
                                        tecla = Console.ReadKey(true);
                                        if (tecla.Key == ConsoleKey.DownArrow)
                                        {
                                            menus[1].bajarMenu();
                                        }
                                        if (tecla.Key == ConsoleKey.UpArrow)
                                        {
                                            menus[1].subirMenu();
                                        }
                                        if (tecla.Key == ConsoleKey.Enter)
                                        {
                                            while (true)
                                            {
                                                Console.BackgroundColor = ConsoleColor.Black;
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.CursorVisible = true;
                                                Console.Clear();
                                                Console.SetCursorPosition(30, 10);
                                                valor = 0;
                                                esp = "";
                                                con = "";
                                                if (menus[1].salir == true)
                                                {
                                                    break;
                                                }
                                                if (menus[1].posMenu == 0)
                                                {
                                                    Console.WriteLine("Ingrese la cantidad de dinero a depositar en pesos:");
                                                    while (true)
                                                    {
                                                        if (esp == " ")
                                                        {
                                                            borrarline(esp, con);
                                                        }
                                                        Console.SetCursorPosition(30, 12);
                                                        con = Console.ReadLine();
                                                        if (Int32.TryParse(con, out valor) == false || valor <= 0)
                                                        {
                                                            errormsg("Error: No se ha podido realizar el deposito. Vuelva aa intentarlo", 30, 15);
                                                            esp = " ";
                                                        }
                                                        else
                                                        {
                                                            saldo += valor;
                                                            break;
                                                        }
                                                    }
                                                    Console.Clear();
                                                    Console.SetCursorPosition(30, 10);
                                                    Console.WriteLine("Su deposito de {0} pesos a sido exitoso", valor);
                                                    Console.SetCursorPosition(30, 11);
                                                    Console.WriteLine("Actualmente tiene en su cuenta {0} pesos", saldo);
                                                }
                                                if (menus[1].posMenu == 1)
                                                {
                                                    Console.WriteLine("Ingrese la cantidad de dinero a retirar en pesos:");
                                                    while (true)
                                                    {
                                                        if (esp == " ")
                                                        {
                                                            borrarline(esp, con);
                                                        }
                                                        Console.SetCursorPosition(30, 12);
                                                        con = Console.ReadLine();
                                                        if (Int32.TryParse(con, out valor) == false || valor <= 0 || saldo - valor < 0)
                                                        {
                                                            errormsg("Error: No se ha podido realizar el retiro. Vuelva a intentarlo", 30, 15);
                                                            esp = " ";
                                                        }
                                                        else
                                                        {
                                                            saldo -= valor;
                                                            break;
                                                        }
                                                    }
                                                    Console.Clear();
                                                    Console.SetCursorPosition(30, 10);
                                                    Console.WriteLine("Su retiro de {0} pesos a sido exitoso", valor);
                                                    Console.SetCursorPosition(30, 11);
                                                    Console.WriteLine("Actualmente tiene en su cuenta {0} pesos", saldo);
                                                }
                                                if (menus[1].posMenu == 2)
                                                {
                                                    Console.WriteLine("Su saldo actual es de {0} pesos", saldo);
                                                }
                                                if (menus[1].posMenu == 3)
                                                {
                                                    menus[1].salir = true;
                                                    menus[1].fin = true;
                                                    break;
                                                }
                                                Console.SetCursorPosition(0, 24);
                                                Console.WriteLine("Presione v para volver al cajero o r para volver a realizar la acción...");
                                                ConsoleKeyInfo opa;
                                                while (true)
                                                {
                                                    opa = Console.ReadKey(true);
                                                    if (opa.Key == ConsoleKey.V)
                                                    {
                                                        menus[1].salir = true;
                                                        break;
                                                    }
                                                    if (opa.Key == ConsoleKey.R)
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            if (menus[0].posMenu == 2)
                            {
                                int intentos = 0;
                                int ac = rd.Next(1, 100);
                                Console.Write("Adivina adivinador ¿En que numero estoy pensando yo?");
                                Console.SetCursorPosition(30, 18);
                                Console.Write("PD: El número esta entre el 1 y el 100");
                                while (true)
                                {
                                    if (esp == " ")
                                    {
                                        borrarline(esp, con);
                                    }
                                    Console.SetCursorPosition(30, 12);
                                    con = Console.ReadLine();
                                    if (Int32.TryParse(con, out valor) == false || valor > 100 || valor < 1)
                                    {
                                        errormsg("El valor ingresado no es correcto. Vuelve a intentarlo", 30, 15);
                                    }
                                    else
                                    {
                                        intentos++;
                                        if (ac == valor)
                                        {
                                            break;
                                        }
                                        Console.SetCursorPosition(0, 13);
                                        Console.Write("No ese no es :(");
                                        Console.SetCursorPosition(0, 14);
                                        if (valor - ac < 0)
                                        {
                                            Console.Write("Es mayor a {0} ;)", valor);
                                        }
                                        else
                                        {
                                            Console.Write("Es menor a {0} ;)", valor);
                                        }
                                    }
                                    esp = " ";
                                }
                                Console.Clear();
                                Console.SetCursorPosition(30, 10);
                                Console.WriteLine("Felicidades lo conseguiste!!");
                                Console.SetCursorPosition(30, 12);
                                if (intentos == 1)
                                {
                                    Console.WriteLine("Y EN TAN SOLO UN INTENTO, IMPOSIBLE :O");
                                }
                                else
                                {
                                    Console.WriteLine("Intentos: {0}. Podras hacerlo mejor?", intentos);
                                }
                            }
                            if (menus[0].posMenu == 3)
                            {
                                Console.WriteLine("Ingrese la cantidad de numeros primos");
                                while (true)
                                {
                                    if (esp == " ")
                                    {
                                        borrarline(esp, con);
                                    }
                                    Console.SetCursorPosition(30, 12);
                                    con = Console.ReadLine();
                                    if (Int32.TryParse(con, out valor) == false || valor < 1)
                                    {
                                        errormsg("El valor ingresado no es valido. Vuelva a intentarlo", 30, 15);
                                        esp = " ";
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                Console.Clear();
                                Console.SetCursorPosition(30, 10);
                                Console.WriteLine("{0} números primos", valor);
                                Console.SetCursorPosition(30, 11);
                                int cont = 3, y = 1;
                                List<int> primos = new List<int> { 2 };

                                for (int i = 0; i < valor; i++)
                                {

                                    double ci = cont, puente;
                                    int j = 0;
                                    while (true)
                                    {
                                        puente = ci;
                                        ci /= primos[j];
                                        if (ci == Convert.ToInt32(ci))
                                        {
                                            if (ci == 1)
                                            {
                                                cont++;
                                                i--;
                                                break;
                                            }
                                        }
                                        else if (j < primos.Count - 1)
                                        {
                                            ci = puente;
                                            j++;
                                        }
                                        else
                                        {
                                            primos.Add(cont);
                                            Console.Write("{0},", cont);
                                            cont++;
                                            break;
                                        }
                                    }
                                }
                            }
                            if (menus[0].posMenu == 4)
                            {
                                List<string> palabra = palabras[rd.Next(0, palabras.Count - 1)];
                                List<string> usadas = new List<string> { };
                                List<string> nrepeat = new List<string> { palabra[0] };
                                Console.WriteLine("Ingrese una letra");
                                int v = 6;
                                int cor = 0;
                                bool res = false;
                                Console.SetCursorPosition(30, 17);
                                for (int i = 0; i < palabra.Count; i++)
                                {
                                    Console.Write("_");
                                    for (int j = 0; j < nrepeat.Count; j++)
                                    {
                                        if (palabra[i] == nrepeat[j])
                                        {
                                            break;
                                        }
                                        else if (j == nrepeat.Count - 1)
                                        {
                                            nrepeat.Add(palabra[i]);
                                        }
                                    }
                                }
                                while (true)
                                {
                                    if (esp == " ")
                                    {
                                        borrarline(esp, con);
                                    }
                                    Console.SetCursorPosition(30, 12);
                                    con = Console.ReadLine();
                                    if (Int32.TryParse(con, out valor) == true || con.Length > 1)
                                    {
                                        errormsg("El valor ingresado no es valido. Vuelve a intentarlo", 30, 15);
                                    }
                                    else
                                    {
                                        Console.SetCursorPosition(30, 15);
                                        Console.Write("                                                        ");
                                        bool bandera = true;
                                        for (int i = 0; i < usadas.Count; i++)
                                        {
                                            if (con == usadas[i])
                                            {
                                                bandera = false;
                                                Console.SetCursorPosition(0, 13);
                                                Console.Write("Ya se uso esa letra ");
                                                break;
                                            }
                                        }
                                        if (bandera == true)
                                        {
                                            bandera = false;
                                            for (int i = 0; i < palabra.Count; i++)
                                            {
                                                if (con == palabra[i])
                                                {
                                                    bandera = true;
                                                    Console.SetCursorPosition(30 + i, 17);
                                                    Console.Write(con);
                                                }
                                            }
                                            if (bandera == true)
                                            {
                                                cor++;
                                                if (cor == nrepeat.Count)
                                                {
                                                    res = true;
                                                    break;
                                                }
                                                Console.SetCursorPosition(0, 13);
                                                Console.Write("Correcto sigue asi! ");
                                            }
                                            else
                                            {
                                                Console.SetCursorPosition(0, 13);
                                                Console.Write("No esta esa letra :(");
                                                Console.SetCursorPosition(0, 14);
                                                v--;
                                                Console.Write("Te quedan {0} intentos", v);
                                                if (v == 0)
                                                {
                                                    break;
                                                }
                                            }
                                            usadas.Add(con);
                                        }
                                    }
                                    esp = " ";
                                }
                                Console.Clear();
                                Console.SetCursorPosition(30, 10);
                                string final = "";
                                for (int i = 0; i < palabra.Count; i++)
                                {
                                    final += palabra[i];
                                }
                                if (res == true)
                                {
                                    Console.WriteLine("Ganaste!! era {0}", final);
                                }
                                else
                                {
                                    Console.WriteLine("Perdiste :( era {0}", final);
                                }
                            }
                            if (menus[0].posMenu == 5)
                            {
                                while (true)
                                {
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.ForegroundColor = ConsoleColor.White;
                                    menus[4].pintarMenu();
                                    menus[4].posMenu = 0;
                                    menus[4].salir = false;
                                    Console.CursorVisible = false;

                                    if (menus[4].fin == true)
                                    {
                                        break;
                                    }
                                    while (true)
                                    {
                                        if (menus[4].salir == true)
                                        {
                                            break;
                                        }
                                        tecla = Console.ReadKey(true);
                                        if (tecla.Key == ConsoleKey.DownArrow)
                                        {
                                            menus[4].bajarMenu();
                                        }
                                        if (tecla.Key == ConsoleKey.UpArrow)
                                        {
                                            menus[4].subirMenu();
                                        }
                                        if (tecla.Key == ConsoleKey.Enter)
                                        {
                                            while (true)
                                            {
                                                Console.BackgroundColor = ConsoleColor.Black;
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.CursorVisible = true;
                                                Console.Clear();
                                                Console.SetCursorPosition(30, 10);
                                                valor = 0;
                                                esp = "";
                                                con = "";
                                                if (menus[4].salir == true)
                                                {
                                                    break;
                                                }
                                                if (menus[4].posMenu == 0)
                                                {
                                                    Console.WriteLine("Tareas:");
                                                    Console.SetCursorPosition(30, 11);
                                                    Console.WriteLine("IMPORTANTES:");
                                                    int y = 0;
                                                    for (int i = 0; i < tareas[0].Count; i++)
                                                    {
                                                        Console.SetCursorPosition(30, 12 + i);
                                                        Console.Write(tareas[0][i]);
                                                        y += 1;
                                                    }
                                                    Console.SetCursorPosition(30, 14 + y);
                                                    Console.WriteLine("No tan importantes:");
                                                    for (int i = 0; i < tareas[1].Count; i++)
                                                    {
                                                        Console.SetCursorPosition(30, 11 + i + 1);
                                                        Console.Write(tareas[1][i]);
                                                    }
                                                }

                                                if (menus[4].posMenu == 1)
                                                {
                                                    Console.WriteLine("Ingrese el nombre de nueva tarea:");
                                                    while (true)
                                                    {
                                                        if (esp == " ")
                                                        {
                                                            borrarline(esp, con);
                                                        }
                                                        Console.SetCursorPosition(30, 12);
                                                        con = Console.ReadLine();
                                                        tareas[1].Add(con);
                                                        break;

                                                    }
                                                    Console.Clear();
                                                    Console.SetCursorPosition(30, 10);
                                                    Console.WriteLine("Se subio la tarea {0}", con);
                                                }
                                                if (menus[4].posMenu == 2)
                                                {
                                                    string tarea;
                                                    bool accion = false;
                                                    Console.WriteLine("¿Que tarea desea mover?");
                                                    while (true)
                                                    {
                                                        if (esp == " ")
                                                        {
                                                            borrarline(esp, con);
                                                        }
                                                        Console.SetCursorPosition(30, 12);
                                                        con = Console.ReadLine();
                                                        tarea = tareas[1].Find(p => p == con);
                                                        if (tarea == null)
                                                        {
                                                            tarea = tareas[0].Find(p => p == con);
                                                            if (tarea == null)
                                                            {
                                                                errormsg("Esa tarea no existe", 30, 15);
                                                                esp = " ";
                                                            }
                                                            else
                                                            {
                                                                tareas[0].Remove(tareas[0].Find(p => p == tarea));
                                                                tareas[1].Add(tarea);
                                                                accion = true;
                                                                break;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            tareas[1].Remove(tareas[0].Find(p => p == tarea));
                                                            tareas[0].Add(tarea);
                                                            accion = false;
                                                            break;
                                                        }
                                                    }
                                                    Console.Clear();
                                                    Console.SetCursorPosition(30, 10);
                                                    if (accion)
                                                    {
                                                        Console.Write("La tarea {0} se movio a no tan importante", tarea);
                                                    }
                                                    else
                                                    {
                                                        Console.Write("La tarea {0} se movio a IMPORTANTE", tarea);

                                                    }
                                                }
                                                if (menus[4].posMenu == 3)
                                                {
                                                    menus[4].salir = true;
                                                    menus[4].fin = true;
                                                    break;
                                                }
                                                Console.SetCursorPosition(0, 24);
                                                Console.WriteLine("Presione v para volver al cajero o r para volver a realizar la acción...");
                                                ConsoleKeyInfo opa;
                                                while (true)
                                                {
                                                    opa = Console.ReadKey(true);
                                                    if (opa.Key == ConsoleKey.V)
                                                    {
                                                        menus[4].salir = true;
                                                        break;
                                                    }
                                                    if (opa.Key == ConsoleKey.R)
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            if (menus[0].posMenu == 6)
                            {
                                Console.WriteLine("Ingrese la cantidad de numeros que contendra el conjunto (max 20 y min 5):");
                                while (true)
                                {
                                    if (esp == " ")
                                    {
                                        borrarline(esp, con);
                                    }
                                    Console.SetCursorPosition(30, 12);
                                    con = Console.ReadLine();
                                    if (Int32.TryParse(con, out valor) == false || (valor < 5 || valor > 20))
                                    {
                                        errormsg("Error: el número ingresado es mayor o menor a los limites, o no es un entero", 30, 15);
                                        esp = " ";
                                    }
                                    else
                                    {
                                        esp = "";
                                        break;
                                    }
                                }
                                List<int> nums = new List<int> { };
                                int num = 0;
                                Console.Clear();
                                Console.SetCursorPosition(30, 10);
                                Console.WriteLine("Ingrese un numero:");
                                for (int i = 0; i < valor; i++)
                                {
                                    while (true)
                                    {
                                        if (esp == " ")
                                        {
                                            borrarline(esp, con);
                                        }
                                        Console.SetCursorPosition(30, 12);
                                        con = Console.ReadLine();
                                        if (Int32.TryParse(con, out num) == false)
                                        {
                                            errormsg("Error: el número ingresado no es entero", 30, 15);
                                            esp = " ";
                                        }
                                        else
                                        {
                                            esp = "";
                                            for (int j = 0; j < con.Length; j++)
                                            {
                                                esp += " ";
                                            }
                                            Console.SetCursorPosition(30, 12);
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.Write(esp);
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.SetCursorPosition(30, 15);
                                            Console.Write("                                                           ");
                                            nums.Add(num);
                                            break;
                                        }
                                    }
                                }
                                int max = nums[0], min = nums[1];
                                foreach (int n in nums)
                                {
                                    if (max < n)
                                    {
                                        max = n;
                                    }
                                    if (min > n)
                                    {
                                        min = n;
                                    }
                                }
                                Console.Clear();
                                Console.SetCursorPosition(30, 10);
                                Console.WriteLine("El número más grande es {0} y el mas pequeño es {1}", max, min);
                            }
                            if (menus[0].posMenu == 7)
                            {
                                while (true)
                                {
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.ForegroundColor = ConsoleColor.White;
                                    menus[3].pintarMenu();
                                    menus[3].posMenu = 0;
                                    menus[3].salir = false;
                                    Console.CursorVisible = false;

                                    if (menus[3].fin == true)
                                    {
                                        break;
                                    }
                                    while (true)
                                    {
                                        if (menus[3].salir == true)
                                        {
                                            break;
                                        }
                                        tecla = Console.ReadKey(true);
                                        if (tecla.Key == ConsoleKey.DownArrow)
                                        {
                                            menus[3].bajarMenu();
                                        }
                                        if (tecla.Key == ConsoleKey.UpArrow)
                                        {
                                            menus[3].subirMenu();
                                        }
                                        if (tecla.Key == ConsoleKey.Enter)
                                        {
                                            while (true)
                                            {
                                                Console.BackgroundColor = ConsoleColor.Black;
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.CursorVisible = true;
                                                Console.Clear();
                                                Console.SetCursorPosition(30, 10);
                                                valor = 0;
                                                esp = "";
                                                con = "";
                                                if (menus[3].salir == true)
                                                {
                                                    break;
                                                }
                                                if (menus[3].posMenu == 0)
                                                {
                                                    Console.WriteLine("Libros:");

                                                    string est = "";
                                                    for (int i = 0; i < libros.Count; i++)
                                                    {
                                                        if (libros[i].estado == true)
                                                        {
                                                            est = "disponible";
                                                        }
                                                        else
                                                        {
                                                            est = "en posesión";
                                                        }
                                                        Console.SetCursorPosition(30, 10 + i + 1);
                                                        Console.Write(libros[i].nombre + " " + est);
                                                    }
                                                }

                                                if (menus[3].posMenu == 1)
                                                {
                                                    Libro libro;
                                                    Console.WriteLine("¿Que libro desea llevar?");
                                                    while (true)
                                                    {
                                                        if (esp == " ")
                                                        {
                                                            borrarline(esp, con);
                                                        }
                                                        Console.SetCursorPosition(30, 12);
                                                        con = Console.ReadLine();
                                                        libro = libros.Find(p => p.nombre == con);
                                                        if (libro == null)
                                                        {
                                                            errormsg("No tengo ese libro. Vuelve a intentarlo", 30, 15);
                                                            esp = " ";
                                                        }
                                                        else
                                                        {
                                                            libros.Find(p => p.nombre == con).estado = false;
                                                            break;
                                                        }
                                                    }
                                                    Console.Clear();
                                                    Console.SetCursorPosition(30, 10);
                                                    Console.WriteLine("Se le presto el libro {0}, no se olvide de devolverlo!", libro.nombre);
                                                }
                                                if (menus[3].posMenu == 2)
                                                {
                                                    Libro libro;
                                                    Console.WriteLine("¿Que libro va a devolver?");
                                                    while (true)
                                                    {
                                                        if (esp == " ")
                                                        {
                                                            borrarline(esp, con);
                                                        }
                                                        Console.SetCursorPosition(30, 12);
                                                        con = Console.ReadLine();
                                                        libro = libros.Find(p => p.nombre == con);
                                                        if (libro == null)
                                                        {
                                                            errormsg("No posees ese libro. Vuelve a intentarlo", 30, 15);
                                                            esp = " ";
                                                        }
                                                        else
                                                        {
                                                            libros.Find(p => p.nombre == con).estado = true;
                                                            break;
                                                        }
                                                    }
                                                    Console.Clear();
                                                    Console.SetCursorPosition(30, 10);
                                                    Console.WriteLine("Devolvio el libro {0}, muchas gracias!", libro.nombre);
                                                }
                                                if (menus[3].posMenu == 3)
                                                {
                                                    menus[3].salir = true;
                                                    menus[3].fin = true;
                                                    break;
                                                }
                                                Console.SetCursorPosition(0, 24);
                                                Console.WriteLine("Presione v para volver al cajero o r para volver a realizar la acción...");
                                                ConsoleKeyInfo opa;
                                                while (true)
                                                {
                                                    opa = Console.ReadKey(true);
                                                    if (opa.Key == ConsoleKey.V)
                                                    {
                                                        menus[3].salir = true;
                                                        break;
                                                    }
                                                    if (opa.Key == ConsoleKey.R)
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            if (menus[0].posMenu == 8)
                            {
                                List<int> ns = new List<int> { 0, 0, 0, 0 };
                                for (int i = 0; i < 2; i++)
                                {
                                    Console.Clear();
                                    Console.SetCursorPosition(30, 10);
                                    Console.WriteLine("Punto n°{0}", i + 1);
                                    Console.SetCursorPosition(30, 11);
                                    Console.WriteLine("Ingrese un número entero para x:");
                                    while (true)
                                    {
                                        if (esp == " ")
                                        {
                                            borrarline(esp, con);
                                        }
                                        Console.SetCursorPosition(30, 12);
                                        con = Console.ReadLine();
                                        if (Int32.TryParse(con, out valor) == false)
                                        {
                                            errormsg("Error: el valor ingresado no es valido", 30, 15);
                                            esp = " ";
                                        }
                                        else
                                        {
                                            ns[i] = valor;
                                            esp = "";
                                            break;
                                        }
                                    }
                                    Console.Clear();
                                    Console.SetCursorPosition(30, 10);
                                    Console.Write("Punto n°{0}", i + 1);
                                    Console.SetCursorPosition(30, 11);
                                    Console.Write("Ahora ingrese un número entero para y:");
                                    while (true)
                                    {
                                        if (esp == " ")
                                        {
                                            borrarline(esp, con);
                                        }
                                        Console.SetCursorPosition(30, 12);
                                        con = Console.ReadLine();
                                        if (Int32.TryParse(con, out valor) == false)
                                        {
                                            errormsg("Error: el valor ingresado no es valido", 30, 15);
                                            esp = " ";
                                        }
                                        else
                                        {
                                            ns[i + 2] = valor;
                                            esp = "";
                                            break;
                                        }
                                    }
                                }
                                Console.Clear();
                                Console.SetCursorPosition(30, 10);
                                double resultado = Math.Sqrt((ns[2] - ns[0]) * (ns[2] - ns[0]) + (ns[3] - ns[1]) * (ns[3] - ns[1]));
                                Console.WriteLine("La distancia entre el punto ({0};{1}) y el punto ({2};{3}) es {4}", ns[0], ns[2], ns[1], ns[3], resultado);
                            }
                            if (menus[0].posMenu == 9)
                            {
                                while (true)
                                {
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.ForegroundColor = ConsoleColor.White;
                                    menus[2].pintarMenu();
                                    menus[2].posMenu = 0;
                                    menus[2].salir = false;
                                    Console.CursorVisible = false;

                                    if (menus[2].fin == true)
                                    {
                                        break;
                                    }
                                    while (true)
                                    {
                                        if (menus[2].salir == true)
                                        {
                                            break;
                                        }
                                        tecla = Console.ReadKey(true);
                                        if (tecla.Key == ConsoleKey.DownArrow)
                                        {
                                            menus[2].bajarMenu();
                                        }
                                        if (tecla.Key == ConsoleKey.UpArrow)
                                        {
                                            menus[2].subirMenu();
                                        }
                                        if (tecla.Key == ConsoleKey.Enter)
                                        {
                                            while (true)
                                            {
                                                Console.BackgroundColor = ConsoleColor.Black;
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.CursorVisible = true;
                                                Console.Clear();
                                                Console.SetCursorPosition(30, 10);
                                                valor = 0;
                                                esp = "";
                                                con = "";
                                                if (menus[2].salir == true)
                                                {
                                                    break;
                                                }
                                                if (menus[2].posMenu == 0)
                                                {
                                                    Console.WriteLine("Ingrese un valor en metros:");
                                                    while (true)
                                                    {
                                                        if (esp == " ")
                                                        {
                                                            borrarline(esp, con);
                                                        }
                                                        Console.SetCursorPosition(30, 12);
                                                        con = Console.ReadLine();
                                                        if (Int32.TryParse(con, out valor) == false || valor <= 0)
                                                        {
                                                            errormsg("Error: Valor incorrecto. Vuelva a intentarlo", 30, 15);
                                                            esp = " ";
                                                        }
                                                        else
                                                        {
                                                            break;
                                                        }
                                                    }
                                                    Console.Clear();
                                                    Console.SetCursorPosition(30, 10);
                                                    double resultado = valor * 3.28084;
                                                    Console.WriteLine("{0}m equivalen a {1}ft", valor, resultado); ;
                                                }
                                                if (menus[2].posMenu == 1)
                                                {
                                                    Console.WriteLine("Ingrese un valor en pies:");
                                                    while (true)
                                                    {
                                                        if (esp == " ")
                                                        {
                                                            borrarline(esp, con);
                                                        }
                                                        Console.SetCursorPosition(30, 12);
                                                        con = Console.ReadLine();
                                                        if (Int32.TryParse(con, out valor) == false || valor <= 0)
                                                        {
                                                            errormsg("Error: Valor incorrecto. Vuelva a intentarlo", 30, 15);
                                                            esp = " ";
                                                        }
                                                        else
                                                        {
                                                            break;
                                                        }
                                                    }
                                                    Console.Clear();
                                                    Console.SetCursorPosition(30, 10);
                                                    double resultado = valor * 0.3048;
                                                    Console.WriteLine("{0}ft equivalen a {1}m", valor, resultado);
                                                }
                                                if (menus[2].posMenu == 2)
                                                {
                                                    Console.WriteLine("Ingrese un valor en gramos:");
                                                    while (true)
                                                    {
                                                        if (esp == " ")
                                                        {
                                                            borrarline(esp, con);
                                                        }
                                                        Console.SetCursorPosition(30, 12);
                                                        con = Console.ReadLine();
                                                        if (Int32.TryParse(con, out valor) == false || valor <= 0)
                                                        {
                                                            errormsg("Error: Valor incorrecto. Vuelva a intentarlo", 30, 15);
                                                            esp = " ";
                                                        }
                                                        else
                                                        {
                                                            break;
                                                        }
                                                    }
                                                    Console.Clear();
                                                    Console.SetCursorPosition(30, 10);
                                                    double resultado = valor * 0.00220462;
                                                    Console.WriteLine("{0}gr equivalen a {1}lb", valor, resultado);
                                                }
                                                if (menus[2].posMenu == 3)
                                                {
                                                    Console.WriteLine("Ingrese un valor en libras:");
                                                    while (true)
                                                    {
                                                        if (esp == " ")
                                                        {
                                                            borrarline(esp, con);
                                                        }
                                                        Console.SetCursorPosition(30, 12);
                                                        con = Console.ReadLine();
                                                        if (Int32.TryParse(con, out valor) == false || valor <= 0)
                                                        {
                                                            errormsg("Error: Valor incorrecto. Vuelva a intentarlo", 30, 15);
                                                            esp = " ";
                                                        }
                                                        else
                                                        {
                                                            break;
                                                        }
                                                    }
                                                    Console.Clear();
                                                    Console.SetCursorPosition(30, 10);
                                                    double resultado = valor * 453.592;
                                                    Console.WriteLine("{0}lb equivalen a {1}gr", valor, resultado);
                                                }
                                                if (menus[2].posMenu == 4)
                                                {
                                                    Console.WriteLine("Ingrese un valor en centimetros:");
                                                    while (true)
                                                    {
                                                        if (esp == " ")
                                                        {
                                                            borrarline(esp, con);
                                                        }
                                                        Console.SetCursorPosition(30, 12);
                                                        con = Console.ReadLine();
                                                        if (Int32.TryParse(con, out valor) == false || valor <= 0)
                                                        {
                                                            errormsg("Error: Valor incorrecto. Vuelva a intentarlo", 30, 15);
                                                            esp = " ";
                                                        }
                                                        else
                                                        {
                                                            break;
                                                        }
                                                    }
                                                    Console.Clear();
                                                    Console.SetCursorPosition(30, 10);
                                                    double resultado = valor * 0.393701;
                                                    Console.WriteLine("{0}cm equivalen a {1}pul", valor, resultado);
                                                }
                                                if (menus[2].posMenu == 5)
                                                {
                                                    Console.WriteLine("Ingrese un valor en pulgadas:");
                                                    while (true)
                                                    {
                                                        if (esp == " ")
                                                        {
                                                            borrarline(esp, con);
                                                        }
                                                        Console.SetCursorPosition(30, 12);
                                                        con = Console.ReadLine();
                                                        if (Int32.TryParse(con, out valor) == false || valor <= 0)
                                                        {
                                                            errormsg("Error: Valor incorrecto. Vuelva a intentarlo", 30, 15);
                                                            esp = " ";
                                                        }
                                                        else
                                                        {
                                                            break;
                                                        }
                                                    }
                                                    Console.Clear();
                                                    Console.SetCursorPosition(30, 10);
                                                    double resultado = valor * 2.54;
                                                    Console.WriteLine("{0}pul equivalen a {1}cm", valor, resultado);
                                                }
                                                if (menus[2].posMenu == 6)
                                                {
                                                    menus[2].salir = true;
                                                    menus[2].fin = true;
                                                    break;
                                                }
                                                Console.SetCursorPosition(0, 24);
                                                Console.WriteLine("Presione v para volver al cajero o r para volver a realizar la acción...");
                                                ConsoleKeyInfo opa;
                                                while (true)
                                                {
                                                    opa = Console.ReadKey(true);
                                                    if (opa.Key == ConsoleKey.V)
                                                    {
                                                        menus[2].salir = true;
                                                        break;
                                                    }
                                                    if (opa.Key == ConsoleKey.R)
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            if (menus[0].posMenu == 10)
                            {
                                menus[0].fin = true;
                                menus[0].salir = true;
                                break;
                            }
                            if (menus[1].fin == true || menus[2].fin == true || menus[3].fin == true || menus[4].fin == true)
                            {
                                menus[0].salir = true;
                                menus[1].fin = false;
                                menus[2].fin = false;
                                menus[3].fin = false;
                                menus[4].fin = false;
                                break;
                            }
                            Console.SetCursorPosition(0, 24);
                            Console.WriteLine("Presione v para volver al menu o r para volver a utilizar el programa...");
                            ConsoleKeyInfo op;
                            while (true)
                            {
                                op = Console.ReadKey(true);
                                if (op.Key == ConsoleKey.V)
                                {
                                    menus[0].salir = true;
                                    break;
                                }
                                if (op.Key == ConsoleKey.R)
                                {
                                    break;
                                }
                            }
                        }
                    }

                }
            }
        }
    }
}