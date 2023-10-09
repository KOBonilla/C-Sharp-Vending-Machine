using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Capstone
{
    public class VendingMachineClass
    {
        public Inventory inventory;

        // Initialized transactionLog
        private TransactionLogClass transactionLog = new TransactionLogClass();

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
            Console.WriteLine("4. Main Menu");

                string input2 = Console.ReadLine();
                switch (input2)
                {
                    case "1":
                        MainMenuClass.ClearScreen();
                        FeedMoney();
                        break;

                    case "2":
                        MainMenuClass.ClearScreen();
                        SelectProduct();
                        break;

                    case "3":
                        MainMenuClass.ClearScreen();
                        FinishTransaction();
                        break;

                    case "4":
                        MainMenuClass.ClearScreen();
                        Run();
                        return;

                    default:
                        MainMenuClass.ClearScreen();
                        Console.WriteLine("Invalid input. Try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }




        public void FeedMoney()
        {
            MainMenuClass.ClearScreen();
            Console.WriteLine("Enter dollar amount: ");
            decimal amountToAdd = decimal.Parse(Console.ReadLine());
            Balance += amountToAdd;

            // Added LogFeedingMoney Method to FeedMoney
            transactionLog.LogFeedingMoney(amountToAdd, Balance);

            Console.WriteLine("Your current balance is: " + Balance.ToString("0.00"));
        }




        public void SelectProduct()
        {
            while (true)
            {
                Console.WriteLine("Available Products:");

                inventory.ItemInfo();

                Console.WriteLine("Enter the code of the product you want to purchase: ");
                Console.WriteLine("Press Enter to return To purchase menu.");
                string inputCode = Console.ReadLine().ToUpper();
                Item item = inventory.GetItemByCode(inputCode);

                if (item == null)
                {
                    MainMenuClass.ClearScreen();
                    return;
                }
                else if (item.Qty <= 0)
                {
                    MainMenuClass.ClearScreen();
                    Console.WriteLine("This product is sold out. Please choose another product.");
                }
                else if (Balance < item.Price)
                {
                    MainMenuClass.ClearScreen();
                    Console.WriteLine("Insufficient funds for this item.");
                }
                else
                {
                    MainMenuClass.ClearScreen();
                    Console.WriteLine($"Dispensing {item.Name} for ${item.Price.ToString("0.00")}");

                    Balance -= item.Price;
                    item.Qty -= 1;

                    // Added LogPurchase Method to SelectProduct
                    transactionLog.LogPurchase(item.Name, item.Price, Balance, item.SlotLocation);

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
            Change();

            // Added LogFinishTransaction Method to FinishTransaction
            transactionLog.LogFinishTransaction(Balance);

            decimal quarters = (Balance / 0.25m);
            Balance -= quarters * 0.25m;

            decimal dimes = (Balance / 0.10m);
            Balance -= dimes * 0.10m;

            decimal nickels = (Balance / 0.05m);
            Balance -= nickels * 0.05m;

            Console.WriteLine("Change returned");
            Console.WriteLine("Remaining balance: " + Balance.ToString("0.00"));

            Balance = 0;

            Console.WriteLine("Thank you for using Vendo-Matic 800! Come Again!");
            Console.WriteLine("Press Enter to return to the main menu...");
            Console.ReadLine();
        }

        public void Change()
        {
            decimal quarters = 0.25M;
            decimal dimes = 0.10M;
            decimal nickles = 0.05M;


            int quartersChange = Convert.ToInt32(Math.Floor(Balance / quarters));
            decimal remainingBalance = Balance - (quarters * quartersChange);
            int dimesChange = Convert.ToInt32(Math.Floor(remainingBalance / dimes));
            remainingBalance = remainingBalance - (dimes * dimesChange);
            int nicklesChange = Convert.ToInt32(Math.Floor(remainingBalance / nickles));

            Console.WriteLine($"Change: {Balance}");
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Quarters: {quartersChange}");
            Console.WriteLine($"Dimes: {dimesChange}");
            Console.WriteLine($"Nickles: {nicklesChange}");
            Console.WriteLine("-----------------------------");
        }

        public void Run()
        {
            string vendingMachineName = @" 
             _    __               ___                __  ___           __    _          
            | |  / /__  ____  ____/ (_)___  ____ _   /  |/  /___ ______/ /_  (_)___  ___ 
            | | / / _ \/ __ \/ __  / / __ \/ __ `/  / /|_/ / __ `/ ___/ __ \/ / __ \/ _ \
            | |/ /  __/ / / / /_/ / / / / / /_/ /  / /  / / /_/ / /__/ / / / / / / /  __/
            |___/\___/_/ /_/\__,_/_/_/ /_/\__, /  /_/  /_/\__,_/\___/_/ /_/_/_/ /_/\___/ 
                                         /____/                                          

            ";
            Console.WriteLine(vendingMachineName);
            string filePath = "vendingmachine.csv";
            FileHandler fileHandler = new FileHandler();
            List<Item> vendingMachineItems = fileHandler.ReadVendingMachineData(filePath);

            inventory = new Inventory(vendingMachineItems);
            inventory.PopulateInventory();

            Console.WriteLine("Welcome to the CuteCo Inc. Vendo-Matic 800! Press Enter to continue: ");
            Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Please select an option: ");
                Console.WriteLine("1. Display Vending Machine Items");
                Console.WriteLine("2. Purchase");
                Console.WriteLine("3. Exit");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        MainMenuClass.ClearScreen();
                        inventory.DisplayInventory();
                        Console.WriteLine("Press a key to continue.");
                        Console.ReadKey();
                        MainMenuClass.ClearScreen();
                        break;

                    case "2":
                        MainMenuClass.ClearScreen();
                        PurchaseMenu();
                        break;

                    case "3":
                        MainMenuClass.ClearScreen();
                        Environment.Exit(0);
                        break;
                    default:
                        MainMenuClass.ClearScreen();
                        Console.WriteLine("Invalid input. Try again.");
                        break;

                }
            }
        }
    }
}
