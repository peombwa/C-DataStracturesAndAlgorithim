using System;

namespace PowerRecursive
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare an array of integers that are not sorted
            int[] nums = { 5, 10, 3, 2, 4 };

            // Output the unsorted array to the console
            Console.WriteLine("Before: 5, 10, 3, 2, 4");

            nums = BubbleSort.Sort(nums);

            Console.Write("After: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0}, ", nums[i]);
            }

            // Use Console.ReadLine() in the event application was started with debugging.
            Console.ReadLine();
        }

        static int Power(int baseNumber, int exponent)
        {
            if (exponent > 0)
            {
                exponent--;
                return baseNumber * Power(baseNumber, exponent);
            }
            else
            {
                return 1;
            }
        }

        static double CylinderVolume(float r, float h)
        {
            double pi = Math.PI;// 3.1444444;
            double v = 0;

            if (r > 0 && h > 0)
            {
                double area = pi * Math.Pow(r, 2);
                v = area * h;
            }

            return Math.Round(v, 2);
        }
    }
}
