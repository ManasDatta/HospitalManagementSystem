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
    public partial class UserControlAdminAddDoctor : UserControl
    {
        private static UserControlAdminAddDoctor _instance;
        public static UserControlAdminAddDoctor Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlAdminAddDoctor();
                return _instance;
            }
        }

        public UserControlAdminAddDoctor()
        {
            InitializeComponent();
            hmsDataContext dbcon = new hmsDataContext();
            Department p = new Department();
            metroComboBox3.DataSource = dbcon.Departments;
            metroComboBox3.ValueMember = "DepartmentName";
        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void metroTextButtonAddDoctorConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                hmsDataContext dbcon = new hmsDataContext();
                Doctor_ dc = new Doctor_();
                Login_ lg = new Login_();
                Salary_ sl = new Salary_();
                Department dp = new Department();

                dc.DoctorName = metroTextBox1.Text;
                dc.DoctorEmail = metroTextBox3.Text;
                dc.DoctorAddress = metroTextBox6.Text;
                dc.DoctorPhone = metroTextBox7.Text;
                dc.DoctorUsername = metroTextBox9.Text;
                dc.DoctorProfile = metroComboBox1.Text;
                dc.DoctorGender = metroComboBox2.Text;
                dc.DoctorAge = metroTextBox5.Text;
                dc.DoctorSalary = metroTextBox8.Text;

                lg.LoginPassword = metroTextBox10.Text;
                lg.LoginUserName = metroTextBox9.Text;
                lg.Profile = metroComboBox1.Text;

                sl.Name = metroTextBox1.Text;
                sl.Salary = metroTextBox8.Text;
                sl.Profile = metroComboBox1.Text;
                dc.DoctorDepartmentName = metroComboBox3.Text;
                dbcon.Doctor_s.InsertOnSubmit(dc);
                dbcon.Login_s.InsertOnSubmit(lg);
                dbcon.Salary_s.InsertOnSubmit(sl);
                dbcon.SubmitChanges();
                // MessageBox.Show("Succesfully saved!!");
                MetroMessageBox.Show(this, "Succesfully Saved.", "Congratulation!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                metroTextBox1.Clear();
                metroTextBox3.Clear();
                metroTextBox5.Clear();
                metroTextBox6.Clear();
                metroTextBox7.Clear();
                metroTextBox8.Clear();
                metroTextBox9.Clear();
                metroTextBox10.Clear();
                metroComboBox1.SelectedItem = null;
                metroComboBox2.SelectedItem = null;
                metroComboBox3.SelectedItem = null;
            }

            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Username already exist.", "Halt!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                metroTextBox9.Clear();
                // metroTextBox2.Clear();
            }
       
        }

        private void metroPanelAdminAddDoctor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox8_Click(object sender, EventArgs e)
        {
            metroTextBox8.Clear();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            metroTextBox1.Clear();
        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {
            metroTextBox3.Clear();
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

        private void metroTextBox9_Click(object sender, EventArgs e)
        {
            metroTextBox9.Clear();
        }

        private void metroTextBox10_Click(object sender, EventArgs e)
        {
            metroTextBox10.Clear();
        }
    }
}
