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
        public static int func(int num)
        {
            if (num == 0)
                return 0;
            return (num % 10) + func(num / 10);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter an integer number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = func(num);
            Console.WriteLine("Sum of digits of {0} = {1}", num, result);
        }
    }
}