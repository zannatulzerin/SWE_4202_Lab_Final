using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_system
{
    public partial class Form1 : Form
    {

        
        List<Account> accounts = new List<Account>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = NameTextBox.Text;
            string account_no = AccnoTextBox.Text;
            string password = PassTextBox.Text;
            string account_type = SelectComboBox.Text;
            string amount = AmountTextBox.Text;

            Account dummy = new Account();

            dummy.username = username;
            dummy.account_no = account_no;
            dummy.password = password;
            dummy.account_type = account_type;
            dummy.amount = amount;

            accounts.Add(dummy);
            MessageBox.Show("Account has been created successfully.");
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            string account_no = Accno2TextBox.Text;
            string deposit_amount = DepositTextBox.Text;
            string date = Date1TextBox.Text;


        }
    }
}
