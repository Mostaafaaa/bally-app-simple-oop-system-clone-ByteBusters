using System.ComponentModel;

namespace TrainingProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            Console.WriteLine("Hi, Log In (L) / Register (R)");
            char choise = Console.ReadLine().ToUpper()[0];
            if (choise == 'L')
            {

                Console.WriteLine("Enter The Email : ");
                string email = Console.ReadLine();
                Console.WriteLine("Enter The password : ");
                string password = Console.ReadLine();
                AccountService.LogIn(email, password);
            }
            else if (choise == 'R')
            {
                Console.WriteLine("are you Driver (D) or Custoemr(C)");
                char UserType = Console.ReadLine().ToUpper()[0];
                if (UserType == 'D')
                {
                    Console.WriteLine("enter your UserName,Email,Password,Age,phoneNumeber");
                    string userName = Console.ReadLine();
                    string Email = Console.ReadLine();
                    string Password = Console.ReadLine();
                    int age = Convert.ToInt32(Console.ReadLine());
                    int PhoneNumber = Convert.ToInt32(Console.ReadLine());
                    Account a1 = new Account(userName, Email, Password, age, PhoneNumber, "Driver");
                    Driver d1 = new Driver(a1);
                    AccountService.register();//here we send the information to check validation
                    manager.AddDriver(d1);
                    
                }
                if (UserType == 'c')
                {
                    Console.WriteLine("enter your UserName,Email,Password,Age,phoneNumeber");
                    string userName = Console.ReadLine();
                    string Email = Console.ReadLine();
                    string Password = Console.ReadLine();
                    int age = Convert.ToInt32(Console.ReadLine());
                    int PhoneNumber = Convert.ToInt32(Console.ReadLine());
                    Account a2 = new Account(userName, Email, Password, age, PhoneNumber, "Customer");
                    Customer c1 = new Customer(a2);
                    AccountService.register();//here we send the information to check validation
                    manager.AddCustoemr(c1);
                }
            }

                
        
               
        }
    }
}
