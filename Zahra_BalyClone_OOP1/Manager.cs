using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahra_BalyClone_OOP1
{
    internal class Manager
    {
        public String Name;
        
        public void AddDriver(string DriverID)
        {
            Console.WriteLine($"Driver {DriverID} added successfully.");
        }

        public void RemoveDriver(string DriverID)
        {
            Console.WriteLine($"Driver {DriverID} removed successfully.");
        }

        public void ViewAllDrivers()
        {
            Console.WriteLine("Displaying all drivers.");
        }

        public void AddCar(string CarID)
        {
            Console.WriteLine($"Car {CarID} added successfully.");
        }
        public void RemoveCar(string CarID)
        {
            Console.WriteLine($"Car {CarID} removed successfully.");
        }

        public void ViewAllCars()
        {
            Console.WriteLine("Displaying all cars.");
        }

        public void AddCustomer(string CustomerID)
        {
            Console.WriteLine($"Customer {CustomerID} added successfully.");
        }
        public void RemoveCustomer(string CustomerID)
        {
            Console.WriteLine($"Customer {CustomerID} removed successfully.");
        }

        public void ViewAllCustomers()
        {
            Console.WriteLine("Displaying all customers.");
        }

        public void BlockUser(string UserID)
        {
            Console.WriteLine($"User {UserID} blocked successfully.");
        }
        public void UnblockUser(string UserID)
        {
            Console.WriteLine($"User {UserID} unblocked successfully.");
        }
        public void ViewAllBlockedUsers()
        {
            Console.WriteLine("Displaying all blocked users.");
        }


    }
}
