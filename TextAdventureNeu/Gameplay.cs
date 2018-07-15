using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Tests
{
    class Gameplay : GameData
    {
        public static Player CreatePlayer()
        {
            Player player = new Player { entityName = "hero", health = 150, strength = 40, defence = 40, stillalive = true, };
            Room entry = LoadGameData();
            player.playerPosition = entry;

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
        public static void Fight(Player hero, Room currentroom)
        {
            Entity foe;
            foe = currentroom.entity;

            StartFight(hero, foe);



        }
        public static void StartFight(Entity hero, Entity foe)
        {
        
            string foeName;
            int foeUpdateHealth;
            int foeHealth;
            int foeStrength;
            int foeDefence;
            int foeHealthDifference;

            int heroUpdateHealth;
            int herohealth;
            int heroStrength;
            int heroDefence;
            foeHealth = foe.health;
            foeStrength = foe.strength;
            foeDefence = foe.defence;
            foeName = foe.entityName;

            herohealth = hero.health;
            heroStrength = hero.strength;
            heroDefence = hero.defence;
            Console.WriteLine("It's you against "+ foeName+" Let the battle Begin! - You Start");
            
            
            foeUpdateHealth = (foeHealth - heroStrength-(foeDefence/4));
            
            foeHealthDifference = foeHealth - foeUpdateHealth ;

            }


        }

    }
}

