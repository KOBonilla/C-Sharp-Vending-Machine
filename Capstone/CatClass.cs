﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    public class CatClass
    {
        public string ItemType { get; set; }

        public CatClass(string slotLocation, decimal price, string name, string itemType, int quantity)// : base(slotLocation, price, name, quantity)
        {
            ItemType = itemType;
        }
        //CatClass BlackCat = new CatClass(.90M, "Black Cat", Dictionary<string, int>("A", 1) itemPosition, "Cat", 5);
        //CatClass WhiteCat = new CatClass(.90M, "White Cat", Dictionary<string, int>("A", 1) itemPosition, "Cat", 5);
        //CatClass TabbyCat = new CatClass(.90M, "Tabby Cat", Dictionary<string, int>("A", 1) itemPosition, "Cat", 5);
        //CatClass CalicoCat = new CatClass(.90M, "Calico Cat", Dictionary<string, int>("A", 1) itemPosition, "Cat", 5);
    }
    
}
