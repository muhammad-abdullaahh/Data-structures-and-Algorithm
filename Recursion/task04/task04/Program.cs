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
        public static void func(int n, char from_rod, char to_rod, char aux_rod)
        {
            if (n == 1)
            {
                count++;
                Console.WriteLine("Step : " + count + " Move disk 1 from rod " +
               from_rod + " to rod " + to_rod);
                return;
            }
            func(n - 1, from_rod, aux_rod, to_rod);
            count++;
            Console.WriteLine("Step : " + count + " Move disk " + n + " from rod " +
           from_rod + " to rod " + to_rod);
            func(n - 1, aux_rod, to_rod, from_rod);
        }
        static void Main(string[] args)
        {
            int n = 4;
            func(n, 'A', 'C', 'B');
            Console.WriteLine("Total step count : " + count);
        }
    }
}