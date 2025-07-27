using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahra_BalyClone_OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Costumer Mohammed = new Costumer();
            //Costumer Ali = new Costumer();
            Costumer Zetta = new Costumer();
             
            //Mohammed.Name = "Mohammed";
            //Ali.Name = "Ali";
            Zetta.Name = "Zetta";

            //Mohammed.BookRide("Ride123");
            //Ali.BookRide("Ride456");
            Zetta.BookRide("Ride789");
            Zetta.StartTrip();
            Zetta.Rate(5);
            Zetta.EndTrip();
        }
    }
}