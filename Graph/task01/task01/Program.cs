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
			Graphs graph = new Graphs(6);
			graph.AddUndirectedEdge(0, 1);
			graph.AddUndirectedEdge(0, 3);
			graph.AddUndirectedEdge(1, 4);
			graph.AddUndirectedEdge(2, 3);
			graph.AddUndirectedEdge(4, 5);
			graph.PrintMatrix();
		}
	}
}
