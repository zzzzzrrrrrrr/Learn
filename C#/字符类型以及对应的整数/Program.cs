using System;


namespace _001_字符类型
{
    class Test
    {
        static void Main()
        {
            char a = 'a';
            int b = a;
            Console.WriteLine(a);
            Console.WriteLine(b);

            //强制类型转换
            int c = 97;
            char d = (char)c;
            Console.WriteLine(c);
            Console.WriteLine(d);


            char e = '1';
            int f = e;
            Console.WriteLine(e);
            Console.WriteLine(f);

            //常见的转义字符
            char a1 = '\n';
            char a2 = '\\';
            char a3 = '\"';
            char a4 = '\t';
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);
            Console.WriteLine(a4);

            Console.WriteLine("c:\\a\\b\\c");
            Console.WriteLine(@"c:\a\b\c");//@可以使转义字符失效

            String str = @"www.github.com\ngithub";
            Console.WriteLine(str);

            String str1 = "123" + "456";
            Console.WriteLine(str1);
            String str2 = "www" + str1;
            Console.WriteLine(str2);

            //读取一行字符串
            String str3 = Console.ReadLine();
            Console.WriteLine(str3 + "-");

            //输入的是数字可以转换成整形
            String str4 = Console.ReadLine();
            int strint = Convert.ToInt32(str4);
            Console.WriteLine(strint);

            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(g);
            //可得到整形相加
            Console.WriteLine(strint + g);
            //平均数
            Console.WriteLine((strint + g)/2);
            //平分
            Console.WriteLine(strint/g);

            
        }
        class Test1
        {
            static void  Main()
            {
                int a = 5, b = 10;

                int ret = a;
                    a = b;
                    b = a;

                    a = a + b;
                    b = a - b;
                    a = a - b;
                
                Console.WriteLine(a);
            }
        }
    }
}