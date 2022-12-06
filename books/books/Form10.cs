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
    public partial class Form10 : Form
    {
        public static double s2=Form7.s2;
        public static double sum = 0;
        public static double s4 = 0;
        public Form10()
        {
            InitializeComponent();
        }
        private void Form10_Load(object sender, EventArgs e)
        {
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Οι αστέρες του εγκληματικού πανθέου")
            {
                pictureBox1.Image = Image.FromFile("pic1.png");
                label6.Text = "Σόμπολος Πάνος";
                label7.Text = "Εκδόσεις Πατάκη";
                sum = 8.85 ;
                label8.Text = sum.ToString() + "€";
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;                
            }
            else if (comboBox1.Text == "Ο χιονάνθρωπος")
            {
                pictureBox1.Image = Image.FromFile("pic2.png");
                label6.Text = "Jo Nesbo";
                label7.Text = "Μεταίχμιο";
                sum = 13.10;
                label8.Text = sum.ToString()+ "€";
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text== "Ο χιονάνθρωπος")
            {
                comboBox1.Text = "Ο χιονάνθρωπος";
            }
            else if (textBox1.Text== "Οι αστέρες του εγκληματικού πανθέου")
            {
                comboBox1.Text = "Οι αστέρες του εγκληματικού πανθέου";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            s4 = Convert.ToInt32(numericUpDown1.Value);
            s2 = s2 + s4 * sum;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(s2.ToString() + "€");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            s2= 0;
        }
        private void Helper_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help.chm", HelpNavigator.Topic, "html/hs8.htm");
        }
    }
}
