using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba3ro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string a = listBox1.Items[2].ToString();
            List<string> s = new List<string>();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                for(int j = i+1; j < listBox1.Items.Count; j++)
                {
                    if (listBox1.Items[j + 1].ToString()[0] > listBox1.Items[j].ToString()[0])
                    {
                        object p = listBox1.Items[j];
                        listBox1.Items[j] = listBox1.Items[j+1];
                        listBox1.Items[j + 1] = p;
                    }
                }
            }*/
            listBox1.Sorted = true;
            listBox2.Sorted = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = listBox1.Items.Count-1; i >= 0; i--) {
                if (listBox1.Items[i].ToString().Length <= 5) listBox1.Items.Remove(listBox1.Items[i]);
            }
            for (int i = listBox2.Items.Count - 1; i >= 0; i--)
            {
                if (listBox2.Items[i].ToString().Length <= 5) listBox2.Items.Remove(listBox2.Items[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                if (listBox1.Items[i].ToString().Length <= 5)
                {
                    listBox3.Items.Add(listBox1.Items[i]);
                    listBox1.Items.Remove(listBox1.Items[i]);
                }
            }
            for (int i = listBox2.Items.Count - 1; i >= 0; i--)
            {
                if (listBox2.Items[i].ToString().Length <= 5)
                {
                    listBox4.Items.Add(listBox2.Items[i]);
                    listBox2.Items.Remove(listBox2.Items[i]);
                }
            }
            listBox1.Items.AddRange(listBox4.Items);
            listBox2.Items.AddRange(listBox3.Items);
            listBox3.Items.Clear();
            listBox4.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            object b = listBox1.Items[listBox1.Items.Count-1];
            listBox1.Items[listBox1.Items.Count - 1] = listBox2.Items[listBox2.Items.Count-1];
            listBox2.Items[listBox2.Items.Count - 1] = b;
            object c = listBox1.Items[0];
            listBox1.Items[0] = listBox2.Items[0];
            listBox2.Items[0] = c;
        }
    }
}
