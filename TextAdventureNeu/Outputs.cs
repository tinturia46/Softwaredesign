using System;
using System.Collections.Generic;


namespace Tests
{
    class Outputs
    {
       public static void HowTo()
        {
            Console.WriteLine("Welcome Stranger, This is a TextAdventure Game.");
            Console.WriteLine("Your Quest will be explained later, for now learn the commands:");
            Console.WriteLine("type (l) to look at your sorroundings or at your items, a description of them will appear on screen");
            Console.WriteLine("type (n),(e),(s),(w) to go north, east, south, or west");
            Console.WriteLine("type (f) to fight, type (i) to see your inventory, (t)<item> to add something to it or (d)<item> to drop something in the room");
            Console.WriteLine("by typing the(h) Key, you will see the possible commands");
        }
        public static void NextMove(){
            Console.WriteLine("what do you want to do?");
            

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
            Console.WriteLine("type (n),(e),(s),(w) to go north, east, south, or west. type (f) to fight, type (i) to see your inventory, (t)<item> to add something to it or (d)<item> to drop something in the room ");
            NextMove();
        }
    }
}