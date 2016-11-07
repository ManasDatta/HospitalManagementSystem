using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagementSystem.UI.Doctor.UI;
using HospitalManagementSystem.UI.Login.UI;
using MetroFramework;

namespace HospitalManagementSystem.UI.Doctor.UC
{
    public partial class UserControlDoctorProfile : UserControl
    {
        private static UserControlDoctorProfile _instance;
        public static UserControlDoctorProfile Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlDoctorProfile();
                return _instance;
            }
        }
        public UserControlDoctorProfile()
        {
            InitializeComponent();
            metroPanelDoctorProfileChangePassword.Hide();
            hmsDataContext dbcon = new hmsDataContext();
            Doctor_ doc = dbcon.Doctor_s.SingleOrDefault(x => x.DoctorUsername == FormMain.user);
            metroLabel2.Text = doc.DoctorName;
            metroLabel7.Text = doc.DoctorAddress;
            metroLabel8.Text = doc.DoctorPhone;
            metroLabel10.Text = FormMain.user;
        }

        private void metroTextButtonDoctorProfileInformation_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTextButtonDoctorUpdateProfile_Click(object sender, EventArgs e)
        {
            metroPanelDoctorProfileChangePassword.Show();
        }

        private void metroPanelDoctorProfile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroPanelDoctorProfileButton_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTextButtonDoctorChangePassword_Click(object sender, EventArgs e)
        {
            hmsDataContext dbcon = new hmsDataContext();
            if (dbcon.Login_s.Any(x => x.LoginUserName == FormMain.user && x.LoginPassword == metroTextBox2.Text) == true)
            {
                if (metroTextBox7.Text.Length < 6)
                {
                    MetroMessageBox.Show(this, "Please, select a password with at least 6 characters.", "Warning!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                }
                else if (metroTextBox7.Text != metroTextBox1.Text)
                {
                    MetroMessageBox.Show(this, "Password doesn't match.", "Halt!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                else
                {
                    Login_ lg = new Login_();
                    lg = dbcon.Login_s.SingleOrDefault(x => x.LoginUserName == FormMain.user);

                    if (lg != null)
                    {
                        lg.LoginUserName = metroLabel10.Text;
                        lg.LoginPassword = metroTextBox1.Text;
                        dbcon.SubmitChanges();
                        //MetroMessageBox.Show(this, "Your password has been changed successfully. Please login with your new password.", "Congratulation!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        //this.Dispose();
                        //FormDoctor.ActiveForm.Dispose();
                        //new FormMain().Show();
                        MetroMessageBox.Show(this, "Your password has been changed successfully. Please restart the application and login with your new password.", "Congratulation!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Application.Exit();
                    }
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Your password is incorrect.", "Halt!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {
            metroTextBox2.Clear();
        }

        private void metroTextBox7_Click(object sender, EventArgs e)
        {
            metroTextBox7.Clear();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            metroTextBox1.Clear();
        }
    }
}
