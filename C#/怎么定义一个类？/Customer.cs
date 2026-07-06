using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 定义类_
{
    internal class Customer
    {
        public string name;
        public string address;
        private int age;
        public string createTime;
        public int setAge()
        {
            if(age < 0)
            {
                age = 0;
            }
            return age;
        }

        public void Show()
        {
            Console.WriteLine("名字 " + name);
            Console.WriteLine("地址" + address);
            Console.WriteLine("年龄" + age);
            Console.WriteLine("创建时间" + createTime);
        }
    }

}
