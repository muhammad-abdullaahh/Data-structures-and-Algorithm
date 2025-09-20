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
            if (num == 1)
                return 1;
            return func(num - 1) + (2 * num - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = func(num);
            Console.WriteLine("Square of {0} = {1}", num, result);
        }
    }
}