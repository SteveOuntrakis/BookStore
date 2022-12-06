using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace books
{
    public partial class Form9 : Form
    {
        public int b=0;
        public static bool flagb = false;
        public static double sum = Form3.sum;
        public static double s2 = Form11.s2;
        public static int k = 0;
        public Form9()
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
            button1.Location = new Point(470, 245);
            label6.Location = new Point(280, 495);
            label1.Location = new Point(360, 55);
            label2.Location = new Point(360, 105);
            label3.Location = new Point(360, 135);
            this.label1.Font = new Font("Arial", 8, FontStyle.Bold);
            this.label2.Font = new Font("Arial", 8, FontStyle.Bold);
            this.label3.Font = new Font("Arial", 8, FontStyle.Bold);

        }
        public void max()
        {
            button1.Location = new Point(1050, 340);
            label6.Location = new Point(580, 750);
            label1.Location = new Point(800, 100);
            label2.Location = new Point(800, 160);
            label3.Location = new Point(800, 230);
            this.label1.Font = new Font("Arial", 14, FontStyle.Bold);
            this.label2.Font = new Font("Arial", 14, FontStyle.Bold);
            this.label3.Font = new Font("Arial", 14, FontStyle.Bold);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flagb == false)
            {
                BackgroundImage = Image.FromFile("5b.png");
                flagb = true;
            }
            else
            {
                BackgroundImage = Image.FromFile("5.png");
                flagb = false;
            }
        }

        private void Form9_Resize(object sender, EventArgs e)
        {
            resize();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            resize();
            sum = Form3.sum;
            s2 = sum;
            b = 0;
            if (k == 1)
            {
                sum = 0;
                k = 0;
            }
        timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (b == 0)
            {
                label1.Visible = true;
                label1.Text = "Καλησπέρα σας, το υπόλοιπο είναι : " + sum;
            }
            else if (b==1)
            {
                label1.Text = "Πως θα θέλατε να πληρώσετε;";
                label2.Visible = true;
                label3.Visible = true;
                timer1.Stop();
            }
            else if (b==2)
            {
                label1.Text = "Ευχαριστούμε, η συναλλαγή ολοκληρώθηκε";
                label2.Visible = false;
                label3.Visible = false;
                s2 = 1;
                k = 1;
                
            }
            else if (b==3)
            {
                    label1.Text= "το υπόλοιπο είναι : " + sum;
                    b = 0;
                    timer1.Stop();  
            }
            b += 1;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form11 card = new Form11();
            card.Show();
        }

        private void Form9_Activated(object sender, EventArgs e)
        {
            s2 = Form11.s2;
            if (s2==0)
            {

            }
            else if (s2==1)
            {
                sum = 0;
                b = 2;
                timer1.Start();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            b = 2;
            timer1.Start();
            sum = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Helper_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help.chm", HelpNavigator.Topic, "html/hs9.htm");
        }
    }
}
