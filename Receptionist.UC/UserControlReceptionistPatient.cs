using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagementSystem.UI.Receptionist.UI;

namespace HospitalManagementSystem.UI.Receptionist.UC
{
    public partial class UserControlReceptionistPatient : UserControl
    {
        private static UserControlReceptionistPatient _instance;
        public static UserControlReceptionistPatient Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlReceptionistPatient();
                return _instance;
            }
        }
        public UserControlReceptionistPatient()
        {
            InitializeComponent();
        }

        private void metroTextButtonReceptionistPatientList_Click(object sender, EventArgs e)
        {
            FormReceptionist.ActiveForm.Hide();
            new ReceptionistPatientList().Show();
        }

        private void metroTextButtonReceptionistAddPatient_Click(object sender, EventArgs e)
        {
            if (!metroPanelReceptionistPatient.Controls.Contains(UserControlReceptionistAddPatient.Instance))
            {
                metroPanelReceptionistPatient.Controls.Add(UserControlReceptionistAddPatient.Instance);
                UserControlReceptionistAddPatient.Instance.Dock = DockStyle.Fill;
                UserControlReceptionistAddPatient.Instance.BringToFront();
            }
            else
            {
                UserControlReceptionistAddPatient.Instance.BringToFront();
            }
        }
    }
}
