using System;

namespace _001_do.while使用方法
{
    class Test
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 11);

            while(i < 0);
            {
                Console.WriteLine("i < 0");
            }
        }
    }
}

namespace _002_do.while使用方法
{
    class Test
    {
        static void Main(string[] args)
        {
            int n = 0;
            int sum = 0;
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
            } while (n != 0);
            Console.WriteLine(sum);
        }
    }
}

namespace _003_do.while使用方法
{
    class Test
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            double high = n;

        for (int i = 0; i < 10; i++)    
        {
                high /= 2;
        }
        Console.WriteLine("第十次落地后会反弹的高度是"+high);

            double distance = 2 * n;
            double sum = distance;

            for(int i = 0;i < 9;i++)
            {
                distance /= 2;
                sum += distance;
            }
            Console.WriteLine("第十次落地后经过{0}米" ,sum);
    }
}

namespace _004_do.while使用方法
{
    class Test
    {
        static void Main(string[] args)
        {

        }
    }
}