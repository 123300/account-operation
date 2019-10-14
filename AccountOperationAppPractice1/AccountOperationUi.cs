using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationAppPractice1
{
    public partial class AccountOperationUi : Form
    {
        Account account = new Account();
        public double deposit;
        public double widthraw;
        public string cstmerName;
        public string acnt;
        public double balance;
        public AccountOperationUi()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            cstmerName = account.customerName = customerNameTextBox.Text;
            acnt = account.accountNumber =accountNoTextBox.Text;
        }

        private void DipositButton_Click(object sender, EventArgs e)
        {
            balance = account.Deposit(Convert.ToDouble(amountTextBox.Text));
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            balance = account.Widthraw(Convert.ToDouble(amountTextBox.Text));
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Customer: "+cstmerName+"  "+"AccountNo: "+acnt+"  "+"Balance:  "+ balance);
        }
    }
}
