using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab09template
{
    //private static sum
    // infix implementation
    public partial class Form1 : Form
    {
        Exception binaryOperation = new ArithmeticException("Бинарные операции постфиксного вида выолняются только с двумя числами");

        // operands
        private double fst = 0;
        private double snd = 0;

        private bool getResult = false;
        private delegate double PerformCalculation(double x, double y);
        PerformCalculation _operator;

        public Form1()
        {
            InitializeComponent();
        }

        private void getresult()
        {
            try
            {
                resultBox.Text = System.Convert.ToString(_operator(fst, snd));
            }
            catch (Exception)
            {
                resultBox.Text = "ERROR";
            }
            getResult = true;
            fst = 0; snd = 0;
        }

        private void checkResultBox()
        {
            if (getResult)
            {
                resultBox.Text = "";
                getResult = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkResultBox();
            resultBox.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkResultBox();
            resultBox.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkResultBox();
            resultBox.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkResultBox();
            resultBox.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkResultBox();
            resultBox.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            checkResultBox();
            resultBox.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            checkResultBox();
            resultBox.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            checkResultBox();
            resultBox.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            checkResultBox();
            resultBox.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            checkResultBox();
            resultBox.Text += "0";
        }

        private bool operandsFormat()
        {
            if (fst == 0)
            {
                fst = System.Convert.ToDouble(resultBox.Text);
                resultBox.Text = "";
                return true;
            }
            else
            {
                return false;
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (operandsFormat())
            {
                _operator = (x,y) => x + y; // lambda-calculus
                
            }
            else
            {
                throw binaryOperation;
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (operandsFormat())
            {
                _operator = (x, y) => x - y;
            }
            else
            {
                throw binaryOperation;
            }
        }

        private void buttonProd_Click(object sender, EventArgs e)
        {
            if (operandsFormat())
            {
                _operator = (x, y) => x * y;
            }
            else
            {
                throw binaryOperation;
            }
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (operandsFormat())
            {
                _operator = (x, y) => x / y;
            }
            else
            {
                throw binaryOperation;
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (!operandsFormat())
            {
                snd = System.Convert.ToDouble(resultBox.Text);
                getresult();  
            }
            else
            {
                throw binaryOperation;
            }
        }
    }
}

