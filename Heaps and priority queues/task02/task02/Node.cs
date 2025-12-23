using System;
using System.Collections.Generic;
using System.Text;

namespace task02
{
	internal class Node
	{
		public Node parent;
		public Node left;
		public Node right;
		public int data;

		public Node(int data)
		{
			this.data = data;
			parent = null;
			left = null;
			right = null;
		}
	}
}
