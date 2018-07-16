using System;
using System.Collections.Generic;


namespace NewTextAdventure
{
    class Outputs
    {
       public static void HowTo()
        {
            Console.WriteLine("Welcome Stranger, This is a TextAdventure Game.");
            Console.WriteLine("Your Quest will be explained later, for now learn the commands:");
            Console.WriteLine("to look at an object or a room, type 'l object' or 'look object'. Change object to the name of the item, room or person you want to look at");
            Console.WriteLine("type 'n','e','s','w' or 'north', 'east', 'south', 'west' to go to the selected direction.");
            Console.WriteLine("type 'f' or 'fight' to fight, 'c' or 'talk' to conversate, type 'i' or 'inventory' to see your inventory,");
            Console.WriteLine("'take object' and 't object' will add an object to it and 'drop object'or 'd object' will drop an object from ypur inventory in the room");
            Console.WriteLine("by typing 'h' o 'help', you can see the possible commands again");
        }
        public static void NextMove(){
            Console.WriteLine("What do you want to do?");
            

        }
        public static void NoDirection(){
            Console.WriteLine("You can't go against a wall. Unless you aren't some kind of wizard, which you are not!");
            NextMove();
        }
        public static void Locked(){
            Console.WriteLine("This Room seems to be Locked, Find a Key!");
        }
        public static void EmptyInventory(){
            Console.WriteLine("Your Inventory is empty! search for something to collect!");
        }
        public static void ShowCommands(){
            Console.WriteLine("type 'n','e','s','w' to go north, east, south, or west. type (f) to fight, type (i) to see your inventory, (t) to add something to it or (d) to drop something in the room ");
            NextMove();
        }
        public static void GameOver(){
            Console.WriteLine("you lost - what a shame...");
        }
        public static void NobodyHere(){
            Console.WriteLine("There is nobody here...");
        }
        public static void WhatToLook(){
            Console.WriteLine("What do you want to look at? ");

        }
        public static void WhatToTake(){
            Console.WriteLine("What do you want to take ?");

        }
        public static void WhatToDrop(){
            
            Console.WriteLine("What do you want to drop ?");
            

        }
        public static void ErrorMessage(){
            Console.WriteLine("Something went wrong, try Again!");
        }
        public static void Exit(){
            Console.WriteLine("You disapper suddendly, for some reason");
        }
        
    }
}