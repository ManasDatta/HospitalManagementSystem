using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagementSystem.UI.Admin.UI;

namespace HospitalManagementSystem.UI.Admin.UC
{
    public partial class UserControlAdminDepartment : UserControl
    {
        private static UserControlAdminDepartment _instance;
        public static UserControlAdminDepartment Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlAdminDepartment();
                return _instance;
            }
        }
        public UserControlAdminDepartment()
        {
            InitializeComponent();
        }
        private void metroTextButton2_Click(object sender, EventArgs e)
        {
            if (!metroPanelAdminDepartment.Controls.Contains(UserControlAdminAddDepartment.Instance))
            {
                metroPanelAdminDepartment.Controls.Add(UserControlAdminAddDepartment.Instance);
                UserControlAdminAddDepartment.Instance.Dock = DockStyle.Fill;
                UserControlAdminAddDepartment.Instance.BringToFront();
            }
            else
            {
                UserControlAdminAddDepartment.Instance.BringToFront();
            }
        }

        private void metroTextButtonAdminDepartmentList_Click(object sender, EventArgs e)
        {
            FormAdmin.ActiveForm.Hide();
            new AdminDepartmentList().Show();
        }

        private void metroPanelAdminDepartment_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroPanelAdminDepartmentButton_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
