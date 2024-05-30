using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2;

namespace _03PracticingStrings._03ExtractAllPalindromes
{
    class Palindromes
    {
        static bool IsPalindrome(string word)
        {
            int length = word.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (word[i] != word[length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public string[] GetPalindromes(string[] words) {
            List<string> li = new();
            foreach (string word in words)
            {
                if (IsPalindrome(word)) {
                    li.Add(word);
                }
            }
            return li.ToArray();
        }

        private string[] CleanedWords(string[] uncleanedText) {
            List<string> li = new();
            ReverseSentence rs = new();
            foreach (string uncleaned in uncleanedText)
            {
                string[] words = rs.ExtractWordsFromString(uncleaned);
                foreach (string word in words)
                {
                    li.Add(word);
                }
            }
            return li.ToArray();
        }

        public string[] GetUnique(string[] words) { 
            return new HashSet<string>(words).ToArray();
        }

        public void PerformOperation(string text)
        {
            string[] uncleanedWords = text.Split(" ");
            string[] cleanedWords = CleanedWords(uncleanedWords);
            string[] palindromes = GetPalindromes(cleanedWords);
            Array.Sort(palindromes);
            Console.WriteLine(String.Join(", ", palindromes));
        }

    }
}
