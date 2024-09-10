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