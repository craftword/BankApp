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
    public partial class Login
        : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Substring(0, 3) == "Adm")
            {
                string qry = "SELECT * FROM Admin where AdminUsername=@usr and AdminPassword=@pwd";
                SqlCommand cmd = new SqlCommand(qry, ConnectionHandler.ConnectObj);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@usr", txtUsername.Text);
                cmd.Parameters.AddWithValue("@pwd", HashPassword.ComputeSha256Hash(txtPassword.Text));

                ConnectionHandler.ConnectObj.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    //MessageBox.Show(String.Format("{0}", reader[2]));
                    MessageBox.Show("YOU ARE GRANTED WITH ACCESS");
                    AdminDashboard frm2 = new AdminDashboard(String.Format("Welcome {0} - {1}", reader[1], reader[2]), String.Format("{0}", reader[6]), String.Format("{0}", reader[0]));
                    reader.Close();
                    frm2.ShowDialog();
                    //this.Close();
                   
                }
                else
                {
                    MessageBox.Show("INVALID USERNAME OR PASSWORD");
                }
                
                
                ConnectionHandler.ConnectObj.Close();

            }
            else
            {
                //string qry = "SELECT * FROM Account where AccountNumber=@usr and PIN=@pwd";
                string qry = "SELECT Customer.CustomerFirstname, Customer.CustomerLastname, Account.* FROM Customer JOIN Account ON Customer.CustomerID = Account.CustomerID WHERE Account.AccountNumber=@usr and Account.PIN=@pwd ";
                SqlCommand cmd = new SqlCommand(qry, ConnectionHandler.ConnectObj);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@usr", txtUsername.Text);
                cmd.Parameters.AddWithValue("@pwd", txtPassword.Text);

                ConnectionHandler.ConnectObj.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    CustomerDashboard frm2 = new CustomerDashboard(reader);
                    reader.Close();
                    MessageBox.Show("YOU ARE GRANTED WITH ACCESS");
                    //MessageBox.Show(String.Format("Welcome {0} - {1}", reader[3], reader[4]));
                    frm2.ShowDialog();                    
                    this.Close();

                }
                else
                {
                    MessageBox.Show("INVALID ACCOUNT NUMBER OR PIN");
                }


                ConnectionHandler.ConnectObj.Close();
            }
        }

        private void lbUsernamer_Click(object sender, EventArgs e)
        {

        }
    }
}
