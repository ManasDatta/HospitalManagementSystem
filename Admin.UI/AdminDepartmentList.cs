using HospitalManagementSystem.UI.Admin.UC;
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
    public partial class AdminDepartmentList : MetroFramework.Forms.MetroForm
    {
        public AdminDepartmentList()
        {
            InitializeComponent();
        }
        private void AdminDepartmentList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.hMSDataSet.Department);

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            AdminDepartmentList.ActiveForm.Hide();
            new FormAdmin().Show();
        }
    }
}
