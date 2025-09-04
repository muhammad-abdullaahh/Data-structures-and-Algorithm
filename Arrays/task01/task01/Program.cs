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
        static void Main(string[] args)
        {
            int[] arr = { 22, 12, 19, 3, 13, 4, 45, 6, 49, 11 };
            int sum = 0;
            double average = 0;
            //pairs with sum 25
            Console.WriteLine("Checking if the sum of any two values in the array is 25 or not");
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if(arr[i] + arr[j] == 25)
                    {
                        Console.WriteLine("The values at {0} and {1} indexes make up a sum of 25",i,j);
                    }
                }
            }
            // even/odd elements
            Console.WriteLine("\nChecking for even / odd numbers");
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine("The value at index {0} is an even number",i);
                }
                else
                {
                    Console.WriteLine("The value at index {0} is an odd number",i);
                }
            }
            //average of the array
            Console.WriteLine("\nAverage of the array");
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            average = sum / 10;
            Console.WriteLine("The average of the elements in the array is "+average);
        }
    }
}
