using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace task04
{
	internal class Graphs
	{
		private int vertices;
		private Node[] adjacencyList;

		public Graphs(int v)
		{
			vertices = v;
			adjacencyList = new Node[v];
		}

		public void AddEdge(int src, int dest)
		{
			Node newNode = new Node(dest);
			newNode.Next = adjacencyList[src];
			adjacencyList[src] = newNode;

			Node newNode2 = new Node(src);
			newNode2.Next = adjacencyList[dest];
			adjacencyList[dest] = newNode2;
		}

		public void PrintGraph()
		{
			for (int i = 0; i < vertices; i++)
			{
				Console.Write("Vertex " + i + " -> ");
				Node temp = adjacencyList[i];
				while (temp != null)
				{
					Console.Write(temp.Vertex + " ");
					temp = temp.Next;
				}
				Console.WriteLine();
			}
		}

		public void DFS(int start)
		{
			bool[] visited = new bool[vertices];
			Console.WriteLine("DFS Traversal:");
			DFSUtil(start, visited);
		}

		private void DFSUtil(int vertex, bool[] visited)
		{
			visited[vertex] = true;
			Console.Write(vertex + " ");
			Node temp = adjacencyList[vertex];
			while (temp != null)
			{
				if (!visited[temp.Vertex])
				{
					DFSUtil(temp.Vertex, visited);
				}
				temp = temp.Next;
			}
		}
	}
}