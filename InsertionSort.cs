using System;

namespace sorting_algorithms
{
    class Insertion
    {
        public static int[] sort(int[] arr)
        {
            int[] nums = arr;
            Console.WriteLine($"Unsorted array: {string.Join(", ", nums)}");
            Console.WriteLine("----------");

            int newValue;

            for (int i = 1; i < nums.Length; i++)
            {
                Console.WriteLine($"Before swap: {string.Join(", ", nums)}");
                newValue = nums[i];
                int j = i;

                while (j > 0 && nums[j - 1] > newValue)
                {
                    nums[j] = nums[j - 1];
                    j--;
                }

                nums[j] = newValue;
                Console.WriteLine($"After swap: {string.Join(", ", nums)}");
                Console.WriteLine("----------");
            }

            Console.WriteLine($"Insertion sorted: {string.Join(", ", nums)}");
            return nums;
        }
    }
}