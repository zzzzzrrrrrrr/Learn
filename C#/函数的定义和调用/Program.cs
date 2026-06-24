using System;

namespace _001_函数
{
    class Program
    {
        static void Testadvice()
        {
            Console.WriteLine("Michael Jackson");
        }

        static bool TrueUsername(string username)
        {
            Console.WriteLine("检验逻辑修改");
            return true;
        }

        static void Username(string username)
        {
            Console.WriteLine(username);
        }

        static void Add1()
        {
            int result = 3 + 4;
        }

        static int Add2(int a,int b)
        {
            int result = a + b;
            return result;
        }
   
        static void Main(string[] args)
        {
            Testadvice();
            Testadvice();

            string s1 = "Michael Jackson";
            Username(s1);

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Add1();
            Add2(a, b);
        }
    }
}
