using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        private double firstNumber = 0;
        private double secondNumber = 0;
        private string currentOperation = "";
        private bool isNewCalculation = true;
        public Form1()
        {
            InitializeComponent();
            btnAdd.Click += OperationButton_Click;
            btnSubtract.Click += OperationButton_Click;
            btnMultiply.Click += OperationButton_Click;
            btnDivide.Click += OperationButton_Click;
            btnEquals.Click += btnEquals_Click;
            btnClear.Click += btnClear_Click;
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (isNewCalculation)
            {
                txtResult.Text = "";
                isNewCalculation = false;
            }

            txtResult.Text += button.Text;
        }
      

        private void btn0_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (!string.IsNullOrEmpty(txtResult.Text))
            {
                firstNumber = double.Parse(txtResult.Text);
                currentOperation = button.Text;
                lblOperation.Text = currentOperation;
                isNewCalculation = true;
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResult.Text) && !string.IsNullOrEmpty(currentOperation))
            {
                secondNumber = double.Parse(txtResult.Text);

                try
                {
                    Calculator calculator = new Calculator();
                    double result = calculator.Calculate(firstNumber, secondNumber, currentOperation);
                    txtResult.Text = result.ToString();
                }
                catch (DivideByZeroException)
                {
                    txtResult.Text = "Cannot divide by zero";
                }
                catch (Exception ex)
                {
                    txtResult.Text = "Error";
                }

                lblOperation.Text = "";
                currentOperation = "";
                isNewCalculation = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            lblOperation.Text = "";
            firstNumber = 0;
            secondNumber = 0;
            currentOperation = "";
            isNewCalculation = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
