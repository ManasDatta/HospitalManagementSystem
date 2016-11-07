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
    public partial class UserControlAdminDoctor : UserControl
    {
        private static UserControlAdminDoctor _instance;
        public static UserControlAdminDoctor Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlAdminDoctor();
                return _instance;
            }
        }
        public UserControlAdminDoctor()
        {
            InitializeComponent();
        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            FormAdmin.ActiveForm.Hide();
            new AdminDoctorList().Show();
        }

        private void metroTextButtonAdminAddDoctor_Click(object sender, EventArgs e)
        {
            if (!metroPanelAdminDoctor.Controls.Contains(UserControlAdminAddDoctor.Instance))
            {
                metroPanelAdminDoctor.Controls.Add(UserControlAdminAddDoctor.Instance);
                UserControlAdminAddDoctor.Instance.Dock = DockStyle.Fill;
                UserControlAdminAddDoctor.Instance.BringToFront();
            }
            else
            {
                UserControlAdminAddDoctor.Instance.BringToFront();
            }
        }
    }
}
