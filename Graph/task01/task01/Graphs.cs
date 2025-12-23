using System;
using System.Collections.Generic;
using System.Text;

namespace task01
{
	internal class Graphs
	{
		private int[,] adjacencyMatrix;
		private int vertices;
		public Graphs(int vertices)
		{
			this.vertices = vertices;
			adjacencyMatrix = new int[vertices, vertices];
		}
		public void AddEdge(int source, int destination)
		{
			adjacencyMatrix[source, destination] = 1;
		}
		public void AddUndirectedEdge(int v1, int v2)
		{
			adjacencyMatrix[v1, v2] = 1;
			adjacencyMatrix[v2, v1] = 1;
		}
		public void PrintMatrix()
		{
			Console.WriteLine("Adjacency Matrix:");
			for (int i = 0; i < vertices; i++)
			{
				for (int j = 0; j < vertices; j++)
				{
					Console.Write(adjacencyMatrix[i, j] + " ");
				}
				Console.WriteLine();
			}
		}
	}
}