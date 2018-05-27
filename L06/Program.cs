using System;

namespace L06
{
    class Program
    {
        public class Person
        {
            public string name;
            public int age;

        }
        public class Prof : Person
        {
            public string consult;
            public int room;
        }

        public class Participant : Person
        {
            public int number;
        }

        public class Course
        {
            int room;
            string time;
            string title;
            public Participant participant;
            public Prof prof;

        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
        }
    }
}
