using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NewTextAdventure
{
    class Gameplay : GameData
    {
        public static Player CreatePlayer()
        {
            Player player = new Player { entityName = "you", health = 150, strength = 40, defence = 40, stillalive = true, };
            Item key = new Item { itemName = "key", itemDescription = "It's a key ..." };
            Room entry = LoadGameData();
            player.playerPosition = entry;
            player.Inventory.Add(key);

            return player;
        }
        public static Room GoEast(Room currentroom)
        {
            Room newCurrentRoom = currentroom.east;
            return newCurrentRoom;
        }
        public static Room GoWest(Room currentroom)
        {
            Room newCurrentRoom = currentroom.west;
            return newCurrentRoom;
        }
        public static Room GoSouth(Room currentroom)
        {
            Room newCurrentRoom = currentroom.south;
            return newCurrentRoom;
        }
        public static Room GoNorth(Room currentroom)
        {
            Room newCurrentRoom = currentroom.north;
            return newCurrentRoom;
        }


        public static void Look(Entity player, Room currentroom, string input)
        {
            Item itemInRoom = currentroom.itemsInRoom.Find(x => x.itemName.Equals(input));
            Item iteminInventory = player.Inventory.Find(x => x.itemName.Equals(input));

            if (input.Equals(iteminInventory))
            {
                Console.WriteLine(iteminInventory.itemDescription);
            }
            if (input.Equals(itemInRoom))
            {
                Console.WriteLine(itemInRoom.itemDescription);
            }
            if (input.Equals(currentroom.entity.entityName))
            {
                Console.WriteLine(currentroom.entity.entitiyDescription);
            }
            if (input.Equals(currentroom.name))
            {
                Console.WriteLine(currentroom.description);
            }

        }
        public static void Take(Entity taker, string item, Room currentroom)
        {
            Item toTake = currentroom.itemsInRoom.Find(x => x.itemName.Equals(item));
            currentroom.itemsInRoom.Remove(toTake);
            taker.Inventory.Add(toTake);

            Console.WriteLine("you took " + item + " from " + currentroom.name + "!");
        }
        public static void Drop(Entity dropper, string item, Room currentroom)
        {
            Item toDrop = dropper.Inventory.Find(x => x.itemName.Equals(item));
            dropper.Inventory.Remove(toDrop);
            currentroom.itemsInRoom.Add(toDrop);

            Console.WriteLine(dropper.entityName + " dropped " + item + " in " + currentroom.name + "!");
        }
        public static void Conversate(Entity talker, Room currentroom)
        {
            talker = currentroom.entity;
            if (talker == null)
            {
                Outputs.NobodyHere();
            }
            if (talker.spokenTo == false)
            {
                Console.WriteLine(talker.entityName + ": " + talker.speech1);
            }
            else
            {
                Console.WriteLine(talker.entityName + ": " + talker.speech2);
            }


        }
        public static void DropItems(Room room)
        {
            Entity entity = room.entity;




        }
        public static void Fight(Player hero, Entity foe)
        {
            if (hero.health >= 0)
            {
                Console.WriteLine("you attack " + foe.entityName + "!");
                foe.health = AttackFoe(hero, foe);

                if (foe.health >= 0)
                {
                    Console.WriteLine(foe.entityName + " still has " + foe.health + " health points remaining!");
                    Console.WriteLine(foe.entityName + " is attacking you");
                    hero.health = AttackHero(hero, foe);
                    Console.WriteLine("You have " + hero.health + " health points remaining!");
                    Fight(hero, foe);
                }
                else
                {
                    foe.health = 0;
                    Console.WriteLine(foe.entityName + " has " + foe.health + " health points remaining!");
                    Console.WriteLine("you defeated " + foe.entityName + "Good Job!");
                    Outputs.NextMove();
                }
            }
            else
            {

                Outputs.GameOver();
            }

        }
        public static int AttackFoe(Player hero, Entity foe)
        {

            int newFoeHealth = (foe.health - (hero.strength - (foe.defence / 4)));
            return newFoeHealth;

        }
        public static int AttackHero(Player hero, Entity foe)
        {

            int newHeroHealth = (hero.health - (foe.strength - (hero.defence / 4)));
            return newHeroHealth;

        }




    }


}