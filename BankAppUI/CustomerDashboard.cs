using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helpers;
using System.Data.SqlClient;


namespace BankAppUI
{
    public partial class CustomerDashboard : Form
    {
        private int customerID;
        private int accountID;
        private int balance;      
        private int newBalance;
        private string accountType;
        public CustomerDashboard(SqlDataReader reader)
        {
            InitializeComponent();
           
            lbWelcome.Text = String.Format("Welcome {0} - {1}", reader[0], reader[1]);
            lbResults.Text = String.Format("Current Balance: {0}", reader[6]);
            lbResult.Text = String.Format("Account Type: {0}", reader[4]);
            balance = Convert.ToInt32(reader[6]);
            customerID = Convert.ToInt32(reader[5]);
            accountID = Convert.ToInt32(reader[2]);
            accountType = String.Format("{0}", reader[4]);
            reader.Close();
        }

        //private void BtnCheckBalance_Click(object sender, EventArgs e)
        //{
            
        //    string qry = "SELECT Balance FROM Account where AccountID=@usr";
        //    SqlCommand cmd = new SqlCommand(qry, ConnectionHandler.ConnectObj);
        //    cmd.Parameters.Clear();
        //    cmd.Parameters.AddWithValue("@usr",accountID);

        //    int custId = Convert.ToInt32(cmd.ExecuteScalar());
        //    lbResults.Text = String.Format("Current Balance: {0}", custId);

        //}

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {

        }

        private void BtnDeposit_Click(object sender, EventArgs e)
        {

            //balance += Convert.ToInt32(txtInput.Text);
            //MessageBox.Show(String.Format("Current Balance: {0}", balance));
            newBalance = AccountHandler.Deposit(balance, txtInput.Text, customerID, accountID);


            if (newBalance != 0)
            {
                lbResults.Text = String.Format("Current Balance: {0}", newBalance);
                balance = newBalance;
            }
            else
            {
                MessageBox.Show("Error in update the Database");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
        }

        private void BtnWithdraw_Click(object sender, EventArgs e)
        {

            //balance -= Convert.ToInt32(txtInput.Text);
            
            newBalance = AccountHandler.Withdraw(txtInput.Text, accountType, balance, customerID, accountID);
            
            if (newBalance == 0)
            {

                MessageBox.Show("Insufficient Balance");
            }
            else if (newBalance == -1)
            {
                MessageBox.Show("Error in update the Database");
            }
            else
            {
                lbResults.Text = String.Format("Current Balance: {0}", newBalance);
                balance = newBalance;
            }

        }



        private void BtnTransfer_Click(object sender, EventArgs e)
        {
            Transfer frm2 = new Transfer(balance, customerID, accountID, accountType);
            frm2.ShowDialog();
            this.Close();
        }

        private void BtnStatement_Click(object sender, EventArgs e)
        {
            Transaction frm2 = new Transaction(accountID);
            frm2.ShowDialog();
            this.Close();
        }
    }
}
