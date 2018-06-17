using System;

namespace TicTacToe
{
    class Field
    {
        public static int counter = 0;
        public static char[] gamedata = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public static void createfield()
        {
            Console.WriteLine(" ");
            Console.WriteLine(" " + gamedata[1] + " | " + gamedata[2] + " | " + gamedata[3] + " ");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" " + gamedata[4] + " | " + gamedata[5] + " | " + gamedata[6] + " ");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" " + gamedata[7] + " | " + gamedata[8] + " | " + gamedata[9] + " ");
            Console.WriteLine(" ");
        }
    }
    class Play : Field
    {
        public static void getTurn()
        {
            if (counter == 9)
            {
                Console.WriteLine("Look: It's a draw!");
                createfield();

            }
            else
            {
                char[] turn = { 'x', 'o' };

                if ((counter % 2) == 0)
                {
                    Console.WriteLine("Player " + turn[0] + " it's your turn.");
                    getPosition(turn[0]);
                    counter++;
                    

                }

                else
                {
                    Console.WriteLine("Player  " + turn[1] + " it's your turn.");
                    getPosition(turn[1]);
                    counter++;
                    
                }
            }
        }
        public static void getPosition(char turn)
        {
            Console.WriteLine("Give me a Position 1-9");
            int input = Int32.Parse(Console.ReadLine());
            if (input >= 1 && input <= 9)
            {
                if (gamedata[input] == 'x' || gamedata[input] == 'o')
                {
                    Console.WriteLine("Position already taken, try again!");
                    getPosition(turn);
                }
                else
                {
                    gamedata[input] = turn;
                    createfield();
                    counter++;
                    checkWin(turn);
                    
                }
            }
            else
            {
                Console.WriteLine("Wrong Input try Again");
                getPosition(turn);
            }
        }

        public static void checkWin(char turn)
        {

            bool win = false;
            char[] row1 = new char[] { gamedata[1], gamedata[2], gamedata[3] };
            char[] row2 = new char[] { gamedata[4], gamedata[5], gamedata[6] };
            char[] row3 = new char[] { gamedata[7], gamedata[8], gamedata[9] };
            char[] col1 = new char[] { gamedata[1], gamedata[4], gamedata[7] };
            char[] col2 = new char[] { gamedata[2], gamedata[5], gamedata[8] };
            char[] col3 = new char[] { gamedata[3], gamedata[6], gamedata[9] };
            char[] dia1 = new char[] { gamedata[1], gamedata[5], gamedata[9] };
            char[] dia2 = new char[] { gamedata[7], gamedata[5], gamedata[3] };

            if (row1[0] == row1[1] && row1[0] == row1[2])
            {

                win = true;

            }
            if (row2[0] == row2[1] && row2[0] == row2[2])
            {
                win = true;
            }
            if (row3[0] == row3[1] && row3[0] == row3[2])
            {
                win = true;
            }
            if (col1[0] == col1[1] && col1[0] == col1[2])
            {
                win = true;
            }
            if (col2[0] == col2[1] && col2[0] == col2[2])
            {
                win = true;
            }
            if (col3[0] == col3[1] && col3[0] == col3[2])
            {
                win = true;
            }
            if (dia1[0] == dia1[1] && dia1[0] == dia1[2])
            {
                win = true;
            }
            if (dia2[0] == dia2[1] && dia2[0] == dia2[2])
            {
                win = true;
            }

            if (win == true)
            {
                Console.WriteLine(turn + " won! Congratulations");
                createfield();

            }
            else
            {
                getTurn();
            }


        }
    }

}












