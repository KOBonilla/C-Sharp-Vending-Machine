using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    public class Item
    {
        public string SlotLocation { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }
        public int Qty { get; set; }

        public Item(string slotLocation, string name, decimal price, string type)
        {
            SlotLocation = slotLocation;
            Name = name;
            Price = price;
            Type = type;
            Qty = 5;
        }

    }
}

