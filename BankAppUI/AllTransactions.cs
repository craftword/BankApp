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
    public partial class AllTransactions : Form
    {
        public AllTransactions()
        {
            InitializeComponent();
            
        }

        private void AllTransactions_Load(object sender, EventArgs e)
        {
            string qry = "SELECT Account.AccountNumber, Histories.TransactionDescription, Histories.TransactionAmount, Histories.TransactionDate FROM Account JOIN Histories ON Account.AccountID = Histories.AccountID";
            SqlDataAdapter sqlAll = new SqlDataAdapter(qry, ConnectionHandler.ConnectObj);
            DataTable dtlb = new DataTable();
            sqlAll.Fill(dtlb);
            dgAllTransaction.DataSource = dtlb;
        }
    }
}
