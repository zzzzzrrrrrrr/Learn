using System;

namespace _001_函数重载
{
    class Test
    {
        static int MaxValue(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++) 
            {
                max = array[i];
            }
            return max;
        }

        static double MaxValue(double[] array)
        {
            double max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                max = array[i];
            }
            return max;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(MaxValue(new int[] { 1, 28, 33, 40, 51, 6 });

        }
    }
}