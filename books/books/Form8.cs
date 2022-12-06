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
    public partial class Form8 : Form
    {
        public static double s1 = Form7.s1;
        public double s3 = 0;
        public string str;
        public int sum = 0;
        public static int b = 0;
        public static int b1 = 0;
        SoundPlayer audio = new SoundPlayer(books.Properties.Resources.copy_wav);
        public static SoundPlayer cd = Form7.audio;
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            label1.Visible = true;
            label1.Text = "Προετοιμασία για Σάρωση...";
            s3 = 0;
            b = 2;
            b1 = 0;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            label1.Visible = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            
            label2.Visible = true;
            numericUpDown1.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            s3 = 0.10;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;

            label2.Visible = true;
            numericUpDown1.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            s3 = 0.20;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;

            label2.Visible = true;
            numericUpDown1.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            s3 = 0.50;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            label1.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (b == 0)
            {
                button3.Visible = false;
                label1.Visible = true;
            }
            else if (b == 1)
            {
                button1.Visible = true;
                button2.Visible = true;
                label1.Visible = false;
                timer1.Stop();
            }
            else if (b == 2 | b == 3)
            {
                if (b1 == 0)
                {
                    label1.Text = "Σάρωση...";

                }
                else if (b1 == 1)
                {
                    label1.Text = "H διαδικασία ολοκληρώθηκε!";

                }
                b1 += 1;
            }
            else if (b == 4)
            {
                label1.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
                timer1.Stop();
            }
            else if(b==5 | b==6)
            {
                
                if(b1==0)
                {
                    label1.Text = "Εκτύπωση...";
                }
                else if(b1==1)
                {
                    label1.Text = "H διαδικασία ολοκληρώθηκε!";
                }
                b1 += 1;
            }
            else if (b == 7)
            {
                label1.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
                audio.Stop();
                cd.Play();
                timer1.Stop();

            }
            b += 1;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
            timer1.Stop();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Σάρωση: Δωρεάν!"+"\n"+"Κανονική: 0.10 το αντίτυπο"+"\n"+ "Διπλή όψεως: 0.20 το αντίτυπο" + "\n"+ "Φωτογραφίας: 0.50 το αντίτυπο"+s1);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Visible = false;
            button10.Visible = false;            
            label2.Visible = false;
            numericUpDown1.Visible = false;

            sum = Convert.ToInt32(numericUpDown1.Value);
            s1 = s1+ s3 * sum;
            label1.Visible = true;
            label1.Text = "Προετοιμασία για Εκτύπωση...";

            b = 5;
            b1 = 0;
            audio.Play();
            timer1.Start();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button9.Visible = false;
            button10.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            numericUpDown1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Helper_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help.chm", HelpNavigator.Topic, "html/hs7.htm");
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            b = 0;
        }
    }
}
