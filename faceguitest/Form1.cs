using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.UI;
using Emgu.CV.Structure;
//using Emgu.CV.
using Emgu.Util;
namespace faceguitest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            string lokasi = "E:/Picture/gambarpixel.jpg";
            Image<Bgra, Byte> Gambar = new Image<Bgra, byte>(lokasi);
            pictureBox1.Image = Gambar.ToBitmap();

            lblWidth.Text = Gambar.Width.ToString();
            lblHeight.Text = Gambar.Height.ToString();
            lblResolusi.Text = Gambar.Size.ToString();


            Console.WriteLine(Gambar[1,1].Dimension);
            Console.WriteLine(Gambar.Width);

            
            string pesan = "";

            // Multidimensi array index [baris][kolom]
            Char[,] Reds = new Char[ Gambar.Height , Gambar.Width];
            string[,] Greens = new string[Gambar.Height, Gambar.Width]; 
            string[,] Blues = new string[Gambar.Height, Gambar.Width];

            for(int i = 0; i < Gambar.Width; i++)
            {
                Reds[0, i] = ( (Char) (Gambar[0, i].Red) );
                Greens[0, i] = Gambar[0, i].Green.ToString();
                Blues[0, i] = Gambar[0, i].Blue.ToString();
            }
            txtHasil.Text = "Red /n";
            foreach(Char r in Reds)
            {
                txtHasil.Text += r ;
            }

            //OpenFileDialog Openfile = new OpenFileDialog();
            //if (Openfile.ShowDialog() == DialogResult.OK)
            //{
            //    Image<Bgr, Byte> Gambar = new Image<Bgr, byte>(Openfile.FileName);
            //    pictureBox1.Image = Gambar.ToBitmap();
            //}

            timer.Stop();
            lblWaktu.Text = timer.ElapsedMilliseconds.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


    }
}
