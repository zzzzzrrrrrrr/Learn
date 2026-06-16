using System;

namespace _001_caycatchfinally处理异常
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] myarr = { 1, 2, 3, 4 };

            try
            {
                int ret = myarr[4];
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("数组下标越界了0.0");
            }
            finally
            {
                Console.WriteLine("请输入正确的数组下标");
            }
        }
    }
}