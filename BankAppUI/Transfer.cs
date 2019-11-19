using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankAppUI
{
    public partial class Transfer : Form
    {
        private int bal;
        private int senderID;
        private int senderAccNo;
        private int newBalance;
        private string senderAccType;

        public Transfer(int balance, int senderCustomerID, int senderAccountID, string accountType)
        {
            InitializeComponent();
            bal = balance;
            senderID = senderCustomerID;
            senderAccNo = senderAccountID;
            senderAccType = accountType;


        }

        private void BtnTransfer_Click(object sender, EventArgs e)
        {
            string amt = txtAmount.Text;
            string receiverAccNo = txtAccountNo.Text;

            //get reciever details 
            string qry = "SELECT Customer.CustomerFirstname, Customer.CustomerLastname, Account.* FROM Customer JOIN Account ON Customer.CustomerID = Account.CustomerID WHERE Account.AccountNumber=@usr";
            SqlCommand cmd = new SqlCommand(qry, ConnectionHandler.ConnectObj);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@usr", receiverAccNo);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                MessageBox.Show(String.Format("Transfer will be made to: {0} - {1}", reader[0], reader[1]));
                int recieverID = Convert.ToInt32(reader[5]);
                int balance = Convert.ToInt32(reader[6]);
                int recieverAccID = Convert.ToInt32(reader[2]);
                reader.Close();
                newBalance = AccountHandler.Withdraw(amt, senderAccType, bal, senderID, senderAccNo);

                if (newBalance > 0)
                {
                    int newDeposit = AccountHandler.Deposit(balance, amt, recieverID, recieverAccID);
                    //string message = String.Format("Transfer {0} to the account Number {1}", amt, recieverAccID);
                    if (newBalance != 0)
                    {
                        lbDisplay.Text = String.Format("Transfer is successful");
                       // balance = newBalance;
                    }
                    else
                    {
                        MessageBox.Show("Error in update the Database");
                    }

                }
                else
                {
                    MessageBox.Show("Insufficient Balance");
                }

            }
            else
            {
                MessageBox.Show("INVALID ACCOUNT NUMBER");
            }
           
            

        }
    }
}
