using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox2.Text);
            textBox2.Text = "";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listBox2.Items.Add(textBox2.Text);
                textBox2.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(listBox1.Items);
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void sada(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items);
            listBox2.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem == null) return;
            listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
        }
    }
}
