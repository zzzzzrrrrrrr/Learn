using System;

namespace _002_字符串输出
{
    class Test
    {
        static void Main(string[] args)
        {
            int a = 23, b = 45;

            Console.WriteLine("{0}+{1}={2}",a,b,a + b);

            Console.WriteLine("两个数字相加{0}+{0}={2}", 34, 123, 4);

            Console.WriteLine("两个数字相加{0}+{0}={3}", 34, 123, 4);


        }
    }
}