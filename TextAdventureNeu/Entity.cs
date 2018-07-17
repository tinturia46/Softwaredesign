using System;
using System.Collections.Generic;
using System.Collections;

namespace NewTextAdventure
{
    class Entity
    {
        public string entitiyDescription;
        public string speech1;
        public string speech2;

        public bool spokenTo = false;
        public string entityName;
        public int health;
        public int strength;
        public int defence;
        public bool stillalive;
        public List<Item> Inventory = new List<Item> { };

    }
    class Player : Entity
    {
        public Room playerPosition;
    }

}
