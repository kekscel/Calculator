using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private decimal firstvalue = 0.0m;
        private decimal secondvalue = 0.0m;
        private decimal resultvalue = 0.0m;
        private string operators = "+";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            if(textBoxPrimary.Text == "0")
            {
                textBoxPrimary.Text = "0";
            }
            else
            {
                textBoxPrimary.Text += "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxPrimary.Text == "0")
            {
                textBoxPrimary.Text = "1";
            }
            else
            {
                textBoxPrimary.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxPrimary.Text == "0")
            {
                textBoxPrimary.Text = "2";
            }
            else
            {
                textBoxPrimary.Text += "3";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxPrimary.Text == "0")
            {
                textBoxPrimary.Text = "3";
            }
            else
            {
                textBoxPrimary.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxPrimary.Text == "0")
            {
                textBoxPrimary.Text = "4";
            }
            else
            {
                textBoxPrimary.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBoxPrimary.Text == "0")
            {
                textBoxPrimary.Text = "5";
            }
            else
            {
                textBoxPrimary.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBoxPrimary.Text == "0")
            {
                textBoxPrimary.Text = "6";
            }
            else
            {
                textBoxPrimary.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBoxPrimary.Text == "0")
            {
                textBoxPrimary.Text = "7";
            }
            else
            {
                textBoxPrimary.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBoxPrimary.Text == "0")
            {
                textBoxPrimary.Text = "8";
            }
            else
            {
                textBoxPrimary.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBoxPrimary.Text == "0")
            {
                textBoxPrimary.Text = "9";
            }
            else
            {
                textBoxPrimary.Text += "9";
            }
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if (!textBoxPrimary.Text.Contains("."))
            {
                textBoxPrimary.Text += ".";
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "-":
                    secondvalue = decimal.Parse(textBoxPrimary.Text);
                    resultvalue = firstvalue - secondvalue;
                    textBoxPrimary.Text = resultvalue.ToString();
                    break;
                case "+":
                    secondvalue = decimal.Parse(textBoxPrimary.Text);
                    resultvalue = firstvalue + secondvalue;
                    textBoxPrimary.Text = resultvalue.ToString();
                    break;
                case "*":
                    secondvalue = decimal.Parse(textBoxPrimary.Text);
                    resultvalue = firstvalue * secondvalue;
                    textBoxPrimary.Text = resultvalue.ToString();
                    break;
                case "/":
                    secondvalue = decimal.Parse(textBoxPrimary.Text);
                    resultvalue = firstvalue / secondvalue;
                    textBoxPrimary.Text = resultvalue.ToString();
                    break;
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            firstvalue = decimal.Parse(textBoxPrimary.Text);
            textBoxPrimary.Clear();
            operators = "+";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            firstvalue = decimal.Parse(textBoxPrimary.Text);
            textBoxPrimary.Clear();
            operators = "-";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            firstvalue = decimal.Parse(textBoxPrimary.Text);
            textBoxPrimary.Clear();
            operators = "*";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            firstvalue = decimal.Parse(textBoxPrimary.Text);
            textBoxPrimary.Clear();
            operators = "/";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            firstvalue = 0.0m;
            secondvalue = 0.0m;
            textBoxPrimary.Text = "0";
        }

        private void buttonMinusPlus_Click(object sender, EventArgs e)
        {
            if (textBoxPrimary.Text.Contains("-"))
            {
                textBoxPrimary.Text = textBoxPrimary.Text.Trim('-');
            }
            else
            {
                textBoxPrimary.Text = "-" + textBoxPrimary.Text;
            }
        }
    }
}
