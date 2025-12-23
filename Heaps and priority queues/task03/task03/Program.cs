using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task03;

namespace MyFirstProgram
{
	class Program
	{
		static void Main(string[] args)
		{
			PriorityQueue PQ = new PriorityQueue();
			PQ.Enqueue(45);
			PQ.Enqueue(25);
			PQ.Enqueue(20);
			PQ.Enqueue(30);
			PQ.Display();
			PQ.Dequeue();
			PQ.Dequeue();
			PQ.Display();
		}
	}
}

