using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();
            c1.num1 = 78.9;
            c1.num2 = 12.9;
            Console.WriteLine($"The sum of two numbers is: {c1.Add()}");
            Console.ReadLine();
        }
    }
    public class Calculator
    {
        public double num1 { get; set; }
        public double num2 { get; set; }


        public double Add()
        { return num1 + num2; }

        public double Sub()
        { return num1 - num2; }

        public double Multi()
        { return num1 * num2; }

        public double Divide()
        { return num1 / num2; }
    }
}
