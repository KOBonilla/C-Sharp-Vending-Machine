using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    public class TransactionLogClass
    {
        public void LogPurchase(string productName, decimal price)
        {
            string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - Purchased {productName} for ${price.ToString("0.00")}";
            File.AppendAllText("Log.txt", logEntry + Environment.NewLine);
        }


    }
}
