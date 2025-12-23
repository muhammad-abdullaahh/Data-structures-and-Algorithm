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
			Graphs listGraph = new Graphs(7);
			listGraph.AddEdge(0, 1);
			listGraph.AddEdge(0, 6);
			listGraph.AddEdge(1, 4);
			listGraph.AddEdge(2, 5);
			listGraph.AddEdge(3, 6);
			listGraph.AddEdge(4, 5);
			listGraph.AddEdge(5, 6);
			listGraph.PrintGraph();
		}
	}
}
