using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculater
{
    // ctrl + K + C
    public partial class FrmCalc : Form
    {
        public FrmCalc()
        {
            InitializeComponent();
        }
        static CalcFunc method = new CalcFunc();


        private void button1_Click(object sender, EventArgs e)
        {
            textinput.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textinput.Text.Length == 0)
            {
                textinput.Text += "/";
                return;
            }
            else if (textinput.Text.Length == 3)
            {
                if (textinput.Text.Substring(1, 1) == "+")
                {
                    textinput.Text = (int.Parse(textinput.Text.Substring(0, 1)) + int.Parse(textinput.Text.Substring(2, 1))).ToString();
                }
                else if (textinput.Text.Substring(1, 1) == "-")
                {
                    textinput.Text = (int.Parse(textinput.Text.Substring(0, 1)) - int.Parse(textinput.Text.Substring(2, 1))).ToString();
                }
                else if (textinput.Text.Substring(1, 1) == "*")
                {
                    textinput.Text = (int.Parse(textinput.Text.Substring(0, 1)) * int.Parse(textinput.Text.Substring(2, 1))).ToString();
                }
                else if (textinput.Text.Substring(1, 1) == "/")
                {
                    textinput.Text = (int.Parse(textinput.Text.Substring(0, 1)) / int.Parse(textinput.Text.Substring(2, 1))).ToString();
                }
            }
           
            textinput.Text += "/";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textinput.Text.Length == 0)
            {
                textinput.Text += "+";
                return;
            }
            else if(textinput.Text.Length == 3)
            {
                ;
            }
            
            textinput.Text += "+";
     
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textinput.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textinput.Text += "1";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textinput.Text += "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textinput.Text += "2";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textinput.Text = textinput.Text.Remove(textinput.Text.Length - 1,1);
        }

        private void three_Click(object sender, EventArgs e)
        {
            textinput.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            textinput.Text += "4";
        }

        private void fire_Click(object sender, EventArgs e)
        {
            textinput.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            textinput.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            textinput.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            textinput.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            textinput.Text += "9";
        }

        private void sub_Click(object sender, EventArgs e)
        {
            textinput.Text += "-";
        }

        private void divis_Click(object sender, EventArgs e)
        {
            textinput.Text += "*";
        }
    }
}
