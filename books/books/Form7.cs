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
    public partial class Form7 : Form
    {
        public static int el = Form11.s2;
        public static SoundPlayer audio = new SoundPlayer("bib.wav");
        public static bool flagb = false;
        public static double s1 = 0;
        public static double s2 = 0;
        public static double sum = 0;
        public static double k = Form3.sum;
        public Form7()
        {
            InitializeComponent();            
        }

        private void Form7_Load(object sender, EventArgs e)
        {                      
            audio.Play();
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
            this.label6.Location = new Point(280, 500);
            this.label17.Location = new Point(138, 360);
            this.label17.Font = new Font("Arial", 8, FontStyle.Bold);
            this.label18.Location = new Point(500, 470);
            this.label18.Font = new Font("Arial", 8, FontStyle.Bold);            
            this.label5.Location = new Point(520, 300);
            this.label5.Font = new Font("Arial", 8, FontStyle.Bold);
            this.button1.Location = new Point(490, 230);

            if (s1==0)
            {
                this.label19.Visible = true;
                this.label1.Visible = false;
                this.label2.Visible = false;
                this.label3.Visible = false;
                this.label4.Visible = false;
                this.label19.Location = new Point(360, 90);
                this.label19.Font = new Font("Arial", 8, FontStyle.Bold);

            }
            else
            {
                this.label19.Visible = false;
                this.label1.Visible = true;
                this.label2.Visible = true;
                this.label3.Visible = true;
                this.label4.Visible = false;
                this.label1.Location = new Point(360, 90);
                this.label1.Font = new Font("Arial", 8, FontStyle.Bold);
                this.label2.Location = new Point(370, 120);
                this.label2.Font = new Font("Arial", 8, FontStyle.Bold);
                this.label3.Location = new Point(410, 120);
                this.label3.Font = new Font("Arial", 8, FontStyle.Bold);
                this.label4.Location = new Point(420, 150);
                this.label4.Font = new Font("Arial", 8, FontStyle.Bold);
            }
        }
        public void max()
        {
            this.label6.Location = new Point(580, 750);
            this.label17.Location = new Point(300, 530);
            this.label17.Font = new Font("Arial", 14, FontStyle.Bold);
            this.label18.Location = new Point(1160, 700);
            this.label18.Font = new Font("Arial", 14, FontStyle.Bold);
           
            this.label5.Location = new Point(1160, 400);
            this.label5.Font = new Font("Arial", 14, FontStyle.Bold);

            this.button1.Location = new Point(1100, 330);
            if(s1==0)
            {
                this.label19.Visible = true;
                this.label1.Visible = false;
                this.label2.Visible = false;
                this.label3.Visible = false;
                this.label4.Visible = false;
                this.label19.Location = new Point(800, 130);
                this.label19.Font = new Font("Arial", 14, FontStyle.Bold);
            }
            else
            {
                this.label19.Visible = false;
                this.label1.Visible = true;
                this.label2.Visible = true;
                this.label3.Visible = true;
                this.label4.Visible = false;
                this.label1.Location = new Point(800, 130);
                this.label1.Font = new Font("Arial", 14, FontStyle.Bold);
                this.label2.Location = new Point(810, 180);
                this.label2.Font = new Font("Arial", 14, FontStyle.Bold);
                this.label3.Location = new Point(870, 180);
                this.label3.Font = new Font("Arial", 14, FontStyle.Bold);
                this.label4.Location = new Point(890, 230);
                this.label4.Font = new Font("Arial", 14, FontStyle.Bold);
            }

        }

        private void Form7_Resize(object sender, EventArgs e)
        {
            resize();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            audio.Stop();
            Form3 st = new Form3();
            st.Show();
            this.Close();
        }
        private void label17_Click(object sender, EventArgs e)
        {
            Form8 fwt = new Form8();
            fwt.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (flagb == false)
            {
                BackgroundImage = Image.FromFile("3rdb.png");
                flagb = true;
            }
            else
            {
                BackgroundImage = Image.FromFile("3rd.png");
                flagb = false;
            }
        }
        private void label19_Click(object sender, EventArgs e)
        {
            MessageBox.Show(s1.ToString());
        }
        private void Form7_Activated(object sender, EventArgs e)
        {            
            s1 = Form8.s1;
            s2 = Form10.s2;
            sum = s1 + s2;           
            resize();
            this.Refresh();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            label1.Text="Ορίστε";
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = true;
        }
        private void label3_Click(object sender, EventArgs e)
        {
            label19.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }
        private void label4_Click(object sender, EventArgs e)
        {
            label19.Visible = true;
            resize();
            label1.Visible = false;
            label1.Text = "Θα θέλατε βιβλιοδεσία;" + "\n" + "(Προσφορά καταστήματος).";
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }
        private void label18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Το υπόλοιπο είναι : " + sum + "€"+ "\n" +s1+ "€ Από φωτοτυπικό" + "\n" + s2 + "€ Από Αγορά Βιβλίων");
        }
        private void label5_Click(object sender, EventArgs e)
        {
            Form10 shop = new Form10();
            shop.Show();
        }
        private void label7_Click(object sender, EventArgs e)
        {
           
        }

        private void Helper_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help.chm", HelpNavigator.Topic, "html/hs6.htm");
        }
    }
}
