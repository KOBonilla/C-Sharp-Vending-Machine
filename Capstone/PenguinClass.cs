using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    public class PenguinClass
    {
        public string ItemType { get; set; }

        public PenguinClass(string slotLocation, decimal price, string name, string itemType, int quantity)// : base(slotLocation, price, name, quantity)
        {
            ItemType = itemType;
        }
        //PenguinClass EmperorPenguin = new PenguinClass(.90M, "Emperor Penguin", Dictionary<string, int>("A", 1) itemPosition, "Penguin", 5);
        //PenguinClass MacaroniPenguin = new PenguinClass(.90M, "Macaroni Penguin", Dictionary<string, int>("A", 1) itemPosition, "Penguin", 5);
        //PenguinClass RockhopperPenguin = new PenguinClass(.90M, "Rockhopper Penguin", Dictionary<string, int>("A", 1) itemPosition, "Penguin", 5);
        //PenguinClass GalapagosPenguin = new PenguinClass(.90M, "Galapagos Penguin", Dictionary<string, int>("A", 1) itemPosition, "Penguin", 5);
    }
}
