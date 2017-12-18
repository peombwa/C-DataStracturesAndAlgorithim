using System;
using System.Collections.Generic;
using System.Text;

namespace PowerRecursive
{
    public static class BubbleSort
    {
        public static int[] Sort(int[] nums)
        {
            bool swapped;
            do
            {
                swapped = false;

                for (var i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] > nums[i + 1])
                    {
                        int temp = nums[i + 1];
                        nums[i + 1] = nums[i];
                        nums[i] = temp;
                        swapped = true;
                    }
                }

            } while (swapped == true);

            return nums;
        }
    }    
}
