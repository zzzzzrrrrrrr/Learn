using System;

/*namespace _001_if语句
{
    class Test
    {
        static void Main(string[] args)
        {
            int age = Convert.ToInt32(Console.ReadLine());

            if(age <= 16)
            {
                Console.WriteLine("可以进入");
            }
            else
            {
                Console.WriteLine("年龄太大不能进入");
            }

            Console.WriteLine("程序结束");
        }

    }
}*/

namespace _002_if嵌套
{
    class Test
    {
        static void Main(string[] args)
        {
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18 && age <= 30)
            {
                Console.WriteLine("可以参加活动");

                if(age % 2 == 1)
                {   
                    Console.WriteLine("获得奖品");
                }
                else
                {
                    Console.WriteLine("没有获得奖品");
                }
            }
            else
            {
                Console.WriteLine("不能参加活动");
            }
            Console.WriteLine("程序结束");
        }
    }
}

namespace _003_if
{
    class Test
    {
        static void Main(string[] args)
        {


        }
    }
}