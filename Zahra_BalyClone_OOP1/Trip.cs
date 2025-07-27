using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahra_BalyClone_OOP1
{
    internal class Trip
    {
        public string InitialPoint;
        public string EndPoint;
        public double Price;
        public string time;
        public string TripType;

        public void Rate(int stars)
        {
           Console.WriteLine($"Trip rated with {stars} stars.");
        }

        public double Discount(double percentage)
        {
            return Price *= percentage;
        }

        public double CalculatePrice(double Price, double distance, double Time)
        {
            return Price + (distance * Time);
        }
    }
}
