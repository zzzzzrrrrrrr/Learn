using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 属性_
{
    class Customer
    {
        private string name;
        private string address;
        private int age;
        private string createTime;

        //public void SetAge(int age)
        //{ 
        //    this.age = age;
        //}
        //public int GetAge()
        //{
        //    return age;
        //}
        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    {
        //        name = value;
        //    }
        //}

        //public int Age
        //{
        //    get
        //    {
        //        return age;
        //    }
        //    set
        //    {
        //        if (value < 0) return;
        //        age = value;
        //    }
        //}

        public string Name
        {
            get;set;
        }
        public int Age { get; set; }

        //public Customer(string name,string address,int age ,string createTime)
        //{
        //    this.name = name;
        //    this.address = address;
        //    this.age = age;
        //    this.createTime = createTime;
        //}

        public void Show()
        {
            Console.WriteLine("名字 " + name);
            Console.WriteLine("地址" + address);
            Console.WriteLine("年龄" + age);
            Console.WriteLine("创建时间" + createTime);
        }
    }
}
