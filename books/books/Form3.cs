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
    public partial class Form3 : Form
    {
        
        public static double sum ;
        public static bool flagb = false;
        public static double k = Form9.k;
        SoundPlayer audio = new SoundPlayer(books.Properties.Resources.main_wav);
        public Form3()
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
            this.label3.Location = new Point(420, 350);
            this.label4.Location = new Point(580, 200);
            this.label5.Location = new Point(5, 200);
            this.button1.Location = new Point(295, 200);
        }
        public void max()
        {
            this.label6.Location = new Point(580, 750);
            this.label3.Location = new Point(970, 530);
            this.label4.Location = new Point(1380, 350);
            this.label5.Location = new Point(5, 350);
            this.button1.Location = new Point(650, 300);
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            k = sum;
            resize();            
            audio.Play();
        }

        private void label4_Resize(object sender, EventArgs e)
        {
           
        }

        private void Form3_Resize(object sender, EventArgs e)
        {
            resize();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            audio.Stop();
            Form4 cafe = new Form4();
            cafe.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (sum == 0)
            {
                audio.Stop();
                this.Close();               
            }
            else
            {
                MessageBox.Show("Έχετε υπόλοιπο παρακαλώ περάστε από το Ταμείο");
            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
            audio.Stop();
            Form7 bibl = new Form7();
            bibl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flagb == false)
            {
                BackgroundImage = Image.FromFile("2ndb.jpg");
                flagb = true;
            }
            else
            {
                BackgroundImage = Image.FromFile("2nd.jpg");
                flagb = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
            sum = Form7.sum;
            
            Form9 cash = new Form9();
            cash.Show();
        }

        private void Form3_Activated(object sender, EventArgs e)
        {
            sum = Form7.sum;
            k = Form9.k;
            if (k==1)
            {
                sum = 0;
            }
            
           
            resize();
            this.Refresh();
        }
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Helper_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help.chm", HelpNavigator.Topic, "html/hs2.htm");
        }
    }
}
