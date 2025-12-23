using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task01;

namespace MyFirstProgram
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array = { 89, 12, 45, 67, 23, 91, 34, 56 };
			QuickSort quickSorter = new QuickSort(array);

			Console.WriteLine("Original Array:");
			quickSorter.Display();

			quickSorter.QSort();

			Console.WriteLine("Sorted Array:");
			quickSorter.Display();
		}
	}
}
