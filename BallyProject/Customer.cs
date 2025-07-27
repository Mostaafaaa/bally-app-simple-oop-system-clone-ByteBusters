using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject
{
    internal class Customer : User
    {
        public Customer(Account acc)
        {
            UserAcc = acc;
        }
        public double CuastomerRate { get; set; }
        public void SearchTrip()
        {
            //here we will make the customer details appear to Driver so he can accept it
        }
        public void StartTrip() 
        {
            Trip trip = new Trip();
        }
    }
}
