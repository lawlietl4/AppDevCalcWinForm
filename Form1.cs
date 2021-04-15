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
        private string input = "";
        List<int> inputs = new List<int>();
        int a = 0;
        int b = 0;

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
            input = "1";
            inputs.Add(Convert.ToInt32(input));
            outBox.AppendText("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            input = "2";
            inputs.Add(Convert.ToInt32(input));
            outBox.AppendText("2");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            input = "3";
            inputs.Add(Convert.ToInt32(input));
            outBox.AppendText("3");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            input = "4";
            inputs.Add(Convert.ToInt32(input));
            outBox.AppendText("4");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            input = "5";
            inputs.Add(Convert.ToInt32(input));
            outBox.AppendText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            input = "6";
            inputs.Add(Convert.ToInt32(input));
            outBox.AppendText("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            input = "7";
            inputs.Add(Convert.ToInt32(input));
            outBox.AppendText("7");
        }
        private void button8_Click(object sender, EventArgs e)
        {
            input = "8";
            inputs.Add(Convert.ToInt32(input));
            outBox.AppendText("8");
        }
        private void button9_Click(object sender, EventArgs e)
        {
            input = "9";
            inputs.Add(Convert.ToInt32(input));
            outBox.AppendText("9");
        }
        private void button10_Click(object sender, EventArgs e)
        {
            input = "0";
            inputs.Add(Convert.ToInt32(input));
            outBox.AppendText("0");
        }
        private void perBtn_Click(object sender, EventArgs e)
        {
            input = ".";
            outBox.AppendText(".");
            
        }
        private void eqBtn_Click(object sender, EventArgs e)
        {
            input = "=";
            outBox.AppendText("=");
            Operations();
            inputs.Clear();
        }
        private void additionBtn_Click(object sender, EventArgs e)
        {
            input = "+";
            outBox.AppendText("+");
            op = ops.add;
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            input = "-";
            outBox.AppendText("-");
            op = ops.subtract;
        }
        private void multiBtn_Click(object sender, EventArgs e)
        {
            input = "*";
            outBox.AppendText("*");
            op = ops.multiply;
        }
        private void divBtn_Click(object sender, EventArgs e)
        {
            input = "/";
            outBox.AppendText("/");
            op = ops.divide;
        }
        
        public int Operations()
        {
            int current = 0;
            int total = 0;
            foreach (int inp in inputs)
            {
                a = inp;
                b = total;
                switch (op)
                {
                    case ops.add:
                        total = a += b;
                        break;
                    case ops.divide:
                        total = a /= b;
                        break;
                    case ops.multiply:
                        total = a *= b;
                        break;
                    case ops.subtract:
                        total = b -=a;
                        break;
                }
            }
            outBox.AppendText($"\n{total}\n");
            return total;
        }
    }
}
