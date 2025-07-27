using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahra_BalyClone_OOP1
{
    internal class Account
    {
        public String UserName;
        public String Password;
        public String Email;
        public String PhoneNumber;
        public String FullName;
        public String AccountType; // e.g., "Admin", "User", "Guest"
        public int Age; // could be in User class instead?
        public static void FogetPassword()
        {
            // Logic to handle password recovery
            Console.WriteLine("Password recovery process initiated.");
        }
    }
}
