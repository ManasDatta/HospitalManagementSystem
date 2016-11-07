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
    public partial class UserControlAdminPatient : UserControl
    {
        private static UserControlAdminPatient _instance;
        public static UserControlAdminPatient Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlAdminPatient();
                return _instance;
            }
        }
        public UserControlAdminPatient()
        {
            InitializeComponent();
        }

        private void metroTextButtonAdminPatientList_Click(object sender, EventArgs e)
        {
            FormAdmin.ActiveForm.Hide();
            new AdminPatientList().Show();
        }
    }
}
