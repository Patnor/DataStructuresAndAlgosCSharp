using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgosCSharp
{
    // n - 1 passes
    class SelectionSort_PN
    {
        public static void SelectionSort(int[] a)
        {
            for(int i = 0; i < a.Length - 1; i++)
            {
                int min = i;
                
                for(int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] < a[min])
                    {
                        min = j;
                    }
                    if(min != i)
                    {
                        (a[i], a[min]) = (a[min], a[i]);
                    }
                }
            }
        }

        public static void SelectionSort<T>(T[] a) where T : IComparable<T>
        {
           
        }
    }
}
