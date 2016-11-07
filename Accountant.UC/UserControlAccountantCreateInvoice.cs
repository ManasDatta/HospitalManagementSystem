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
using HospitalManagementSystem.UI.Accountant.UI;
using HospitalManagementSystem.UI.Receptionist.UI;

namespace HospitalManagementSystem.UI.Accountant.UC
{
    public partial class UserControlAccountantCreateInvoice : UserControl
    {
        private static UserControlAccountantCreateInvoice _instance;
        public static UserControlAccountantCreateInvoice Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlAccountantCreateInvoice();
                return _instance;
            }
        }
        
        public UserControlAccountantCreateInvoice()
        {
            InitializeComponent();

            hmsDataContext dbcon = new hmsDataContext();
            /*-----------------------------------------------
            Patient pat = dbcon.Patients.SingleOrDefault(x => x.PatientName == metroTextBox3.Text);
            if (pat.PatientName == metroTextBox3.Text)
            {
                //metroComboBox2.DataSource = dbcon.Patients;
                //metroComboBox2.ValueMember = "PatientDoctorName";
                metroTextBox8.Text = pat.PatientDoctorName;

                //metroComboBox1.DataSource = dbcon.Rooms;
                //metroComboBox1.ValueMember = "PatientRoomNo";
                metroTextBox9.Text = pat.PatientRoomNo;

                metroTextBox10.Text = pat.PatientDateOfAdmission;

            }
            //metroComboBox2.DataSource = dbcon.Patients;
            //metroComboBox2.ValueMember = "PatientDoctorName";

            //metroComboBox1.DataSource = dbcon.Rooms;
            //metroComboBox1.ValueMember = "PatientRoomNo";

            //metroDateTime1.Text = "PatientAdmissionDate";
            //--------------------------------------------------*/

            Patient p = new Patient();
            metroComboBox2.DataSource = dbcon.Doctor_s;
            metroComboBox2.ValueMember = "DoctorName";

            metroComboBox1.DataSource = dbcon.Rooms;
            metroComboBox1.ValueMember = "RoomNo";

        }
        public static string invoice = "";
        private void metroPanelAccountantAddInvoice_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void metroTextButtonAddInvoiceConfirm_Click(object sender, EventArgs e)
        {
            try {
                hmsDataContext dbcon = new hmsDataContext();
                Invoice inv = new Invoice();

                inv.InvoiceDate = metroDateTime3.Text;
                inv.InvoicePatientName = metroTextBox3.Text;
                inv.InvoiceRoomNo = metroComboBox1.Text;
                inv.InvoiceDateOfAdmission = metroDateTime1.Text;
                inv.InvoiceDateOfRelease = metroDateTime2.Text;
                inv.InvoiceDoctorName = metroComboBox2.Text;
                inv.InvoiceAdmissionCharge = metroTextBox4.Text;
                inv.InvoiceServiceCharge = metroTextBox1.Text;
                inv.InvoiceDoctorFees = metroTextBox2.Text;
                inv.InvoiceRoomChargePerDay = metroTextBox6.Text;
                inv.InvoiceRoomNoOfDays = metroTextBox5.Text;
                

                //---------delete room no and room type----------------//

                String rmm = metroComboBox1.Text;

                var bills = from b in dbcon.Rooms
                            where b.RoomNo == rmm
                            select b;

                dbcon.Rooms.DeleteAllOnSubmit(bills);

                dbcon.SubmitChanges();

                // ------------------------------Billing ---------------------------------//

                double admissioncharge = Convert.ToDouble(metroTextBox4.Text);
                double doctorfees = Convert.ToDouble(metroTextBox2.Text);
                double servicecharge = Convert.ToDouble(metroTextBox1.Text);
                double count = Convert.ToDouble(metroTextBox5.Text);
                double roomcharge = Convert.ToDouble(metroTextBox6.Text);
                double discount = Convert.ToDouble(metroTextBox7.Text);


                double resultWithoutVat,vat,discountMoney,result;

                resultWithoutVat = admissioncharge + doctorfees + servicecharge + (count * roomcharge);
                vat = (resultWithoutVat * 15) / 100;
                result = resultWithoutVat + vat;
                discountMoney = (result * discount) / 100;

                double bill = result - discountMoney;

                //metroTextBox8.Text = Convert.ToString(bill);

                inv.InvoiceVat = Convert.ToString(vat);
                inv.InvoiceDiscount = Convert.ToString(discountMoney);
                inv.InvoiceTotalBill = Convert.ToString(bill);
                dbcon.Invoices.InsertOnSubmit(inv);
                dbcon.SubmitChanges();

                MetroMessageBox.Show(this, "Your Invoice has been generated and Patient Data from Room has cleared Succesfully. To see the bllling form, press 'OK'.", "Congratulation!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                invoice = metroTextBox3.Text;
                //FormMain.ActiveForm.Hide();
                new AccountantPatientBillingForm().Show();

                metroTextBox4.Clear();
                metroTextBox2.Clear();
                metroTextBox1.Clear();
                metroTextBox5.Clear();
                metroTextBox6.Clear();
                metroTextBox7.Clear();
                metroTextBox3.Clear();
                metroComboBox1.SelectedItem = null;
                metroComboBox2.SelectedItem = null;

                //MetroMessageBox.Show(this, "Your Invoice has been generated and Patient Data from Room has cleared Succesfully and total bill is " + bill + " TK.", "Congratulation!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Please insert all required section.", "Warning!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void metroTextBox9_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {
            metroTextBox4.Text = string.Empty;
        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {
            metroTextBox3.Text = string.Empty;
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text = string.Empty;
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {
            metroTextBox2.Text = string.Empty;
        }

        private void metroTextBox6_Click(object sender, EventArgs e)
        {
            metroTextBox6.Text = string.Empty;
        }

        private void metroTextBox5_Click_1(object sender, EventArgs e)
        {
            metroTextBox5.Text = string.Empty;
        }

        private void metroTextBox7_Click(object sender, EventArgs e)
        {
            metroTextBox7.Text = string.Empty;
        }

        private void metroTextBox8_Click(object sender, EventArgs e)
        {

        }
    }
}
