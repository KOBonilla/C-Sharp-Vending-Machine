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
        public decimal Price { get; set; }
        public string Name { get; set; }
        public Dictionary<string,int> ItemPosition { get; }
        public bool IsSoldOut { get; set; } = false;
        public int Quantity { get; set; } = 5;

        Dictionary<string, int> itemPosition = new Dictionary<string, int>()
        {
            {"A", 1 },
            {"A", 2 },
            {"A", 3 },
            {"A", 4 },
            {"B", 1 },
            {"B", 2 },
            {"B", 3 },
            {"B", 4 },
            {"C", 1 },
            {"C", 2 },
            {"C", 3 },
            {"C", 4 },
            {"D", 1 },
            {"D", 2 },
            {"D", 3 },
            {"D", 4 }
        };
        
        public ItemsClass(decimal price, string name, Dictionary<string,int> itemPostion, int quantity)
        {
            Price = price;
            Name = name;
            ItemPosition = itemPostion;
            Quantity = quantity;

        }
        

    }
    //public ItemsClass item1 = new ItemsClass()
    


}
