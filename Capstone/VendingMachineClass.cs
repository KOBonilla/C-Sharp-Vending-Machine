using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace Capstone
{
    public class VendingMachineClass
    {
        public decimal Balance { get; private set; }

        public VendingMachineClass(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public static void Run()
        {

            //CSV File data somehow

            Console.WriteLine("Welcome to the CuteCo Inc. Vendo-Matic 800! Press Enter to continue: ");
            Console.ReadLine();

            Console.WriteLine("Please select an option: ");
            Console.WriteLine("1. Display Vending Machine Items");
            Console.WriteLine("2. Purchase");
            Console.WriteLine("3. Exit");

            string input = Console.ReadLine();
            if (input == "3")
            {
                Environment.Exit(0);
            }
            else if (input == "2")
            {
                //PurchaseMenu();
            }
            else
            {
                //DisplayVendingMachineItems()
            }
        }

        public void PurchaseMenu()
        {
            Console.WriteLine("Current Money Provided is: " + Balance.ToString("0.00"));
            Console.WriteLine("1. Feed Money");
            Console.WriteLine("2. Select Product");
            Console.WriteLine("3. Finish Transaction");

            string input2 = Console.ReadLine();
            if (input2 == "1")
            {
                FeedMoney();
            }
            else if (input2 == "2")
            {
                SelectProduct();
            }
            else if (input2 == "3")
            {
                FinishTransaction();
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