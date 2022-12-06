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
    public partial class Form6 : Form
    {
        SoundPlayer audio = new SoundPlayer("toi.wav");
        public Form6()
        {
            InitializeComponent();
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
            this.label6.Location = new Point(280, 500);
            this.pictureBox1.Location = new Point(200, 0);
            this.pictureBox1.Size = new Size(300, 220);
        }
        public void max()
        {
            this.label6.Location = new Point(580, 750);
            this.pictureBox1.Location = new Point(440, 0);
            this.pictureBox1.Size = new Size(660, 330);
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            audio.Play();
            resize();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            audio.Stop();
            Form4 st = new Form4();
            this.Close();
            st.Show();
        }

        private void Form6_Resize(object sender, EventArgs e)
        {
            resize();
        }

        private void Helper_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help.chm", HelpNavigator.Topic, "html/hs5.htm");
        }
    }
}
