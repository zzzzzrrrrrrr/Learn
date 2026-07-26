using System;

namespace _001_字符串
{
    class Test
    {
        static void Main(string[] args)
        {
            string name = "Micheal Jackson";
            Console.WriteLine(name.Length);
            Console.WriteLine(name[3]);

            for (int i = 0; i < name.Length; i++) 
            {
                Console.WriteLine(name[i]);
            }

            for (int i = name.Length; i >= 0; i++)
            {
                Console.WriteLine(name[i]);
            }
        }
    }
}

namespace _002_字符串
{
    class Test
    {
        static void Main(string[] args)
        {
            string name = "Micheal Jackson";

            //小写
            string str = name.ToLower();
            Console.WriteLine(name + "-" + str);

            //大写
            string str2 = name.ToUpper();
            Console.WriteLine(name + "-" + str2);

            //去除空格
            string str3 = name.Trim();
            Console.WriteLine(name + "-" + str3);

            //去除前面空格
            string str4 = name.TrimStart();
            Console.WriteLine(name + "-" + str4 + "|");

            //去除后面空格
            string str5 = name.TrimEnd();
            Console.WriteLine(name + "-" + str4 + "|");


        }
    }
}

namespace _003_字符串操作split
{
    class Test
    {
        static void Main(string[] args)
        {
            string name = "Micheal Jackson,ED Sheeran,Charlie Puth,OneRepublic";
            string[] strArray = name.Split(',');
            foreach (string str in strArray)
            {
                Console.WriteLine(str);
            }
        }
    }
}

namespace _004_喝可乐
{
    class Test
    {
        static void Main(string[] args)
        {
            int pNumber = 364;
            int hNumber = 364;
            while (pNumber > 2) 
            {
                hNumber += pNumber / 3;
                pNumber = (pNumber / 3) + (pNumber % 3);
            }
            Console.WriteLine("一共可以喝" + hNumber + "剩下" + pNumber);  
        }
    }
}
