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
    public partial class UserControlAdminEmployee : UserControl
    {
        private static UserControlAdminEmployee _instance;
        public static UserControlAdminEmployee Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlAdminEmployee();
                return _instance;
            }
        }
        public UserControlAdminEmployee()
        {
            InitializeComponent();
        }

        private void UserControlAdminEmployee_Load(object sender, EventArgs e)
        {

        }

        private void metroTextButtonAdminEmployeeList_Click(object sender, EventArgs e)
        {
            FormAdmin.ActiveForm.Hide();
            new AdminEmployeeList().Show();
        }

        private void metroTextButtonAdminAddEmployee_Click(object sender, EventArgs e)
        {
            if (!metroPanelAdminEmployee.Controls.Contains(UserControlAdminAddEmployee.Instance))
            {
                metroPanelAdminEmployee.Controls.Add(UserControlAdminAddEmployee.Instance);
                UserControlAdminAddEmployee.Instance.Dock = DockStyle.Fill;
                UserControlAdminAddEmployee.Instance.BringToFront();
            }
            else
            {
                UserControlAdminAddEmployee.Instance.BringToFront();
            }
        }

        private void metroPanelAdminEmployee_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
