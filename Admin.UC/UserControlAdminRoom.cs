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
    public partial class UserControlAdminRoom : UserControl
    {
        private static UserControlAdminRoom _instance;
        public static UserControlAdminRoom Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlAdminRoom();
                return _instance;
            }
        }
        public UserControlAdminRoom()
        {
            InitializeComponent();
        }

        private void metroTextButtonAdminRoomList_Click(object sender, EventArgs e)
        {
            FormAdmin.ActiveForm.Hide();
            new AdminRoomList().Show();
        }

        private void metroTextButtonAdminAddRoom_Click(object sender, EventArgs e)
        {
        }
    }
}
