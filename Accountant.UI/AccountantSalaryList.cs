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
    public partial class AccountantSalaryList : MetroFramework.Forms.MetroForm
    {
        public AccountantSalaryList()
        {
            InitializeComponent();
        }

        private void AccountantSalaryList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.Salary' table. You can move, or remove it, as needed.
            this.salaryTableAdapter.Fill(this.hMSDataSet.Salary);
            // TODO: This line of code loads data into the 'hMSDataSet.Salary' table. You can move, or remove it, as needed.
            this.salaryTableAdapter.Fill(this.hMSDataSet.Salary);
            // TODO: This line of code loads data into the 'hMSDataSet.Salary' table. You can move, or remove it, as needed.
            this.salaryTableAdapter.Fill(this.hMSDataSet.Salary);
            // TODO: This line of code loads data into the 'hMSDataSet1.Salary' table. You can move, or remove it, as needed.
            this.salaryTableAdapter.Fill(this.hMSDataSet.Salary);

        }

        private void salaryBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            AccountantSalaryList.ActiveForm.Hide();
            new FormAccountant().Show();
        }
    }
}
