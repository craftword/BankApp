using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Customers;
using System.Data.SqlClient;

namespace BankAppUI
{
    public partial class CreateCustomer : Form
    {
        
        public CreateCustomer()
        {
            InitializeComponent();
            
        }

        private void CreateCustomer_Load(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {

            ConnectionHandler.ConnectObj.Close();
            string fName = txtFirstname.Text;
            string lName = txtCustomerLastname.Text;
            string phone = txtCustomerPhone.Text;
            string address = txtAddress.Text;
            

            string qry = String.Format("insert into Customer  OUTPUT INSERTED.CustomerID values('{0}', '{1}', '{2}', '{3}')", fName, lName, phone, address);
            SqlCommand cmd = new SqlCommand(qry, ConnectionHandler.ConnectObj);

            ConnectionHandler.ConnectObj.Open();
            int custId = Convert.ToInt32(cmd.ExecuteScalar());
            //MessageBox.Show(String.Format("{0}", custId));
            //MessageBox.Show(custId.ToString());

            string accountNumber = Customer.AccountNumber;
            string accountType = cmbAccountType.Text;
            string balance = txtBalance.Text;
            string createdAt = DateTime.Today.ToString();
            int PIN = new Random().Next(1000, 9999);

            string qry1 = String.Format("insert into Account  values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", accountNumber, accountType, custId, balance, createdAt, PIN);
            SqlCommand cmd1 = new SqlCommand(qry1, ConnectionHandler.ConnectObj);
            try
            {
                int i = cmd1.ExecuteNonQuery();
                if (i >= 0)
                {
                    //MessageBox.Show("Customer added sucessfully");
                    lbWelcome.Text = String.Format("Account Number {0} is created successfully", accountNumber);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occurred during the write operation:" + ex.Message);
            }

            ConnectionHandler.ConnectObj.Close();

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtFirstname.Text = " ";
            txtCustomerLastname.Text = " ";
            txtCustomerPhone.Text  = " ";
            txtAddress.Text = " ";
            cmbAccountType.Text = " ";
            txtBalance.Text = " ";
            lbWelcome.Text = "Create New Customer";
        }
    }
}
