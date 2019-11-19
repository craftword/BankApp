using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAppUI
{
    public partial class AdminDashboard : Form
    {
        private string oldId;
        public AdminDashboard(string fullname, string role, string ID)
        {
            InitializeComponent();
            LbWelcome.Text = fullname;
            oldId = ID;
            
            if(role == "Admin")
            {
                BtnCreateUsers.Hide();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AddUsers frm2 = new AddUsers();
           
            frm2.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateCustomer frm3 = new CreateCustomer();
            // MessageBox.Show(oldId);
            frm3.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AllTransactions frm3 = new AllTransactions();           
            frm3.ShowDialog();
            this.Close();
        }
    }
}
