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
                if (gamedata[input - 1] == 'x' || gamedata[input - 1] == 'o')
                {
                    Console.WriteLine("Position already taken, try again!");
                    getPosition(turn);
                }
                else
                {
                    gamedata[input - 1] = turn;
                    printfield();
                    checkWin(turn);
                    counter++;


                }
            }
            else
            {
                Console.WriteLine("Wrong Input try Again");
                getPosition(turn);
            }
        }

        public static bool checkWin(char turn)
        {
            bool win = false;
            {
                int[,] cases = new int[,] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, { 0, 4, 8 }, { 2, 4, 6 } };

                for (int i = 0; i < gamedata.Length - 1; i++)
                {
                    if (gamedata[cases[i, 0]] == turn && gamedata[cases[i, 1]] == turn && gamedata[cases[i, 2]] == turn)
                    {
                        win = true;
                    }
                }

                if (win == true)
                {
                    
                    won(turn);
                    
                }
                else
                {
                    counter++;
                    play();
                }
                return false;





            }


        }
    }

}












