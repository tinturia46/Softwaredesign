using System;

namespace L08
{
    public class Field
    {
            public static string[] row1 = new string[] { "|", " - ", " - ", " - ", "|" };
            public static string[] row2 = new string[] { "|", " r ", " 2 ", " 3 ", "|" };
            public static string[] row3 = new string[] { "|", " 4 ", " 5 ", " 6 ", "|" };
            public static string[] row4 = new string[] { "|", " 7 ", " 8 ", " 9 ", "|" };
            public static string[] row5 = new string[] { "|", " - ", " - ", " - ", "|" };
        public static void createfield()
        {
            
            foreach (var item in row1)
            {
                Console.Write(item.ToString());
            }
            Console.WriteLine("");
            foreach (var item in row2)
            {
                Console.Write(item.ToString());
            }
            Console.WriteLine("");
            foreach (var item in row3)
            {
                Console.Write(item.ToString());
            }
            Console.WriteLine("");
            foreach (var item in row4)
            {
                Console.Write(item.ToString());
            }
            Console.WriteLine("");
            foreach (var item in row5)
            {
                Console.Write(item.ToString());
            }
        }

    }
}
