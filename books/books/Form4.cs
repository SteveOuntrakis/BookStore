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
    
    public partial class Form4 : Form
    {
        public static string c = "";
        public static int a = 0;
        public static PictureBox pic = new PictureBox();
        double p = 0;
        public static bool flagb = false;
        public static SoundPlayer audio = new SoundPlayer(books.Properties.Resources.cafeteria_wav);

        public Form4()
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
            this.label7.Location = new Point(5, 300);
            this.label16.Location = new Point(90, 110);

            this.label1.Location = new Point(255, 110);
            this.label1.Font = new Font("Arial", 8, FontStyle.Bold);

            this.label8.Location = new Point(245, 80);
            this.label8.Font = new Font("Arial", 8, FontStyle.Bold | FontStyle.Underline);

            this.label9.Location = new Point(245, 110);
            this.label9.Font = new Font("Arial", 10, FontStyle.Bold);

            this.label10.Location = new Point(245, 130);
            this.label10.Font = new Font("Arial", 10, FontStyle.Bold);

            this.label20.Location = new Point(305, 430);
            this.label20.Font = new Font("Arial", 8, FontStyle.Bold | FontStyle.Underline);

            this.label11.Location = new Point(255, 95);
            this.label11.Font = new Font("Arial", 8, FontStyle.Bold);
            this.label12.Location = new Point(255, 110);
            this.label12.Font = new Font("Arial", 8, FontStyle.Bold);
            this.label13.Location = new Point(255, 125);
            this.label13.Font = new Font("Arial", 8, FontStyle.Bold);
            this.label14.Location = new Point(255, 140);
            this.label14.Font = new Font("Arial", 8, FontStyle.Bold);
            this.label15.Location = new Point(290, 155);
            this.label15.Font = new Font("Arial", 8, FontStyle.Bold);
            this.pictureBox2.Size = new Size(40, 30);
            this.pictureBox2.Location = new Point(235, 245);
            this.pictureBox3.Size = new Size(50, 50);
            this.pictureBox3.Location = new Point(130, 195);
            this.button1.Location = new Point(295, 210);
        }
        public void max()
        {
            this.label6.Location = new Point(580, 750);            
            this.label7.Location = new Point(5, 450);
            this.label16.Location = new Point(260, 170);

            this.label8.Location = new Point(545, 120);
            this.label8.Font = new Font("Arial", 12, FontStyle.Bold | FontStyle.Underline);

            this.label9.Location = new Point(560, 150);
            this.label9.Font = new Font("Arial", 18, FontStyle.Bold);

            this.label10.Location = new Point(560, 190);
            this.label10.Font = new Font("Arial", 18, FontStyle.Bold);

            this.label20.Location = new Point(675, 650);
            this.label20.Font = new Font("Arial", 12, FontStyle.Bold | FontStyle.Underline);

            this.label1.Location = new Point(580, 170);
            this.label1.Font = new Font("Arial", 14, FontStyle.Bold);

            this.label11.Location = new Point(580, 140);
            this.label11.Font = new Font("Arial", 14, FontStyle.Bold);
            this.label12.Location = new Point(580, 165);
            this.label12.Font = new Font("Arial", 14, FontStyle.Bold);
            this.label13.Location = new Point(580, 190);
            this.label13.Font = new Font("Arial", 14, FontStyle.Bold);
            this.label14.Location = new Point(580, 215);
            this.label14.Font = new Font("Arial", 14, FontStyle.Bold);
            this.label15.Location = new Point(650, 230);
            this.label15.Font = new Font("Arial", 12, FontStyle.Bold);
            this.pictureBox2.Size = new Size(80, 60);
            this.pictureBox2.Location = new Point(530, 350);

            this.pictureBox3.Size = new Size(100, 60);
            this.pictureBox3.Location = new Point(300, 285);
            this.button1.Location = new Point(660, 315);
        }
        private void Form4_Load(object sender, EventArgs e)
        {
         
            this.label7.Visible = true;
            this.label8.Visible = true;
            this.label9.Visible = true;
            this.label10.Visible = true;
            this.label16.Visible = true;
            resize();
            audio.Play();
        }

        private void Form4_Resize(object sender, EventArgs e)
        {
            resize();
        }
        private void label9_Click(object sender, EventArgs e)
        {
           
        }

        private void label15_Click(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {
           
        }

        private void label12_Click(object sender, EventArgs e)
        {
           
        }

        private void label13_Click(object sender, EventArgs e)
        {
            
        }

        private void label14_Click(object sender, EventArgs e)
        {
           
        }

        private void label10_Click(object sender, EventArgs e)
        {          

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {
            if (label9.Text == "Παραγγελία")
            {
                this.pictureBox2.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
            }
        }

        private void label10_Click_1(object sender, EventArgs e)
        {
            this.pictureBox2.Visible = false;
            label8.Text = "Μάλιστα, το υπόλοιπο είναι :";
            label1.Text = p.ToString() + " €";
            label1.Visible = true;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Text = "Πληρωμή";
            label15.Visible = true;
        }

        private void label11_Click_1(object sender, EventArgs e)
        {
            if (label11.Text == "Σοκολάτα")
            {
                this.pictureBox2.Image = Image.FromFile("chocolate.png");
                this.pictureBox2.Visible = true;
                p = p + 2.5;
                label8.Text = "Ορίστε,θα θέλατε και κάτι άλλο;";
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
            }
        }

        private void label12_Click_1(object sender, EventArgs e)
        {
            if (label12.Text == "Καφέ")
            {
                this.pictureBox2.Image = Image.FromFile("coffee.png");
                this.pictureBox2.Visible = true;
                p = p + 3;
                label8.Text = "Ορίστε,θα θέλατε και κάτι άλλο;";
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
            }
        }

        private void label13_Click_1(object sender, EventArgs e)
        {
            if (label13.Text == "Μπύρα")
            {
                p = p + 4;
                this.pictureBox2.Image = Image.FromFile("beer.png");
                this.pictureBox2.Visible = true;
                label8.Text = "Ορίστε,θα θέλατε και κάτι άλλο;";
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
            }
        }

        private void label14_Click_1(object sender, EventArgs e)
        {
            if (label14.Text == "Κρασί")
            {
                p = p + 3.5;
                this.pictureBox2.Image = Image.FromFile(@"C:\Users\Admin\Desktop\bibliopwleio\bibliopwleio\bin\Debug\wine.png");
                this.pictureBox2.Visible = true;
                label8.Text = "Ορίστε,θα θέλατε και κάτι άλλο;";
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
            }
        }

        private void label15_Click_1(object sender, EventArgs e)
        {
            if (label15.Text == "Πίσω")
            {
                label8.Text = "Καλησπέρα, τι θα θέλατε;";
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
            }
            else if (label15.Text == "Πληρωμή")
            {
                label1.Visible = false;
                p = 0;
                label8.Text = "Ευχαριστούμε";
                label15.Text = "Πίσω";
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Form5 air = new Form5();
            air.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox3.Visible = pic.Visible;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            audio.Stop();
            Form3 st = new Form3();
            this.Close();
            st.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
            audio.Stop();
            Form6 toilet = new Form6();
            toilet.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flagb == false)
            {
                BackgroundImage = Image.FromFile("4rdb.png");
                flagb = true;
            }
            else
            {
                BackgroundImage = Image.FromFile("4rd.png");
                flagb = false;
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Σοκολάτα: 2.50€" + "\n" + "Καφές: 3€" + "\n" + "Μπύρα 4€" + "\n" + "Κρασί 3.50€");
        }

        private void Helper_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help.chm", HelpNavigator.Topic, "html/hs3.htm");
        }
    }
}
