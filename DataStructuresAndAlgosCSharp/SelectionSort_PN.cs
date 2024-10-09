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
    /// 
    /// 
    /// 
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

/* 
 
 Explaination: 
 
Selection Sort

Selection Sort is a simple comparison-based sorting algorithm. It works by repeatedly finding the minimum element from the unsorted part of the array and moving it to the beginning. The algorithm maintains two subarrays in a given array:
1.	Subarray which is already sorted.
2.	Remaining subarray which is unsorted.
Steps of Selection Sort
1.	Initialize: Start with the first element as the minimum.
2.	Find Minimum: Traverse the unsorted part of the array to find the minimum element.
3.	Swap: Swap the found minimum element with the first element of the unsorted part.
4.	Repeat: Move the boundary between the sorted and unsorted subarrays one element to the right and repeat the process until the entire array is sorted.
Example
Consider the array [64, 25, 12, 22, 11]:

·	Initial Array: [64, 25, 12, 22, 11]
·	First Pass: Find the minimum element (11) and swap it with the first element.
·	Array after first pass: [11, 25, 12, 22, 64]
·	Second Pass: Find the minimum element (12) in the remaining unsorted part and swap it with the second element.
·	Array after second pass: [11, 12, 25, 22, 64]
·	Third Pass: Find the minimum element (22) in the remaining unsorted part and swap it with the third element.
·	Array after third pass: [11, 12, 22, 25, 64]
·	Fourth Pass: Find the minimum element (25) in the remaining unsorted part and swap it with the fourth element.
·	Array after fourth pass: [11, 12, 22, 25, 64]
The array is now sorted.

Time Complexity
·	Best Case: (O(n^2))
·	Average Case: (O(n^2))
·	Worst Case: (O(n^2))

The time complexity is (O(n^2)) for all cases because the algorithm always performs (n-1) passes and each pass involves a linear scan of the remaining elements.
Space Complexity
·	Space Complexity: (O(1))
Selection Sort is an in-place sorting algorithm, meaning it does not require additional storage proportional to the input size. It only uses a constant amount of extra space for variables like the index of the minimum element.
Summary

·	Advantages:
    ·	Simple to understand and implement.
    ·	Performs well on small datasets.
    ·	In-place sorting algorithm with (O(1)) space complexity.

·	Disadvantages:
    ·	Inefficient on large datasets due to its (O(n^2)) time complexity.
    ·	Not stable, meaning it does not preserve the relative order of equal elements.
 
 
 */