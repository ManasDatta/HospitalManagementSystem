using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace HospitalManagementSystem.UI.Admin.UC
{
    public partial class UserControlAdminAddAccountant : UserControl
    {
        private static UserControlAdminAddAccountant _instance;
        public static UserControlAdminAddAccountant Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlAdminAddAccountant();
                return _instance;
            }
        }
        public UserControlAdminAddAccountant()
        {
            InitializeComponent();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroTextButtonAddAccountantConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                hmsDataContext dbcon = new hmsDataContext();
                Accountant_ ac = new Accountant_();
                Login_ lg = new Login_();
                Salary_ sl = new Salary_();

                ac.AccountantName = metroTextBox1.Text;
                ac.AccountantAddress = metroTextBox3.Text;
                ac.AccountantPhone = metroTextBox4.Text;
                ac.AccountantUsername = metroTextBox6.Text;
                ac.AccountantProfile = metroComboBox1.Text;
                ac.AccountantSalary = metroTextBox5.Text;

                lg.LoginPassword = metroTextBox7.Text;
                lg.LoginUserName = metroTextBox6.Text;
                lg.Profile = metroComboBox1.Text;

                sl.Name = metroTextBox1.Text;
                sl.Salary = metroTextBox5.Text;
                sl.Profile = metroComboBox1.Text;

                dbcon.Salary_s.InsertOnSubmit(sl);
                dbcon.Login_s.InsertOnSubmit(lg);
                dbcon.Accountant_s.InsertOnSubmit(ac);
                dbcon.SubmitChanges();

                // MessageBox.Show("Succesfully saved!!");
                MetroMessageBox.Show(this, "Succesfully Saved.", "Congratulation!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                metroTextBox1.Clear();
                metroTextBox3.Clear();
                metroTextBox4.Clear();
                metroTextBox5.Clear();
                metroTextBox6.Clear();
                metroTextBox7.Clear();
                metroComboBox1.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Username already exist.", "Halt!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                metroTextBox6.Clear();
               
            }

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            metroTextBox1.Clear();
        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {
            metroTextBox3.Clear();
        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {
            metroTextBox4.Clear();
        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {
            metroTextBox5.Clear();
        }

        private void metroTextBox6_Click(object sender, EventArgs e)
        {
            metroTextBox6.Clear();
        }

        private void metroTextBox7_Click(object sender, EventArgs e)
        {
            metroTextBox7.Clear();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
 