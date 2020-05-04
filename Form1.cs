using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int Number;
        string text;
        string text2;
        string test;

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
            label9.Text = text;
            label10.Text = text2;

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

            //label6.Text = "GOTIT";
           // label6.Text = "switch test before= " + test;
          if ((text != null) && (text2 != null))
            {

               // label8.Text = "switch test after= "+test;
                switch (test)
                {
                    case "Plus":
                        Number = int.Parse(text) + int.Parse(text2);
                        outputLbl.Text = Number.ToString();
                   // label7.Text = "output " + Number.ToString();

                    break;
                    case "Minus":
                        Number = int.Parse(text) - int.Parse(text2);
                        outputLbl.Text = Number.ToString();
                    //label7.Text = "output " + Number.ToString();
                    break;
                    case "Multiply":
                        Number = int.Parse(text) * int.Parse(text2);
                        outputLbl.Text = Number.ToString();
                    //label7.Text = "output " + Number.ToString();
                    break;
                    case "Divide":
                        Number = int.Parse(text) / int.Parse(text2);
                        outputLbl.Text = Number.ToString();
                   // label7.Text = "output " + Number.ToString();
                    break;
                    case "Power":
                        Number = int.Parse(text) * int.Parse(text2) * int.Parse(text2);
                        outputLbl.Text = Number.ToString();
                  
                        break;
                    default:
                        //label6.Text = "working on null";
                        //Number = 2000;
                    //label7.Text = "output " + Number.ToString();
                    break;
                }
            }
             label7.Text = "output "+Number.ToString(); 
           // outputLbl.Text = Number.ToString();
            //label8.Text = "116 " + Number.ToString();

        }
    }
           


}

