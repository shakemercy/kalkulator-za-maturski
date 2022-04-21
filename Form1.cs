using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        string function = "";
        double result = 0.0;
        string userInput = "";
        bool ifPreviouslyModified = false;
        bool equalsClicked = false;
        bool operationClicked = false;
        double lastNum;

        public Form1()
        {
            InitializeComponent();
        }

        private void num0_Click(object sender, EventArgs e)
        {
            if (ifPreviouslyModified)
            {
                ifPreviouslyModified = false;
                userInput = "";
            }
            if (operationClicked)
            {
                userInput = "";
                operationClicked = false;
            }
            if (equalsClicked)
            {
                result = 0;
                equalsClicked = false;
            }
            if (calculatorDisplay.Text != "0")
            {
                calculatorDisplay.Text = "";
                userInput += "0";
                calculatorDisplay.Text += userInput;
            }
        }

        private void num1_Click(object sender, EventArgs e)
        {
//prvi_button
            if (ifPreviouslyModified)
            {
                ifPreviouslyModified = false;
                userInput = "";
            }
            if (operationClicked)
            {
                userInput = "";
                operationClicked = false;
            }
            if (equalsClicked)
            {
                result = 0;
                equalsClicked = false;
            }
            calculatorDisplay.Text = "";
            userInput += "1";
            calculatorDisplay.Text += userInput;
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (ifPreviouslyModified)
            {
                ifPreviouslyModified = false;
                userInput = "";
            }
            if (operationClicked)
            {
                userInput = "";
                operationClicked = false;
            }
            if (equalsClicked)
            {
                result = 0;
                equalsClicked = false;
            }
            calculatorDisplay.Text = "";
            userInput += "2";
            calculatorDisplay.Text += userInput;
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (ifPreviouslyModified)
            {
                ifPreviouslyModified = false;
                userInput = "";
            }
            if (operationClicked)
            {
                userInput = "";
                operationClicked = false;
            }
            if (equalsClicked)
            {
                result = 0;
                equalsClicked = false;
            }
            calculatorDisplay.Text = "";
            userInput += "3";
            calculatorDisplay.Text += userInput;
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (ifPreviouslyModified)
            {
                ifPreviouslyModified = false;
                userInput = "";
            }
            if (operationClicked)
            {
                userInput = "";
                operationClicked = false;
            }
            if (equalsClicked)
            {
                result = 0;
                equalsClicked = false;
            }
            calculatorDisplay.Text = "";
            userInput += "4";
            calculatorDisplay.Text += userInput;
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (ifPreviouslyModified)
            {
                ifPreviouslyModified = false;
                userInput = "";
            }
            if (operationClicked)
            {
                userInput = "";
                operationClicked = false;
            }
            if (equalsClicked)
            {
                result = 0;
                equalsClicked = false;
            }
            calculatorDisplay.Text = "";
            userInput += "5";
            calculatorDisplay.Text += userInput;
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (ifPreviouslyModified)
            {
                ifPreviouslyModified = false;
                userInput = "";
            }
            if (operationClicked)
            {
                userInput = "";
                operationClicked = false;
            }
            if (equalsClicked)
            {
                result = 0;
                equalsClicked = false;
            }
            calculatorDisplay.Text = "";
            userInput += "6";
            calculatorDisplay.Text += userInput;
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (ifPreviouslyModified)
            {
                ifPreviouslyModified = false;
                userInput = "";
            }
            if (operationClicked)
            {
                userInput = "";
                operationClicked = false;
            }
            if (equalsClicked)
            {
                result = 0;
                equalsClicked = false;
            }
            calculatorDisplay.Text = "";
            userInput += "7";
            calculatorDisplay.Text += userInput;
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (ifPreviouslyModified)
            {
                ifPreviouslyModified = false;
                userInput = "";
            }
            if (operationClicked)
            {
                userInput = "";
                operationClicked = false;
            }
            if (equalsClicked)
            {
                result = 0;
                equalsClicked = false;
            }
            calculatorDisplay.Text = "";
            userInput += "8";
            calculatorDisplay.Text += userInput;
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (ifPreviouslyModified)
            {
                ifPreviouslyModified = false;
                userInput = "";
            }
            if (operationClicked)
            {
                userInput = "";
                operationClicked = false;
            }
            if (equalsClicked)
            {
                result = 0;
                equalsClicked = false;
            }
            calculatorDisplay.Text = "";
            userInput += "9";
            calculatorDisplay.Text += userInput;
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            if (userInput != "" && equalsClicked == false && operationClicked == false)
            {
                if (function == "")
                {
                    result += Convert.ToDouble(userInput);
                    userInput = "";
                }
                else
                {
                    result /= Convert.ToDouble(userInput);
                    calculatorDisplay.Text = result.ToString();
                    ifPreviouslyModified = false;
                    lastNum = Convert.ToDouble(userInput);
                    userInput = "";
                }
            }
            function = "/";
            equalsClicked = false;
            operationClicked = true;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (userInput != "" && equalsClicked == false && operationClicked == false)
            {
                if (function == "")
                {
                    result += Convert.ToDouble(userInput);
                    userInput = "";
                }
                else
                {
                    result *= Convert.ToDouble(userInput);
                    calculatorDisplay.Text = result.ToString();
                    ifPreviouslyModified = false;
                    lastNum = Convert.ToDouble(userInput);
                    userInput = "";
                }
            }
            function = "*";
            equalsClicked = false;
            operationClicked = true;
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (userInput != "" && equalsClicked == false && operationClicked == false)
            {
                if (function == "")
                {
                    result += Convert.ToDouble(userInput);
                    userInput = "";
                }
                else
                {
                    result -= Convert.ToDouble(userInput);
                    calculatorDisplay.Text = result.ToString();
                    ifPreviouslyModified = false;
                    lastNum = Convert.ToDouble(userInput);
                    userInput = "";
                }

            }
            function = "-";
            equalsClicked = false;
            operationClicked = true;
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            if (Double.IsNaN(calculatorDisplay.Text[calculatorDisplay.Text.Length - 1]))
            {
                calculatorDisplay.Text = calculatorDisplay.Text.Substring(1);
            }
            if (userInput != "" && equalsClicked == false && operationClicked == false)
            {
                if (function == "")
                {
                    result += Convert.ToDouble(userInput);
                    userInput = "";
                }
                else
                {
                    result += Convert.ToDouble(userInput);
                    calculatorDisplay.Text = result.ToString();
                    ifPreviouslyModified = false;
                    lastNum = Convert.ToDouble(userInput);
                    userInput = "";
                }
            }
            function = "+";
            equalsClicked = false;
            operationClicked = true;
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            equalsClicked = true;
            if (userInput != "")
            {
                double firstNum;
                firstNum = Convert.ToDouble(userInput);

                //Plus
                if (function == "+")
                {
                    function = "";
                    result += firstNum;
                    calculatorDisplay.Text = result.ToString();
                    userInput = "";
                    ifPreviouslyModified = true;
                }

                //Minus
                else if (function == "-")
                {
                    function = "";
                    result -= firstNum;
                    calculatorDisplay.Text = result.ToString();
                    userInput = "";
                    ifPreviouslyModified = true;
                }

                //Puta
                else if (function == "*")
                {
                    function = "";
                    result *= firstNum;
                    calculatorDisplay.Text = result.ToString();
                    userInput = "";
                    ifPreviouslyModified = true;
                }

                //Podeljeno
                else if (function == "/")
                {
                    if (firstNum == 0)
                    {
                        calculatorDisplay.Text = "Error";
                        return;
                    }
                    function = "";
                    result /= firstNum;
                    calculatorDisplay.Text = result.ToString();
                    userInput = "";
                    ifPreviouslyModified = true;
                }
            }

        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            if (userInput.Contains(".")) return;
            if (userInput=="")
            {
                calculatorDisplay.Text += ".";
                userInput += "0.";
            }
            else 
            {
                calculatorDisplay.Text += ".";
                userInput += ".";
            }
        }

        private void reciprocalButton_Click(object sender, EventArgs e)
        {
            if (userInput == "0")
            {
                calculatorDisplay.Text = "Error";
                return;
            }
            calculatorDisplay.Text = "";
            if (equalsClicked)
            {
                calculatorDisplay.Text += 1 / result;
                userInput = (1 / result).ToString();
                result = 1 / result;
            }
            else
            {
                calculatorDisplay.Text += 1 / Double.Parse(userInput);
                userInput = (1 / Double.Parse(userInput)).ToString();
            }
            ifPreviouslyModified = true;
        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            if (userInput == "0")
            {
                calculatorDisplay.Text = "Error";
                return;
            }
            calculatorDisplay.Text = "";
            if (equalsClicked)
            {
                calculatorDisplay.Text += Math.Pow(result, 2);
                userInput = Math.Pow(result, 2).ToString();
                result = Math.Pow(result, 2);
            }
            else 
            {
                calculatorDisplay.Text += Math.Pow(Double.Parse(userInput), 2);
                userInput = Math.Pow(Double.Parse(userInput), 2).ToString();
            }
            ifPreviouslyModified = true;
        }

        private void rootButton_Click(object sender, EventArgs e)
        {
            if (userInput == "0")
            {
                calculatorDisplay.Text = "Error";
                return;
            }
            calculatorDisplay.Text = "";
            if (equalsClicked)
            {
                calculatorDisplay.Text += Math.Sqrt(result);
                userInput = Math.Sqrt(result).ToString();
                result = Math.Sqrt(result);
            }
            else
            {
                calculatorDisplay.Text += Math.Sqrt(Double.Parse(userInput));
                userInput = Math.Sqrt(Double.Parse(userInput)).ToString();
            }
            ifPreviouslyModified = true;
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            if (ifPreviouslyModified) return;

            if (calculatorDisplay.Text.Length > 0)
            {
                userInput = calculatorDisplay.Text.Remove(calculatorDisplay.Text.Length - 1, 1);
                calculatorDisplay.Text = calculatorDisplay.Text.Remove(calculatorDisplay.Text.Length - 1, 1);
            }

            if (calculatorDisplay.Text == "")
                calculatorDisplay.Text = "0";
        }

        private void clearEntryButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "0";
            userInput = "";
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            userInput = "";
            result = 0.0;
            calculatorDisplay.Text = "0";
            ifPreviouslyModified = false;
            equalsClicked = false;
            operationClicked = false;
            function = "";
        }

        private void negativeNumberButton_Click(object sender, EventArgs e)
        {
            if (calculatorDisplay.Text.Length > 0)
            {
                if (calculatorDisplay.Text.StartsWith("-"))
                {
                    calculatorDisplay.Text = calculatorDisplay.Text.Substring(1);
                    userInput = userInput.Substring(1);
                }
                else if (!string.IsNullOrEmpty(calculatorDisplay.Text) && decimal.Parse(calculatorDisplay.Text) != 0)
                {
                    calculatorDisplay.Text = "-" + calculatorDisplay.Text;
                    userInput = userInput.Insert(0, "-");
                }
            }
        }
    }
}