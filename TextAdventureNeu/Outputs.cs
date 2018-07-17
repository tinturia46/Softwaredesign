using System;
using System.Collections.Generic;


namespace TextAdventureNeu
{
    class Outputs
    {
        public static void HowTo()
        {
            Console.WriteLine("Welcome Stranger, This is a TextAdventure Game.");
            Console.WriteLine("Your Quest will be explained later, for now learn the commands:");
            ShowCommands();
            
        }
        public static void NextMove()
        {
            Console.WriteLine("What do you want to do?");
        }
        public static void NoDirection()
        {
            Console.WriteLine("You can't go against a wall. Unless you aren't some kind of wizard, which you are not!");
           
        }
        public static void Locked(Room room)
        {
            if(room.name=="the second part of a long hall"){
            Console.WriteLine("This Room seems to be Locked, Find a Key!");
        }if(room.name=="a secret Room!"){
            Console.WriteLine("You can't go against a wall. Even if they're shiny!");
        }else{

        }
        }

        public static void EmptyInventory()
        {
            Console.WriteLine("Your Inventory is empty! search for something to collect!");
        }
        public static void ShowCommands()
        {
            Console.WriteLine("to look at an object or a room, type 'l object' or 'look object'. Change object to the name of the item, room or person you want to look at");
            Console.WriteLine("type 'n','e','s','w' or 'north', 'east', 'south', 'west' to go to the selected direction.");
            Console.WriteLine("type 'f' or 'fight' to fight, 'c' or 'talk' to conversate with the nearest Entity, type 'i' or 'inventory' to see your inventory,");
            Console.WriteLine("'take object' and 't object' will add an object to it and 'drop object'or 'd object' will drop an object from ypur inventory in the room");
            Console.WriteLine("'give object' and 'g object' will give an object to the nearest entity");
            Console.WriteLine("by typing 'h' o 'help', you can see the possible commands again");
            
        }
        public static void GameOver()
        {
            Console.WriteLine("you lost - what a shame...");
        }
        public static void NobodyHere()
        {
            Console.WriteLine("There is nobody here...");
        }

        public static void ErrorMessage()
        {
            Console.WriteLine("Something went wrong, try Again!");
        }
        public static void Exit()
        {
            Console.WriteLine("You disappered suddendly, for some reason");
        }

        public static void NothingToTake()
        {
            Console.WriteLine("There is nothing to take from here");
        }
        public static void GameWon()
        {
            Console.WriteLine("Guard: You Did it! you brought me 3 Skulls, now you can go back where you came from!");
            Console.WriteLine("The Guard locked you a dark, gross, cell");
        }
        public static void Line(){
            Console.WriteLine("____________________");
        }
    }
}