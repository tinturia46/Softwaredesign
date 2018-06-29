using System;

namespace TicTacToe
{
    class Field
    {
        public static int counter = 0;
        public static char[] gamedata = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public static void printfield()
        {
            Console.WriteLine(" ");
            Console.WriteLine(" " + gamedata[1] + " | " + gamedata[2] + " | " + gamedata[3] + " ");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" " + gamedata[4] + " | " + gamedata[5] + " | " + gamedata[6] + " ");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" " + gamedata[7] + " | " + gamedata[8] + " | " + gamedata[9] + " ");
            Console.WriteLine(" ");
        }

        public static void draw()
        {
            Console.WriteLine("Look it's a draw!");
        }
    }

}