using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureNeu
{
    class GameData
    {

        public static Room LoadGameData()
        {
            // Create Rooms

            Item key = new Item { itemName = "Key", itemDescription = "After beating the first monster, you got this Key from the Guard!", strengthPoints = 0, defensePoints = 0, isEquipped = false };
            Item armor = new Item { itemName = "Armor", itemDescription = "a strong, steel armor, gives you +80 defence points!", strengthPoints = 0, defensePoints = 80, isEquipped = false};
            Item amulet = new Item { itemName = "Amulet", itemDescription = "It's an old Amulet, can't do much... Maybe you could try to trade it?", strengthPoints = 0, defensePoints = 0, isEquipped = false, };
            Item skull1 = new Item { itemName = "GreenSkull", itemDescription = "It's the skull of the first slain monster! You did a great Job!", strengthPoints = 0, defensePoints = 0, isEquipped = false, };
            Item skull2 = new Item { itemName = "BlueSkull", itemDescription = "It's the skull of the second slain monster! You did a great Job there too!", strengthPoints = 0, defensePoints = 0, isEquipped = false, };
            Item skull3 = new Item { itemName = "RedSkull", itemDescription = "It's the skull of the last slain monster! You could get out of here soon!!", strengthPoints = 0, defensePoints = 0, isEquipped = false, };
            Item sword = new Item { itemName = "Sword", itemDescription = "There has never been an hero without a sword.It gives you +10 attack points! You got it from an old man... what a cliché!", strengthPoints = 0, defensePoints = 0, isEquipped = false, };
            Item wreckin_ball = new Item { itemName = "WreckingBall", itemDescription = "What are you supposed to do with that? it seems pretty useless against Monsters of any kind!", strengthPoints = 0, defensePoints = 0, isEquipped = false, };

            // Create Entities
            Entity monster1 = new Entity { entityName = "GreenMonster", entitiyDescription = "It's a stinky, green monster", health = 100, strength = 30, defence = 24, stillalive = true, speech1 = "*fart*.. ahahahaha" };
            Entity monster2 = new Entity { entityName = "BlueMonster", entitiyDescription = "It's a filthy, blue monster", health = 120, strength = 40, defence = 32, stillalive = true, speech1 = "*Skrreeeeeeeeech*" };
            Entity monster3 = new Entity { entityName = "RedMonster", entitiyDescription = "It's a filthy, red monster", health = 150, strength = 50, defence = 48, stillalive = true, speech1 = "you. will.. NEVER. DEFEAT. MEE!" };
            Entity guard = new Entity { entityName = "Guard", entitiyDescription = "It's a Guard!", health = 375, strength = 100, defence = 120, stillalive = true, speech1 = "Welcome to your challenge Hero! bring me 3 Monster Skulls and I will let you out of here.", speech2 = "You gave me the first Skull, Great Job! Take this Key!" };
            Entity old_man = new Entity { entityName = "OldMan", entitiyDescription = "It's an old man...", health = 375, strength = 100, defence = 120, stillalive = true, speech1 = "Hello Youngster, Bring me my Amulet and i will reward You!", speech2 = "It is Dangerous to go alone, take this!" };

            // Create Room
            Room entry = new Room { name = "Entry", isAccesible = true, isHere = true, entity = guard, description = "You are in a big Room, there are only a few candles, so you can't see much. There is a Guard, who seems to stare menacely at you... You hear a Growling sound coming from West and see some light coming from east.From North you hear slightly quieter Growl." };
            Room cell1 = new Room { name = "the first cell", isAccesible = true, isHere = false, entity = monster1, description = "You see a green, disgusting Monster, it smells horrible too! Its big claws are covered in blood! It seems to be a dead end!" };
            Room cell2 = new Room { name = "the second cell", isAccesible = true, isHere = false, entity = monster3, description = "This must be the last Monster... Get ready to fight" };
            Room room2 = new Room { name = "a dark room", isAccesible = true, isHere = false, entity = old_man, description = "It seems to be a dead End! - Next to flame you see an old man sitting on the floor. He smiles at you." };
            Room room3 = new Room { name = "the first part of a long hall", isAccesible = true, entity = null, isHere = false, description = "The echo of your steps is very strong... there are some torches on the wall but you can't see much but some metal bars with a locked door on the nort side. " };
            Room room4 = new Room { name = "the second part of a long hall", isAccesible = false, entity = monster2, isHere = false, description = $"Thanks to the Key you managed to proceed on this hall. Don't rest, another of those filthy creature has already seen you... North seems to be the only way to go to complete your quest." };
            Room room5 = new Room { name = "an intersection", isAccesible = true, isHere = false, entity = null, description = "Ok, it seems you can only go west from here. There is only a strange shiny wall on the east side." };
            Room s_room = new Room { name = "a secret Room!", isAccesible = true, isHere = false, entity = null, description = "Oh my God! who would have known! Behind that strange wall was a secret room! it looks like an armor is hanging on the wall!" };



            // Link Rooms together
            entry.west = cell1;
            entry.east = room2;
            entry.north = room3;
            cell1.east = entry;
            room2.west = entry;
            room3.south = entry;
            room3.north = room4;
            room4.south = room3;
            room4.north = room5;
            room5.south = room4;
            room5.east = s_room;
            s_room.west = room5;
            room5.west = cell2;
            cell2.east = room5;

            // Set Items in Places and Entities
            guard.Inventory.Add(key);
            monster1.Inventory.Add(amulet);
            monster1.Inventory.Add(skull1);
            monster2.Inventory.Add(skull2);
            monster3.Inventory.Add(skull3);
            old_man.Inventory.Add(sword);

            // Set Entities in Rooms
            s_room.itemsInRoom.Add(armor);
            room3.itemsInRoom.Add(wreckin_ball);




            return entry;
        }


    }
}