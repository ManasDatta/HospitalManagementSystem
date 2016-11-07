using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.UI.Admin.UI
{
    public partial class AdminAccountantList : MetroFramework.Forms.MetroForm
    {
        public AdminAccountantList()
        {
            InitializeComponent();
        }

        private void AdminAccountantList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.Accountant' table. You can move, or remove it, as needed.
            this.accountantTableAdapter.Fill(this.hMSDataSet.Accountant);

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            AdminAccountantList.ActiveForm.Hide();
            new FormAdmin().Show();
        }
    }
}
