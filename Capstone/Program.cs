using System;
using System.Collections.Generic;

namespace Capstone
{
    public class Program
    {
        static void Main(string[] args)
        {
            string filePath = "vendingmachine.csv";
            FileHandler fileHandler = new FileHandler();
            List<Item> vendingMachineItems = fileHandler.ReadVendingMachineData(filePath);

            Inventory inventory = new Inventory(vendingMachineItems);
            inventory.PopulateInventory();
            inventory.DisplayInventory();
        }
    }
}
