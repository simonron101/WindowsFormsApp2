﻿using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int Number;
        string text;
        string text2;
        string test;
        int toBase = 10;
        int fromBase = 10;


        public Form1()
        {
            InitializeComponent();
        }

        private void Stuff_Here_lbl_Click(object sender, EventArgs e)
        {
            label1.ForeColor = System.Drawing.Color.Red;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CheckNumbers(textBox1.Text, textBox2.Text);
            DoMath(text, text2);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            CheckNumbers(textBox2.Text, textBox1.Text);
            DoMath(text2,text);
        }

        public int CheckNumbers(string text, string text2)
        {
  

            // Number = 0;
            if ((text != null) && (text2 != null))
            {
                bool success = (int.TryParse(text, out Number)) && (int.TryParse(text2, out Number));
                if (!success)
                {

                    outputLbl.Text = "Not a number";
                    return Number;
                }
                DoMath(text, text2);
                DoMath(text2, text);
            }
      
            return Number;
        }


        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           

             test = listBox1.GetItemText(listBox1.SelectedItem);
            CheckNumbers(textBox1.Text, textBox2.Text);
        }
        public void DoMath(string text, string text2)
        {

          if ((text != null) && (text2 != null))
            {

                switch (test)
                {
                    case "Plus":
                        Number = int.Parse(text) + int.Parse(text2);
                        outputLbl.Text = Number.ToString();

                    break;
                    case "Minus":
                        Number = int.Parse(text) - int.Parse(text2);
                        outputLbl.Text = Number.ToString();
                    break;
                    case "Multiply":
                        Number = int.Parse(text) * int.Parse(text2);
                        outputLbl.Text = Number.ToString();
                    break;
                    case "Divide":
                        Number = int.Parse(text) / int.Parse(text2);
                        outputLbl.Text = Number.ToString();
                        break;

                    default:
         
                    break;
                }
            }




           // String number = "100";
           // int fromBase = 10;
           // int toBase = 16;

           // String result = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);

        }

        // public void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        // private void listBox3_SelectedIndexChanged(object sender, System.EventArgs e)
        //{
        //}
  
        private void HandleScroll(Object sender, ScrollEventArgs e)
        {
                   // label10.Text = listBox3.SelectedItem.ToString(); //let textBox1 be your TextBox name and listBox1 be your ListBox name
}
 

        public void numericUpDown1_TextChanged(object sender, EventArgs e)
        {
            if(numericUpDown1.Text != "") {
                label7.Text = Convert.ToString(Convert.ToInt32(numericUpDown1.Text, fromBase), toBase);
                
            }
        }

  

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            toBase = 10;
            label7.Text = Convert.ToString(Convert.ToInt32(numericUpDown1.Text, fromBase), toBase);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            toBase = 2;
            label7.Text = Convert.ToString(Convert.ToInt32(numericUpDown1.Text, fromBase), toBase);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            toBase = 16;
            label7.Text = Convert.ToString(Convert.ToInt32(numericUpDown1.Text, fromBase), toBase);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            toBase = 8;
            label7.Text = Convert.ToString(Convert.ToInt32(numericUpDown1.Text, fromBase), toBase);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label7.Text = Convert.ToString(Convert.ToInt32(numericUpDown1.Text, fromBase), toBase);
        }
    }
           


}

