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
    public partial class UserControlAdminAddReceptionist : UserControl
    {
        private static UserControlAdminAddReceptionist _instance;
        public static UserControlAdminAddReceptionist Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlAdminAddReceptionist();
                return _instance;
            }
        }
        public UserControlAdminAddReceptionist()
        {
            InitializeComponent();
        }

        private void metroTextButtonAddReceptionistConfirm_Click(object sender, EventArgs e)
        {
            try {
                hmsDataContext dbcon = new hmsDataContext();
                Receptionist_ rs = new Receptionist_();
                Login_ lg = new Login_();
                Salary_ sl = new Salary_();

                rs.ReceptionistName = metroTextBox1.Text;
                rs.ReceptionistAddress = metroTextBox3.Text;
                rs.ReceptionistPhone = metroTextBox4.Text;
                rs.ReceptionistUsername = metroTextBox6.Text;
                rs.ReceptionistProfile = metroComboBox1.Text;
                rs.ReceptionistSalary = metroTextBox5.Text;

                lg.LoginPassword = metroTextBox7.Text;
                lg.LoginUserName = metroTextBox6.Text;
                lg.Profile = metroComboBox1.Text;

                sl.Name = metroTextBox1.Text;
                sl.Salary = metroTextBox5.Text;
                sl.Profile = metroComboBox1.Text;

                dbcon.Receptionist_s.InsertOnSubmit(rs);
                dbcon.Login_s.InsertOnSubmit(lg);
                dbcon.Salary_s.InsertOnSubmit(sl);
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
    }
}
