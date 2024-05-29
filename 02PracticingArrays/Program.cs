using System;

namespace Assignment2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Problem #1
            CopyingAnArray caa = new();
            caa.PerformOperation();
            Console.WriteLine();

            //Problem #2
            //ManageListOfElements ml = new();
            //ml.PerformOperation();

            //Problem #3
            int[] primes = CalculatePrimeNumbers.FindPrimesInRange(1, 100);
            Console.WriteLine($"The prime values from 1 to 100 are: {String.Join(", ", primes)}");
            Console.WriteLine();

            //Problem #4
            ArrayShifting arrShift = new();
            int[] output = arrShift.PerformOperation();
            Console.WriteLine("The sum array after the rotation is shown below.");
            Console.WriteLine(String.Join(" ", output));
            

        }
    }
}
