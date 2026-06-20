using System;

namespace _001_参数数组
{
    class Test
    {
        static int Add1(int a,int b)
        {
            int result = a + b;
            return result;
        }

        static int Add2(int[] array)
        {
            int sum = 0;
            foreach(int temp in array)
            {
                sum += temp;
            }
            return sum;
        }

        //params参数数组
        //参数数组必须是最后一个形参
        static int Add3(params int[] array)
        {
            int sum = 0;
            foreach (int temp in array)
            {
                sum += temp;
            }
            return sum;
        }


        static void Main(string[] args)
        {
            int sum1 = Add2(new int[] { 2, 4, 8 });
            Console.WriteLine(sum1);

            int[] array2 = { 6, 8, 9 };
            int sum2 = Add2(array2);
            Console.WriteLine(sum2);

            int sum3 = Add3(6, 8, 1);
            Console.WriteLine(sum3);



        }
    }

}