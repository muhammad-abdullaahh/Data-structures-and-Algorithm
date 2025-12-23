using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task02;

namespace MyFirstProgram
{ 
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = { 7, 12, 33, 35, 49, 56, 57, 60, 74, 98 };
			int size = numbers.Length;

			int[] targets = { 35, 78, 95 };

			for (int t = 0; t < targets.Length; t++)
			{
				int x = targets[t];
				Console.WriteLine("Searching for {0}", x);

				int index = BinarySearch.binary_search(numbers, x, 0, size - 1);

				if (index != -1)
				{
					Console.WriteLine("{0} found at index {1}. Deleting...", x, index);
					size = BinarySearch.delete_at(numbers, size, index);
				}
				else
				{
					Console.WriteLine("{0} not found:", x);
				}

				Console.Write("Array now: ");
				for (int i = 0; i < size; i++)
					Console.Write(numbers[i] + " ");
				Console.WriteLine("\n");
			}
		}
	}
}