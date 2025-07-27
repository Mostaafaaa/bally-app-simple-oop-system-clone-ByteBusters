using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahra_BalyClone_OOP1
{
    internal class FinanceManager: Trip
    {
        public double totalAmount = 0.0;
        public void CalculateAmount()
        {

            // Calculate total amount from trips
            totalAmount += Price;

            Console.WriteLine($"Total Amount: {totalAmount}");
        }
    }
}
