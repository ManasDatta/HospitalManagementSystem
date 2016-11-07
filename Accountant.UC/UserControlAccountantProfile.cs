using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagementSystem.UI.Login.UI;
using MetroFramework;
using HospitalManagementSystem.UI.Accountant.UI;

namespace HospitalManagementSystem.UI.Accountant.UC
{
    public partial class UserControlAccountantProfile : UserControl
    {
        private static UserControlAccountantProfile _instance;
        public static UserControlAccountantProfile Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlAccountantProfile();
                return _instance;
            }
        }
        public UserControlAccountantProfile()
        {
            InitializeComponent();
            metroPanelAccountantProfileChangePassword.Hide();
            hmsDataContext dbcon = new hmsDataContext();
            Accountant_ acc = dbcon.Accountant_s.SingleOrDefault(x => x.AccountantUsername == FormMain.user);
            metroLabel2.Text = acc.AccountantName;
            metroLabel7.Text = acc.AccountantAddress;
            metroLabel8.Text = acc.AccountantPhone;
            metroLabel10.Text = FormMain.user;
        }

        private void metroTextButtonAccountantProfileInformation_Click(object sender, EventArgs e)
        {

        }

        private void metroTextButtonAccountantUpdateProfile_Click(object sender, EventArgs e)
        {
            metroPanelAccountantProfileChangePassword.Show();
        }

        private void metroTextButtonAccountantChangePassword_Click(object sender, EventArgs e)
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
                        //FormAccountant.ActiveForm.Dispose();
                        //new FormMain().Show();
                        MetroMessageBox.Show(this, "Your password has been changed successfully. Please restart the application and login with your new password.", "Congratulation!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Application.Exit();
                    }
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Your password is incorrect.", "Halt!!!",MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void metroLabel13_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            metroTextBox1.Clear();
        }

        private void metroLabel12_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox7_Click(object sender, EventArgs e)
        {
            metroTextBox7.Clear();
        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {
            metroTextBox2.Clear();
        }
    }
}
