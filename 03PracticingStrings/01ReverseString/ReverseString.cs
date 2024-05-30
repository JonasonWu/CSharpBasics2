using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{

    class UserInput {
        public static string GetUserInput() {
            Console.Write("Give me a line of text: ");
            return Console.ReadLine().Trim();
        }
    }
    class ReverseString
    {
        /// <summary>
        /// Returns a reversed version of the string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReversedString(string str) {
            return new string(str.ToCharArray().Reverse().ToArray());
        }
        /// <summary>
        /// Prints the string as the string is getting reversed.
        /// </summary>
        /// <param name="str"></param>
        public void PrintReversedString(string str) { 
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
        }
        public void PerformOperation() {
            string userInput = UserInput.GetUserInput();
            Console.WriteLine("Method 1: Print after reversing whole string.");
            Console.WriteLine(ReversedString(userInput));
            Console.WriteLine("Method 2: Print reversed string character by character.");
            PrintReversedString(userInput);


        }
    }
    class ReverseSentence {

        private string separators = ".,:;=()&[]\"'\\/!? ";

        public string[] ExtractWordsFromString(string input) {
            List<string> li = new();
            StringBuilder sb = new();
            foreach (char c in input) {
                if (!this.separators.Contains(c))
                {
                    sb.Append(c);
                }
                else if (sb.Length == 0) 
                {
                    continue;
                }
                else
                {
                    li.Add(sb.ToString());
                    sb.Clear();
                }
            }
            if (sb.Length > 0) li.Add(sb.ToString());
            return li.ToArray();
        }

        public string[] GetOrderOfSeparatorsInString(string input) {
            List<string> li = new();
            StringBuilder sb = new();
            foreach(char c in input) {
                if (this.separators.Contains(c))
                {
                    sb.Append(c);
                }
                else if (sb.Length == 0)
                {
                    continue;
                }
                else
                {
                    li.Add(sb.ToString());
                    sb.Clear();
                }
            }
            if (sb.Length >= 0) li.Add(sb.ToString());
            return li.ToArray();
        }

        /// <summary>
        /// Given the words and the separators in order, reverse the order of the words while retaining the order of the
        /// separators.
        /// </summary>
        /// <param name="words"></param>
        /// <param name="separators"></param>
        /// <returns></returns>
        public string GetReversedSentence(string[] words, string[] separators)
        {
            StringBuilder sb = new();
            for (int i = words.Length - 1; i >= 0; i--) {
                sb.Append(words[i]);
                sb.Append(separators[separators.Length - 1 - i]);
            }
            return sb.ToString();
        }
        public void PerformOperation()
        {
            string userInput = UserInput.GetUserInput();
            string[] words = ExtractWordsFromString(userInput);
            string[] separators = GetOrderOfSeparatorsInString(userInput);

            string reverseSentenceRetainPunctuation = GetReversedSentence(words, separators);
            Console.WriteLine(reverseSentenceRetainPunctuation);
        }
    }
}
