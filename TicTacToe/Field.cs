using System;

namespace TicTacToe
{
    class Play : Field
    {
        public static void play()
        {
            if (counter == 9)
            {
                draw();
                printfield();

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
                    Console.WriteLine("Player " + turn[1] + " it's your turn.");
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
                    printfield();
                    counter++;
                    checkWin();

                }
            }
            else
            {
                Console.WriteLine("Wrong Input try Again");
                getPosition(turn);
            }
        }

        public static void checkWin()
        {
            bool win = false;

            int[,] cases = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 1, 4, 7 }, { 2, 5, 8 }, { 3, 6, 9 }, { 1, 5, 9 }, { 3, 5, 7 } };


            for (int i = 0; i <= cases.Length - 1; i++)
            {

            }
        }


    }
}

}












