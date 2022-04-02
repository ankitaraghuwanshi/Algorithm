using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    class Anagram
    {
        public void Anagrams()
        {
            Console.Write("Enter first word:");
            string word_1 = Console.ReadLine();
            Console.Write("Enter second word:");
            string word_2 = Console.ReadLine();

            char[] charactorOne = word_1.ToLower().ToCharArray();
            char[] charactorTwo = word_2.ToLower().ToCharArray();
            Array.Sort(charactorOne);
            Array.Sort(charactorTwo);

            string NewWordOne = new string(charactorOne);
            string NewWordTwo = new string(charactorTwo);
            if (NewWordOne == NewWordTwo)
            {
                Console.WriteLine("Yes! Words are Anagrams", NewWordOne, NewWordTwo);
            }
            else
            {
                Console.WriteLine("No! Words are not Anagrams", NewWordOne, NewWordTwo);
            }
            Console.ReadLine();
        }
    }
}
