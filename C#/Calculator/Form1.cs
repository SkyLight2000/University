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
        private string a;
        private string b;
        private char operation;
        private bool p = false;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void N(int s)
        {
            if ((rtb1.Text.IndexOf("∞") == -1))
            {
                if (rtb1.Text == "0")
                {
                    rtb1.Text = s.ToString("0.######");
                }
                else
                {
                    rtb1.Text += s;
                }
            }
        }

        private void Add()
        {
            int i = a.Length + 1;
            while (i < rtb1.Text.Length)
            {
                b += rtb1.Text[1];
                i++;
            }
            rtb1.Text = Convert.ToString(Convert.ToDouble(a) + Convert.ToDouble(b));
            b = null;
        }

        private void Calc()
        {
            int i = a.Length + 1;
            while (i < rtb1.Text.Length)
            {
                b += rtb1.Text[i];
                i++;
            }
            if (operation == '+')
            {
                rtb1.Text = Convert.ToString(Convert.ToDouble(a) + Convert.ToDouble(b));
            }
            if (operation == '-')
            {
                rtb1.Text = Convert.ToString(Convert.ToDouble(a) - Convert.ToDouble(b));
            }
            if (operation == '*')
            {
                rtb1.Text = Convert.ToString(Convert.ToDouble(a) * Convert.ToDouble(b));
            }
            if (operation == '/')
            {
                if (b == "0")
                {
                    rtb1.Font = new Font(rtb1.Font.Name, 25);
                    rtb1.Text = "Деление на ноль невозможно";
                }
                else
                {
                    rtb1.Text = Convert.ToString(Convert.ToDouble(a) / Convert.ToDouble(b));
                }
            }
            b = null;
        }

        private void Cl(char c)
        {
            if (p)
            {
                Calc();
            }
            operation = c;
            a = rtb1.Text;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            rtb1.Text = "0";
            p = false;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (rtb1.Text == "0")
            {
                rtb1.Text = "0";
            }
            else
            {
                rtb1.Text += "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            N(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            N(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            N(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            N(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            N(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            N(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            N(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            N(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            N(9);
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            string rez = "";
            int i = 0;
            if (rtb1.Text != "0")
            {
                while (i < rtb1.Text.Length - 1)
                {
                    rez += rtb1.Text[i];
                    i++;
                }
                rtb1.Text = rez;
                if (rez == string.Empty)
                {
                    rtb1.Text = "0";
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Cl('+');
            rtb1.Text += "+";
            p = true;
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            Cl('-');
            rtb1.Text += "-";
            p = true;
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            Cl('*');
            rtb1.Text += "×";
            p = true;

        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            Cl('/');
            rtb1.Text += "÷";
            p = true;
        }
        private void buttonEq_Click(object sender, EventArgs e)
        {
            Calc();
            p = false;
        }

        private void buttonChangeSign_Click(object sender, EventArgs e)
        {
            if(rtb1.Text[0] == '-')
            {
                rtb1.Text = rtb1.Text.Remove(0, 1);
            }
            else
            {
                rtb1.Text = "-" + rtb1.Text;
            }
        }

        private void buttonCom_Click(object sender, EventArgs e)
        {
            if((rtb1.Text.IndexOf("∞") == -1))
            {
                rtb1.Text += ",";
            }
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            rtb1.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(rtb1.Text)));
        }
    }
}
