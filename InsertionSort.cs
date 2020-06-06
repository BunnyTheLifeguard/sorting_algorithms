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

            // Variable for insertion
            int newValue;

            for (int i = 1; i < nums.Length; i++)
            {
                Console.WriteLine($"Before swap: {string.Join(", ", nums)}");
                // Start at second element in array (since first one has no preceding value)
                newValue = nums[i];
                // Set start of inner loop to same value as i
                int j = i;

                /* Check value of j to ensure the end of iteration (j = 0) is not reached and if value preceding the current value is larger If true => Swap, decrement j, test next value until (j = 0) */
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