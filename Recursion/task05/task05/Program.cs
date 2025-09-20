using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyFirstProgram
{
    class Program
    {
        public static int count = 0;
        public static int func(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return func(b, a % b);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = func(num1, num2);
            Console.WriteLine($"HCF of {num1} and {num2} = {result}");
        }
    }
}