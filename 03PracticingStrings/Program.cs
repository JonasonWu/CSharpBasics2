
using _03PracticingStrings._03ExtractAllPalindromes;
using Assignment3;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem #1
            Console.WriteLine("Reversing Strings.");
            ReverseString rs = new();
            rs.PerformOperation();
            Console.WriteLine();

            //Problem #2
            Console.WriteLine("Reversing words without changing punctuations and spaces");
            ReverseSentence rSent = new();
            rSent.PerformOperation();
            Console.WriteLine();

            //Problem #3
            Console.WriteLine("Extracting all palindromes from specified text.");
            string text = "Hi,exe? ABBA! Hog fully a string: ExE. Bob";
            Console.WriteLine(text);
            Palindromes pal = new();
            pal.PerformOperation(text);
            Console.WriteLine();

            //Problem #4
            Console.WriteLine("Parsing URL to extract components.");
            URLParser up = new();
            up.PerformOperation("https://www.apple.com/iphone");
            Console.WriteLine();
            up.PerformOperation("ftp://www.example.com/employee");
            Console.WriteLine();
            up.PerformOperation("https://google.com");
            Console.WriteLine();
            up.PerformOperation("www.apple.com");
            Console.WriteLine();
        }
    }
}
