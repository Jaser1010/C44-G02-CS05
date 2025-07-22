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

            #region Q9 - Print 1D array in reverse order
            /*
            int[] arr = { 10, 20, 30, 40, 50 };
            Console.WriteLine("Array in reverse:");
            for (int i = arr.Length - 1; i >= 0; i--)
                Console.Write(arr[i] + " ");
            */
            #endregion

            #region Q1 - Difference between passing value types by value and by reference
            /*
            void ModifyValue(ref int a)
            {
                a = 20;
            }

            int x = 10;
            Console.WriteLine("Before: " + x);
            ModifyValue(ref x);
            Console.WriteLine("After (by ref): " + x);

            void ModifyValueByCopy(int a)
            {
                a = 20;
            }

            int y = 10;
            Console.WriteLine("Before: " + y);
            ModifyValueByCopy(y);
            Console.WriteLine("After (by value): " + y);
            */
            #endregion

            #region Q2 - Difference between passing reference types by value and by reference
            /*
            void ModifyReference(MyClass obj)
            {
                obj.Value = 100;
            }

            void ReassignReference(ref MyClass obj)
            {
                obj = new MyClass();
                obj.Value = 200;
            }

            MyClass myObj = new MyClass();
            myObj.Value = 10;

            ModifyReference(myObj);
            Console.WriteLine("After ModifyReference: " + myObj.Value);

            ReassignReference(ref myObj);
            Console.WriteLine("After ReassignReference: " + myObj.Value);
            */
            #endregion

            #region Q3 - Function with 4 parameters to return summation and subtraction
            /*
            int SumSubtract(int a, int b, int c, int d)
            {
                return (a + b) - (c + d);
            }

            Console.WriteLine("Enter 4 numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());

            int result = SumSubtract(a, b, c, d);
            Console.WriteLine("Result: " + result);
            */
            #endregion

            #region Q4 - Sum of digits
            /*
            int SumOfDigits(int number)
            {
                int sum = 0;
                while (number != 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                return sum;
            }

            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int digitSum = SumOfDigits(num);
            Console.WriteLine("The sum of the digits of the number " + num + " is: " + digitSum);
            */
            #endregion

            #region Q5 - IsPrime function
            /*
            bool IsPrime(int number)
            {
                if (number < 2) return false;
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0) return false;
                }
                return true;
            }

            Console.WriteLine("Enter a number:");
            int primeCheck = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Is prime? " + IsPrime(primeCheck));
            */
            #endregion

            #region Q6 - MinMaxArray function using ref
            /*
            void MinMaxArray(int[] arr, ref int min, ref int max)
            {
                min = arr[0];
                max = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] < min) min = arr[i];
                    if (arr[i] > max) max = arr[i];
                }
            }

            int[] numbers = { 5, 1, 9, 2, 8 };
            int minVal = 0, maxVal = 0;
            MinMaxArray(numbers, ref minVal, ref maxVal);
            Console.WriteLine("Min: " + minVal + ", Max: " + maxVal);
            */
            #endregion

            #region Q7 - Iterative factorial
            /*
            int Factorial(int n)
            {
                int result = 1;
                for (int i = 2; i <= n; i++)
                    result *= i;
                return result;
            }

            Console.WriteLine("Enter a number:");
            int factNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factorial: " + Factorial(factNum));
            */
            #endregion









        }
    }
}
