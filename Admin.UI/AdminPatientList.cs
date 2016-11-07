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
    public partial class AdminPatientList : MetroFramework.Forms.MetroForm
    {
        public AdminPatientList()
        {
            InitializeComponent();
        }

        private void AdminPatientList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.hMSDataSet.Patient);

        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            AdminPatientList.ActiveForm.Hide();
            new FormAdmin().Show();
        }
    }
}
