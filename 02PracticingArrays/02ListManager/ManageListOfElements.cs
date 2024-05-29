using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    enum ListOptions { 
        Add,
        Remove,
        Clear
    }
    class ManageListOfElements
    {

        private List<String> elements;
        public ManageListOfElements() {
            this.elements = new List<String>();
        }

        /// <summary>
        /// Performs the operation based on user input.
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns></returns>
        private string PerformTask(string userInput) {
            if (userInput.StartsWith("+"))
            {
                this.elements.Add(userInput.Substring(1).Trim());
            }
            else if (userInput.StartsWith("--"))
            {
                this.elements.Clear();
            }
            else if (userInput.StartsWith("-"))
            {
                this.elements.Remove(userInput.Substring(1).Trim());
            }
            else {
                return "Invalid Input. Try again.";
            }
            return "The operation was performed.";
        }

        private void PrintStoredElements() {
            Console.WriteLine("Current Items:");
            foreach(string s in this.elements) {
                Console.WriteLine($"* {s}");
            }
            Console.WriteLine();
        }

        private string AskForTask() {
            Console.Write("Enter command (+ item, - item, or -- to clear)): ");
            return Console.ReadLine();
        }

        public void PerformOperation()
        {

            for (; ; ) {
                string task = AskForTask();
                string result = PerformTask(task);
                Console.WriteLine(result);
                Console.WriteLine();
                PrintStoredElements();
            }
        }
    }
}
