using System;


namespace _001_嵌套循环使用方法
{
    class Test
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 10; i++)
                {
                    Console.WriteLine("*");
                }
            }
            Console.WriteLine("\n");
        }
    }
}

namespace _002_嵌套循环使用方法
{
    class Test
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("*");
                }
            }
            Console.WriteLine("\n");
        }
    }
}

namespace _003_嵌套循环使用方法
{
    class Test
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < n+1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine("*");
                }
            }
            Console.WriteLine("");
        }
    }
}

namespace _004_嵌套循环使用方法
{
    class Test
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 0; j < i-1; j++)
                {
                    Console.WriteLine(" ");
                }
            }
            Console.WriteLine("*");
        }
    }
}

namespace _005_嵌套循环使用方法
{
    class Test
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = n; i > 0; i--)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    Console.WriteLine(" ");
                }
            }
            Console.WriteLine("*");
        }
    }
}

namespace _006_嵌套循环使用方法
{
    class Test
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < n-i; j++)
                {
                    Console.WriteLine(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine("*");
                }
            }
        }
    }
}

namespace _007_嵌套循环使用方法
{
    class Test
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.WriteLine(" ");
                }
                for (int j = 0; j < 2*i-1; j++)
                {
                    Console.WriteLine("*");
                }
            }
        }
    }
}

namespace _008_嵌套循环使用方法
{
    class Test
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.WriteLine(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine("*");
                }
            }
        }
    }
}

namespace _009_嵌套循环使用方法
{
    class Test
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.WriteLine(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine("*");
                }
            }
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine(" ");
                }
                int count = (n - i) * 2 - 1;
                for (int j = 0; j < count; j++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();
            }
        }
    }
}