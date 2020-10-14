using System;
namespace lesson4
{
    public class Person
    {
        public string name;
        public int age;

        public void GetInfo()
        {
            Console.WriteLine($"you name is {name} and your age is {age}");
        }
    }


    public struct Student
    {
        public string name;
        public int age;

        public void GetInfo()
        {
            Console.WriteLine($"you name is {name} and your age is {age}");
            Console.ReadLine();
        }
    }
}
