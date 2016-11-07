using HospitalManagementSystem.UI.Accountant.UC;
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

namespace HospitalManagementSystem.UI.Accountant.UI
{
    public partial class FormAccountant : MetroFramework.Forms.MetroForm
    {
        Timer t = new Timer();
       

        public FormAccountant()
        {

            InitializeComponent();
        }
        

        private void metroPanelAccountantBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTextButtonAccountantDashboard_Click(object sender, EventArgs e)
        {
            FormAccountant f = new FormAccountant();
            f.Show();
            this.Hide();
        }

        private void metroTextButtonAccountantInvoice_Click(object sender, EventArgs e)
        {
            if (!metroPanelAccountantBody.Controls.Contains(UserControlAccountantInvoice.Instance))
            {
                metroPanelAccountantBody.Controls.Add(UserControlAccountantInvoice.Instance);
                UserControlAccountantInvoice.Instance.Dock = DockStyle.Fill;
                UserControlAccountantInvoice.Instance.BringToFront();
            }
            else
            {
                UserControlAccountantInvoice.Instance.BringToFront();
            }
        }

        private void metroTextButtonAccountantSalary_Click(object sender, EventArgs e)
        {
            if (!metroPanelAccountantBody.Controls.Contains(UserControlAccountantSalary.Instance))
            {
                metroPanelAccountantBody.Controls.Add(UserControlAccountantSalary.Instance);
                UserControlAccountantSalary.Instance.Dock = DockStyle.Fill;
                UserControlAccountantSalary.Instance.BringToFront();
            }
            else
            {
                UserControlAccountantSalary.Instance.BringToFront();
            }
        }

        private void metroTextButtonAccountantProfile_Click(object sender, EventArgs e)
        {
            if (!metroPanelAccountantBody.Controls.Contains(UserControlAccountantProfile.Instance))
            {
                metroPanelAccountantBody.Controls.Add(UserControlAccountantProfile.Instance);
                UserControlAccountantProfile.Instance.Dock = DockStyle.Fill;
                UserControlAccountantProfile.Instance.BringToFront();
            }
            else
            {
                UserControlAccountantProfile.Instance.BringToFront();
            }
        }

        private void metroTileAccountantLogOut_Click(object sender, EventArgs e)
        {
            FormAccountant.ActiveForm.Hide();
            new FormMain().Show();
            FormMain.user = "";
        }

        private void metroTileAccountantInvoice_Click(object sender, EventArgs e)
        {
            if (!metroPanelAccountantBody.Controls.Contains(UserControlAccountantInvoice.Instance))
            {
                metroPanelAccountantBody.Controls.Add(UserControlAccountantInvoice.Instance);
                UserControlAccountantInvoice.Instance.Dock = DockStyle.Fill;
                UserControlAccountantInvoice.Instance.BringToFront();
            }
            else
            {
                UserControlAccountantInvoice.Instance.BringToFront();
            }
        }


        private void metroTileAccountantSalary_Click(object sender, EventArgs e)
        {
            if (!metroPanelAccountantBody.Controls.Contains(UserControlAccountantSalary.Instance))
            {
                metroPanelAccountantBody.Controls.Add(UserControlAccountantSalary.Instance);
                UserControlAccountantSalary.Instance.Dock = DockStyle.Fill;
                UserControlAccountantSalary.Instance.BringToFront();
            }
            else
            {
                UserControlAccountantSalary.Instance.BringToFront();
            }
        }


        private void metroTileAccountantProfile_Click(object sender, EventArgs e)
        {
            if (!metroPanelAccountantBody.Controls.Contains(UserControlAccountantProfile.Instance))
            {
                metroPanelAccountantBody.Controls.Add(UserControlAccountantProfile.Instance);
                UserControlAccountantProfile.Instance.Dock = DockStyle.Fill;
                UserControlAccountantProfile.Instance.BringToFront();
            }
            else
            {
                UserControlAccountantProfile.Instance.BringToFront();
            }
        }

        private void FormAccountant_Load(object sender, EventArgs e)
        {
            t.Interval = 1000; // in ms
            t.Tick += new EventHandler(this.timer1_Tick);
            t.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string clock = DateTime.Now.ToString("HH:mm:ss");
            string date = DateTime.Now.ToString("dd:MM:yyyy");
            metroTileAccountantTime.Text = clock;
            metroTileAccountantDate.Text = date;
        }


    }
}
