using AlgorithmProblem;
using AlgorithmProgram;
using System;

namespace AlgorithmProblem
{
    public class program
    {
        public static void Main(String[] args)
        {
           // StringPermutation stringPermutation = new StringPermutation();
            //stringPermutation.Input();
            Console.WriteLine("1: For String Permutation");
            Console.WriteLine("2: For Bubble Sort");
            Console.WriteLine("3: For insertion Sort");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    StringPermutation stringPermutation = new StringPermutation();
                    stringPermutation.Input();
                    break;
                case 2:
                    BubbleSort bubbleSort = new BubbleSort();
                    bubbleSort.BubbleSorting();
                    Console.WriteLine();
                    break;
                case 3:
                    InsertionSort insertionSort = new InsertionSort();
                    insertionSort.Insert();
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("press a valid number");
                    break;
            }
        }

    }
}
        
        
    
