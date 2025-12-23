using System;
using System.Collections.Generic;
using System.Text;

namespace task03
{
	internal class Node
	{
		public int Vertex;
		public Node Next;
		public Node(int vertex)
		{
			Vertex = vertex;
			Next = null;
		}
	}
}