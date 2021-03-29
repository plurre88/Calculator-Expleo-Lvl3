using System;

namespace Calculator_3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Write your math expression and press enter");
                Console.WriteLine(Calculator.Calculate(Console.ReadLine()));
            }
        }
    }
}
