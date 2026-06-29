using System;

namespace _001_数组
{
    class Test
    {
        static void Main(string[] args)
        {
            int[] ages = { 18, 22, 31, 48, 53, 62, 70, 88, 91, };

            Console.WriteLine(ages[7]);

            double[] temp1;
            char[] temp2;
            string[] temp3;

            int[] intArray = new int[9];
            char[] charArray = new char[20];
            float[] floatArray = new float[5];
            string[] stringArray = new string[4];
        }
    }
}

namespace _002_数组的赋值
{
    class Test
    {
        static void Main(string[] args)
        {
            int[] ages;
            ages = new int[] { 12, 21, 5, 4, 18 };

            ages[4] = 20;
            Console.WriteLine(ages[4]);
        }
    }
}

namespace _003_数组的遍历
{
    class Test
    {
        static void Main(string[] args)
        {
            int[] ages = { 18, 22, 31, 48, 53, 62, 70, 88, 91 };

            //for
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(ages[i] + " ");
            }
            Console.WriteLine();

            //while
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine(ages[j] + " ");
                j++;
            }

            //foreach   有点像auto
            foreach (int temp in ages)
            {
                Console.WriteLine(temp + " ");
            }
        }
    }
}

namespace _004_数组倒序遍历
{
    class Test
    {
        static void Main(string[] args)
        {
            int[] ages = { 18, 22, 31, 48, 53, 62, 70, 88, 91 };

            //for
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(ages[i] + " ");
            }
            Console.WriteLine();

            //while
            int j = 10;
            while (j > 0)
            {
                Console.WriteLine(ages[j] + " ");
                j--;
            }
        }
    }
}

namespace _004_数组长度获取
{
    class Test
    {
        static void Main(string[] args)
        {
            int[] ages = { 18, 22, 31, 48, 53, 62, 70, 88, 91 };
            Console.WriteLine(ages.Length);
            Console.WriteLine();

            for (int i = 0; i < ages.Length; i++)
            {
                Console.WriteLine(ages[i] + " ");
            }
        }
    }
}