using System;
using System.Text;

namespace ProgChallenge2
{
    class Program
    {
        static (bool, int) CheckForPalindrome(string s) {
            s = OnlyAlphanumeric(s);
            s = s.ToLower();
            string reverse = Reverse(s);

            bool isPal;
            if (s == "") {
                isPal = false;
            }
            else if (s == reverse) {
                isPal = true;
            }
            else {
                isPal = false;
            }
            return (isPal ? true : false, isPal ? s.Length : 0);
        }
        static string Reverse(string s) {
            char[] temp = s.ToCharArray();
            Array.Reverse(temp);
            return new string(temp);
        }
        static string OnlyAlphanumeric(string s) {
            StringBuilder result = new StringBuilder();
            foreach (char c in s) {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z')) {
                   result.Append(c); 
                }
            }
            return result.ToString();
        }
        static void Main(string[] args)
        {
            // Loop condition
            bool keepGoing = true;
            // Main loop
            do {
                Console.WriteLine("Please enter a word.");
                Console.WriteLine("'quit' to exit.");

                string input = Console.ReadLine();
                if (input == "quit") {
                    keepGoing = false;
                }
                else {
                    (bool IsPal, int Len) result = CheckForPalindrome(input);
                    Console.WriteLine($"IsPal: {result.IsPal}; Length: {result.Len}");
                    Console.WriteLine();
                }
            } while (keepGoing);
        }
    }
}
