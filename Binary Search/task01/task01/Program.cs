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
			string[] names = { "Majid Kaleem", "Adolf Hitler", "Asim Muneer", "Genghis Khan", "Legend Imran Khan" };
			int[] ages = { 155, 20, 30, 28, 55 };

			Console.Write("Enter the name to search: ");
			string searchName = Console.ReadLine();

			BinarySearch binarySearch = new BinarySearch();
			int index = binarySearch.Search(names, searchName);

			if (index != -1)
			{
				Console.WriteLine("{0}'s age is {1}", names[index], ages[index]);
			}
			else
			{
				Console.WriteLine("Name not found in the list.");
			}
		}
	}
}