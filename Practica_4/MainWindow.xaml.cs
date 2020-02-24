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

namespace Practica_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int num1 = 0;
        int num2 = 0;
        string op = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                num1 = (num1 * 10) + 1;
                tbPantalla.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 1;
                tbPantalla.Text = num2.ToString();
            }

            
        }
        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                num1 = (num1 * 10) + 2;
                tbPantalla.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 2;
                tbPantalla.Text = num2.ToString();
            }
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                num1 = (num1 * 10) + 3;
                tbPantalla.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 3;
                tbPantalla.Text = num2.ToString();
            }
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                num1 = (num1 * 10) + 4;
                tbPantalla.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 4;
                tbPantalla.Text = num2.ToString();
            }
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                num1 = (num1 * 10) + 5;
                tbPantalla.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 5;
                tbPantalla.Text = num2.ToString();
            }
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                num1 = (num1 * 10) + 6;
                tbPantalla.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 6;
                tbPantalla.Text = num2.ToString();
            }
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                num1 = (num1 * 10) + 7;
                tbPantalla.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 7;
                tbPantalla.Text = num2.ToString();
            }
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                num1 = (num1 * 10) + 8;
                tbPantalla.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 8;
                tbPantalla.Text = num2.ToString();
            }
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                num1 = (num1 * 10) + 9;
                tbPantalla.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 9;
                tbPantalla.Text = num2.ToString();
            }
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                num1 = (num1 * 10);
                tbPantalla.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10);
                tbPantalla.Text = num2.ToString();
            }
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            op = "+";
            tbPantalla.Text = "0";
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            op = "-";
            tbPantalla.Text = "0";
        }

        private void BtnMul_Click(object sender, RoutedEventArgs e)
        {
            op = "*";
            tbPantalla.Text = "0";
        }

        private void BtnDiv_Click(object sender, RoutedEventArgs e)
        {
            op = "/";
            tbPantalla.Text = "0";
        }

        private void BtnEqual_Click(object sender, RoutedEventArgs e)
        {
            switch (op)
            {
                case "+":
                    tbPantalla.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    tbPantalla.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    tbPantalla.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    tbPantalla.Text = (num1 / num2).ToString();
                    break;
            }
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            num1 = 0;
            num2 = 0;
            op = "";
            tbPantalla.Text = "0";
        }
    }
}
