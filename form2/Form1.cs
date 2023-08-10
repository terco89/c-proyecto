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
        private Image imagen,nueva;
        private int cont = 0,alto,ancho;
        private double zoomw = 1,zoomh = 1;
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
                    alto = imagen.Height;
                    ancho = imagen.Width;
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
                pictureBox1.Top = this.Height / 2 - alto / 2;
                pictureBox1.Left = this.Width / 2 - ancho / 2;
            }
            
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(this.Width / 2 - this.toolStripButton1.Width, 1, 0, 2);
            this.toolStripButton3.Margin = new System.Windows.Forms.Padding(this.toolStripButton1.Margin.Left/2 - this.toolStripButton3.Width, 1, 0, 2);
            //this.toolStripButton3.Margin = new System.Windows.Forms.Padding((.Width/4)*3+ this.toolStripButton2.Width - this.toolStripButton3.Width / 2, 1, 0, 2);
            //this.toolStripLabel1.Margin = new System.Windows.Forms.Padding((this.Width/4)*3+(this.toolStripButton2.Width*2) - this.toolStripLabel1.Width / 2, 1, 0, 2);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (imagen == null) return;
            zoomw = zoomw - 0.05;
            zoomh = zoomh - 0.05;
            Image.GetThumbnailImageAbort thumbnailCallback = ThumbnailCallback;
            nueva = imagen.GetThumbnailImage((int)Math.Round(imagen.Width * zoomw), (int)Math.Round(imagen.Height * zoomh), thumbnailCallback, IntPtr.Zero);
            pictureBox1.Image = nueva;
            pictureBox1.Height = nueva.Height;
            pictureBox1.Width = nueva.Width;
            alto = nueva.Height;
            ancho = nueva.Width;
            pictureBox1.Top = this.Height / 2 - alto / 2;
            pictureBox1.Left = this.Width / 2 - ancho / 2;
            toolStripLabel1.Text = zoomw*100+"%";
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (imagen == null) return;
            zoomw = zoomw + 0.05;
            zoomh = zoomh + 0.05;
            Image.GetThumbnailImageAbort thumbnailCallback = ThumbnailCallback;
            nueva = imagen.GetThumbnailImage((int)Math.Round(imagen.Width*zoomw), (int)Math.Round(imagen.Height*zoomh), thumbnailCallback, IntPtr.Zero);
            pictureBox1.Image = nueva;
            pictureBox1.Height = nueva.Height;
            pictureBox1.Width = nueva.Width;
            alto = nueva.Height;
            ancho = nueva.Width;
            pictureBox1.Top = this.Height / 2 - alto / 2;
            pictureBox1.Left = this.Width / 2 - ancho / 2;
            toolStripLabel1.Text = zoomw * 100 + "%";
        }
        private bool ThumbnailCallback()
        {
            return false; // Devuelve siempre falso para generar la imagen reducida
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (imagen == null) return;
            cont++;
            if (cont == 1) {
                pictureBox1.Height = ancho;
                pictureBox1.Width = alto;
                pictureBox1.Top = this.Height / 2 - ancho / 2;
                pictureBox1.Left = this.Width / 2 - alto / 2;
            }
            else if (cont == 2)
            {
                pictureBox1.Height = alto;
                pictureBox1.Width = ancho;
                pictureBox1.Top = this.Height / 2 - alto / 2;
                pictureBox1.Left = this.Width / 2 - ancho / 2;
            }
            else if (cont == 3)
            {
                pictureBox1.Height = ancho;
                pictureBox1.Width = alto;
                pictureBox1.Top = this.Height / 2 - ancho / 2;
                pictureBox1.Left = this.Width / 2 - alto / 2;
            }
            else
            {
                pictureBox1.Height = alto;
                pictureBox1.Width = ancho;
                pictureBox1.Top = this.Height / 2 - alto / 2;
                pictureBox1.Left = this.Width / 2 - ancho / 2;
                cont = 0;
            }
            if (nueva == null)
            {
                imagen.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Image = imagen;
            }
            else
            {
                nueva.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Image = nueva;
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
