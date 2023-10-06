using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    public class Inventory
    {
        private List<Item> vendingMachineItems;

        public Inventory(List<Item> items)
        {
            vendingMachineItems = items;
        }

        public void PopulateInventory()
        {
            foreach (var item in vendingMachineItems)
            {
                item.Qty = 5;
            }
        }

        public void DisplayInventory()
        {
            Console.WriteLine("Current Inventory:");
            foreach (var item in vendingMachineItems)
            {
                Console.WriteLine($"Slot: {item.SlotLocation}, Name: {item.Name}, Price: {item.Price:C}, Quantity: {item.Qty}");
            }
        }
    }
}
