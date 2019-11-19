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
    public partial class Transaction : Form
    {
        private int ID;
        public Transaction(int accountID)
        {
            InitializeComponent();
            ID = accountID;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string qry = String.Format("SELECT TransactionID, TransactionDescription, TransactionAmount, TransactionDate FROM Histories WHERE AccountID = {0}", ID);
            SqlDataAdapter sqlDa = new SqlDataAdapter(qry, ConnectionHandler.ConnectObj);
            DataTable dtlb = new DataTable();
            sqlDa.Fill(dtlb);
            dgHistory.DataSource = dtlb;
            

        }
    }
}
