using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.UI.Accountant.UI
{
    public partial class AccountantInvoiceList : MetroFramework.Forms.MetroForm
    {
        public AccountantInvoiceList()
        {
            InitializeComponent();
        }

        private void AccountantInvoiceList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.Invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.hMSDataSet.Invoice);
            // TODO: This line of code loads data into the 'hMSDataSet.Invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.hMSDataSet.Invoice);
            // TODO: This line of code loads data into the 'hMSDataSet.Invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.hMSDataSet.Invoice);

        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            AccountantInvoiceList.ActiveForm.Hide();
            new FormAccountant().Show();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
