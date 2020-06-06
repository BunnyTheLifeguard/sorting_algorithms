using System;

namespace sorting_algorithms
{
    class Bubble
    {
        public static int[] sort(int[] arr)
        {
            int[] nums = arr;
            Console.WriteLine($"Unsorted array: {string.Join(", ", nums)}");
            Console.WriteLine("----------");

            bool swapped;

            do
            {
                swapped = false;

                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] > nums[i + 1])
                    {
                        Console.WriteLine($"Before swap: {string.Join(", ", nums)}");
                        int temp = nums[i + 1];
                        nums[i + 1] = nums[i];
                        nums[i] = temp;
                        swapped = true;
                        Console.WriteLine($"After swap: {string.Join(", ", nums)}");
                        Console.WriteLine("----------");
                    }
                }
            } while (swapped == true);

            Console.WriteLine($"Bubble sorted: {string.Join(", ", nums)}");
            return nums;
        }
    }
}