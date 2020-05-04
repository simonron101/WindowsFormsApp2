using System;
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

        private void testTextBox_TextChanged(object sender, EventArgs e)
        {
            label1.Text = testTextBox.Text;
            label1.ForeColor = System.Drawing.Color.DarkBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            testTextBox.Text = "";
            label1.Text = "Cleared";
            label1.ForeColor = System.Drawing.Color.DarkGreen;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            CheckNumbers(textBox1.Text, textBox2.Text);
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
            CheckNumbers(textBox2.Text, textBox1.Text);
   
        }

        public int CheckNumbers(string text, string text2)
        {
            int Number;
            Number = 0;
            if ((text != null) && (text2 != null))
            { 
                bool success =(int.TryParse(text, out Number))&& (int.TryParse(text2, out Number));
                if (!success)
                {
                 
                   outputLbl.Text = "Not a number";
                   return Number;
                }

               // else
               // {
                  //  Number = int.Parse(text) + int.Parse(text2);
                  //  return Number;
               // }
               
            }
            Number = int.Parse(text) + int.Parse(text2);
            outputLbl.Text = Number.ToString();
            return Number;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.Text = "show me";
        }





        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
