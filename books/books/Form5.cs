using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace books
{
    public partial class Form5 : Form
    {

        SoundPlayer audio = new SoundPlayer("air.wav");
        public static SoundPlayer cd = Form4.audio;
        //SoundPlayer audio = new SoundPlayer(books.Properties.Resources.air);
        public static int a = Form4.a;
        public static string c = Form4.c;
        public static PictureBox pic = Form4.pic;
        public Form5()
        {
            InitializeComponent();
        }
        public void lab()
        {
            if (comboBox1.Visible == true)
            {
                c = comboBox1.Text + "°C";
            }
            else if (comboBox2.Visible == true)
            {
                c = comboBox2.Text + "°C";
            }
            else if (comboBox3.Visible == true)
            {
                c = comboBox3.Text + "°C";
            }
            else
            {
                c = "";
            }
            label2.Text = c;
        }
        public void resize()
        {
            if (WindowState == FormWindowState.Normal)
            {
                normal();
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                max();
            }
        }
        public void normal()
        {

        }
        public void max()
        {

        }
        private void Form5_Load(object sender, EventArgs e)
        {
            if (a == 0)
            {
                pictureBox1.Image = Image.FromFile("air0.png");
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                pic.Visible = false;
            }
            else if (a == 1)
            {
                pictureBox1.Image = Image.FromFile("air1.png");
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                pic.Visible = false;
                audio.Play();
            }
            else if (a == 2)
            {
                pictureBox1.Image = Image.FromFile("air2.png");
                comboBox1.Visible = false;
                comboBox2.Visible = true;
                comboBox3.Visible = false;
                pic.Visible = true;
                audio.Play();
            }
            else if (a == 3)
            {
                pictureBox1.Image = Image.FromFile("air3.png");
                comboBox1.Visible = true;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                pic.Visible = true;
                audio.Play();
            }
            else if (a == 4)
            {
                pictureBox1.Image = Image.FromFile("air4.png");
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = true;
                pic.Visible = true;
                audio.Play();
            }
            lab();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (a == 0)
            {
                audio.Play();
                pictureBox1.Image = Image.FromFile("air1.png");
                a = 1;

            }
            else
            {
                audio.Stop();
                pictureBox1.Image = Image.FromFile("air0.png");
                a = 0;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
            }
            pic.Visible = false;
            lab();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {

            }
            else
            {
                pictureBox1.Image = Image.FromFile("air2.png");
                comboBox1.Visible = false;
                comboBox2.Visible = true;
                comboBox3.Visible = false;
                a = 2;
                pic.Visible = true;
            }
            lab();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {

            }
            else
            {
                pictureBox1.Image = Image.FromFile("air4.png");
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = true;
                a = 4;
                pic.Visible = true;
            }
            lab();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {

            }
            else
            {
                pictureBox1.Image = Image.FromFile("air3.png");
                comboBox1.Visible = true;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                a = 3;
                pic.Visible = true;
            }
            lab();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            lab();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lab();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lab();
        }

        private void label6_Click(object sender, EventArgs e)
        {
          
           audio.Stop();
           cd.Play();
           this.Close();
        }

        private void Helper_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help.chm", HelpNavigator.Topic, "html/hs4.htm");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
