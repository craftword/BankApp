using System;
using Helpers;


namespace Customers
{
    public class Customer
    {
        private string accountNumber;
        protected string accountType;

        //properties
        public static string AccountNumber
        {
            get
            {
                return DateTime.UtcNow.Ticks.ToString().Substring(8);
            }

        }

        public string AccountType
        {
            get { return accountType; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Please enter");
                accountType = value;
            }
        }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public static string CreatedAt {
            get
            {
                return DateTime.Now.ToString("h:mm:ss tt");
            }
        }


        

        public void CreateUser(object Model)
        {
            Console.WriteLine("Enter customer Full Name");
            this.FullName = Console.ReadLine();
            Console.WriteLine("Enter customer Email");
            this.EmailAddress = Console.ReadLine();

            Console.WriteLine("Enter customer Mobile Number");
            this.MobileNumber = Console.ReadLine();

            Console.WriteLine("Enter Customer Account Type");
            this.AccountType = Console.ReadLine();
            
           //ReadWriteHelper.WriteJson(Model, this.AccountNumber);



        }

        public object AllUser(string customerNO)
        {
            return ReadWriteHelper.ReadJson(customerNO);


        }



    }
}
