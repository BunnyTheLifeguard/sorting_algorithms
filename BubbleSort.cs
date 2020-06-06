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

            // Variable to know when to stop sorting routine
            bool swapped;

            do
            {
                // Set to false to guarantee at least one pass on array
                swapped = false;

                for (int i = 0; i < nums.Length - 1; i++)
                {
                    // Compare first value with adjacent value
                    if (nums[i] > nums[i + 1])
                    {
                        Console.WriteLine($"Before swap: {string.Join(", ", nums)}");
                        // Temporarily save the value to the right
                        int temp = nums[i + 1];
                        // Replace right value with the larger one
                        nums[i + 1] = nums[i];
                        // Reassign smaller temp value to previous location of the larger one
                        nums[i] = temp;
                        // Indicate that a swap happened => Continue checking values
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