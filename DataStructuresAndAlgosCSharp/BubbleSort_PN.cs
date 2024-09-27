using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgosCSharp { 


    // each pass moves the largest remaining elements
    // to the end of the unsorted elements
    // O(n^2) time complexity
    // bubble sort is stable.
    public class BubbleSort_PN
    {
        public static void BubbleSort(int[] array)
        {
            Console.WriteLine("in bubble");
            for(int i = 0; i < array.Length - 1; i++)
            {
                for(int j = 0; j < array.Length -1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // swap
                        //int temp = array[i];
                        //array[i] = array[i + 1];
                        //array[i + 1] = temp;

                        // using tuples
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    }
                }

            }

        }

        public static void BubbleSort<T>(T[] array) where T : IComparable<T>
        {
            Console.WriteLine("in bubble generic");
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    }
                }
            }
        }



        public static void BubbleSort2<T>(T[] arr) where T : IComparable<T>
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        // Swap elements
                        T temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public static void BubbleSortString(String[] arr) 
        {
            Console.WriteLine("in bubblesort string");
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        // Swap elements
                        String temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
