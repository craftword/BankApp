using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users;
using Customers;
using Accounts;
using Helpers;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;



namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Customer person = new Customer();
            
            User user = new User();
            Account acc = new Account();
            Customer person = new Customer();

           var records =  person.AllUser("customer");
            
            
            //Entry point for both customer and admins

            //Console.WriteLine("Please Enter Account Number: ");
            //string accNo = Console.ReadLine();

            //if (accNo == "Admin0001")
            //{

            //    Console.WriteLine("Please enter your passord");
            //    string pwd = Console.ReadLine();
            //    Console.WriteLine(UserHelper.CheckPassord(pwd, user.Password));
            //    if (UserHelper.CheckPassord(pwd, user.Password))
            //    {
            //        Console.WriteLine("Hello Admin");



            //        while (true)
            //        {
            //            Console.WriteLine("Choose an Option");
            //            Console.WriteLine("______________________");
            //            Console.WriteLine("1. Create Customer");
            //            Console.WriteLine("2. View All Customer");
            //            Console.WriteLine("3. Terminate App");
            //            Console.WriteLine("_____________________");

            //            string option = Console.ReadLine();
            //            Console.WriteLine(option);

            //            if (option == "1")
            //            {
            //                person.CreateUser(person);
            //                //person.CreateUser(person, "customer");
            //            }
            //            else if (option == "2")
            //            {
            //                var obj = JObject.Parse(person.AllUser("customer"));
                            
            //            }
            //            else
            //            {
            //                break;
            //            }


            //        }




            //    }
            //    else
            //    {
            //        Console.WriteLine("Incorrect password");
            //    }

            //}
            //else
            //{
            //    try
            //    {
            //        JObject customer = JObject.Parse(person.AllUser(accNo));
            //        Console.WriteLine("Hello {0}", customer["FullName"]);

            //        while (true)
            //        {
            //            Console.WriteLine("Choose an Option");
            //            Console.WriteLine("______________________");
            //            Console.WriteLine("1. Check Balance");
            //            Console.WriteLine("2. Deposit Money");
            //            Console.WriteLine("3. Withdraw Money");
            //            Console.WriteLine("3. Transfer Money");
            //            Console.WriteLine("4. Terminate ");
            //            Console.WriteLine("______________________");

            //            string option = Console.ReadLine();
            //            Console.WriteLine(option);

            //           if(option == "1")
            //            {
            //                Console.WriteLine("Your Account Balance is: {0}", acc.Balance());
            //            }
            //           else if(option == "2")
            //            {
            //                Console.WriteLine("Enter the amount");
            //                double amt = Convert.ToDouble(Console.ReadLine());
            //                acc.DepositBalance(amt);
            //                Console.WriteLine("Successfull Deposite");

            //            }
            //            else if (option == "3")
            //            {
            //                Console.WriteLine("Enter the amount");
            //                double amt = Convert.ToDouble(Console.ReadLine());
            //                acc.WithBalance(amt, customer["AccountType"].ToString());
            //            }
            //           else
            //            {
            //                break;
            //            }


            //        }

            //    }
            //    // Most specific:
            //    catch (FileNotFoundException e)
            //    {
            //        Console.WriteLine("Account Number does not found");
            //    }
            //    // Least specific:
            //    catch (Exception e)
            //    {
            //        Console.WriteLine("{0} Error nexception caught.", e);
            //    }










            //}


        }
    }
}
