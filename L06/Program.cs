using System;
using System.Collections.Generic;
using System.Globalization;


namespace L06
{
    class Program
    {
        class Course
        {
            public int room;
            public string Datetime;
            public string title;
            public Participant participant;
            public Prof prof;
            
            }

        public class Person
        {
            public string name;
            public int age;

        }
        public class Prof : Person
        {
            public string consult;
            public string room;

            public List<Course> Course;

        public class Participant : Person
        {
            public int number;
            public List<Course> Course ;
        }


            //Example
        Prof mueller = new Prof {name = "Müller", age = 50, consult="Mo 14:00 - 15:00", room = "L:2.06" , course = "Softwaredesign"};
        static void Main(string[] args)
        {
            
        }
    }
}
