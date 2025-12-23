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
			Graphs bfsGraph = new Graphs(8);
			bfsGraph.AddEdge(0, 1);
			bfsGraph.AddEdge(0, 7);
			bfsGraph.AddEdge(1, 2);
			bfsGraph.AddEdge(1, 5);
			bfsGraph.AddEdge(2, 3);
			bfsGraph.AddEdge(3, 4);
			bfsGraph.AddEdge(4, 6);
			bfsGraph.AddEdge(5, 6);
			bfsGraph.PrintGraph();
			Console.WriteLine();
			bfsGraph.BFS(0);
		}
	}
}
