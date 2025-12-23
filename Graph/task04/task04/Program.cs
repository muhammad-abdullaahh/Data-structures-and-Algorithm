using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task04;

namespace MyFirstProgram
{
	class Program
	{
		static void Main(string[] args)
		{
			Graphs dfsGraph = new Graphs(7);
			dfsGraph.AddEdge(0, 1);
			dfsGraph.AddEdge(0, 6);
			dfsGraph.AddEdge(1, 2);
			dfsGraph.AddEdge(1, 4);
			dfsGraph.AddEdge(2, 3);
			dfsGraph.AddEdge(3, 5);
			dfsGraph.AddEdge(4, 5);
			dfsGraph.PrintGraph();
			Console.WriteLine();
			dfsGraph.DFS(3);
		}
	}
}

