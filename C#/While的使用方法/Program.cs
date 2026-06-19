using System;

namespace _001_While的使用方法
{
    class Test 
    {
        static void Main(string[] args)
        {
            int i = 1;

            while(i<= 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}


namespace _002_While的使用方法
{
    class Test
    {
        static void Main(string[] args)
        {
            int Hp = 100;
            while(Hp > 0)
            {
                Hp -= 5;
                Console.WriteLine("HP"+Hp);
            }
        }
    }
}


namespace _003_While的使用方法
{
    class Test
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            int i = num1;
            while(i <num2 +1)
            {
                Console.WriteLine(i);
            }
            i++;
        }
    }
}


namespace _004_While的使用方法
{
    class Test
    {
        static void Main(string[] args)
        {
            int number = 80000;
            int year = 2006;
            while( number < 200000)
            {
                number = (int)(number * 1.25);
                year++;
            }
            Console.WriteLine(year);
        }
    }
}

