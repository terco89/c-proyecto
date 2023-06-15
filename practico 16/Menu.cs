using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_16
{
    class Menu
    {
        private string[] menu;
        private int posMenu;

        public Menu(string[] menu)
        {
            this.menu = menu;
        }

        public string[] GetMenu
        {
            get
            {
                return menu;
            }
        }
        public int PosMenu
        {
            get
            {
                return posMenu;
            }
            set
            {
                posMenu = value;
            }
        }
        public void pintar()
        {
            posMenu = 0;
            for (int i = 0; i < menu.Count(); i++)
            {
                Console.SetCursorPosition(30, i + 10);
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

        public void bajar()
        {
            if (posMenu < menu.Count()-1)
            {
                Console.SetCursorPosition(30, posMenu + 10);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(menu[posMenu]+" ");
                posMenu++;
                Console.SetCursorPosition(30, posMenu + 10);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(menu[posMenu]);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(30, posMenu + 10);
                Console.Write(menu[posMenu]+" ");
                posMenu = 0;
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(30, posMenu + 10);
                Console.Write(menu[posMenu]);
            }
        }
        public void subir()
        {
            if (posMenu > 0)
            {
                Console.SetCursorPosition(30, posMenu + 10);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(menu[posMenu]+" ");
                posMenu--;
                Console.SetCursorPosition(30, posMenu + 10);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(menu[posMenu]);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(30, posMenu + 10);
                Console.Write(menu[posMenu]+" ");
                posMenu = menu.Count()-1;
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(30, posMenu + 10);
                Console.Write(menu[posMenu]);
            }
        }
    }
}
