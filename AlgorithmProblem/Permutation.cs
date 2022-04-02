using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblem
{
    internal class StringPermutation
    {
        public void Input()
        {
            Console.Write("Enter the word for permutation: ");
            string Word = Console.ReadLine();
            Recursion(Word, 0);
        }

        public static void Recursion(string word, int start)
        {
            int Length = word.Length;

            for (int i = start; i < Length; i++)
            {
                word= (Swap(word, start, i));
                Console.WriteLine(word);
                Recursion(word, start + 1);
                word = Swap(word, start, i);
            }
        }
        public static string Swap(string word, int start, int end)
        {
            char store;
            char[] charArray = word.ToCharArray();
            store = charArray[start];
            charArray[start] = charArray[end];
            charArray[end] = store;
            string newword = new string(charArray);
            return newword;
        }
    }
}