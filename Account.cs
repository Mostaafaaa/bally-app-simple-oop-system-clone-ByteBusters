using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject
{
    internal class Account
    {
        public Account(string username, string email, string password, int age,int phonenumber,string accountType)
        {
            UserName = username;
            Email = email;
            Password = password;
            Age = age;
            PhoneNumber = phonenumber;
            AccountType = accountType;
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string AccountType { get; set; }
        public void ForgetPassWord()
        {

        }
        
    }
}
