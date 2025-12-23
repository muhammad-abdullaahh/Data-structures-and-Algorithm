using System;
using System.Collections.Generic;
using System.Text;

namespace task02
{
	internal class MinHeap
	{
		public Node Root;
		private Queue<Node> nodesQueue;

		public MinHeap()
		{
			Root = null;
			nodesQueue = new Queue<Node>();
		}

		public void Insert(int data)
		{
			Node newNode = new Node(data);

			if (Root == null)
			{
				Root = newNode;
				nodesQueue.Enqueue(newNode);
				return;
			}

			Node parent = nodesQueue.Peek();

			if (parent.left == null)
			{
				parent.left = newNode;
				newNode.parent = parent;
			}
			else
			{
				parent.right = newNode;
				newNode.parent = parent;
				nodesQueue.Dequeue();
			}
			nodesQueue.Enqueue(newNode);
			HeapifyUp(newNode);
		}

		private void HeapifyUp(Node node)
		{
			while (node.parent != null && node.data < node.parent.data)
			{
				int temp = node.data;
				node.data = node.parent.data;
				node.parent.data = temp;
				node = node.parent;
			}
		}

		public void Delete()
		{
			if (Root == null)
			{
				Console.WriteLine("Heap is empty");
				return;
			}

			Node last = null;
			Queue<Node> q = new Queue<Node>();
			q.Enqueue(Root);

			while (q.Count > 0)
			{
				last = q.Dequeue();
				if (last.left != null) q.Enqueue(last.left);
				if (last.right != null) q.Enqueue(last.right);
			}

			Root.data = last.data;

			if (last.parent.left == last)
				last.parent.left = null;
			else
				last.parent.right = null;

			HeapifyDown(Root);
		}

		private void HeapifyDown(Node node)
		{
			while (node.left != null)
			{
				Node smaller = node.left;

				if (node.right != null && node.right.data < node.left.data)
					smaller = node.right;

				if (node.data <= smaller.data)
					break;

				int temp = node.data;
				node.data = smaller.data;
				smaller.data = temp;

				node = smaller;
			}
		}

		public void Display()
		{
			if (Root == null)
			{
				Console.WriteLine("Heap is empty");
				return;
			}

			Queue<Node> q = new Queue<Node>();
			q.Enqueue(Root);

			while (q.Count > 0)
			{
				Node current = q.Dequeue();
				Console.Write(current.data + " ");
				if (current.left != null) q.Enqueue(current.left);
				if (current.right != null) q.Enqueue(current.right);
			}
			Console.WriteLine();
		}
	}
}