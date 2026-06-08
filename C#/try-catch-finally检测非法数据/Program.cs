using System;

namespace _001_检测非法数据
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入两个数字,每行一个");
            int n1, n2;
            //检测一次
            try
            {
                //尝试捕捉两个输入的变量内容
                n1 = Convert.ToInt32(Console.ReadLine());
                n2 = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException e)
            {
                Console.WriteLine("你输入的数据不符合规则请重新输入");
                //尝试重新捕捉两个输入的变量内容
                n1 = Convert.ToInt32(Console.ReadLine());
                n2 = Convert.ToInt32(Console.ReadLine());
            }

            while (true)
            {
                try
                {
                    //尝试捕捉两个输入的变量内容
                    n1 = Convert.ToInt32(Console.ReadLine());
                    n2 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("你输入的数据不符合规则请重新输入");
                }

            }
            Console.WriteLine(n1 + n2);
        }
    }
}