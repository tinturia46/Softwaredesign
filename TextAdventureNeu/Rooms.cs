using System;
using System.Collections.Generic;
using System.Collections;

namespace NewTextAdventure
{



    class Room
    {
        public string name;
        public string description;
        public bool isAccesible;
        public bool isHere;

        

        public Room north = null;
        public Room south = null;
        public Room east = null;
        public Room west = null;

        public Entity entity;

        public List<Item> itemsInRoom = new List<Item>();





    }


}