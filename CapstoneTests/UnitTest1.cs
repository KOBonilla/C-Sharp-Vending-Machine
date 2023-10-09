using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;


namespace CapstoneTests
{
    [TestClass]
    public class UnitTest1
    {
        private VendingMachineClass vendingMachine;

        [TestInitialize]
        public void Initialize()
        {
            vendingMachine = new VendingMachineClass(10.00m);
        }

        [TestMethod]
        public void FeedMoney_AddsToBalance()
        {
            vendingMachine.FeedMoney();

            Assert.AreEqual(20.00m, VendingMachineClass.Balance);
        }

        [TestMethod]
        public void SelectProduct_PurchasingItemUpdatesBalance()
        {
            Item mockItem = new Item("A1", "Chips", 1.00m, "Snack", 10);

            vendingMachine.inventory = new Inventory(new List<Item> { mockItem });

            using (StringReader sr = new StringReader("A1"))
            {
                Console.SetIn(sr);
                vendingMachine.SelectProduct();
            }

            Assert.AreEqual(9.00m, VendingMachineClass.Balance);
        }

        [TestMethod]
        public void FinishTransaction_ReturnsChangeAndResetsBalance()
        {
            vendingMachine.FinishTransaction();

            Assert.AreEqual(0.00m, VendingMachineClass.Balance);
        }
    }
}
