using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator_3
{
    public static class Calculator
    {
        public static double Calculate(string problem)
        {
            bool runFirstStep = true;

            var numbers = Array.ConvertAll(problem.Split('+', '-', '*', '/'), double.Parse).ToList();
            var chars_ = problem.Split('1', '2', '3', '4', '5', '6', '7', '8', '9', '0');

            List<string> chars = chars_.Where(c => c != "").ToList();

            while (runFirstStep)
            {
                if (chars.Contains("*"))
                {
                    int index = chars.IndexOf("*");
                    double result = numbers[index] * numbers[index+1];
                    numbers[index] = result;
                    numbers.Remove(numbers[index + 1]);
                    chars.Remove(chars[index]);
                }
                else if (chars.Contains("/"))
                {
                    int index = chars.IndexOf("/");
                    double result = numbers[index] / numbers[index + 1];
                    numbers[index] = result;
                    numbers.Remove(numbers[index + 1]);
                    chars.Remove(chars[index]);
                }
                else
                {
                    runFirstStep = false;
                }
            }

            double sum = numbers[0];

            for (int i = 0; i < numbers.Count -1; i++)
            {
                if (chars[i].Equals("+"))
                {
                    sum += numbers[i+1];
                }
                else if (chars[i].Equals("-"))
                {
                    sum -= numbers[i+1];
                }
            }              
            return sum;
        }
    }
}
