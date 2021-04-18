using System;
using System.Linq;

namespace Exercise28
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set bool to true to being a while loop
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("Please enter some text.");
                string words = Console.ReadLine().ToLower();

                //Call the Remove Vowels method created for this exercise
                string output = RemoveVowels(words);
                Console.WriteLine(output);

                Console.WriteLine("Would you like to input more text? y/n");
                //No matter if capital or lower case is used, a Y/y will return bool true
                string answer = Console.ReadLine().ToLower();

                if (answer == "y")
                {
                    repeat = true;
                }
                //Any answer other than Y/y will return bool false, and the loop will terminate.
                else
                {
                    Console.WriteLine("Goodbye.");
                    repeat = false;
                }
            }
        }

        public static string RemoveVowels(string word)
        {
            //A string is passed through this method. The method looks for vowels in the string,
            //and essentially turns them into white space causing them to "delete".
            string answer = word.Replace("a", String.Empty)
                                .Replace("e", String.Empty)
                                .Replace("i", String.Empty)
                                .Replace("o", String.Empty)
                                .Replace("u", String.Empty);
            return answer;

        }
    }
}