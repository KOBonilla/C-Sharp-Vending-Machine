using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    public class VendingMachineClass
    {
        public void Run()
        {
            Console.WriteLine("Welcome to the CuteCo Inc. Vendo-Matic 800! Press any Key to continue: ");
            Console.ReadLine();

            Console.WriteLine("Please select an option: ");
            Console.WriteLine("1. Display Vending Machine Items");
            Console.WriteLine("2. Purchase");
            Console.WriteLine("3. Exit");
            Console.ReadLine();
        }
        public int PurchaseMenu();
        public decimal FeedMoney();
        public void SelectProduct();
        public void FinishTransaction();
        public void CashBalance();
        public void DispenseChange();
    }

}
