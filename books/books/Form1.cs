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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            this.BackgroundImageLayout = ImageLayout.Stretch;
            resize();
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
            this.label2.Location = new Point(300, 165);
        }
        public void max()
        {
            this.label2.Location = new Point(710, 260);
        }

        private void label2_Click(object sender, EventArgs e)
        {            
            SoundPlayer audio = new SoundPlayer(books.Properties.Resources.door_wav); 
            audio.Play();
            timer1.Start();
        }

        private void Form1_MaximumSizeChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resize();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Form3 sec = new Form3();
            sec.Show();
            timer1.Stop();
        }

        private void Helper_Click(object sender, EventArgs e)
        {
            //Help.ShowHelp(this, "help.chm");
            Help.ShowHelp(this, "help.chm", HelpNavigator.Topic, "html/hs1.htm");
        }
    }
}
