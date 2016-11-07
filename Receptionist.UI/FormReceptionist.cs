using HospitalManagementSystem.UI.Login.UI;
using HospitalManagementSystem.UI.Receptionist.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.UI.Receptionist.UI
{
  
    public partial class FormReceptionist : MetroFramework.Forms.MetroForm
    {
        Timer t = new Timer();
        public FormReceptionist()
        {
            InitializeComponent();
        }
        //public static string patient = "";
        private void metroTextButtonReceptionistPatient_Click(object sender, EventArgs e)
        {
            if (!metroPanelReceptionistBody.Controls.Contains(UserControlReceptionistPatient.Instance))
            {
                metroPanelReceptionistBody.Controls.Add(UserControlReceptionistPatient.Instance);
                UserControlReceptionistPatient.Instance.Dock = DockStyle.Fill;
                UserControlReceptionistPatient.Instance.BringToFront();
            }
            else
            {
                UserControlReceptionistPatient.Instance.BringToFront();
            }
        }

        private void metroTextButtonReceptionistDashboard_Click(object sender, EventArgs e)
        {
            FormReceptionist f = new FormReceptionist();
            f.Show();
            this.Hide();
        }

        private void metroTextButtonReceptionistProfile_Click(object sender, EventArgs e)
        {
            if (!metroPanelReceptionistBody.Controls.Contains(UserControlReceptionistProfile.Instance))
            {
                metroPanelReceptionistBody.Controls.Add(UserControlReceptionistProfile.Instance);
                UserControlReceptionistProfile.Instance.Dock = DockStyle.Fill;
                UserControlReceptionistProfile.Instance.BringToFront();
            }
            else
            {
                UserControlReceptionistProfile.Instance.BringToFront();
            }
        }

        private void metroTileReceptionistLogOut_Click(object sender, EventArgs e)
        {
            FormReceptionist.ActiveForm.Hide();
            new FormMain().Show();
            FormMain.user = "";
        }

        private void metroTileReceptionistPatient_Click(object sender, EventArgs e)
        {
            if (!metroPanelReceptionistBody.Controls.Contains(UserControlReceptionistPatient.Instance))
            {
                metroPanelReceptionistBody.Controls.Add(UserControlReceptionistPatient.Instance);
                UserControlReceptionistPatient.Instance.Dock = DockStyle.Fill;
                UserControlReceptionistPatient.Instance.BringToFront();
            }
            else
            {
                UserControlReceptionistPatient.Instance.BringToFront();
            }
        }

        private void metroTileReceptionistProfile_Click(object sender, EventArgs e)
        {
            if (!metroPanelReceptionistBody.Controls.Contains(UserControlReceptionistProfile.Instance))
            {
                metroPanelReceptionistBody.Controls.Add(UserControlReceptionistProfile.Instance);
                UserControlReceptionistProfile.Instance.Dock = DockStyle.Fill;
                UserControlReceptionistProfile.Instance.BringToFront();
            }
            else
            {
                UserControlReceptionistProfile.Instance.BringToFront();
            }
        }

       


            private void FormReceptionist_Load(object sender, EventArgs e)
        {
            t.Interval = 1000; // in ms
            t.Tick += new EventHandler(this.timer1_Tick);
            t.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string clock = DateTime.Now.ToString("HH:mm:ss");
            string date = DateTime.Now.ToString("dd:MM:yyyy");
            metroTileReceptionistTime.Text = clock;
            metroTileReceptionistDate.Text = date;
        }
    }
}
