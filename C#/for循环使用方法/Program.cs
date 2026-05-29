using System;

namespace _001_for循环使用方法
{
    class Test
    {
        static void Main(string[] args)
        {
            for(int i = 1; i<11;i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

namespace _002_for循环使用方法
{
    class Test
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = n; i <= m; i++)
            {
                if(i%17 ==0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
namespace _003_for循环使用方法
{
    class Test
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 20; i++)
            {
                Console.WriteLine("*");
            }
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
namespace _004_for循环使用方法
{
    class Test
    {
        static void Main(string[] args)
        {



        }
    }
}
