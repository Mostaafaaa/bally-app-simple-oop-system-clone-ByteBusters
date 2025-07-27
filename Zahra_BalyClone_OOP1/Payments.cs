using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahra_BalyClone_OOP1
{
    internal class Payments
    {
        public string PaymentID;
        public string CostumerID;
        public string CurrencyID;
        public int PaymentMethod; // e.g., "Credit Card", "PayPal", "Cash"

        public void ChoosePaymentMethod()
        {
            Console.WriteLine("How do you want to pay? (1 for Credit Card, 2 for PayPal, 3 for Cash)");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You have chosen Credit Card.");
                    PaymentMethod = 1; // Credit Card
                    break;
                case 2:
                    Console.WriteLine("You have chosen PayPal.");
                    PaymentMethod = 2; // PayPal
                    break;
                case 3:
                    Console.WriteLine("You have chosen Cash.");
                    PaymentMethod = 3; // Cash
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    ChoosePaymentMethod();
                    break;
            }
        }
        public void ProcessPayment(string CostumerID, double Amount)
        {
            Console.WriteLine($"Processing payment of {Amount} for customer {CostumerID}.");
        }
        public void ViewPaymentHistory(string CostumerID)
        {
            Console.WriteLine($"Displaying payment history for customer {CostumerID}.");
        }
        public void ApplyDiscount(string CostumerID, double DiscountAmount)
        {
            Console.WriteLine($"Applying discount of {DiscountAmount} to customer {CostumerID}.");
        }
    }
}
