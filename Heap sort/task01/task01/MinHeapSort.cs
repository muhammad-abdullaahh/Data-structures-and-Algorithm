using System;
using System.Collections.Generic;
using System.Text;

namespace task01
{
	internal class MinHeapSort
	{
		public void HeapSort(int[] arr)
		{
			int n = arr.Length;
			for (int i = n / 2 - 1; i >= 0; i--)
			{
				Heapify(arr, n, i);
			}
			for (int i = 0; i < n; i++)
			{
				int min = arr[0];
				arr[0] = arr[n - 1 - i];
				arr[n - 1 - i] = min;
				Heapify(arr, n - 1 - i, 0);
			}
		}

		public void Heapify(int[] arr, int n, int i)
		{
			int smallest = i;
			int left = 2 * i + 1;
			int right = 2 * i + 2;
			if (left < n && arr[left] < arr[smallest])
				smallest = left;
			if (right < n && arr[right] < arr[smallest])
				smallest = right;
			if (smallest != i)
			{
				int temp = arr[i];
				arr[i] = arr[smallest];
				arr[smallest] = temp;
				Heapify(arr, n, smallest);
			}
		}

		public void PrintArray(int[] arr)
		{
			foreach (int x in arr)
				Console.Write(x + " ");
			Console.WriteLine();
		}
	}
}