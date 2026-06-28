using System;
using 属性_;

namespace _001_属性
{
    class Program
    {
    static void Main(string[] args)
        {
            Customer lisi = new Customer();

            lisi.Age = 23;

            Console.WriteLine(lisi.Age);

            lisi.Name = "edu";
            Console.WriteLine(lisi.Name);

            int age = 12;

            //匿名类型
            var age2 = 45;

            var name = "edu";

        }
    }
}