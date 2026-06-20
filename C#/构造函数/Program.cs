using System;
using 定义类_;

namespace _001_定义类
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer lisi1 = new Customer();
            Customer lisi2 = new Customer();
            Customer lisi3 = new Customer();

            Customer zs  = new Customer("zhangsan","beijing",21,"2025");
            zs.Show();


        }
    }
}

