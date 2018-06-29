using System;

namespace TicTacToe
{
    class Field
    {
        public static int counter = 0;
        public static char[] gamedata = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        public static void printfield()
        {
            Console.WriteLine(" ");
            Console.WriteLine(" " + gamedata[0] + " | " + gamedata[1] + " | " + gamedata[2] + " ");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" " + gamedata[3] + " | " + gamedata[4] + " | " + gamedata[5] + " ");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" " + gamedata[6] + " | " + gamedata[7] + " | " + gamedata[8] + " ");
            Console.WriteLine(" ");
        }
        public static void howto()
        {
            Console.WriteLine("Welcome to TicTacToe - This is the field:");
            Console.WriteLine("Your input will substitute the numbers:");
            Console.WriteLine(" ");
            Console.WriteLine(" " + "1" + " | " + "2" + " | " + "3" + " ");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" " + "4" + " | " + "5" + " | " + "6" + " ");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" " + "7" + " | " + "8" + " | " + "9" + " ");
            Console.WriteLine(" ");
            Console.WriteLine("Have Fun!");
            
        }


        public static void draw()
        {
            Console.WriteLine("Look it's a draw!");
            printfield();
        }
        public static void won(char turn)
        {
            Console.WriteLine(turn + " won! Congratulations!");
            printfield();
        }
       
        }
    }

}