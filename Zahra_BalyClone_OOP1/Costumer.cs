using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahra_BalyClone_OOP1
{
    internal class Costumer: User
    {
        public string CostumerRate { get; set; }
        public string CostumerType { get; set; } // e.g., "Regular", "VIP", "Corporate"


        public void BookRide(string RideID)
        {
            Console.WriteLine($"{Name} Ride {RideID} booked successfully.");
        }
        public void CancelRide(string RideID)
        {
            Console.WriteLine($"Ride {RideID} cancelled successfully.");
        }
        public void ViewRideHistory(string CostumerID)
        {
            Console.WriteLine($"Displaying ride history for customer {CostumerID}.");
        }
        public void RateDriver(string DriverID, string Rating)
        {
            Console.WriteLine($"Driver {DriverID} rated with {Rating} stars.");
        }
        public void ViewDriverDetails(string DriverID)
        {
            Console.WriteLine($"Displaying details for driver {DriverID}.");
        }
        public void ViewCarDetails(string CarID)
        {
            Console.WriteLine($"Displaying details for car {CarID}.");
        }
        public void EndTrip()
        {
            Console.WriteLine("Trip ended successfully.");
        }
        public void StartTrip()
        {
            Console.WriteLine("Trip started successfully.");
        }
    }
}
