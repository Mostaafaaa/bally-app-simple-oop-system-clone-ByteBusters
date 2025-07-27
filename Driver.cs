using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject
{
    internal class Driver : User
    {
        public Driver(Account acc) 
        {
            UserAcc = acc;
        }
        public double DriverRate { get; set; }
        public double Amount { get; set; }
        public bool IsAvalible { get; set; } //is he avalible to accept trip or its not working now or he is already has a trip 
        public bool AcceptTrip(Trip trip)
        {
            return true;
        }
    }
}
