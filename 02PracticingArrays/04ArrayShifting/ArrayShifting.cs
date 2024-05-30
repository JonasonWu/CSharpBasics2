using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class ArrayShifting
    {
        public int[] GetArrayFromUser()
        { 
            bool showSample = false;
            do
            {
                Console.WriteLine("Give an array of integers (space separated) on a single line.");
                if (showSample) Console.WriteLine("Example: 1 2 3 4");
                string[] values = Console.ReadLine().Trim().Split(" ");
                int[] integers = new int[values.Length];
                for (int i = 0; i < values.Length; i++)
                {
                    if (!int.TryParse(values[i], out integers[i]))
                    {
                        Console.WriteLine("Invalid Input. Try again.");
                        showSample = true;
                        break;
                    }
                    if (i == (values.Length - 1)) {
                        return integers;
                    }
                }
            } while (true);
        }

        public int GetNumberOfRotationsFromUser() {
            bool successfulParse = false;
            do
            {
                Console.Write("Give the number of rotations to perform: ");
                int rotations;
                successfulParse = int.TryParse(Console.ReadLine(), out rotations);
                if (successfulParse) return rotations;               
                
            } while (true);
        }

        /// <summary>
        /// Shift the values of each element of the array one space to the right and let the last
        /// element be the first element.
        /// </summary>
        /// <param name="arr"></param>
        public void ShiftArray(int[] arr) {
            int lastElement = arr[arr.Length - 1];
            for (int i = arr.Length - 1; i >= 1; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = lastElement;   
        }

        /// <summary>
        /// Takes the integers in arr and adds it to the summed array.
        /// It is assumed that the length of both arrays are the same.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="summed"></param>
        public void SumArray(int[] arr, int[] summed) { 
            for (int i = 0; i < summed.Length; i++)
            {
                summed[i] += arr[i];
            }
        }

        /// <summary>
        /// Rotate the array to the right k times and sum the obtained arrays after each rotation.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int[] ProductSummationFromRotations(int[] arr, int k)
        {
            int[] arrayCopy = (int[])arr.Clone();
            int[] summed = new int[arrayCopy.Length];
            for (int i = 0; i < k; i++) {
                ShiftArray(arrayCopy);
                SumArray(arrayCopy, summed);
            }
            return summed;
        }

        public int[] PerformOperation() 
        {
            int[] integers = GetArrayFromUser();
            int rotations = GetNumberOfRotationsFromUser();
            int[] outputArray = ProductSummationFromRotations(integers, rotations);
            return outputArray;
        }
    }
}
