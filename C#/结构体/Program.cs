using System;

namespace _001_结构体
{
    class Program
    {
        struct Student
        {
            public int Age;
            public string Name;
            public int Grade;
            public int ID;
        }

        struct Position
        {
            public double x;
            public double y;
            public double z;

            public void PrintPosition()
            {
                Console.WriteLine(x+ ","+y+","+z);
            }
        }

        struct Name
        {
            public string FirstName;
            public string LastName;

            public string FullName()
            {
                return FirstName + LastName;
            }
        }

        struct Vector3
        {
            public double x;
            public double y;
            public double z;
            public double Distance()
            {
                double temp = x*x+y*y+z*z;
                return Math.Sqrt(temp);
            }
        }

        static void Main(string[] args)
        {
            /*int student1Age = 10;
            string student1Name = "cp";
            int student1Grade = 1;
            int student1ID = 10213021;

            int student2Age = 20;
            string student2Name = "op";
            int student2Grade = 2;
            int student2ID = 10213022;
            
            int student3Age = 30;
            string student3Name = "mj";
            int student3Grade = 3;
            int student3ID = 10213023;*/

            Student student1;
            student1.Age = 10;
            student1.Name = "小米";
            student1.Grade = 2;
            student1.ID = 10102101;

            Student[] students = new Student[10];
            students[0].Age = 30;

            Console.WriteLine(students[0].Age);

            Position p1;
            p1.x = 23.3;
            p1.y = 3.4;
            p1.z = 1;
            p1.PrintPosition();

            Position p2;
            p2.x = 1;
            p2.y = 2.2;
            p2.z = 3.4;
            p2.PrintPosition();

            Name name;
            name.FirstName = "zr";
            name.LastName = " 张";
            Console.WriteLine("My name is" +  name.FullName() + ".");

            Name name2;
            name2.FirstName = "m";
            name2.LastName = "j";
            Console.WriteLine(name2.FullName());

            Vector3 v1;
            v1.x = 4;
            v1.y = 5;
            v1.z = 7;
            Console.WriteLine(v1.Distance());

        }
    }
}