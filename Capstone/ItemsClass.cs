using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    public class ItemsClass
    {
        public string SlotLocation { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        //public Dictionary<string,int> ItemPosition { get; }
        public int Quantity { get; set; } = 5;

        //Dictionary<string, int> itemPosition = new Dictionary<string, int>()
        //{
        //    {"A", 1 },
        //    {"A", 2 },
        //    {"A", 3 },
        //    {"A", 4 },
        //    {"B", 1 },
        //    {"B", 2 },
        //    {"B", 3 },
        //    {"B", 4 },
        //    {"C", 1 },
        //    {"C", 2 },
        //    {"C", 3 },
        //    {"C", 4 }, Dictionary<string,int> itemPostion
        //    {"D", 1 },
        //    {"D", 2 },
        //    {"D", 3 },
        //    {"D", 4 }
        //};
        
        public ItemsClass(string slotLocation, decimal price, string name, int quantity)
        {
            SlotLocation = slotLocation;
            Price = price;
            Name = name;
            //ItemPosition = itemPostion;
            Quantity = quantity;

        }
    }
}
