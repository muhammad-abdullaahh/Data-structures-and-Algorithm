using System;
using System.Collections.Generic;
using System.Text;

namespace task01
{
	internal class BinarySearch
	{
		public int Search(string[] names, string target)
		{
			int left = 0;
			int right = names.Length - 1;

			while (left <= right)
			{
				int mid = left + (right - left) / 2;
				int comparison = string.Compare(names[mid], target, StringComparison.OrdinalIgnoreCase);

				if (comparison == 0)
				{
					return mid;
				}
				else if (comparison < 0)
				{
					left = mid + 1;
				}
				else
				{
					right = mid - 1;
				}
			}
			return -1;
		}
	}
}