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
    public partial class AddUsers : Form
    {
       
        public AddUsers()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ConnectionHandler.ConnectObj.Close();
        }

        private void BtnAdminSubmit_Click(object sender, EventArgs e)
        {
            
            string fName = txtFirstName.Text;
            string lName = txtLastName.Text;
            string eMail = txtEmail.Text;
            string password = txtPassword.Text;
            string uName = "Adm" + txtUserName.Text;
            string role = Role.Text;
            string today = DateTime.Today.ToString();

            string hashpassword = HashPassword.ComputeSha256Hash(password);

            MessageBox.Show(hashpassword);

            string qry = String.Format("insert into Admin values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", fName, lName, eMail, uName, hashpassword,  role, today);
            SqlCommand cmd = new SqlCommand(qry, ConnectionHandler.ConnectObj);

            ConnectionHandler.ConnectObj.Open();
            try
            {
               int i = cmd.ExecuteNonQuery();
                if (i >= 0)
                {
                    MessageBox.Show("Admin added sucessfully");
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occurred during the write operation:" + ex.Message);
            }
            ConnectionHandler.ConnectObj.Close();

        }
    }
}
