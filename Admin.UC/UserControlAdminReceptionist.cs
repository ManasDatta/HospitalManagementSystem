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
    public partial class UserControlAdminReceptionist : UserControl
    {
        private static UserControlAdminReceptionist _instance;
        public static UserControlAdminReceptionist Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlAdminReceptionist();
                return _instance;
            }
        }
        public UserControlAdminReceptionist()
        {
            InitializeComponent();
        }

        private void metroTextButtonAdminReceptionistList_Click(object sender, EventArgs e)
        {
            FormAdmin.ActiveForm.Hide();
            new AdminReceptionistList().Show();
        }

        private void metroTextButtonAdminAddReceptionist_Click(object sender, EventArgs e)
        {

            if (!metroPanelAdminReceptionist.Controls.Contains(UserControlAdminAddReceptionist.Instance))
            {
                metroPanelAdminReceptionist.Controls.Add(UserControlAdminAddReceptionist.Instance);
                UserControlAdminAddReceptionist.Instance.Dock = DockStyle.Fill;
                UserControlAdminAddReceptionist.Instance.BringToFront();
            }
            else
            {
                UserControlAdminAddReceptionist.Instance.BringToFront();
            }
        }
    }
}
