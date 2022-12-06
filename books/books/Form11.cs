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
    public partial class Form11 : Form
    {
        public static double sum = Form9.sum;
        public static int s2 = 0;
        public Form11()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                radioButton2.Checked = false;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                radioButton1.Checked = false;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s2 = 0;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("Παρακαλώ βάλτε όνομα");
            }
            else if (textBox2.Text=="")
            {
                MessageBox.Show("Παρακαλώ βάλτε αριθμό κάρτας");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Παρακαλώ βάλτε cvv");
            }
            else if(domainUpDown1.Text=="Month")
            {
                MessageBox.Show("Παρακαλώ βάλτε μήνα");
            }
            else if (domainUpDown2.Text == "Year")
            {
                MessageBox.Show("Παρακαλώ βάλτε χρόνο");
            }
            else
            {
                MessageBox.Show("Η συναλλαγή ολοκληρώθηκε");
                s2 = 1;
                this.Close();    
            }
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void Helper_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help.chm", HelpNavigator.Topic, "html/hs10.htm");
        }
    }
}
