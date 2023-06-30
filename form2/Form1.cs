using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "Imagenes JPG|*.jpg|Archivos PNG|*.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                    pictureBox1.Top = this.Height/2 - pictureBox1.Height/2;
                    pictureBox1.Left = this.Width/2 - pictureBox1.Width/2;
                }
                catch (Exception exp)
                {

                    MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            pictureBox1.Top = this.Height / 2 - pictureBox1.Height / 2;
            pictureBox1.Left = this.Width / 2 - pictureBox1.Width / 2;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
