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
        private string input = "";
        string[] inputs = Array.Empty<string>();

        public string Input { get => input; set => input = value; }
        public string[] Inputs { get => inputs; set => inputs = value; }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Input = "1";
            outBox.AppendText("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Input = "2";
            outBox.AppendText("2");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Input = "3";
            outBox.AppendText("3");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Input = "4";
            outBox.AppendText("4");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Input = "5";
            outBox.AppendText("5");
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            Input = "6";
            outBox.AppendText("6");
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            Input = "7";
            outBox.AppendText("7");
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Input = "8";
            outBox.AppendText("8");
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Input = "9";
            outBox.AppendText("9");
        }
        private void button10_Click(object sender, EventArgs e)
        {
            Input = "0";
            outBox.AppendText("0");
        }
        private void perBtn_Click(object sender, EventArgs e)
        {
            Input = ".";
            outBox.AppendText(".");
        }
        private void eqBtn_Click(object sender, EventArgs e)
        {
            Input = "=";
            outBox.AppendText("=");
        }
        private void additionBtn_Click(object sender, EventArgs e)
        {
            Input = "+";
            outBox.AppendText("+");
        }
        
        private void subBtn_Click(object sender, EventArgs e)
        {
            Input = "-";
            outBox.AppendText("-");
        }
        private void multiBtn_Click(object sender, EventArgs e)
        {
            Input = "*";
            outBox.AppendText("*");
        }
        private void divBtn_Click(object sender, EventArgs e)
        {
            Input = "/";
            outBox.AppendText("/");
        }
        public void calcController()
        {
            while(Input != "=")
            {
                switch (Input)
                {
                    case "1":
                        Inputs.Append("1");
                        break;
                    case "2":
                        Inputs.Append("2");
                        break;
                    case "3":
                        Inputs.Append("3");
                        break;
                    case "4":
                        Inputs.Append("4");
                        break;
                    case "5":
                        Inputs.Append("5");
                        break;
                    case "6":
                        Inputs.Append("6");
                        break;
                    case "7":
                        Inputs.Append("7");
                        break;
                    case "8":
                        Inputs.Append("8");
                        break;
                    case "9":
                        Inputs.Append("9");
                        break;
                    case "0":
                        Inputs.Append("0");
                        break;
                    case "-":
                        Inputs.Append("-");
                        break;
                    case "*":
                        Inputs.Append("*");
                        break;
                    case "/":
                        Inputs.Append("/");
                        break;
                    case "+":
                        Inputs.Append("+");
                        break;
                }
            }
        }
    }
}
