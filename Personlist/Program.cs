

using System;
using System.Collections.Generic;

namespace DesPatternSingleton
{
    public class IDGenerator
    {
        private IDGenerator()
        {
            letzteID = 1;
        }

        private static IDGenerator _instance;

        public static IDGenerator GetInstance()
        {
            if (_instance == null)
                _instance = new IDGenerator();
            return _instance;
        }

        private int letzteID;
        public int GibMirNeId()
        {
            return letzteID++;
        }
    } 
    
        public class Person
    {
        public string Name;
        public int Age;
        private int Id;
        

public Person(string newname, int newage){
    Age = newage;
    Name = newname;
    Id= IDGenerator.GetInstance().GibMirNeId();
    
}
        public override string ToString()
        {
            return "Name: " + Name + ", Age: " + Age + ", " + "Id: " + Id;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {       

            List<Person> personen = new List<Person>();
 
            new Person("Dieter",44);
//          Eine Stelle, an der Personen angelegt werden
//            
//            personen.Add(new Person{ Name="Tusnelda", Age=12,     Id = IDGenerator.GetInstance().GibMirNeId()});

            foreach (var person in personen)
            Console.WriteLine(person);

        }
    }
}












