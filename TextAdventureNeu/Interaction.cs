using System;
using System.Collections.Generic;



namespace NewTextAdventure
{
    class Interaction
    {

        public static string[] input;
        public static Room newPlayerPosition;
        public static Room startposition;
        public static Room currentPosition;
        public static Player player;

        
        public static void GameStart()
        {
            player = Gameplay.CreatePlayer();
            startposition = GameData.LoadGameData();

            Console.WriteLine(startposition.description);
            Outputs.NextMove();
            Move(startposition);
        }

        public static void Move(Room currentPlayerPosition)
        {
            currentPosition = currentPlayerPosition;
            InputSplitter();

            switch (input[0])
            {

                case "n":
                case "north":

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
                case "e":
                case "east":
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
                case "w":
                case "west":
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
                case "s":
                case "south":
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
                case "h":
                case "help":
                    Outputs.ShowCommands();
                    Move(currentPosition);
                    break;
                case "c":
                case "conversate":
                case "talk":
                    Gameplay.Conversate(currentPosition.entity, currentPosition);
                    Outputs.NextMove();
                    Move(currentPosition);
                    break;

                case "f":
                case "fight":

                    break;

                case "l":
                case "look":
                        try{
                         if (input[1] != "")
                        {
                            Gameplay.Look(player,currentPosition,input[1]);
                            Outputs.NextMove();
                            Move(currentPosition);
                        }
                        else
                        {
                            Outputs.ErrorMessage();
                            Outputs.NextMove();
                            Move(currentPosition);
                        }

                    }
                    catch
                    {
                        Outputs.ErrorMessage();
                        Move(currentPosition);
                    }



                    break;
                case "t":
                case "take":
                try{
                         if (input[1] != "")
                        {
                            Gameplay.Take(player, input[1], currentPosition);
                            Outputs.NextMove();
                            Move(currentPosition);
                        }
                        else
                        {
                            Outputs.ErrorMessage();
                            Outputs.NextMove();
                            Move(currentPosition);
                        }

                    }
                    catch
                    {
                        Outputs.ErrorMessage();
                        Move(currentPosition);
                    }



                    break;
                case "d":
                case "drop":
                    try
                    {
                        if (input[1] != "")
                        {
                            Gameplay.Drop(player, input[1], currentPosition);
                            
                            Outputs.NextMove();
                            Move(currentPosition);
                        }
                        else
                        {
                            Outputs.ErrorMessage();
                            Outputs.NextMove();
                            Move(currentPosition);
                        }

                    }
                    catch
                    {
                        Outputs.ErrorMessage();
                        Move(currentPosition);
                    }


                    break;

                case "q":
                case "quit":
                    Outputs.Exit();
                    Environment.Exit(0);
                    break;
                default:
                    Outputs.ErrorMessage();
                    Move(currentPosition);
                    break;





            }

        }
        public static Array InputSplitter()
        {
            string _fullInput = Console.ReadLine();
            input = _fullInput.Split(' ');
            return input;
        }
    }

}