using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject
{
    internal class Manager : User
    {
        public List<Driver> drivers=new List<Driver>();
        public List<Customer> customers=new List<Customer>();
        public void AddDriver(Driver driver)
        {
            drivers.Add(driver);
        }
        public void AddCustoemr(Customer customer)
        {
            customers.Add(customer);
        }
        public void BlockUser(Customer customer)
        {
        }
    }
}
