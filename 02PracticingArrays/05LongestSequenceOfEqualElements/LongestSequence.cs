using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{ 
    class LongestSequence
    {
        /// <summary>
        /// Given an array, finds the longest sequence of equal elements in the array of integers and
        /// returns the results.
        /// </summary>
        /// <param name="arr">The array of integers to find longest sequence</param>
        /// <param name="sequenceElement">The output variable to store the value that has the longest sequence.</param>
        /// <param name="count">The output variable to store the count of the longest sequence.</param>
        public void GetLongestSequenceOfEqualElements(int[] arr, out int sequenceElement, out int count) {
            sequenceElement = 0;
            count = 0;
            if (arr.Length == 0) {
                return;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                int currentElement = arr[i];
                int currentCount = 1;
                for (int j = i+1; j < arr.Length; j++) {
                    if (arr[j] == currentElement) {
                        currentCount++;
                        i++;
                    } else { break; }
                }
                if (currentCount > count) { 
                    count = currentCount;
                    sequenceElement = currentElement;
                }
            }
        }

        public void PerformOperation() {

            ArrayShifting arrayShifting = new();
            int[] array = arrayShifting.GetArrayFromUser();

            int element, count;
            GetLongestSequenceOfEqualElements(array, out element, out count);

            Console.Write($"The longest sequence is: ");
            for (int i = 0; i < count; i++) {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
