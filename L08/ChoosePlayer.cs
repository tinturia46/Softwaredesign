using System;

namespace L08
{
    public class ChoosePlayer
    {
       
           public static string choice;
        
       
        public static void choosePlayer()
        {
             
            Console.WriteLine("");
            Console.WriteLine("Player 1, choose X or O");
            

            switch (Console.ReadLine())
            {
                case "x":
                    Console.WriteLine("You chose X, Player 2 is O");
                    choice = "X";
                    break;
                case "X":
                    Console.WriteLine("You chose X, Player 2 is O");
                    choice = "X";
                    break;
                case "o":
                    Console.WriteLine("You chose O, Player 2 is X");
                    choice = "O";
                    break;
                case "O":
                    Console.WriteLine("You chose O, Player 2 is X");
                    choice = "O";
                    break;
                default:
                    Console.WriteLine("Unvalid Input, Try Again");
                    Console.ReadLine();
                    break;
            }
        }
    }

}
