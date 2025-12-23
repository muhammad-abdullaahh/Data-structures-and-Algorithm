using System;
using System.Collections.Generic;
using System.Text;

namespace task02
{
	internal class BinarySearch
	{
		public static int binary_search(int[] arr, int x, int lower, int upper)
		{
			if (lower > upper)
			{
				return -1;
			}
			int mid = lower + (upper - lower) / 2;

			if (arr[mid] == x)
			{
				return mid;
			}
			else if (arr[mid] < x)
			{
				return binary_search(arr, x, mid + 1, upper);
			}
			else
			{
				return binary_search(arr, x, lower, mid - 1);
			}
		}

		public static int delete_at(int[] arr, int size, int index)
		{
			for (int i = index; i < size - 1; i++)
				arr[i] = arr[i + 1];

			return size - 1;
		}
	}
}