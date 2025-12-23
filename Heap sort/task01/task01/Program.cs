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
			MinHeapSort heapSorter = new MinHeapSort();

			Console.WriteLine("Original Array:");
			heapSorter.PrintArray(array);

			heapSorter.HeapSort(array);

			Console.WriteLine("Sorted Array:");
			heapSorter.PrintArray(array);
		}
	}
}
