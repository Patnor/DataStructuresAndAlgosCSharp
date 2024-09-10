using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgosCSharp
{
    public class InsertionSort_PN
    {
        /// <summary>
        /// Sorts an array of integers using the insertion sort algorithm.
        /// </summary>
        /// <param name="nums">The array of integers to be sorted.</param>
        public static void InsertionSort(int[] nums)
        {
            // Iterate over each element in the array starting from the second element
            for (int i = 1; i < nums.Length; i++)
            {
                // Store the current element and the index of the previous element
                int j = i - 1;
                int temp = nums[i];

                // Shift elements of the sorted segment forward if they are greater than the current element
                while (j > -1 && nums[j] > temp)
                {
                    nums[j + 1] = nums[j];
                    j--;
                }
                // Place the current element in its correct position
                nums[j + 1] = temp;
            }
        }

        public static void InsertionSortGen<T>(T[] items) where T : IComparable<T>
        {
            for (int i = 1; i < items.Length; i++)
            {
                T temp = items[i];
                int j = i - 1;

                while (j > -1 && items[j].CompareTo(temp) > 0)
                {
                    items[j + 1] = items[j];
                    j--;
                }
                items[j + 1] = temp;
            }
        }
    }
}
