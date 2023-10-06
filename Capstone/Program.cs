using System;
using System.Collections.Generic;

namespace Capstone
{
    public class Program
    {
        static void Main(string[] args)
        {
            VendingMachineClass vendingMachineClass = new VendingMachineClass(0);
            vendingMachineClass.Run();
        }
    }
}
