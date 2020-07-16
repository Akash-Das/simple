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
    public partial class Calculator : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public Calculator()
        {
            InitializeComponent();
        }

        

       

        

        

       

       

        private void buttonDigit_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed ))
            {
                textBox_Result.Clear();
            }
            isOperationPerformed = false;
            Button button = (Button)sender; //casting buttton
            if(button.Text ==".")
            {
              if(!textBox_Result.Text.Contains("."))
                {
                    textBox_Result.Text = textBox_Result.Text + button.Text;
                }
            }
            else
            textBox_Result.Text = textBox_Result.Text + button.Text;
            

            
        }
        private void buttonOperation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; //casting buttton
            if(resultValue != 0)
            {
                buttonEqual.PerformClick();
                operationPerformed = button.Text;
                isOperationPerformed = true;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
            }
            else 
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox_Result.Text);
                isOperationPerformed = true;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
            }
           
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
        }

        private void buttonClearEntry_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+" :
                    {
                        textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
                        break;
                    }
                case "-":
                    {
                        textBox_Result.Text = (resultValue - Double.Parse(textBox_Result.Text)).ToString();
                        break;
                    }
                case "*":
                    {
                        textBox_Result.Text = (resultValue * Double.Parse(textBox_Result.Text)).ToString();
                        break;
                    }
                case "/":
                    {
                        textBox_Result.Text = (resultValue / Double.Parse(textBox_Result.Text)).ToString();
                        break;
                    }
                default:
                    {
                        break;
                    }


            }
            resultValue = Double.Parse(textBox_Result.Text);
            labelCurrentOperation.Text = "";
        }
    }
}
