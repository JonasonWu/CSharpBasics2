using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class CopyingAnArray
    {

        /// <summary>
        /// Copy over arr1 into arr2. It is assumed that both arrays have the same length.
        /// </summary>
        /// <param name="arr1">The array containing the details to copy over</param>
        /// <param name="arr2">The array to copy data over into.</param>
        public void CopyArray(int[] arr1, int[] arr2)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }
        }

        /// <summary>
        /// Print a table that contains the details of both arrays.
        /// It is assumed that both arrays have the same length.
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        public void PrintArrayDetails(int[] arr1, int[] arr2)
        {
            string formatString = "{0,-6} | {1,6}";
            Console.WriteLine(formatString, "Array1", "Array2");
            Console.WriteLine("---------------");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(formatString, arr1[i], arr2[i]);
            }

        }

        /// <summary>
        /// Entry point that showcases a task to perform.
        /// </summary>
        public void PerformOperation()
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arr2 = new int[arr1.Length];
            this.CopyArray(arr1, arr2);
            this.PrintArrayDetails(arr1, arr2);
        }
    }
}
