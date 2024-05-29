using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class CalculatePrimeNumbers
    {

        public static bool IsPrime(int num) {
            for (int i = 2; i < num; i++) { 
                if (num % i == 0) 
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Find all prime numbers in the given range and returns them as an array of integers.
        /// </summary>
        /// <param name="startNum"></param>
        /// <param name="endNum"></param>
        /// <returns></returns>
        public static int[] FindPrimesInRange(int startNum, int endNum) {
            if (startNum <= 2) startNum = 2;
            if (startNum > endNum) return Array.Empty<int>();

            List<int> primes = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i)) {
                    primes.Add(i);
                }
            }
            return primes.ToArray();
        }
    }
}
