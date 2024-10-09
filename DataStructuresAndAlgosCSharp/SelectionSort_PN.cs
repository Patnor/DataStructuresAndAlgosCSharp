using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgosCSharp
{
    // n - 1 passes
    /// <summary>
    /// This class provides static methods to perform selection sort on arrays.
    /// </summary>
    class SelectionSort_PN
    {
        /// <summary>
        /// Sorts an array of integers using the selection sort algorithm.
        /// </summary>
        /// <param name="a">The array of integers to be sorted.</param>
        public static void SelectionSort(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                int min = i;

                // Find the index of the minimum element in the unsorted part of the array
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] < a[min])
                    {
                        min = j;
                    }
                }

                // Swap the found minimum element with the first element of the unsorted part
                if (min != i)
                {
                    (a[i], a[min]) = (a[min], a[i]);
                }
            }
        }

        /// <summary>
        /// Sorts an array of elements of type T using the selection sort algorithm.
        /// The type T must implement the IComparable<T> interface.
        /// </summary>
        /// <typeparam name="T">The type of elements in the array. Must implement IComparable<T>.</typeparam>
        /// <param name="a">The array of elements to be sorted.</param>
        public static void SelectionSort<T>(T[] a) where T : IComparable<T>
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                int min = i;

                // Find the index of the minimum element in the unsorted part of the array
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j].CompareTo(a[min]) < 0)
                    {
                        min = j;
                    }
                }

                // Swap the found minimum element with the first element of the unsorted part
                if (min != i)
                {
                    (a[i], a[min]) = (a[min], a[i]);
                }
            }
        }
    }
}
