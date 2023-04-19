using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace pong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show("Enter key pressed");
            }
            if (e.KeyChar == 13)
            {
                MessageBox.Show("Enter key pressed");
            }
        }
    }
    class Pong
    {
        public int x, y;
        public ConsoleKey ar, ab;

        public Pong(int x, int y,ConsoleKey ar, ConsoleKey ab)
        {
            this.x = x;
            this.y = y;
            this.ar = ar;
            this.ab = ab;
        }
        public void crear()
        {
            for (int j = y; j < y+3; j++)
            {
                for (int i = x; i < x+10; i++)
                {
                    Console.SetCursorPosition(j, i);
                    Console.WriteLine("█");
                }
            }
        }
    }

    class Ficha 
    {
        public int x = 60, y = 15;
        
        public void crear()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("■");
        }
        public void mover()
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /*Pong p1 = new Pong(10,0);
            p1.crear();
            Pong p2 = new Pong(10,117);
            p2.crear();
            Ficha f1 = new Ficha();
            f1.crear();

             var map = { };
            onkeydown = onkeyup = function(e){
                e = e || event;
            map [e.keyCode] = e.type == 'keydown';

            List<ConsoleKey> map = new List<ConsoleKey>();*/


        Console.ReadKey();
        }
    }
}
