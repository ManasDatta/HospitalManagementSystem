using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using HospitalManagementSystem.UI.Admin.UI;
using HospitalManagementSystem.UI.Doctor.UI;
using HospitalManagementSystem.UI.Accountant.UI;
using MetroFramework;
using HospitalManagementSystem.UI.Receptionist.UI;

namespace HospitalManagementSystem.UI.Login.UI
{
    public partial class FormMain : MetroFramework.Forms.MetroForm
    {
        Timer t = new Timer();
        public FormMain()
        {
            InitializeComponent();
            metroTextBox2.PasswordChar = '●';
            metroPanelLoginBody.Hide();
        }
        public static string user = "";
        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            metroPanelLoginBody.Show();
        }

        private void metroTextButtonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                hmsDataContext DBcon = new hmsDataContext();
                Login_ log = new Login_();
                log = DBcon.Login_s.SingleOrDefault(x => x.LoginUserName == metroTextBox1.Text && x.LoginPassword == metroTextBox2.Text);

                if (log.Profile == "ADMIN" && log.LoginUserName == "admin" && metroTextBox1.Text == log.LoginUserName && metroTextBox2.Text == log.LoginPassword)
                {
                    user = metroTextBox1.Text;
                    FormMain.ActiveForm.Hide();
                    new FormAdmin().Show();
                    metroTextBox1.Clear();
                    metroTextBox2.Clear();
                }
                if (log.Profile != "ADMIN")
                {
                    if (log.Profile == "DOCTOR" && metroTextBox1.Text == log.LoginUserName && metroTextBox2.Text == log.LoginPassword)
                    {
                        user = metroTextBox1.Text;
                        FormMain.ActiveForm.Hide();
                        new FormDoctor().Show();
                        metroTextBox1.Clear();
                        metroTextBox2.Clear();
                    }
                }
                if (log.Profile != "ADMIN" && log.Profile != "DOCTOR")
                {
                    if (log.Profile == "ACCOUNTANT" && metroTextBox1.Text == log.LoginUserName && metroTextBox2.Text == log.LoginPassword)
                    {
                        user = metroTextBox1.Text;
                        FormMain.ActiveForm.Hide();
                        new FormAccountant().Show();
                        metroTextBox1.Clear();
                        metroTextBox2.Clear();
                    }
                }
                if (log.Profile != "ADMIN" && log.Profile != "DOCTOR" && log.Profile != "ACCOUNTANT")
                {
                    if (log.Profile == "RECEPTIONIST" && metroTextBox1.Text == log.LoginUserName && metroTextBox2.Text == log.LoginPassword)
                    {
                        user = metroTextBox1.Text;
                        FormMain.ActiveForm.Hide();
                        new FormReceptionist().Show();
                        metroTextBox1.Clear();
                        metroTextBox2.Clear();
                        
                    }
                }
                
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Incorrect Username or Password", "Halt!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                metroTextBox1.Clear();
                metroTextBox2.Clear();
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
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
            metroTile1.Text = clock;
            metroTile2.Text = date;
        }

        private void metroPanelLoginBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            metroPanelLoginBody.Show();
            metroPanelLoginBody.BringToFront();
        }
    }
}
