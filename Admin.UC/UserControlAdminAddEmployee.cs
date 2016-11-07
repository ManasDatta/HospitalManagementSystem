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
    public partial class UserControlAdminAddEmployee : UserControl
    {
        private static UserControlAdminAddEmployee _instance;
        public static UserControlAdminAddEmployee Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlAdminAddEmployee();
                return _instance;
            }
        }
        public UserControlAdminAddEmployee()
        {
            InitializeComponent();
        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {
            metroTextBox5.Clear();
        }

        private void metroTextButtonAddEmployeeConfirm_Click(object sender, EventArgs e)
        {

            try {
                hmsDataContext dbcon = new hmsDataContext();
                Employee emp = new Employee();
                Salary_ sl = new Salary_();

                emp.EmployeeName = metroTextBox1.Text;
                emp.EmployeeAddress = metroTextBox3.Text;
                emp.EmployeePhone = metroTextBox4.Text;
                emp.EmployeeSalary = metroTextBox5.Text;
                emp.EmployeeProfile = metroComboBox1.Text;

                sl.Name = metroTextBox1.Text;
                sl.Salary = metroTextBox5.Text;
                sl.Profile = metroComboBox1.Text;

                dbcon.Employees.InsertOnSubmit(emp);
                dbcon.Salary_s.InsertOnSubmit(sl);
                dbcon.SubmitChanges();

                // MessageBox.Show("Succesfully saved!!");
                MetroMessageBox.Show(this, "Succesfully Saved.", "Congratulation!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                metroTextBox1.Clear();
                metroTextBox3.Clear();
                metroTextBox4.Clear();
                metroTextBox5.Clear();
                metroComboBox1.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Please insert all section.", "Warning!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }

        }

        private void metroPanelAdminAddEmployee_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
