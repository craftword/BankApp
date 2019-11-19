using System;


namespace Helpers
{
    public class UserHelper
    {
              
        public static bool CheckPassord(string Password, string cmdPassword)    
        {           

            if (cmdPassword == Password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string CheckIsAdmin(bool IsAdmin)
        {
            if (IsAdmin == true)
            {
                return "A";
            }
            else
            {
                return "B";
            }
        }
    }
}
