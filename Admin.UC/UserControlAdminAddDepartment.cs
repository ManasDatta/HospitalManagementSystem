using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace HospitalManagementSystem.UI.Admin.UC
{
    public partial class UserControlAdminAddDepartment : UserControl
    {
        private static UserControlAdminAddDepartment _instance;
        public static UserControlAdminAddDepartment Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlAdminAddDepartment();
                return _instance;
            }
        }
        public UserControlAdminAddDepartment()
        {
            InitializeComponent();
        }

        private void metroTextButtonAddDepartmentConfirm_Click(object sender, EventArgs e)
        {
            try {
                hmsDataContext dbcon = new hmsDataContext();
                Department dp = new Department();


                dp.DepartmentName = metroTextBox1.Text;
                dp.DepartmentDescription = metroTextBox3.Text;

                dbcon.Departments.InsertOnSubmit(dp);

                dbcon.SubmitChanges();

                // MessageBox.Show("Succesfully saved!!");
                MetroMessageBox.Show(this, "Succesfully Saved.", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                metroTextBox1.Clear();
                metroTextBox3.Clear();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Please insert all section.", "Warning!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            metroTextBox1.Clear();
        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {
            metroTextBox3.Clear();
        }

        private void metroPanelAdminAddDepartment_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
