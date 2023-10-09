using Capstone;
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
            // Arrange
            decimal initialBalance = 10.00m; // Starting balance
            decimal amountToAdd = 5.00m; // Amount to add
            VendingMachineClass vendingMachine = new VendingMachineClass(initialBalance);

            // Act
            vendingMachine.FeedMoney(amountToAdd);

            // Assert
            decimal expectedBalance = initialBalance + amountToAdd;
            Assert.AreEqual(expectedBalance, VendingMachineClass.Balance);
        }

        [TestMethod]
        public void SelectProduct_PurchasingItemUpdatesBalance()
        {
            Item mockItem = new Item("A1", "Chips", 1.00m, "Snack");

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
