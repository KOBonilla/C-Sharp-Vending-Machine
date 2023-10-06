using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    public class Inventory
    {
        public static List<Item> vendingMachineItems;

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
        public Item GetItemByCode(string code)
        {
            foreach (var item in vendingMachineItems)
            {
                if (code.Equals(item.SlotLocation))
                {
                    return item;
                }

            }
            return null;
        }
        public void DisplayInventory()
        {
            Console.WriteLine("Current Inventory:");
            foreach (var item in vendingMachineItems)
            {
                Console.WriteLine($"Slot: {item.SlotLocation}, Name: {item.Name}, Price: {item.Price:C}, Quantity: {item.Qty}");
            }
        }
        
        public void ItemInfo()
        {
            foreach (var item in vendingMachineItems)
            {
                    Console.WriteLine($"Slot: {item.SlotLocation}, Name: {item.Name}, Price: {item.Price:C}");
            }
        }














        //public static void SelectProduct()
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("Available Products:");

        //        Inventory.ItemInfo();

        //        Console.Write("Enter the code of the product you want to purchase: ");
        //        string inputCode = Console.ReadLine().ToUpper();


        //        if (inputCode == null)
        //        {
        //            Console.WriteLine("Choose from the choices above! Please try again.");
        //        }
        //        else if (Item.Qty <= 0)
        //        {
        //            Console.WriteLine("This product is sold out. Please choose another product.");
        //        }
        //        else if (Balance < Item.Price)
        //        {
        //            Console.WriteLine("Insufficient funds for this item.");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"Dispensing {item} for ${Item.Price.ToString("0.00")}");

        //            Balance -= Item.Price;

        //            switch (Item.Type)
        //            {
        //                case "Duck":
        //                    Console.WriteLine("Quack, Quack, Splash!");
        //                    break;
        //                case "Penguin":
        //                    Console.WriteLine("Squawk, Squawk, Whee!");
        //                    break;
        //                case "Cat":
        //                    Console.WriteLine("Meow, Meow, Meow!");
        //                    break;
        //                case "Pony":
        //                    Console.WriteLine("Neigh, Neigh, Yay!");
        //                    break;
        //                default:
        //                    Console.WriteLine("Enjoy your purchase!");
        //                    break;
        //            }

        //            Console.WriteLine($"Your current balance is: ${Balance.ToString("0.00")}");
        //        }
        //    }

        //}
        //Dictionary<string, string> slots = new Dictionary<string, string>()
        //{
        //    { "A1", "Yellow Duck"},
        //    { "A2", "Cube Duck"},
        //    { "A3", "Beach Duck"},
        //    { "A4", "Bat Duck"},
        //    { "B1", "Emperor Penguin"},
        //    { "B2", "Macaroni Penguin"},
        //    { "B3", "Rockhopper Penguin"},
        //    { "B4", "Galapagos Penguin"},
        //    { "C1", "Black Cat"},
        //    { "C2", "White Cat"},
        //    { "C3", "Tabby Cat"},
        //    { "C4", "Calico Cat"},
        //    { "D1", "Unicorn Pony"},
        //    { "D2", "Pegasus Pony"},
        //    { "D3", "Horse"},
        //    { "D4", "Rainbow Horse"},
        //};
    }
}
