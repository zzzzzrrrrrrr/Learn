using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 定义类_
{
    internal class Vehicle
    {
        public int Speed;
        public int MaxSpeed;
        public float weight;

        public void Run()
        {
            Console.WriteLine("车辆跑起来了");
        }
        public void Stop()
        {
            Console.WriteLine("车辆停止了");
        }

    }
}
