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
        // Added balance and slotLocation to LogPurchase, and tweaked the format
        public void LogPurchase(string name, decimal price, decimal balance, string slotLocation)
        {
            string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss tt} - {name} {slotLocation} ${price.ToString("0.00")} ${balance.ToString("0.00")}";
            File.AppendAllText("Log.txt", logEntry + Environment.NewLine);
        }
        // Added Transaction log for Feeding Money
        public void LogFeedingMoney(decimal amount, decimal balance)
        {
            string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss tt} - FEED MONEY: ${amount.ToString("0.00")} ${balance.ToString("0.00")}";
            File.AppendAllText("Log.txt", logEntry + Environment.NewLine);
        }
        // Added Transaxtion log for Finishing Transacton
        public void LogFinishTransaction(decimal change)
        {
            string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss tt} - GIVE CHANGE: ${change.ToString("0.00")} $0.00";
            File.AppendAllText("Log.txt", logEntry + Environment.NewLine);
        }
    }
}
