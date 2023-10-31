using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mergesort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----merge sort-------");
           
           
                int[] marks = { 78, 92, 65, 89, 55, 74, 98, 82, 70 };
                Console.WriteLine("Unsorted Marks:");
                PrintArray(marks);

                MergeSort(marks);

                Console.WriteLine("\nSorted Marks (Ascending Order):");
                PrintArray(marks);
            }

            public static void MergeSort(int[] arr)
            {
                if (arr.Length <= 1)
                    return;

                int middle = arr.Length / 2;
                int[] left = new int[middle];
                int[] right = new int[arr.Length - middle];

                for (int i = 0; i < middle; i++)
                    left[i] = arr[i];

                for (int i = middle; i < arr.Length; i++)
                    right[i - middle] = arr[i];

                MergeSort(left);
                MergeSort(right);
                Merge(arr, left, right);
            }

            public static void Merge(int[] arr, int[] left, int[] right)
            {
                int i = 0, j = 0, k = 0;

                while (i < left.Length && j < right.Length)
                {
                    if (left[i] <= right[j])
                    {
                        arr[k] = left[i];
                        i++;
                    }
                    else
                    {
                        arr[k] = right[j];
                        j++;
                    }
                    k++;
                }

                while (i < left.Length)
                {
                    arr[k] = left[i];
                    i++;
                    k++;
                }

                while (j < right.Length)
                {
                    arr[k] = right[j];
                    j++;
                    k++;
                }
            }

            public static void PrintArray(int[] arr)
            {
                foreach (int num in arr)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            Console.ReadLine();
            }
        }

    }



