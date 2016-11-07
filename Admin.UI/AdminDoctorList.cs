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
    public partial class AdminDoctorList : MetroFramework.Forms.MetroForm
    {
        public AdminDoctorList()
        {
            InitializeComponent();
        }

        private void AdminDoctorList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.hMSDataSet.Doctor);

        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            AdminDoctorList.ActiveForm.Hide();
            new FormAdmin().Show();
        }
    }
}
