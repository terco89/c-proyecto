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
        int indexList = -1,indexList1 = -1,posActual,tam;
        bool banImg = false;

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

        public long CalcularPosicion(string path)
        {
            StringBuilder sbBuffer = new StringBuilder(MAX_PATH);
            mciSendString("set " + path + " time format milliseconds", null, 0, 0);
            mciSendString("status " + path + " position", sbBuffer, MAX_PATH, 0);

            if (sbBuffer.ToString() != "")
                return long.Parse(sbBuffer.ToString()) / 1000;
            else
                return 0L;
        }
        /// <returns>Cadena con la información.</returns>
        public string Posicion(string path)
        {
            // obtenemos los segundos.
            long sec = CalcularPosicion(path);
            long mins;

            if (sec < 60)
                return "0:" + String.Format("{0:D2}", sec);
            else if (sec > 59)
            {
                mins = (int)(sec / 60);
                sec = sec - (mins * 60);
                return String.Format("{0:D2}", mins) + ":" + String.Format("{0:D2}", sec);
            }
            else
                return "";
        }
        public long CalcularTamaño(string path)
        {
            StringBuilder sbBuffer = new StringBuilder(MAX_PATH);
            mciSendString("set " + path + " time format milliseconds", null, 0, 0);
            mciSendString("status " + path + " length", sbBuffer, MAX_PATH, 0);

            if (sbBuffer.ToString() != "")
                return long.Parse(sbBuffer.ToString()) / 1000;
            else
                return 0L;
        }
        public string Tamaño(string path)
        {
            long sec = CalcularTamaño(path);
            long mins;

            if (sec < 60)
                return "0:" + String.Format("{0:D2}", sec);
            else if (sec > 59)
            {
                mins = (int)(sec / 60);
                sec = sec - (mins * 60);
                return String.Format("{0:D2}", mins) + ":" + String.Format("{0:D2}", sec);
            }
            else
                return "";
        }

        public void Pausar()
        {
            // Enviamos el comando de pausa mediante la función mciSendString,
            int mciResul = mciSendString("pause " + sAlias, null, 0, 0);
        }

        public void ReproducirLista()
        {
            int tiempoCalculado = 0;
            DateTime hora = DateTime.Now;
            DateTime horaActual = DateTime.Now;
            TimeSpan tiempoTrasncurrido;
            for (int i = 0; i < mixes[indexList].audios.Count; i++)
            {
                fileName = mixes[indexList].audios[i].dir;
                Reproducir();
                tiempoCalculado = int.Parse(CalcularTamaño(fileName).ToString());
                while (true)
                {
                    if (!banImg) {
                    horaActual = DateTime.Now;
                    tiempoTrasncurrido = horaActual - hora;
                    if (tiempoTrasncurrido.Seconds == tiempoCalculado)
                    {
                        Cerrar();
                        break;
                    }
                    }
                }
            }
        }

        public void Cerrar()
        {
            // Establecemos los comando detener reproducción y cerrar archivo.
            mciSendString("stop " + sAlias, null, 0, 0);
            mciSendString("close " + sAlias, null, 0, 0);
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
            this.groupBox4.Visible = true;
            this.groupBox4.Location = new System.Drawing.Point(6,0);
            indexList = this.listBox1.SelectedIndex;
            ReproducirLista();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.groupBox3.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            mixes[indexList].audios.RemoveAt(this.listBox2.SelectedIndex);
            this.listBox2.Items.RemoveAt(this.listBox2.SelectedIndex);
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
                        string[] outs = path.Split('.')[0].Split('\\');
                        string nombre = outs[outs.Length - 1];
                        for(int i = 0; i <  mixes[indexList].audios.Count; i++)
                        {
                            /*if(c.nombre == nombre)
                            {
                                
                                nombre = c.nombre;
                            }*/
                        }
                        mixes[indexList].audios.Add(new Cancion(nombre,path));
                        this.listBox2.Items.Add(nombre.ToString());
                    }
                }
                catch (Exception exp)
                {

                    MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (banImg)
            {
                banImg = false;
                Reproducir();
            }
            else
            {
                banImg = true;
                Pausar();
            }
        }
    }
}
