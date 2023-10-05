﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    public class DuckClass : ItemsClass
    {
        public string ItemType { get; set; }

        public DuckClass(decimal price, string name, Dictionary<string, int> itemPosition, string itemType, int quantity) : base(price, name, itemPosition, quantity) 
        {
            ItemType = itemType;
        }
        DuckClass YellowDuck = new DuckClass(.90M, "Yellow Duck", itemPosition, "Duck", 5);
        DuckClass CubeDuck = new DuckClass(.90M, "Cube Duck", Dictionary<string, int>("A", 1) itemPosition, "Duck", 5);
        DuckClass BeachDuck = new DuckClass(.90M, "Beach Duck", Dictionary<string, int>("A", 1) itemPosition, "Duck", 5);
        DuckClass BatDuck = new DuckClass(.90M, "Bat Duck", Dictionary<string, int>("A", 1) itemPosition, "Duck", 5);
    }
}
