using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CalculatorKonov
{
    public partial class CalcKonov : Form
    {
        int a = 0;
        int b = 0;
        int c = 0;
        string pusto = "";
        bool funcPlus = false;
        bool funcMinus = false;
        bool funcUmnozhenie = false;
        bool funcDelenie = false;

        public CalcKonov()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text) == pusto)
            {
                textBox1.Text = textBox1.Text + 0;
                a = Convert.ToInt32(textBox1.Text);
                textBox1.Clear();
                label1.Text = Convert.ToString(a) + " +";
                funcPlus = true;
            }
            else
            {
                a = Convert.ToInt32(textBox1.Text);
                textBox1.Clear();
                label1.Text = Convert.ToString(a) + " +";
                funcPlus = true;
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text) == pusto)
            {
                textBox1.Text = textBox1.Text + 0;
                a = Convert.ToInt32(textBox1.Text);
                textBox1.Clear();
                label1.Text = Convert.ToString(a) + " -";
                funcMinus = true;
            }
            else
            {
                a = Convert.ToInt32(textBox1.Text);
                textBox1.Clear();
                label1.Text = Convert.ToString(a) + " -";
                funcMinus = true;
            }
        }

        private void buttonSter_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void buttonDelenie_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text) == pusto)
            {
                textBox1.Text = textBox1.Text + 0;
                a = Convert.ToInt32(textBox1.Text);
                textBox1.Clear();
                label1.Text = Convert.ToString(a) + " /";
                funcDelenie = true;
            }
            else
            {
                a = Convert.ToInt32(textBox1.Text);
                textBox1.Clear();
                label1.Text = Convert.ToString(a) + " /";
                funcDelenie = true;
            }
        }

        private void buttonUmnozhenie_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text) == pusto) 
            {
                textBox1.Text = textBox1.Text + 0;
                a = Convert.ToInt32(textBox1.Text);
                textBox1.Clear();
                label1.Text = Convert.ToString(a) + " *";
                funcUmnozhenie = true;
            }
            else 
            {
                a = Convert.ToInt32(textBox1.Text);
                textBox1.Clear();
                label1.Text = Convert.ToString(a) + " *";
                funcUmnozhenie = true;
            }
        }

        private void buttonRavno_Click(object sender, EventArgs e)
        {
            while (funcPlus) // сложение
            {
                if ((textBox1.Text) == pusto)
                {
                    textBox1.Text = textBox1.Text + "0";
                    b = Convert.ToInt32(b);
                    textBox1.Clear();
                    int c = a + b;
                    textBox1.Text = textBox1.Text + Convert.ToString(c);
                    label1.Text = "";
                    funcPlus = false;
                }
                else
                {
                    b = Convert.ToInt32(textBox1.Text);
                    textBox1.Clear();
                    int c = a + b;
                    textBox1.Text = textBox1.Text + Convert.ToString(c);
                    label1.Text = "";
                    funcPlus = false;
                }
            }

            while (funcMinus) // вычитание
            {
                if ((textBox1.Text) == pusto)
                {
                    textBox1.Text = textBox1.Text + "0";
                    b = Convert.ToInt32(b);
                    textBox1.Clear();
                    int c = a - b;
                    textBox1.Text = textBox1.Text + Convert.ToString(c);
                    label1.Text = "";
                    funcMinus = false;
                }
                else
                {
                    b = Convert.ToInt32(textBox1.Text);
                    textBox1.Clear();
                    int c = a - b;
                    textBox1.Text = textBox1.Text + Convert.ToString(c);
                    label1.Text = "";
                    funcMinus = false;
                }
            }
            while (funcDelenie) // деление
            {
                if ((textBox1.Text) == pusto)
                {
                    textBox1.Text = textBox1.Text + "0";
                    b = Convert.ToInt32(b);
                    textBox1.Clear();
                    int c = a / b;
                    textBox1.Text = textBox1.Text + Convert.ToString(c);
                    label1.Text = "";
                    funcDelenie = false;
                }
                else
                {
                    b = Convert.ToInt32(textBox1.Text);
                    textBox1.Clear();
                    int c = a / b;
                    textBox1.Text = textBox1.Text + Convert.ToString(c);
                    label1.Text = "";
                    funcDelenie = false;
                }
            }

            while (funcUmnozhenie) // умножение
            {
                if ((textBox1.Text) == pusto) 
                {
                    textBox1.Text = textBox1.Text + "0";
                    b = Convert.ToInt32(b);
                    textBox1.Clear();
                    int c = a * b;
                    textBox1.Text = textBox1.Text + Convert.ToString(c);
                    label1.Text = "";
                    funcUmnozhenie = false;
                }
                else
                {
                    b = Convert.ToInt32(textBox1.Text);
                    textBox1.Clear();
                    int c = a * b;
                    textBox1.Text = textBox1.Text + Convert.ToString(c);
                    label1.Text = "";
                funcUmnozhenie = false;
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            bool funcPlus = false;
            bool funcMinus = false;
            bool funcUmnozhenie = false;
            bool funcDelenie = false;
            label1.Text = "";
        }
    }
}
