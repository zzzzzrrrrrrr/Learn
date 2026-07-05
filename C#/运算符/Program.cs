using System;

/*namespace _001_运算符
{
    class Test
    {
        static void Main(string[] args)
        {
            int ar = 23 + 23;
            int b = 2 - 10;
            int c = 3 * 8;
            int d = 45 / 10;
            int e = 45 % 10;
            double f = 45 / 10.0;

            Console.WriteLine(ar);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);

            int num = 78;
            int first = 78 % 10;
            int ten = 78 / 10;

            Console.WriteLine(first);
            Console.WriteLine(ten);

            int a = 0;
            a += 5;
            Console.WriteLine(a);
            a -= 2;
            Console.WriteLine(a);
            a *= 13;
            Console.WriteLine(a);
            a /= 4;
            Console.WriteLine(a);
            a %= 10;
            Console.WriteLine(a);   

        }
    }
}*/

/*namespace _002_自增自减运算符
{
    class Test
    {
        static void Main(string[] args)
        {
            int a = 0;
            a++;
            Console.WriteLine(a);
            a++;
            Console.WriteLine(a);
            a--;
            Console.WriteLine(a);
        }
    }
}*/

/*namespace _003_关系运算符和bool类型
{
    class Test
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;
            Console.WriteLine(a);
            Console.WriteLine(b);

            bool c = 45 == 67;
            Console.WriteLine(c);

            bool d = 45 < 67;
            Console.WriteLine(d);

            bool e = 45 > 67;
            Console.WriteLine(e);

            bool f = 45 < 67;
            Console.WriteLine(f);

            bool g = 45 <= 67;
            Console.WriteLine(g);

            bool h = 45 >= 67;
            Console.WriteLine(h);

            bool i = 45 != 67;
            Console.WriteLine(i);

        }
    }
}*/

/*namespace _004_逻辑运算符
{
    class Test
    {
        static void Main(string[] args)
        {
            bool a = (3 < 4) && (9 < 10);
            bool b = (3 < 2) && (9 < 7);

            bool c = !(4 < 7);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            int age = Convert.ToInt32(Console.ReadLine());
            bool trueage = age >= 18 && age <= 60;

            Console.WriteLine(trueage);


        }
    }
}*/

namespace _005_运算符优先级
{
    class Test
    {
        static void Main(string[] args)
        {
            int ret = 3 + 2 * 4;
            Console.WriteLine(ret);


        }
    }
}
