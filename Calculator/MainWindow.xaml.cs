﻿using System;
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
using System.IO;

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

        private bool justDidCalculation { get; set; }

        private string PathToMemory = "memory.csv";

        private void One_Click(object sender, RoutedEventArgs e)
        {
            if (justDidCalculation == true)
            {
                IndividualNumberWindow.Text = String.Empty;
                IndividualNumberWindow.Text += "1";
                justDidCalculation = false;
                NumberWindow.Text = String.Empty;
            }
            else
            {
                IndividualNumberWindow.Text += "1";
            }           
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            if (justDidCalculation == true)
            {
                IndividualNumberWindow.Text = String.Empty;
                IndividualNumberWindow.Text += "2";
                justDidCalculation = false;
                NumberWindow.Text = String.Empty;
            }
            else
            {
                IndividualNumberWindow.Text += "2";
            }
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            if (justDidCalculation == true)
            {
                IndividualNumberWindow.Text = String.Empty;
                IndividualNumberWindow.Text += "3";
                justDidCalculation = false;
                NumberWindow.Text = String.Empty;
            }
            else
            {
                IndividualNumberWindow.Text += "3";
            }
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            if (justDidCalculation == true)
            {
                IndividualNumberWindow.Text = String.Empty;
                IndividualNumberWindow.Text += "4";
                justDidCalculation = false;
                NumberWindow.Text = String.Empty;
            }
            else
            {
                IndividualNumberWindow.Text += "4";
            }
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            if (justDidCalculation == true)
            {
                IndividualNumberWindow.Text = String.Empty;
                IndividualNumberWindow.Text += "5";
                justDidCalculation = false;
                NumberWindow.Text = String.Empty;
            }
            else
            {
                IndividualNumberWindow.Text += "5";
            }
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            if (justDidCalculation == true)
            {
                IndividualNumberWindow.Text = String.Empty;
                IndividualNumberWindow.Text += "6";
                justDidCalculation = false;
                NumberWindow.Text = String.Empty;
            }
            else
            {
                IndividualNumberWindow.Text += "6";
            }
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            if (justDidCalculation == true)
            {
                IndividualNumberWindow.Text = String.Empty;
                IndividualNumberWindow.Text += "7";
                justDidCalculation = false;
                NumberWindow.Text = String.Empty;
            }
            else
            {
                IndividualNumberWindow.Text += "7";
            }
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            if (justDidCalculation == true)
            {
                IndividualNumberWindow.Text = String.Empty;
                IndividualNumberWindow.Text += "8";
                justDidCalculation = false;
                NumberWindow.Text = String.Empty;
            }
            else
            {
                IndividualNumberWindow.Text += "8";
            }
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            if (justDidCalculation == true)
            {
                IndividualNumberWindow.Text = String.Empty;
                IndividualNumberWindow.Text += "9";
                justDidCalculation = false;
                NumberWindow.Text = String.Empty;
            }
            else
            {
                IndividualNumberWindow.Text += "9";
            }
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            if (justDidCalculation == true)
            {
                IndividualNumberWindow.Text = String.Empty;
                IndividualNumberWindow.Text += "0";
                justDidCalculation = false;
                NumberWindow.Text = String.Empty;
            }
            else
            {
                IndividualNumberWindow.Text += "0";
            }
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
            if (justDidCalculation == true)
            {
                IndividualNumberWindow.Text = String.Empty;
                IndividualNumberWindow.Text += ".";
                justDidCalculation = false;
                NumberWindow.Text = String.Empty;
            }
            else
            {
                IndividualNumberWindow.Text += ".";
            }
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

            justDidCalculation = true;
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

        private void Memory_Store_Click (object sender, RoutedEventArgs e)
        {
            using (var writer = new StreamWriter(PathToMemory))
            {
                writer.WriteLine(IndividualNumberWindow.Text);
            }
        }

        private void Memory_Recall_Click(object sender, RoutedEventArgs e)
        {
            using (var reader = new StreamReader(PathToMemory))
            {
                while (reader.Peek() > -1)
                {
                    IndividualNumberWindow.Text = reader.ReadLine();
                }
            }
        }

        private void Memory_Clear_Click(object sender, RoutedEventArgs e)
        {
            using (var writer = new StreamWriter(PathToMemory))
            {
                writer.WriteLine(String.Empty);
            }
        }

        private void Squared_Click(object sender, RoutedEventArgs e)
        {
            var squared = double.Parse(IndividualNumberWindow.Text);
            squared = squared * squared;
            IndividualNumberWindow.Text = squared.ToString();
        }
    }
}
