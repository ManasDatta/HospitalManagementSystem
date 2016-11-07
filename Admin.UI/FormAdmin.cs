using HospitalManagementSystem.UI.Admin.UC;
using HospitalManagementSystem.UI.Login.UI;
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
    public partial class FormAdmin : MetroFramework.Forms.MetroForm
    {
        Timer t = new Timer();
        public FormAdmin()
        {
            InitializeComponent();
        }

        //public static string admin = "";
        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void metroTextButtonDashboard_Click(object sender, EventArgs e)
        {
            FormAdmin f = new FormAdmin();
            f.Show();
            this.Hide();
        }

        private void metroTextButtonDepartment_Click(object sender, EventArgs e)
        {
            
            if (!metroPanelAdminBody.Controls.Contains(UserControlAdminDepartment.Instance))
            {
                metroPanelAdminBody.Controls.Add(UserControlAdminDepartment.Instance);
                UserControlAdminDepartment.Instance.Dock = DockStyle.Fill;
                UserControlAdminDepartment.Instance.BringToFront();
            }
            else
            {
                UserControlAdminDepartment.Instance.BringToFront();
            }
        }

        private void metroTextButtonDoctor_Click(object sender, EventArgs e)
        {
            if (!metroPanelAdminBody.Controls.Contains(UserControlAdminDoctor.Instance))
            {
                metroPanelAdminBody.Controls.Add(UserControlAdminDoctor.Instance);
                UserControlAdminDoctor.Instance.Dock = DockStyle.Fill;
                UserControlAdminDoctor.Instance.BringToFront();
            }
            else
            {
                UserControlAdminDoctor.Instance.BringToFront();
            }
        }

        private void metroTextButtonPatient_Click(object sender, EventArgs e)
        {
            if (!metroPanelAdminBody.Controls.Contains(UserControlAdminPatient.Instance))
            {
                metroPanelAdminBody.Controls.Add(UserControlAdminPatient.Instance);
                UserControlAdminPatient.Instance.Dock = DockStyle.Fill;
                UserControlAdminPatient.Instance.BringToFront();
            }
            else
            {
                UserControlAdminPatient.Instance.BringToFront();
            }
        }

        private void metroTextButtonEmployee_Click(object sender, EventArgs e)
        {
            if (!metroPanelAdminBody.Controls.Contains(UserControlAdminEmployee.Instance))
            {
                metroPanelAdminBody.Controls.Add(UserControlAdminEmployee.Instance);
                UserControlAdminEmployee.Instance.Dock = DockStyle.Fill;
                UserControlAdminEmployee.Instance.BringToFront();
            }
            else
            {
                UserControlAdminEmployee.Instance.BringToFront();
            }
        }

        private void metroTextButtonAccountant_Click(object sender, EventArgs e)
        {
            if (!metroPanelAdminBody.Controls.Contains(UserControlAdminAccountant.Instance))
            {
                metroPanelAdminBody.Controls.Add(UserControlAdminAccountant.Instance);
                UserControlAdminAccountant.Instance.Dock = DockStyle.Fill;
                UserControlAdminAccountant.Instance.BringToFront();
            }
            else
            {
                UserControlAdminAccountant.Instance.BringToFront();
            }
        }

        private void metroTextButtonReceptionist_Click(object sender, EventArgs e)
        {
            if (!metroPanelAdminBody.Controls.Contains(UserControlAdminReceptionist.Instance))
            {
                metroPanelAdminBody.Controls.Add(UserControlAdminReceptionist.Instance);
                UserControlAdminReceptionist.Instance.Dock = DockStyle.Fill;
                UserControlAdminReceptionist.Instance.BringToFront();
            }
            else
            {
                UserControlAdminReceptionist.Instance.BringToFront();
            }
        }

        private void metroTextButtonAdminRoom_Click(object sender, EventArgs e)
        {
            if (!metroPanelAdminBody.Controls.Contains(UserControlAdminRoom.Instance))
            {
                metroPanelAdminBody.Controls.Add(UserControlAdminRoom.Instance);
                UserControlAdminRoom.Instance.Dock = DockStyle.Fill;
                UserControlAdminRoom.Instance.BringToFront();
            }
            else
            {
                UserControlAdminRoom.Instance.BringToFront();
            }
        }

        private void metroTextButtonProfile_Click(object sender, EventArgs e)
        {
            if (!metroPanelAdminBody.Controls.Contains(UserControlAdminProfile.Instance))
            {
                metroPanelAdminBody.Controls.Add(UserControlAdminProfile.Instance);
                UserControlAdminProfile.Instance.Dock = DockStyle.Fill;
                UserControlAdminProfile.Instance.BringToFront();
            }
            else
            {
                UserControlAdminProfile.Instance.BringToFront();
            }
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroPanelAdminMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTileAdminLogOut_Click_1(object sender, EventArgs e)
        {
            FormAdmin.ActiveForm.Hide();
            new FormMain().Show();
            FormMain.user = "";
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            t.Interval = 1000; // in ms
            t.Tick += new EventHandler(this.timer1_Tick);
            t.Start();
        }
        // Time
        private void timer1_Tick(object sender, EventArgs e)
        {
            string clock = DateTime.Now.ToString("HH:mm:ss");
            string date = DateTime.Now.ToString("dd:MM:yyyy");
            metroTileAdminTime.Text = clock;
            metroTileAdminDate.Text = date;
        }

        private void metroTileAdminDepartment_Click(object sender, EventArgs e)
        {
            if (!metroPanelAdminBody.Controls.Contains(UserControlAdminDepartment.Instance))
            {
                metroPanelAdminBody.Controls.Add(UserControlAdminDepartment.Instance);
                UserControlAdminDepartment.Instance.Dock = DockStyle.Fill;
                UserControlAdminDepartment.Instance.BringToFront();
            }
            else
            {
                UserControlAdminDepartment.Instance.BringToFront();
            }
        }

        private void metroTileAdminDoctor_Click(object sender, EventArgs e)
        {
            if (!metroPanelAdminBody.Controls.Contains(UserControlAdminDoctor.Instance))
            {
                metroPanelAdminBody.Controls.Add(UserControlAdminDoctor.Instance);
                UserControlAdminDoctor.Instance.Dock = DockStyle.Fill;
                UserControlAdminDoctor.Instance.BringToFront();
            }
            else
            {
                UserControlAdminDoctor.Instance.BringToFront();
            }
        }

        private void metroTileAdminPatient_Click(object sender, EventArgs e)
        {
            if (!metroPanelAdminBody.Controls.Contains(UserControlAdminPatient.Instance))
            {
                metroPanelAdminBody.Controls.Add(UserControlAdminPatient.Instance);
                UserControlAdminPatient.Instance.Dock = DockStyle.Fill;
                UserControlAdminPatient.Instance.BringToFront();
            }
            else
            {
                UserControlAdminPatient.Instance.BringToFront();
            }
        }

        private void metroTileAdminEmployee_Click(object sender, EventArgs e)
        {

            if (!metroPanelAdminBody.Controls.Contains(UserControlAdminEmployee.Instance))
            {
                metroPanelAdminBody.Controls.Add(UserControlAdminEmployee.Instance);
                UserControlAdminEmployee.Instance.Dock = DockStyle.Fill;
                UserControlAdminEmployee.Instance.BringToFront();
            }
            else
            {
                UserControlAdminEmployee.Instance.BringToFront();
            }
        }

        private void metroTileAdminAccountant_Click(object sender, EventArgs e)
        {

            if (!metroPanelAdminBody.Controls.Contains(UserControlAdminAccountant.Instance))
            {
                metroPanelAdminBody.Controls.Add(UserControlAdminAccountant.Instance);
                UserControlAdminAccountant.Instance.Dock = DockStyle.Fill;
                UserControlAdminAccountant.Instance.BringToFront();
            }
            else
            {
                UserControlAdminAccountant.Instance.BringToFront();
            }
        }

        private void metroTileAdminReceptionist_Click(object sender, EventArgs e)
        {
            if (!metroPanelAdminBody.Controls.Contains(UserControlAdminReceptionist.Instance))
            {
                metroPanelAdminBody.Controls.Add(UserControlAdminReceptionist.Instance);
                UserControlAdminReceptionist.Instance.Dock = DockStyle.Fill;
                UserControlAdminReceptionist.Instance.BringToFront();
            }
            else
            {
                UserControlAdminReceptionist.Instance.BringToFront();
            }
        }

        private void metroTileAdminRoom_Click(object sender, EventArgs e)
        {
            if (!metroPanelAdminBody.Controls.Contains(UserControlAdminRoom.Instance))
            {
                metroPanelAdminBody.Controls.Add(UserControlAdminRoom.Instance);
                UserControlAdminRoom.Instance.Dock = DockStyle.Fill;
                UserControlAdminRoom.Instance.BringToFront();
            }
            else
            {
                UserControlAdminRoom.Instance.BringToFront();
            }
        }

        private void metroTileAdminProfile_Click(object sender, EventArgs e)
        {
            if (!metroPanelAdminBody.Controls.Contains(UserControlAdminProfile.Instance))
            {
                metroPanelAdminBody.Controls.Add(UserControlAdminProfile.Instance);
                UserControlAdminProfile.Instance.Dock = DockStyle.Fill;
                UserControlAdminProfile.Instance.BringToFront();
            }
            else
            {
                UserControlAdminProfile.Instance.BringToFront();
            }
        }

        private void metroTileAdminDate_Click(object sender, EventArgs e)
        {

        }

        private void metroTileAdminTime_Click(object sender, EventArgs e)
        {

        }
    }
}
