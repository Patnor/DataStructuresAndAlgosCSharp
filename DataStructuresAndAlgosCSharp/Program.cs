
namespace DataStructuresAndAlgosCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test array
            int[] testArray = { 5, 2, 9, 1, 5, 6 };

            // Print the original array
            Console.WriteLine("Original array:");
            PrintArray(testArray);

            // Sort the array using InsertionSort
            InsertionSort_PN.InsertionSortGen(testArray);

            // Print the sorted array
            Console.WriteLine("Sorted array:");
            PrintArray(testArray);

            // Sort using bubble sort
            int[] testArrayBubble = { 5, 2, 9, 1, 5, 6 };

            Console.WriteLine("Original array:");
            PrintArray(testArrayBubble);

            Console.WriteLine("Bubble sorted arry:");
            BubbleSort_PN.BubbleSort(testArrayBubble);
            PrintArray(testArrayBubble);

            // Bubble sort generics
            string[] stringBubble = { "Patrick", "Sammy", "sammy", "Micah", "hutch", "Starsky" };

            Console.WriteLine("Original Generic Array");
            printArrayGeneric(stringBubble);

            Console.WriteLine("Sorted Generic Array");
            BubbleSort_PN.BubbleSortString(stringBubble);
            printArrayGeneric(stringBubble);

            // Merge Sort
            int[] testArrayMerge = { 5, 2, 9, 1, 5, 6 };

            Console.WriteLine("Original merge array:");
            PrintArray(testArrayMerge);

            Console.WriteLine("Merge sorted array:");
            MergeSort_PN.MergeSort(testArrayMerge);
            PrintArray(testArrayMerge);

            string[] stringMerge = { "Patrick", "Sammy", "sammy", "Micah", "hutch", "Starsky" };

            Console.WriteLine("Original Merge Generic Array");
            printArrayGeneric(stringMerge);

            Console.WriteLine("Merge Sorted Generic Array");
            MergeSort_PN.MergeSort(stringMerge);
            printArrayGeneric(stringMerge);

            // Selection sort ******************************************************************
            Console.WriteLine();
            int[] testArraySelect = { 5, 2, 9, 1, 5, 6 };

            Console.WriteLine("Original selection array:");
            PrintArray(testArraySelect);

            Console.WriteLine("Selection sorted array:");
            SelectionSort_PN.SelectionSort(testArraySelect);
            PrintArray(testArraySelect);

            string[] stringSelect = { "Patrick", "Sammy", "sammy", "Micah", "hutch", "Starsky", "Abby" };

            Console.WriteLine("Original Selection Generic Array");
            printArrayGeneric(stringSelect);

            Console.WriteLine("Selection Sorted Generic Array");
            SelectionSort_PN.SelectionSort(stringSelect);
            printArrayGeneric(stringSelect);
        }

        private static void printArrayGeneric<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        // Helper method to print the array
        static void PrintArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}