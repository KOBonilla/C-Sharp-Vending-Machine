using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Capstone
{
    public class VendingMachineClass
    {
        private Inventory inventory;
        public static decimal Balance { get; private set; } = 0;

        public VendingMachineClass(decimal initialBalance)
        {
            Balance = initialBalance;
        }




        public void PurchaseMenu()
        {
            while (true)
            {
          
            Console.WriteLine("Current Money Provided is: " + Balance.ToString("0.00"));
            Console.WriteLine("1. Feed Money");
            Console.WriteLine("2. Select Product");
            Console.WriteLine("3. Finish Transaction");

            string input2 = Console.ReadLine();
                switch (input2)
                {
                    case "1":
                        FeedMoney();
                        break;

                    case "2":
                        SelectProduct();
                        break;

                    case "3":
                        FinishTransaction();
                        break;

                    case "4":
                        return;

                    default:
                        Console.WriteLine("Please select an option above!");
                        break;
                }
            }
        }




        public void FeedMoney()
        {
            Console.WriteLine("Enter dollar amount: ");
            decimal amountToAdd = decimal.Parse(Console.ReadLine());
            Balance += amountToAdd;
            Console.WriteLine("Your current balance is: " + Balance.ToString("0.00"));
        }




        public void SelectProduct()
        {
            while (true)
            {
                Console.WriteLine("Available Products:");

                Inventory.ItemInfo();

                Console.Write("Enter the code of the product you want to purchase: ");
                string inputCode = Console.ReadLine().ToUpper();
                Item item = inventory.GetItemByCode(inputCode);

                if (item == null)
                {
                    Console.WriteLine("Choose from the choices above! Please try again.");
                }
                else if (item.Qty <= 0)
                {
                    Console.WriteLine("This product is sold out. Please choose another product.");
                }
                else if (Balance < item.Price)
                {
                    Console.WriteLine("Insufficient funds for this item.");
                }
                else
                {
                    Console.WriteLine($"Dispensing {item} for ${item.Price.ToString("0.00")}");

                    Balance -= item.Price;

                    switch (item.Type)
                    {
                        case "Duck":
                            Console.WriteLine("Quack, Quack, Splash!");
                            break;
                        case "Penguin":
                            Console.WriteLine("Squawk, Squawk, Whee!");
                            break;
                        case "Cat":
                            Console.WriteLine("Meow, Meow, Meow!");
                            break;
                        case "Pony":
                            Console.WriteLine("Neigh, Neigh, Yay!");
                            break;
                        default:
                            Console.WriteLine("Enjoy your purchase!");
                            break;
                    }

                    Console.WriteLine($"Your current balance is: ${Balance.ToString("0.00")}");
                }
            }
            
        }




        public void FinishTransaction()
        {
                int quarters = (int)(Balance / 0.25m);
                Balance -= quarters * 0.25m;

                int dimes = (int)(Balance / 0.10m);
                Balance -= dimes * 0.10m;

                int nickels = (int)(Balance / 0.05m);
                Balance -= nickels * 0.05m;

                Console.WriteLine("Change returned");
                Console.WriteLine("Remaining balance: " + Balance.ToString("0.00"));

                Balance = 0;

                Console.WriteLine("Thank you for using Vendo-Matic 800! Come Again!");
            Console.WriteLine("Press Enter to return to the main menu...");
            Console.ReadLine();
        }




        public void Run()
        {
            

            string filePath = "vendingmachine.csv";
            FileHandler fileHandler = new FileHandler();
            List<Item> vendingMachineItems = fileHandler.ReadVendingMachineData(filePath);

            inventory = new Inventory(vendingMachineItems);
            inventory.PopulateInventory();

            Console.WriteLine("Welcome to the CuteCo Inc. Vendo-Matic 800! Press Enter to continue: ");
            Console.ReadLine();

            Console.WriteLine("Please select an option: ");
            Console.WriteLine("1. Display Vending Machine Items");
            Console.WriteLine("2. Purchase");
            Console.WriteLine("3. Exit");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1": 
                    Inventory.DisplayInventory();
                    break;

                case "2": 
                    PurchaseMenu();
                    break;

                case "3": 
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
//string vendingMachineName = @" 
// _    __               ___                __  ___           __    _          
//| |  / /__  ____  ____/ (_)___  ____ _   /  |/  /___ ______/ /_  (_)___  ___ 
//| | / / _ \/ __ \/ __  / / __ \/ __ `/  / /|_/ / __ `/ ___/ __ \/ / __ \/ _ \
//| |/ /  __/ / / / /_/ / / / / / /_/ /  / /  / / /_/ / /__/ / / / / / / /  __/
//|___/\___/_/ /_/\__,_/_/_/ /_/\__, /  /_/  /_/\__,_/\___/_/ /_/_/_/ /_/\___/ 
//                             /____/                                          

//";