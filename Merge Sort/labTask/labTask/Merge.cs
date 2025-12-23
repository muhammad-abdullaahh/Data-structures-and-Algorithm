using System;
using System.Collections.Generic;
using System.Text;

namespace labTask
{
    internal class Merge
    {
        class QuickSortInt
        {
            private static void SwapInt(int a, int b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            private static int PartitionInt(int[] arr, int low, int high)
            {
                int pivot = arr[low];
                int i = low + 1;
                for (int j = low + 1; j <= high; j++)
                {
                    if (arr[j] <= pivot)
                    {
                        SwapInt(arr[i], arr[j]);
                        i++;
                    }
                }

                SwapInt(arr[low], arr[i - 1]);
                return (i - 1);
            }

            public static void QuickSortInt(int[] arr, int low, int high)
            {
                if (low < high)
                {
                    int pi = PartitionInt(arr, low, high);
                    QuickSortInt(arr, low, pi - 1);
                    QuickSortInt(arr, pi + 1, high);
                }
            }

            public static void PrintArray(int[] arr)
            {
                foreach (int item in arr)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
    }
}