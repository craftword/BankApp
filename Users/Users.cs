using System;

namespace Users
{
    public class User
    {
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }


        // Constructor
        public User() {
            FullName = "Mr Bond";
            EmailAddress = "admin@decagon.com";
            MobileNumber = "08027313450";
            Password = "beancake123";
            IsAdmin = true;

        }

        
       



    }
}
