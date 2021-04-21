using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcWinForm
{
    public partial class Form1 : Form
    {
        enum ops { add, subtract, divide, multiply, none };
        ops op = ops.none;
        List<int> inputs = new List<int>();
        int a = 0;
        int b = 0;
        double firstNum = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //calcController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (outBox.Text == "0" && outBox.Text != null)
            {
                outBox.Text = "1";
            }
            else
            {
                outBox.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(outBox.Text == "0" && outBox.Text != null)
            {
                outBox.Text = "2";
            }
            else
            {
                outBox.Text += "2";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if(outBox.Text == "0" && outBox.Text != null)
            {
                outBox.Text = "3";
            }
            else
            {
                outBox.Text += "3";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if(outBox.Text == "0" && outBox.Text != null)
            {
                outBox.Text = "4";
            }
            else
            {
                outBox.Text += "4";
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if(outBox.Text == "0" && outBox.Text != null)
            {
                outBox.Text = "5";
            }
            else
            {
                outBox.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(outBox.Text == "0" && outBox.Text != null)
            {
                outBox.Text = "6";
            }
            else
            {
                outBox.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(outBox.Text == "0" && outBox.Text != null)
            {
                outBox.Text = "7";
            }
            else
            {
                outBox.Text += "7";
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if(outBox.Text == "0" && outBox.Text != null)
            {
                outBox.Text = "8";
            }
            else
            {
                outBox.Text += "8";
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if(outBox.Text == "0" && outBox.Text != null)
            {
                outBox.Text = "9";
            }
            else
            {
                outBox.Text += "9";
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            outBox.Text += "0";
        }
        private void perBtn_Click(object sender, EventArgs e)
        {
            outBox.Text += ".";
            
        }
        private void eqBtn_Click(object sender, EventArgs e)
        {
            //outBox.AppendText("=");
            Operations();
            //inputs.Clear();
        }
        private void additionBtn_Click(object sender, EventArgs e)
        {
            //outBox.AppendText("+");
            op = ops.add;
            firstNum = Convert.ToDouble(outBox.Text);
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            //outBox.AppendText("-");
            op = ops.subtract;
            firstNum = Convert.ToDouble(outBox.Text);
        }
        private void multiBtn_Click(object sender, EventArgs e)
        {
            //outBox.AppendText("*");
            op = ops.multiply;
            firstNum = Convert.ToDouble(outBox.Text);
        }
        private void divBtn_Click(object sender, EventArgs e)
        {
            //outBox.AppendText("/");
            op = ops.divide;
            firstNum = Convert.ToDouble(outBox.Text);
        }
        
        public void Operations()
        {
            double SecondNumber;
            double Result;
            SecondNumber = Convert.ToDouble(outBox.Text);
            switch (op)
            {
                case ops.add:
                    Result = (firstNum += SecondNumber);
                    outBox.AppendText($"\n{Result}\n");
                    break;
                case ops.subtract:
                    Result = (firstNum -= SecondNumber);
                    outBox.AppendText($"\n{Result}\n");
                    break;
                case ops.multiply:
                    Result = (firstNum *= SecondNumber);
                    outBox.AppendText($"\n{Result}\n");
                    break;
                case ops.divide:
                    if (SecondNumber == 0)
                    {
                        outBox.Text = "Cannot Divide by 0";
                    }
                    else
                    {
                        Result = (firstNum /= SecondNumber);
                        outBox.AppendText($"\n{Result}\n");
                        break;
                    }
                    break;
            }
        }

        private void ClearEverythingButton_Click(object sender, EventArgs e)
        {
            outBox.Text = "0";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            outBox.Text = "0";
        }
    }
}
