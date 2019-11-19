using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BankAppUI
{
    class ConnectionHandler
    {
        static SqlConnection con = null;
        public static SqlConnection ConnectObj
        {
            get
            {
                if (con == null)
                    con = new SqlConnection("Data Source=DESKTOP-1CH1I23;Initial Catalog=BankApp;Integrated Security=True");
                return con;
            }
        }
    }
}
