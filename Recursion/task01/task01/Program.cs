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
        public static void func(int value, int endingValue)
        {
            if (value > endingValue)
                return;
            else
            {
                Console.WriteLine(value + "\t");
                func(value * 2, endingValue);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the ending value of the series : ");
            int end = Convert.ToInt32(Console.ReadLine());
            func(2, end);
        }
    }
}
