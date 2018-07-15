using System;
using System.Collections.Generic;


namespace Tests
{
    class Interaction
    {
        public bool isHere;
        public static char input;
        public static Room newPlayerPosition;
        public static Room startposition;
        public static Room currentPosition;
        public static Player player;
        public static void GameStart()
        {

            startposition = GameData.LoadGameData();

            Console.WriteLine(startposition.description);
            Outputs.NextMove();
            Move(startposition);
        }

        public static void Move(Room currentPlayerPosition)
        {
            currentPosition = currentPlayerPosition;
            input = Convert.ToChar(Console.ReadLine());
            switch (input)
            {

                case 'n':

                    newPlayerPosition = Gameplay.GoNorth(currentPosition);
                    if (newPlayerPosition == null)
                    {
                        Outputs.NoDirection();
                        Move(currentPosition);
                    }
                    if (newPlayerPosition.isAccesible == false)
                    {
                        Outputs.Locked();
                        Move(currentPosition);
                    }
                    else
                    {
                        Console.WriteLine(newPlayerPosition.description);
                        Outputs.NextMove();
                        Move(newPlayerPosition);
                    }
                    break;
                case 'e':
                    newPlayerPosition = Gameplay.GoEast(currentPosition);
                    if (newPlayerPosition == null)
                    {
                        Outputs.NoDirection();
                        Move(currentPosition);
                    }
                    if (newPlayerPosition.isAccesible == false)
                    {
                        Outputs.Locked();
                        Move(currentPosition);
                    }
                    else
                    {
                        Console.WriteLine(newPlayerPosition.description);
                        Outputs.NextMove();
                        Move(newPlayerPosition);
                    }
                    break;
                case 'w':
                    newPlayerPosition = Gameplay.GoWest(currentPosition);
                    if (newPlayerPosition == null)
                    {
                        Outputs.NoDirection();
                        Move(currentPosition);
                    }
                    if (newPlayerPosition.isAccesible == false)
                    {
                        Outputs.Locked();
                        Move(currentPosition);

                    }
                    else
                    {
                        Console.WriteLine(newPlayerPosition.description);
                        Outputs.NextMove();
                        Move(newPlayerPosition);
                    }
                    break;
                case 's':
                    newPlayerPosition = Gameplay.GoSouth(currentPosition);
                    if (newPlayerPosition == null)
                    {
                        Outputs.NoDirection();
                        Move(currentPosition);
                    }
                    if (newPlayerPosition.isAccesible == false)
                    {
                        Outputs.Locked();
                        Move(currentPosition);
                    }
                    else
                    {

                        Console.WriteLine(newPlayerPosition.description);
                        Outputs.NextMove();
                        Move(newPlayerPosition);
                    }
                    break;
                case 'h':
                Outputs.ShowCommands();
                Move(currentPosition);
                
                break;

            }

        }

    }
}


