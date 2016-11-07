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
using HospitalManagementSystem.UI.Receptionist.UI;

namespace HospitalManagementSystem.UI.Receptionist.UC
{
    public partial class UserControlReceptionistProfile : UserControl
    {
        private static UserControlReceptionistProfile _instance;
        public static UserControlReceptionistProfile Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlReceptionistProfile();
                return _instance;
            }
        }
        public UserControlReceptionistProfile()
        {
            InitializeComponent();
            metroPanelReceptionistProfileChangePassword.Hide();
            hmsDataContext dbcon = new hmsDataContext();
            Receptionist_ rec = dbcon.Receptionist_s.SingleOrDefault(x => x.ReceptionistUsername == FormMain.user);
            metroLabel2.Text = rec.ReceptionistName;
            metroLabel7.Text = rec.ReceptionistAddress;
            metroLabel8.Text = rec.ReceptionistPhone;
            metroLabel10.Text = FormMain.user;
        }

        private void metroPanelReceptionistProfile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTextButtonReceptionistProfileInformation_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTextButtonReceptionistUpdateProfile_Click(object sender, EventArgs e)
        {
            metroPanelReceptionistProfileChangePassword.Show();
        }

        private void metroPanelReceptionistButton_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTextButtonReceptionistChangePassword_Click(object sender, EventArgs e)
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
                        //FormReceptionist.ActiveForm.Dispose();
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

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            metroTextBox1.Clear();
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {
            metroTextBox2.Clear();
        }

        private void metroTextBox7_Click(object sender, EventArgs e)
        {
            metroTextBox7.Clear();
        }
    }
}
