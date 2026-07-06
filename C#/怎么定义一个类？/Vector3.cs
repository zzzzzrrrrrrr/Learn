using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 定义类_
{
    class Vector3
    {
        private float x;
        private float y;
        private float z;
    
        public void SetX(float temp)
        {
            if(temp < 0)
            { 
                return;
            }
            x= temp;
        }
        public void SetY(float temp)
        {
            if (temp < 0)
            {
                return;
            }
            y = temp;
        }
        public void SetZ(float temp)
        {
            if (temp < 0)
            {
                return;
            }
            z = temp;
        }
        public float GetX() 
        {
            return x;
        }

        public double Length()
        {
            return Math.Sqrt(x*x + y*y +z * z);
        }


    }
}
