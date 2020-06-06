using System;

namespace sorting_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 8, 4, 6, 2, 1 };

            Console.WriteLine("Select sorting algorithm:");
            Console.WriteLine("1. Bubble Sort");
            Console.WriteLine("2. Insertion Sort");
            string selection = Console.ReadLine();

            if (selection == "1")
            {
                Bubble.sort(arr);
            }
            else
            {
                Insertion.sort(arr);
            }
        }
    }
}
