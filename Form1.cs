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

    private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                equalsButton.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.NumPad0) || e.KeyCode.Equals(Keys.D0))
            {
                num0.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.NumPad1) || e.KeyCode.Equals(Keys.D1))
            {
                num1.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.NumPad2) || e.KeyCode.Equals(Keys.D2))
            {
                num2.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.NumPad3) || e.KeyCode.Equals(Keys.D3))
            {
                num3.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.NumPad4) || e.KeyCode.Equals(Keys.D4))
            {
                num4.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.NumPad5) || e.KeyCode.Equals(Keys.D5))
            {
                num5.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.NumPad6) || e.KeyCode.Equals(Keys.D6))
            {
                num6.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.NumPad7) || e.KeyCode.Equals(Keys.D7))
            {
                num7.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.NumPad8) || e.KeyCode.Equals(Keys.D8))
            {
                num8.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.NumPad9) || e.KeyCode.Equals(Keys.D9))
            {
                num9.PerformClick();
            }
            //OPERACIJE
            else if (e.KeyCode.Equals(Keys.Multiply))
            {
                multiplyButton.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.Divide))
            {
                divideButton.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.Add))
            {
                plusButton.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.Subtract))
            {
                minusButton.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.Back))
            {
                undoButton.PerformClick();
            }
            else if (e.KeyCode.Equals(Keys.Delete))
            {
                clearEntryButton.PerformClick();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void num0_Click(object sender, EventArgs e)
        {
            if (ifPreviouslyModified)
            {
                userInput = "";
                ifPreviouslyModified = false;
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
            if (ifPreviouslyModified)
            {
                userInput = "";
                ifPreviouslyModified = false;
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
                userInput = "";
                ifPreviouslyModified = false;
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
                userInput = "";
                ifPreviouslyModified = false;
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
                userInput = "";
                ifPreviouslyModified = false;
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
                userInput = "";
                ifPreviouslyModified = false;
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
                userInput = "";
                ifPreviouslyModified = false;
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
                userInput = "";
                ifPreviouslyModified = false;
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
                userInput = "";
                ifPreviouslyModified = false;
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
                userInput = "";
                ifPreviouslyModified = false;
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
            if (userInput == "")
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
            else if (operationClicked == true && userInput == "")
            {
                result = 1 / result;
                calculatorDisplay.Text = result.ToString();
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
            else if (operationClicked == true && userInput == "")
            {
                result = Math.Pow(result, 2);
                calculatorDisplay.Text = result.ToString();
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
            if (userInput == "")
            {
                return;
            }
            if (calculatorDisplay.Text.StartsWith("-"))
            {
                calculatorDisplay.Text = "Error";
                userInput = "";
                return;
            }
            calculatorDisplay.Text = "";
            if (equalsClicked)
            {
                calculatorDisplay.Text += Math.Sqrt(result);
                userInput = Math.Sqrt(result).ToString();
                result = Math.Sqrt(result);
            }
            else if (operationClicked == true && userInput == "") { 
                result = Math.Sqrt(result);
                calculatorDisplay.Text = result.ToString();    
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
            if (calculatorDisplay.Text == "" || calculatorDisplay.Text.StartsWith("-"))
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
                    if (!string.IsNullOrEmpty(userInput))
                        userInput = userInput.Substring(1);
                    if (!string.IsNullOrEmpty(result.ToString()))
                        result *= -1;
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