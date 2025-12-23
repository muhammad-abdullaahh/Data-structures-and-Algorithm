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
			MinHeap MH = new MinHeap();
			MH.Insert(40);
			MH.Insert(20);
			MH.Insert(30);
			MH.Insert(44);
			MH.Display();
			MH.Delete();
			MH.Display();
		}
	}
}
