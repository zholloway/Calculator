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
            IndividualNumberWindow.Text += "1";
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            IndividualNumberWindow.Text += "2";
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            IndividualNumberWindow.Text += "3";
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            IndividualNumberWindow.Text += "4";
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            IndividualNumberWindow.Text += "5";
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            IndividualNumberWindow.Text += "6";
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            IndividualNumberWindow.Text += "7";
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            IndividualNumberWindow.Text += "8";
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            IndividualNumberWindow.Text += "9";
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            IndividualNumberWindow.Text += "0";
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            NumberWindow.Text += $"{IndividualNumberWindow.Text}+";
            IndividualNumberWindow.Text = String.Empty;         
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            NumberWindow.Text += $"{IndividualNumberWindow.Text}-";
            IndividualNumberWindow.Text = String.Empty;
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            NumberWindow.Text += $"{IndividualNumberWindow.Text}*";
            IndividualNumberWindow.Text = String.Empty;
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            NumberWindow.Text += $"{IndividualNumberWindow.Text}/";
            IndividualNumberWindow.Text = String.Empty;
        }

        private void Decimal_Click(object sender, RoutedEventArgs e)
        {
            NumberWindow.Text += ".";
            IndividualNumberWindow.Text += ".";
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
            NumberWindow.Text += IndividualNumberWindow.Text;
            var textWindow = NumberWindow.Text;
            textWindow.Trim(' ');

            if (textWindow.Contains('+'))
            {
                IndividualNumberWindow.Text = Math.Addition('+', textWindow);
            }

            if (textWindow.Contains('-'))
            {
                IndividualNumberWindow.Text = Math.Subtraction('-', textWindow);
            }

            if (textWindow.Contains('*'))
            {
                IndividualNumberWindow.Text = Math.Multiplication('*', textWindow);
            }

            if (textWindow.Contains('/')) //10417
            {
                IndividualNumberWindow.Text = Math.Division('/', textWindow);
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var charList = new List<char>();

            foreach (var character in IndividualNumberWindow.Text)
            {
                charList.Add(character);
            }

            charList.RemoveAt(charList.Count - 1);
            IndividualNumberWindow.Text = String.Empty;

            foreach (var character in charList)
            {
                IndividualNumberWindow.Text += character;
            }
        }

        private void Clear_All_Click(object sender, RoutedEventArgs e)
        {
            NumberWindow.Text = String.Empty;
            IndividualNumberWindow.Text = String.Empty;
        }

        private void CE_Click(object sender, RoutedEventArgs e)
        {
            IndividualNumberWindow.Text = String.Empty;
        }
    }
}
