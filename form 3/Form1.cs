using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.InteropServices;

namespace form_3
{
    public partial class Form1 : Form
    {
        [DllImport("winmm.dll")]
        public static extern int mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLengh, int hwndCallback);
        const int MAX_PATH = 260;
        // Constante con el formato de archivo a reproducir.
        const string Tipo = "MPEGVIDEO";
        // Alias asignado al archivo especificado.
        const string sAlias = "ArchivoDeSonido";
        private string fileName; //Nombre de archivo a reproducir
        [DllImport("winmm.dll")]
        public static extern int waveOutGetNumDevs();


        List<Mix> mixes = new List<Mix>();
        int indexList = -1;
        
        public Form1()
        {
            InitializeComponent();
        }

        public int DispositivosDeSonido()
        {
            return waveOutGetNumDevs();
        }

        private bool Abrir()
        {
            // verificamos que el archivo existe; si no, regresamos falso.
            if (!File.Exists(fileName)) return false;
            // obtenemos el nombre corto del archivo.
            // intentamos abrir el archivo, utilizando su nombre corto
            // y asignándole un alias para trabajar con él.
            if (mciSendString("open " + fileName + " type " + Tipo +
            " alias " + sAlias, null, 0, 0) == 0)
                // si el resultado es igual a 0, la función tuvo éxito,
                // devolvemos verdadero.
                return true;
            else
                // en caso contrario, falso.
                return false;
        }
        /// <summary>
        /// Inicia la reproducción del archivo especificado.
        /// </summary>
        public void Reproducir()
        {
            // Nos cersioramos que hay un archivo que reproducir.
            if (fileName != "")
            {
                // intentamos iniciar la reproducción.
                if (Abrir())
                {
                    int mciResul = mciSendString("play " + sAlias, null, 0, 0);
                    //if (mciResul == 0)
                        // si se ha tenido éxito, devolvemos el mensaje adecuado,
                        //ReproductorEstado("Ok");
                    //else // en caso contrario, la cadena de mensaje de error.
                        //ReproductorEstado(MciMensajesDeError(mciResul));
                }
                //else // sí el archivo no ha sido abierto, indicamos el mensaje de error.
                    //ReproductorEstado("No se ha logrado abrir el archivo especificado");
            }
            //else // si no hay archivo especificado, devolvemos la cadena indicando
                 // el evento.
                //ReproductorEstado("No se ha especificado ningún nombre de archivo");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.groupBox1.Visible = true;
            this.groupBox1.Location = new System.Drawing.Point(159,80);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.groupBox2.Visible = true;
            this.groupBox2.Location = new System.Drawing.Point(0,74);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItem == null) return;
            this.button4.Enabled = true;
            this.button5.Enabled = true;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.groupBox2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.groupBox1.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.listBox1.Items.Add(this.textBox1.Text);
            mixes.Add(new Mix(this.textBox1.Text));
            this.textBox1.Text = "";
            this.groupBox2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.groupBox3.Visible = true;
            this.groupBox3.Location = new System.Drawing.Point(33,41);
            indexList = this.listBox1.SelectedIndex;
            this.listBox2.Items.Clear();
            
            foreach(Cancion c in mixes[indexList].audios)
            {
                this.listBox2.Items.Add(c.nombre);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            indexList = this.listBox1.SelectedIndex;
            fileName = mixes[indexList].audios[0].dir;
            Reproducir();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.groupBox3.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "Imagenes MP3,WAV|*.mp3;*.wav";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    foreach (string path in openFileDialog1.FileNames)
                    {
                        mixes[indexList].audios.Add(new Cancion("Cancion " + (mixes[indexList].audios.Count).ToString(),path));
                        this.listBox2.Items.Add("Cancion " + (mixes[indexList].audios.Count));
                    }
                }
                catch (Exception exp)
                {

                    MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
