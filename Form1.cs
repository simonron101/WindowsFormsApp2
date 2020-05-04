using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        public static int Number { get; private set; }
        public static bool success { get; private set; }

        public Form1()
        {
            InitializeComponent();

        }

        private void Stuff_Here_lbl_Click(object sender, EventArgs e)
        {
            label1.ForeColor = System.Drawing.Color.Red;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label1.ForeColor = System.Drawing.Color.DarkBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "Cleared";
            label1.ForeColor = System.Drawing.Color.DarkGreen;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

            
            private void firstTextBox_TextChanged(object sender, EventArgs e)
        {

            var tuple = CheckNumbers(firstTextBox.Text, int.Parse(textBox2.Text));
            var Number = tuple.Item1;
            var num = tuple.Item2;
            Number = Number + num;
            outputLbl.Text = Number.ToString();
        }




        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            var tuple = CheckNumbers(textBox2.Text, int.Parse(firstTextBox.Text));

            var Number = tuple.Item1;
            var num = tuple.Item2;
            Number = Number + num;
            outputLbl.Text = Number.ToString();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.Text = "show me";
        }





        private void label4_Click(object sender, EventArgs e)
        {

        }



        public Tuple<int, int>  CheckNumbers(string text, int num)
        {
            if (text != null)
            {
                int Number;
                bool success = Int32.TryParse(text, out Number);
                if (!success)
                {
                    Number = 0;
                }
                return new Tuple<int, int>(Number, num);
            }
            else {  Number = 0; 
                return new Tuple<int, int>(Number, num);
            }
        }
    }
}
