using System;
using 定义类_;

namespace _001_定义类
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            Customer c2 = new Customer();
            c1.name = "z";
            c2.name = "a";
            c1.Show();
            c2.Show();

            Vehicle v1 = new Vehicle();
            v1.Run();
            v1.Stop();

            Vector3 v2 = new Vector3();
            v2.SetX(12.3f);
            v2.SetY(2.5f);
            v2.SetZ(1.5f);
            Console.WriteLine(v2.GetX());
            Console.WriteLine(v2.Length());

            Customer lisi = new Customer();
            lisi.setAge(-10);
            lisi.Show();
        }
    }
}