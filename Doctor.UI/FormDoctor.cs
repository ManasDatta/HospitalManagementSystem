using HospitalManagementSystem.UI.Doctor.UC;
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

namespace HospitalManagementSystem.UI.Doctor.UI
{
    public partial class FormDoctor : MetroFramework.Forms.MetroForm
    {
        Timer t = new Timer();
        public FormDoctor()
        {
            InitializeComponent();
        }

        private void metroTextButton4_Click(object sender, EventArgs e)
        {


          if (!metroPanelDoctorBody.Controls.Contains(UserControlDoctorProfile.Instance))
            {
                metroPanelDoctorBody.Controls.Add(UserControlDoctorProfile.Instance);
                UserControlDoctorProfile.Instance.Dock = DockStyle.Fill;
                UserControlDoctorProfile.Instance.BringToFront();
            }
            else
            {
                UserControlDoctorProfile.Instance.BringToFront();
            }
        }

        private void metroTextButton2_Click(object sender, EventArgs e)
        {
            FormDoctor f = new FormDoctor();
            f.Show();
            this.Hide();
        }

        private void metroTextButtonDoctorPatient_Click(object sender, EventArgs e)
        {
            if (!metroPanelDoctorBody.Controls.Contains(UserControlDoctorPatient.Instance))
            {
                metroPanelDoctorBody.Controls.Add(UserControlDoctorPatient.Instance);
                UserControlDoctorPatient.Instance.Dock = DockStyle.Fill;
                UserControlDoctorPatient.Instance.BringToFront();
            }
            else
            {
                UserControlDoctorPatient.Instance.BringToFront();
            }
        }

        private void metroPanelDoctorBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTileDoctorLogOut_Click(object sender, EventArgs e)
        {
            FormDoctor.ActiveForm.Hide();
            new FormMain().Show();
            FormMain.user = "";
        }

        private void metroTileDoctorPatient_Click(object sender, EventArgs e)
        {
            if (!metroPanelDoctorBody.Controls.Contains(UserControlDoctorPatient.Instance))
            {
                metroPanelDoctorBody.Controls.Add(UserControlDoctorPatient.Instance);
                UserControlDoctorPatient.Instance.Dock = DockStyle.Fill;
                UserControlDoctorPatient.Instance.BringToFront();
            }
            else
            {
                UserControlDoctorPatient.Instance.BringToFront();
            }
        }

        private void metroTileDoctorProfile_Click(object sender, EventArgs e)
        {
            if (!metroPanelDoctorBody.Controls.Contains(UserControlDoctorProfile.Instance))
            {
                metroPanelDoctorBody.Controls.Add(UserControlDoctorProfile.Instance);
                UserControlDoctorProfile.Instance.Dock = DockStyle.Fill;
                UserControlDoctorProfile.Instance.BringToFront();
            }
            else
            {
                UserControlDoctorProfile.Instance.BringToFront();
            }
        }

        private void FormDoctor_Load(object sender, EventArgs e)
        {
               
            t.Interval = 1000; // in ms
            t.Tick += new EventHandler(this.timer1_Tick);
            t.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string clock = DateTime.Now.ToString("HH:mm:ss");
            string date = DateTime.Now.ToString("dd:MM:yyyy");
            metroTileDoctorTime.Text = clock;
            metroTileDoctorDate.Text = date;
        }

        private void metroTileDoctorTime_Click(object sender, EventArgs e)
        {

        }

        private void metroTileDoctorDate_Click(object sender, EventArgs e)
        {

        }
    }

    }
