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
    public partial class UserControlAdminAccountant : UserControl
    {
        private static UserControlAdminAccountant _instance;
        public static UserControlAdminAccountant Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlAdminAccountant();
                return _instance;
            }
        }
        public UserControlAdminAccountant()
        {
            InitializeComponent();
        }

        private void metroTextButtonAdminAddAccountant_Click(object sender, EventArgs e)
        {
            if (!metroPanelAdminAccountant.Controls.Contains(UserControlAdminAddAccountant.Instance))
            {
                metroPanelAdminAccountant.Controls.Add(UserControlAdminAddAccountant.Instance);
                UserControlAdminAddAccountant.Instance.Dock = DockStyle.Fill;
                UserControlAdminAddAccountant.Instance.BringToFront();
            }
            else
            {
                UserControlAdminAddAccountant.Instance.BringToFront();
            }
        }

        private void metroTextButtonAccountantList_Click(object sender, EventArgs e)
        {
            FormAdmin.ActiveForm.Hide();
            new AdminAccountantList().Show();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroPanelAdminAccountant_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
