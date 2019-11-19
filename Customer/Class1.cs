using System;

namespace Customers
{
    public class Customer
    {
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }       

        public int Id { get; set; }

        private static int m_Counter = 0;

        public Customer()
        {
            this.Id = System.Threading.Interlocked.Increment(ref m_Counter);
        }
        public void CreateUser ()
        {
            Console.WriteLine("Enter customer Full Name");
             this.FullName = Console.ReadLine();
            Console.WriteLine("Enter customer Email");
            this.EmailAddress = Console.ReadLine();

            Console.WriteLine("Enter customer Mobile Number");
            this.MobileNumber = Console.ReadLine();

        }
    }
}
