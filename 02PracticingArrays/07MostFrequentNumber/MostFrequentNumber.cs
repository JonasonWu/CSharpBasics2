using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class MostFrequentNumber 
    {
        /// <summary>
        /// Construct a dictionary of array elements as the key and the frequency as the value.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private Dictionary<int, int> constructDictionary(int[] arr) {
            Dictionary<int, int> elementsToFrequency = new();
            foreach (int k in arr)
            {
                if (elementsToFrequency.ContainsKey(k))
                {
                    elementsToFrequency[k]++;
                }
                else
                {
                    elementsToFrequency.Add(k, 1);
                }
            }
            return elementsToFrequency;
        }

        /// <summary>
        /// Given the dictionary, find the maximum value element in the dictionary.
        /// </summary>
        /// <returns></returns>
        public int FindMaxDictionaryValue(Dictionary<int, int> dict) {
            int maximum = 0;
            foreach (int v in dict.Values)
            {
                maximum = Math.Max(v, maximum);
            }
            return maximum;
        }
        /// <summary>
        /// Look over the dictionary and get a list of keys that have the value corresponding to the parameter passed into the function.
        /// </summary>
        /// <param name="dict">The dictionary to look over.</param>
        /// <param name="value">The value to match values of the dictionary with.</param>
        /// <returns>A list of keys in the dictionary that are considered matches.</returns>
        public List<int> GetListOfKeyElementsWithSpecificValue(Dictionary<int, int> dict, int value) {
            List<int> li = new();
            foreach (int k in dict.Keys)
            {
                if (dict[k] == value)
                {
                    li.Add(k);
                }
            }
            return li;
        }

        /// <summary>
        /// Finds the most frequent numbers in the arr array. If there are multiple numbers
        /// that are equally most frequent, all those numbers are included.
        /// </summary>
        /// <param name="arr">The array to look through</param>
        /// <param name="mostFrequent">The output for most frequent numbers</param>
        /// <param name="occurrence">The output for occurrence of each of the most frequent numbers.</param>
        public void FindGreatestFrequency(int[] arr, out int[] mostFrequent, out int occurrence)
        {
            Dictionary<int, int> elementsToFrequency = constructDictionary(arr);

            int maximum = FindMaxDictionaryValue(elementsToFrequency);
            List<int> greatestFrequencies = GetListOfKeyElementsWithSpecificValue(elementsToFrequency, maximum);
            occurrence = maximum;
            mostFrequent = greatestFrequencies.ToArray();
        }
        public void PrintFrequencyResults(int[] mostFrequent, int occurrences) {
            if (mostFrequent.Length == 0)
            {
                Console.WriteLine("There are no integers in the array.");
            }
            else if (mostFrequent.Length == 1)
            {
                Console.WriteLine($"The number {mostFrequent[0]} is the most frequent (occurs {occurrences} times)");
            }
            else if (mostFrequent.Length == 2)
            {
                Console.WriteLine($"The numbers {mostFrequent[0]} and {mostFrequent[1]} are the most frequent (occurs {occurrences} times)");
            }
            else
            {
                int leftmost = mostFrequent[0];
                Array.Sort(mostFrequent);
                StringBuilder sb = new();
                sb.Append("The numbers ").Append(mostFrequent[0]);
                for (int i = 1; i < mostFrequent.Length - 1; i++) 
                {
                    sb.Append(", ").Append(mostFrequent[i]);
                }
                sb.Append(" and ").Append(mostFrequent[mostFrequent.Length - 1])
                    .Append(" have the same maximal frequency (each occurs ").Append(occurrences)
                    .Append(" times). The left most of them is ").Append(leftmost).Append(".");
                Console.WriteLine(sb.ToString());

            }
        }
        /// <summary>
        /// This method is in place to search in the sourceArray from left to right and find the first match with the resultArray.
        /// The resultArray will then swap the value on the match to the first position.
        /// </summary>
        /// <param name="sourceArray"></param>
        /// <param name="resultArray">This array is expected to be small.</param>
        private void SwapPositionForLeftmostMatching(int[] sourceArray, int[] resultArray) {
            foreach (int val in sourceArray) {
                for (int i = 0; i < resultArray.Length; i++) {
                    if (resultArray[i] == val)
                    {
                        resultArray[i] = resultArray[0];
                        resultArray[0] = val;
                        return;
                    }
                }
            }
        }
        public void PerformOperation()
        {
            ArrayShifting arrayShift = new();
            int[] arr = arrayShift.GetArrayFromUser();

            int[] greatestFrequency;
            int occurrence;
            FindGreatestFrequency(arr, out greatestFrequency, out occurrence);
            SwapPositionForLeftmostMatching(arr, greatestFrequency);
            PrintFrequencyResults(greatestFrequency, occurrence);
        }
    }
}
