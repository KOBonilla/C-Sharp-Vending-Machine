using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    internal class PonyClass : ItemsClass
    {
        public string ItemType { get; set; }

        public PonyClass(string slotLocation, decimal price, string name, string itemType, int quantity) : base(slotLocation, price, name, quantity)
        {
            ItemType = itemType;
        }
        //PonyClass UnicornPony = new PonyClass(.90M, "Unicorn Pony", Dictionary<string, int>("A", 1) itemPosition, "Pony", 5);
        //PonyClass PegasusPony = new PonyClass(.90M, "Pegasus Pony", Dictionary<string, int>("A", 1) itemPosition, "Pony", 5);
        //PonyClass Horse = new PonyClass(.90M, "Horse", Dictionary<string, int>("A", 1) itemPosition, "Pony", 5);
        //PonyClass RainbowHorse = new PonyClass(.90M, "Rainbow Horse", Dictionary<string, int>("A", 1) itemPosition, "Pony", 5);
    }
}
