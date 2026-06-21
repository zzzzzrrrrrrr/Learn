using System;

namespace _001_函数的递归调用
{
    class Test
    {
        static int F(int n)
        {
            if(n ==1)
            {
                return 1;
            }
            int result = n * F(n - 1);
            return result;
        }


        static void Main(string[] args)
        {


            Console.WriteLine(F(10));
        }
    }
}