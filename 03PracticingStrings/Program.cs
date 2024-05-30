
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

            //Problem #2
            Console.WriteLine("Reversing words without changing punctuations and spaces");
            ReverseSentence rSent = new();
            rSent.PerformOperation();

        }
    }
}
