using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task02;

namespace task02
{
	class Program
	{
		static void Main(string[] args)
		{
			AVL a1 = new AVL();
			a1.Add(20);
			a1.Add(30);
			a1.Add(40);
			a1.Add(50);
			a1.Add(60);
			a1.Add(70);
			a1.Display();
			Console.WriteLine("Find 25: " + a1.Find(50));
			Console.WriteLine("Find 60: " + a1.Find(75));
			Console.WriteLine("Maximum Value: " + a1.Max());
		}
	}
}
