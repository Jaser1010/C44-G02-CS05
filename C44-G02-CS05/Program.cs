using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace C44_G02_CS05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1 - Sum of all elements of the array
            /*
            Console.WriteLine("Enter array size:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < size; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < size; i++)
                sum += arr[i];

            Console.WriteLine("Sum of array elements: " + sum);
            */
            #endregion

            #region Q2 - Merge two arrays of same size sorted in ascending order
            /*
            int[] arr1 = { 1, 3, 5 };
            int[] arr2 = { 2, 4, 6 };
            int[] merged = new int[arr1.Length + arr2.Length];

            arr1.CopyTo(merged, 0);
            arr2.CopyTo(merged, arr1.Length);

            Array.Sort(merged);

            Console.WriteLine("Merged Sorted Array: " + string.Join(" ", merged));
            */
            #endregion

            #region Q3 - Count frequency of each element
            /*
            int[] arr = { 1, 2, 2, 3, 1, 4, 1 };
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;
                bool visited = false;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        visited = true;
                        break;
                    }
                }
                if (!visited)
                {
                    for (int k = i + 1; k < arr.Length; k++)
                    {
                        if (arr[i] == arr[k])
                            count++;
                    }
                    Console.WriteLine(arr[i] + " appears " + count + " times");
                }
            }
            */
            #endregion

            #region Q4 - Find max and min in an array
            /*
            int[] arr = { 5, 3, 9, 1, 7 };
            int max = arr[0], min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }
            Console.WriteLine("Max: " + max + ", Min: " + min);
            */
            #endregion

            #region Q5 - Find second largest element in array
            /*
            int[] arr = { 4, 1, 9, 3, 9, 6 };
            int first = int.MinValue, second = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > first)
                {
                    second = first;
                    first = arr[i];
                }
                else if (arr[i] > second && arr[i] != first)
                {
                    second = arr[i];
                }
            }
            Console.WriteLine("Second largest: " + second);
            */
            #endregion




        }
    }
}
