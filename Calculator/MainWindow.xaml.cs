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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            NumberWindow.Text += "1";
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            NumberWindow.Text += "2";
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            NumberWindow.Text += "3";
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            NumberWindow.Text += "4";
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            NumberWindow.Text += "5";
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            NumberWindow.Text += "6";
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            NumberWindow.Text += "7";
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            NumberWindow.Text += "8";
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            NumberWindow.Text += "9";
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            NumberWindow.Text += "0";
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            NumberWindow.Text += "+";
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            NumberWindow.Text += "-";
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            NumberWindow.Text += "*";
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            NumberWindow.Text += "/";
        }

        private void Decimal_Click(object sender, RoutedEventArgs e)
        {
            NumberWindow.Text += ".";
        }

        /*
        private void Plus_Minus_Click(object sender, RoutedEventArgs e)
        {
            var textWindow = NumberWindow.Text;
            textWindow.Trim(' ');

            if (textWindow.Contains('+'))
            {
                var splitWindow = textWindow.Split('+');
                var number = ((Double.Parse(splitWindow[1])) * -1).ToString();
                NumberWindow.Text = $"{splitWindow[0]}+{number}";
            }
            if (textWindow.Contains('-'))
            {
                
            }

            if (textWindow.Contains('*'))
            {
               
            }

            if (textWindow.Contains('/'))
            {
                
            }
        }
        */

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            var textWindow = NumberWindow.Text;
            textWindow.Trim(' ');

            if (textWindow.Contains('+'))
            {
                NumberWindow.Text = Math.Addition('+', textWindow);
            }

            if (textWindow.Contains('-'))
            {
                NumberWindow.Text = Math.Subtraction('-', textWindow);
            }

            if (textWindow.Contains('*'))
            {
                NumberWindow.Text = Math.Multiplication('*', textWindow);
            }

            if (textWindow.Contains('/')) //10417
            {
                NumberWindow.Text = Math.Division('/', textWindow);
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var charList = new List<char>();

            foreach (var character in NumberWindow.Text)
            {
                charList.Add(character);
            }

            charList.RemoveAt(charList.Count - 1);
            NumberWindow.Text = String.Empty;

            foreach (var character in charList)
            {
                NumberWindow.Text += character;
            }
        }
    }
}
