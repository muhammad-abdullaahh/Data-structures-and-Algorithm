using System;
using System.Collections.Generic;
using System.Text;

namespace task03
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

		public void BFS(int start)
		{
			bool[] visited = new bool[vertices];
			Queue<int> queue = new Queue<int>();
			visited[start] = true;
			queue.Enqueue(start);
			Console.WriteLine("BFS Traversal:");
			while (queue.Count > 0)
			{
				int current = queue.Dequeue();
				Console.Write(current + " ");
				Node temp = adjacencyList[current];
				while (temp != null)
				{
					if (!visited[temp.Vertex])
					{
						visited[temp.Vertex] = true;
						queue.Enqueue(temp.Vertex);
					}
					temp = temp.Next;
				}
				Console.WriteLine();
			}
		}
	}
}