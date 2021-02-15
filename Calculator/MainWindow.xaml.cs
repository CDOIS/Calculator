using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        ///RRO - W0428722
        /// Reference from : https://youtu.be/7YWz44JANEY
        /// </summary>
        //"long" datatype to hold the size of the number.
        long number1 = 0;
        long number2 = 0;
        string operation = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {

            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                calcDisplay.Text = number1.ToString();
            } else
            {
                number2 = (number2 * 10) + 1;
                calcDisplay.Text = number2.ToString();
            }
            
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                calcDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                calcDisplay.Text = number2.ToString();
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                calcDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                calcDisplay.Text = number2.ToString();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                calcDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                calcDisplay.Text = number2.ToString();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                calcDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                calcDisplay.Text = number2.ToString();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                calcDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                calcDisplay.Text = number2.ToString();
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                calcDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                calcDisplay.Text = number2.ToString();
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                calcDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                calcDisplay.Text = number2.ToString();
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                calcDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                calcDisplay.Text = number2.ToString();
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10);
                calcDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10);
                calcDisplay.Text = number2.ToString();
            }
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            calcDisplay.Text = "0";
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            calcDisplay.Text = "0";
        }

        private void btnMulti_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            calcDisplay.Text = "0";
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            calcDisplay.Text = "0";
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            
            switch (operation)
            {
                case "+":
                    calcDisplay.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    calcDisplay.Text = (number1 - number2).ToString();
                    break;
                case "*":
                    calcDisplay.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    calcDisplay.Text = (number1 / number2).ToString();
                    break;
            }
        }

        private void btnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = 0;
               
            } else
            {
                number2 = 0;
            }

            calcDisplay.Text = "0";
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            calcDisplay.Text = "0";
        }

        private void btnBackSpace_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 / 10);
                calcDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 / 10);
                calcDisplay.Text = number2.ToString();
            }
        }

        private void btnPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 *= -1;
                calcDisplay.Text = number1.ToString();
            }
            else
            {
                number2 *= -1;
                calcDisplay.Text = number2.ToString();
            }
        }
    }
}
