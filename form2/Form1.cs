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
        private Image imagen;
        private int cont = 0;
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
            openFileDialog1.Filter = "Imagenes JPG,PNG,JPEG|*.jpg;*.png;*.jpeg";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imagen = Image.FromFile(openFileDialog1.FileName);
                    pictureBox1.Height = imagen.Height;
                    pictureBox1.Width = imagen.Width;
                    pictureBox1.Top = this.Height / 2 - imagen.Height / 2;
                    pictureBox1.Left = this.Width / 2 - imagen.Width / 2;
                    pictureBox1.Image = imagen;
                }
                catch (Exception exp)
                {

                    MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (imagen != null)
            {
                pictureBox1.Top = this.Height / 2 - imagen.Height / 2;
                pictureBox1.Left = this.Width / 2 - imagen.Width / 2;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            cont++;
            if (cont == 1) {
                pictureBox1.Height = imagen.Width;
                pictureBox1.Width = imagen.Height;
                pictureBox1.Top = this.Height / 2 - imagen.Height / 2;
                pictureBox1.Left = this.Width / 2 - imagen.Width / 2;
            }
            else if (cont == 2)
            {
                pictureBox1.Height = imagen.Width;
                pictureBox1.Width = imagen.Height;
                pictureBox1.Top = this.Height / 2 - imagen.Height / 2;
                pictureBox1.Left = this.Width / 2 - imagen.Width / 2;
            }
            else if (cont == 3)
            {
                pictureBox1.Height = imagen.Width;
                pictureBox1.Width = imagen.Height;
                pictureBox1.Top = this.Height / 2 - imagen.Height / 2;
                pictureBox1.Left = this.Width / 2 - imagen.Width / 2;
            }
            else
            {
                pictureBox1.Height = imagen.Width;
                pictureBox1.Width = imagen.Height;
                pictureBox1.Top = this.Height / 2 - imagen.Height / 2;
                pictureBox1.Left = this.Width / 2 - imagen.Width / 2;
                cont = 0;
            }
            imagen.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = imagen;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
