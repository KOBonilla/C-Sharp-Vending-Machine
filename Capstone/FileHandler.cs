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
            List<Item> items = new List<Item>();

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
                            string Name = parts[1];
                            decimal price = decimal.Parse(parts[2]);
                            string type = parts[3];

                            Item item = new Item(slotLocation, Name, price, type);
                            items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading vending machine data file: " + ex.Message);
            }

            return items;
        }
    }
}
