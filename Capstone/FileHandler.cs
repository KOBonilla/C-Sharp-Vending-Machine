using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    public class FileHandler
    {
        public List<Item> ReadVendingMachineData(string filePath)
        {
            List<Item> products = new List<Item>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 4)
                        {
                            string slotLocation = parts[0];
                            string productName = parts[1];
                            decimal price = decimal.Parse(parts[2]);
                            string type = parts[3];

                            // Create a Item instance and add it to the list
                            Item product = new Item(slotLocation, productName, price, type);
                            products.Add(product);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading vending machine data file: " + ex.Message);
            }

            return products;
        }
    }
}
