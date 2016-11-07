using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using HospitalManagementSystem.UI.Admin.UI;
using HospitalManagementSystem.UI.Login.UI;
using MetroFramework;

namespace HospitalManagementSystem.UI.Admin.UC
{
    
    public partial class UserControlAdminProfile : UserControl
    {
        private static UserControlAdminProfile _instance;
        public static UserControlAdminProfile Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlAdminProfile();
                return _instance;
            }
        }
        public UserControlAdminProfile()
        {
            InitializeComponent();
            metroPanelAdminProfileChangePassword.Hide();


            hmsDataContext dbcon = new hmsDataContext();
            Admin_ ad = dbcon.Admin_s.SingleOrDefault(x => x.AdminUsername == FormMain.user);
            
            metroLabel2.Text = ad.AdminName;
            metroLabel7.Text = ad.AdminAddress;
            metroLabel8.Text = ad.AdminPhone;
            metroLabel10.Text = FormMain.user;
        }
        
        private void metroTextButtonAdminProfileInformation_Click(object sender, EventArgs e)
        {
           
        }

        private void metroTextButtonAdminUpdateInformation_Click(object sender, EventArgs e)
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

                    if(lg != null)
                    {
                        lg.LoginUserName = metroLabel10.Text;
                        lg.LoginPassword = metroTextBox1.Text;
                        dbcon.SubmitChanges();
                        //MetroMessageBox.Show(this, "Your password has been changed successfully. Please login with your new password.", "Congratulation!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        //this.Dispose();
                        //FormAdmin.ActiveForm.Dispose();
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

        private void metroTextButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextButton2_Click(object sender, EventArgs e)
        {
            metroPanelAdminProfileChangePassword.Show();
        }

        private void metroPanelAdminProfileButton_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroPanelAdminProfile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox7_Click(object sender, EventArgs e)
        {
            metroTextBox7.Clear();
        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            metroTextBox1.Clear();
        }

        private void metroLabel12_Click(object sender, EventArgs e)
        {

        }

        private void UserControlAdminProfile_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {
            metroTextBox2.Clear();
        }
    }
}
