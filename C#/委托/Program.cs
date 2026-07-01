using System;

namespace _001_委托
{
    class Program
    {
        static double Multiply(double param1, double param2)
        {
            return param1 + param2;
        }
        static double Divide(double param1, double param2)
        {
            return param1 / param2;
        }

        static void Test()
        {
            Console.WriteLine("Test");
        }

        delegate double MyDelegate(double param1, double param2);
        delegate void MyDelegate2();

        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(2.3, 2));
            Console.WriteLine(Divide(4.5, 3));

            MyDelegate Delegate1 = Multiply;
            Console.WriteLine(Delegate1(2,4));

            Delegate1 = Divide;
            Console.WriteLine(Delegate1(2, 4));

            MyDelegate2 Delegate2 = Test;
            Console.WriteLine(Delegate2);

        }
    }
}