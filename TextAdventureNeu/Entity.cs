using System;
using System.Collections.Generic;
using System.Collections;

namespace Tests
{
    class Entity
    {
        public string entityName;
        public int health;
        public int strength;
        public int defence;
        public bool stillalive;
        public List<Item> Inventory = new List<Item> {};
        
    }
    class Player: Entity{
        public Room playerPosition;
    }

}