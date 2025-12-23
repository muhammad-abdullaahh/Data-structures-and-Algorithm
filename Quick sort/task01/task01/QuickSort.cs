using System;
using System.Collections.Generic;
using System.Text;

namespace task01
{
	internal class QuickSort
	{
		public int[] arr;
		public QuickSort(int[] array)
		{
			arr = array;
		}
		public void QSort()
		{
			Sort(0, arr.Length - 1);
		}
		private void Sort(int left, int right)
		{
			if (left < right)
			{
				int pivotIndex = Partition(left, right);
				Sort(left, pivotIndex - 1);
				Sort(pivotIndex + 1, right);
			}
		}

		private int Partition(int left, int right)
		{
			int pivot = arr[left];
			int i = left + 1;
			int j = right;
			while (true)
			{
				while (i <= j && arr[i] <= pivot) i++;
				while (arr[j] > pivot) j--;
				if (i < j)
				{
					Swap(i, j);
				}
				else
				{
					break;
				}
			}
			Swap(left, j);
			return j;
		}

		private void Swap(int i, int j)
		{
			int temp = arr[i];
			arr[i] = arr[j];
			arr[j] = temp;
		}

		public void Display()
		{
			Console.WriteLine(string.Join(" ", arr));
		}
	}
}