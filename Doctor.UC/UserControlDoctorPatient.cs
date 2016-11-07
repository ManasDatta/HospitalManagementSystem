using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagementSystem.UI.Doctor.UI;

namespace HospitalManagementSystem.UI.Doctor.UC
{
    public partial class UserControlDoctorPatient : UserControl
    {
        private static UserControlDoctorPatient _instance;
        public static UserControlDoctorPatient Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlDoctorPatient();
                return _instance;
            }
        }
        public UserControlDoctorPatient()
        {
            InitializeComponent();
        }

        private void metroTextButtonDoctorPatientList_Click(object sender, EventArgs e)
        {
            FormDoctor.ActiveForm.Hide();
            new DoctorPatientList().Show();
        }
    }
}
