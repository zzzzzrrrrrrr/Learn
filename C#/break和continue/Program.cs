using System;

namespace _001_break使用方法
{
    class Test
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 100;i++)
            {
                if(i % 2 == 0)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}

namespace _002_continue使用方法
{
    class Test
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
