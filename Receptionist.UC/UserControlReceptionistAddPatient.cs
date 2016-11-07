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

namespace HospitalManagementSystem.UI.Receptionist.UC
{
    public partial class UserControlReceptionistAddPatient : UserControl
    {
        private static UserControlReceptionistAddPatient _instance;
        public static UserControlReceptionistAddPatient Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlReceptionistAddPatient();
                return _instance;
            }
        }
        public UserControlReceptionistAddPatient()
        {
            InitializeComponent();
            hmsDataContext dbcon = new hmsDataContext();
            Doctor_ p = new Doctor_();
            metroComboBox4.DataSource = dbcon.Doctor_s;
            metroComboBox4.ValueMember = "DoctorName";
            RoomAvailability();

        }
        public void RoomAvailability()
        {
            hmsDataContext dbcon = new hmsDataContext();
            Room r = dbcon.Rooms.SingleOrDefault(x => x.RoomNo == "101 (STANDARD-1)");
            if (r != null)
                metroComboBox1.Items.Remove("101 (STANDARD-1)");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomNo == "102 (STANDARD-2)");
            if (r != null)
                metroComboBox1.Items.Remove("102 (STANDARD-2)");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomNo == "103 (STANDARD-3)");
            if (r != null)
                metroComboBox1.Items.Remove("103 (STANDARD-3)");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomNo == "104 (STANDARD-4)");
            if (r != null)
                metroComboBox1.Items.Remove("104 (STANDARD-4)");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomNo == "105 (STANDARD-5)");
            if (r != null)
                metroComboBox1.Items.Remove("105 (STANDARD-5)");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomNo == "106 (STANDARD-6)");
            if (r != null)
                metroComboBox1.Items.Remove("106 (STANDARD-6)");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomNo == "107 (STANDARD-7)");
            if (r != null)
                metroComboBox1.Items.Remove("107 (STANDARD-7)");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomNo == "201 (SEMI-PRIVATE-1)");
            if (r != null)
                metroComboBox1.Items.Remove("201 (SEMI-PRIVATE-1)");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomNo == "202 (SEMI-PRIVATE-2)");
            if (r != null)
                metroComboBox1.Items.Remove("202 (SEMI-PRIVATE-2)");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomNo == "203 (SEMI-PRIVATE-3)");
            if (r != null)
                metroComboBox1.Items.Remove("203 (SEMI-PRIVATE-3)");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomNo == "204 (SEMI-PRIVATE-4)");
            if (r != null)
                metroComboBox1.Items.Remove("204 (SEMI-PRIVATE-4)");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomNo == "205 (SEMI-PRIVATE-5)");
            if (r != null)
                metroComboBox1.Items.Remove("205 (SEMI-PRIVATE-5)");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomNo == "206 (SEMI-PRIVATE-6)");
            if (r != null)
                metroComboBox1.Items.Remove("206 (SEMI-PRIVATE-6)");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomNo == "301 (PRIVATE-1)");
            if (r != null)
                metroComboBox1.Items.Remove("301 (PRIVATE-1)");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomNo == "302 (PRIVATE-2)");
            if (r != null)
                metroComboBox1.Items.Remove("302 (PRIVATE-2)");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomNo == "303 (PRIVATE-3)");
            if (r != null)
                metroComboBox1.Items.Remove("303 (PRIVATE-3)");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomNo == "304 (PRIVATE-4)");
            if (r != null)
                metroComboBox1.Items.Remove("304 (PRIVATE-4)");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomNo == "305 (PRIVATE-5)");
            if (r != null)
                metroComboBox1.Items.Remove("305 (PRIVATE-5)");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomNo == "401 (DELUXE SUITE-1)");
            if (r != null)
                metroComboBox1.Items.Remove("401 (DELUXE SUITE-1)");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomNo == "402 (DELUXE SUITE-2)");
            if (r != null)
                metroComboBox1.Items.Remove("402 (DELUXE SUITE-2)");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomNo == "403 (DELUXE SUITE-3)");
            if (r != null)
                metroComboBox1.Items.Remove("403 (DELUXE SUITE-3)");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomNo == "501 (EMERGENCY ROOM-1)");
            if (r != null)
                metroComboBox1.Items.Remove("501 (EMERGENCY ROOM-1)");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomNo == "502 (EMERGENCY ROOM-2)");
            if (r != null)
                metroComboBox1.Items.Remove("502 (EMERGENCY ROOM-2)");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomNo == "601 (INTENSIVE CARE-1)");
            if (r != null)
                metroComboBox1.Items.Remove("601 (INTENSIVE CARE-1))");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomNo == "602 (INTENSIVE CARE-2)");
            if (r != null)
                metroComboBox1.Items.Remove("602 (INTENSIVE CARE-2)");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomNo == "701 (OPERATION THEATER-1)");
            if (r != null)
                metroComboBox1.Items.Remove("701 (OPERATION THEATER-1)");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomNo == "702 (OPERATION THEATER-2)");
            if (r != null)
                metroComboBox1.Items.Remove("702 (OPERATION THEATER-2)");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomNo == "801 (SURGERY-1)");
            if (r != null)
                metroComboBox1.Items.Remove("801 (SURGERY-1)");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomNo == "802 (SURGERY-2)");
            if (r != null)
                metroComboBox1.Items.Remove("802 (SURGERY-2)");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomNo == "901 (ICU)");
            if (r != null)
                metroComboBox1.Items.Remove("901 (ICU)");




            /*---------------------------------type availability------------------------
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomType == "STANDARD-1");
            if (r != null)
                metroComboBox2.Items.Remove("STANDARD-1");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomType == "STANDARD-2");
            if (r != null)
                metroComboBox2.Items.Remove("STANDARD-2");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomType == "STANDARD-3");
            if (r != null)
                metroComboBox2.Items.Remove("STANDARD-3");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomType == "STANDARD-4");
            if (r != null)
                metroComboBox2.Items.Remove("STANDARD-4");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomType == "STANDARD-5");
            if (r != null)
                metroComboBox2.Items.Remove("STANDARD-5");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomType == "STANDARD-6");
            if (r != null)
                metroComboBox2.Items.Remove("STANDARD-6");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomType == "STANDARD-7");
            if (r != null)
                metroComboBox2.Items.Remove("STANDARD-7");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomType == "SEMI-PRIVATE-1");
            if (r != null)
                metroComboBox2.Items.Remove("SEMI-PRIVATE-1");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomType == "SEMI-PRIVATE-2");
            if (r != null)
                metroComboBox2.Items.Remove("SEMI-PRIVATE-2");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomType == "SEMI-PRIVATE-3");
            if (r != null)
                metroComboBox2.Items.Remove("SEMI-PRIVATE-3");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomType == "SEMI-PRIVATE-4");
            if (r != null)
                metroComboBox2.Items.Remove("SEMI-PRIVATE-4");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomType == "SEMI-PRIVATE-5");
            if (r != null)
                metroComboBox2.Items.Remove("SEMI-PRIVATE-5");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomType == "SEMI-PRIVATE-6");
            if (r != null)
                metroComboBox2.Items.Remove("SEMI-PRIVATE-6");          
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomType == "PRIVATE-1");
            if (r != null)
                metroComboBox2.Items.Remove("PRIVATE-1");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomType == "PRIVATE-2");
            if (r != null)
                metroComboBox2.Items.Remove("PRIVATE-2");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomType == "PRIVATE-3");
            if (r != null)
                metroComboBox2.Items.Remove("PRIVATE-3");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomType == "PRIVATE-4");
            if (r != null)
                metroComboBox2.Items.Remove("PRIVATE-4");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomType == "PRIVATE-5");
            if (r != null)
                metroComboBox2.Items.Remove("PRIVATE-5");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomType == "DELUXE SUITE-1");
            if (r != null)
                metroComboBox2.Items.Remove("DELUXE SUITE-1");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomType == "DELUXE SUITE-2");
            if (r != null)
                metroComboBox2.Items.Remove("DELUXE SUITE-2");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomType == "DELUXE SUITE-3");
            if (r != null)
                metroComboBox2.Items.Remove("DELUXE SUITE-3");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomType == "EMERGENCY ROOM-1");
            if (r != null)
                metroComboBox2.Items.Remove("EMERGENCY ROOM-1");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomType == "EMERGENCY ROOM-2");
            if (r != null)
                metroComboBox2.Items.Remove("EMERGENCY ROOM-2");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomType == "INTENSIVE CARE-1");
            if (r != null)
                metroComboBox2.Items.Remove("INTENSIVE CARE-1");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomType == "INTENSIVE CARE-2");
            if (r != null)
                metroComboBox2.Items.Remove("INTENSIVE CARE-2");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomType == "OPERATION THEATER-1");
            if (r != null)
                metroComboBox2.Items.Remove("OPERATION THEATER-1");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomType == "OPERATION THEATER-2");
            if (r != null)
                metroComboBox2.Items.Remove("OPERATION THEATER-2");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomType == "SURGERY-1");
            if (r != null)
                metroComboBox2.Items.Remove("SURGERY-1");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomType == "SURGERY-2");
            if (r != null)
                metroComboBox2.Items.Remove("SURGERY-2");
            r = dbcon.Rooms.SingleOrDefault(x => x.RoomType == "ICU");
            if (r != null)
                metroComboBox2.Items.Remove("ICU");

            //-----------------------------------------------end------------------------*/
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroTextButtonAddPatientConfirm_Click(object sender, EventArgs e)
        {
            try {
                hmsDataContext dbcon = new hmsDataContext();
                Patient pt = new Patient();
                Room rm = new Room();

                pt.PatientName = metroTextBox1.Text;
                pt.PatientAddress = metroTextBox3.Text;
                pt.PatientPhone = metroTextBox4.Text;
                pt.PatientBloodGroup = metroComboBox2.Text;
                pt.PatientDateOfBirth = metroDateTime3.Text;
                pt.PatientDoctorName = metroComboBox4.Text;
                pt.PatientGender = metroComboBox3.Text;
                pt.PatientAge = metroTextBox7.Text;
                pt.PatientRoomNo = metroComboBox1.Text;
                pt.PatientDateOfAdmission = metroDateTime1.Text;

                rm.RoomNo = metroComboBox1.Text;
                //rm.RoomType = metroComboBox2.Text;
                /* if (rm.RoomNo == metroComboBox1.Text)
                {
                    rm.RoomDateOfAdmission = metroDateTime1.Text;
                }*/
                dbcon.Patients.InsertOnSubmit(pt);
                dbcon.Rooms.InsertOnSubmit(rm);
                dbcon.SubmitChanges();

                // MessageBox.Show("Succesfully saved!!");
                MetroMessageBox.Show(this, "Succesfully Saved.", "Congratulation!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                metroTextBox1.Clear();
                metroTextBox3.Clear();
                metroTextBox4.Clear();
                metroTextBox7.Clear();
                metroComboBox1.SelectedItem = null;
                metroComboBox2.SelectedItem = null;
                metroComboBox3.SelectedItem = null;
                metroComboBox4.SelectedItem = null;
                RoomAvailability();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Please insert all section.", "Warning!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void metroLabel10_Click(object sender, EventArgs e)
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

        private void metroTextBox7_Click(object sender, EventArgs e)
        {
            metroTextBox7.Clear();
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
