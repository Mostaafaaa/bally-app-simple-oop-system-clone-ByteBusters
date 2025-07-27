using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahra_BalyClone_OOP1
{
    internal class Driver
    {
        public string DriverID;
        public string DriverName;
        public string DriverLicenseNumber;
        public string DriverPhoneNumber;
        public string DriverRating; // e.g., "5 stars", "4.5 stars"
        public string DriverStatus; // e.g., "Available", "Busy", "Offline"
        public string DriverVehicle; // Vehicle ID or name associated with the driver
        public string Amount;    


        public void AcceptTrip()
        {
            Console.WriteLine("Trip accepted.");
        }

    }
}
