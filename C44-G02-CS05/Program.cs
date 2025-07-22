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

            #region Q6 - Longest distance between equal cells
            /*
            Console.WriteLine("Enter array size:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];

            Console.WriteLine("Enter elements:");
            for (int i = 0; i < size; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());

            int maxDistance = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = size - 1; j > i; j--)
                {
                    if (arr[i] == arr[j])
                    {
                        int distance = j - i - 1;
                        if (distance > maxDistance)
                            maxDistance = distance;
                        break;
                    }
                }
            }
            Console.WriteLine("Longest distance: " + maxDistance);
            */
            #endregion

            #region Q7 - Reverse words in a sentence
            /*
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            Array.Reverse(words);
            Console.WriteLine(string.Join(" ", words));
            */
            #endregion

            #region Q8 - Copy one 2D array to another
            /*
            int[,] arr1 = new int[2, 2];
            int[,] arr2 = new int[2, 2];

            Console.WriteLine("Enter 4 elements:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    arr2[i, j] = arr1[i, j];
                }
            }

            Console.WriteLine("Copied Array:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                    Console.Write(arr2[i, j] + " ");
                Console.WriteLine();
            }
            */
            #endregion







        }
    }
}
