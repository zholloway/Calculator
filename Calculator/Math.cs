using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Math
    {
        public static string Addition (char sign, string textWindow)
        {
            var splitArray = textWindow.Split(sign);
            splitArray[0].Trim(' ');
            var number1 = Double.Parse(splitArray[0]);
            splitArray[1].Trim(' ');
            var number2 = Double.Parse(splitArray[1]);
            var sum = number1 + number2;
            return sum.ToString();
        }

        public static string Subtraction(char sign, string textWindow)
        {
            var splitArray = textWindow.Split(sign);
            splitArray[0].Trim(' ');
            var number1 = Double.Parse(splitArray[0]);
            splitArray[1].Trim(' ');
            var number2 = Double.Parse(splitArray[1]);
            var difference = number1 - number2;
            return difference.ToString();
        }

        public static string Multiplication(char sign, string textWindow)
        {
            var splitArray = textWindow.Split(sign);
            splitArray[0].Trim(' ');
            var number1 = Double.Parse(splitArray[0]);
            splitArray[1].Trim(' ');
            var number2 = Double.Parse(splitArray[1]);
            var product = number1 * number2;
            return product.ToString();
        }

        public static string Division(char sign, string textWindow)
        {
            var splitArray = textWindow.Split(sign);
            splitArray[0].Trim(' ');
            var number1 = Double.Parse(splitArray[0]);
            splitArray[1].Trim(' ');
            var number2 = Double.Parse(splitArray[1]);
            var quotient = number1 / number2;
            return quotient.ToString();
        }
    }
}
