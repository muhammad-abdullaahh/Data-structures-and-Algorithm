using System;
using System.Collections.Generic;
using System.Text;

namespace task03
{
	internal class PriorityQueue
	{
		private MaxHeap heap = new MaxHeap();

		public void Enqueue(int data)
		{
			heap.Insert(data);
		}

		public void Dequeue()
		{
			heap.Delete();
		}

		public void Display()
		{
			heap.Display();
		}
	}
}