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
			MaxHeap MH = new MaxHeap();
			MH.Insert(50);
			MH.Insert(55);
			MH.Insert(40);
			MH.Insert(45);
			MH.Display();
			MH.Delete();
			MH.Delete();
			MH.Display();
		}
	}
}
