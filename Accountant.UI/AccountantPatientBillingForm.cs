using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.UI.Accountant.UI
{
    public partial class AccountantPatientBillingForm : MetroFramework.Forms.MetroForm
    {
        public AccountantPatientBillingForm()
        {
            InitializeComponent();
            hmsDataContext dbcon = new hmsDataContext();
            Invoice inv = dbcon.Invoices.SingleOrDefault(x => x.InvoicePatientName == Accountant.UC.UserControlAccountantCreateInvoice.invoice);
            metroLabel31.Text = Convert.ToString(inv.InvoiceId);
            metroLabel30.Text = inv.InvoiceDate;
            metroLabel29.Text = Accountant.UC.UserControlAccountantCreateInvoice.invoice;
            metroLabel28.Text = inv.InvoiceDoctorName;
            metroLabel27.Text = inv.InvoiceDateOfAdmission;
            metroLabel26.Text = inv.InvoiceDateOfRelease;
            metroLabel25.Text = inv.InvoiceAdmissionCharge;
            metroLabel24.Text = inv.InvoiceServiceCharge;
            metroLabel23.Text = inv.InvoiceDoctorFees;
            metroLabel22.Text = inv.InvoiceRoomNo;
            metroLabel21.Text = inv.InvoiceRoomChargePerDay;
            metroLabel20.Text = inv.InvoiceRoomNoOfDays;
            metroLabel19.Text = inv.InvoiceVat;
            metroLabel18.Text = inv.InvoiceDiscount;
            metroLabel17.Text = inv.InvoiceTotalBill;
        }

        private void AccountantPatientBillingForm_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel18_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel19_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel20_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel21_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel22_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel23_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel24_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel25_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel26_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel27_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel28_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel29_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel30_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel31_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel16_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel15_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel14_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel13_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel12_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel17_Click(object sender, EventArgs e)
        {

        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(metroLabel32.Text, new Font("Courier New", 14), Brushes.Black, 75, 25);
            e.Graphics.DrawString(metroLabel1.Text, new Font("Courier New", 14, FontStyle.Bold), Brushes.Black, 225, 100);
            e.Graphics.DrawString(metroLabel2.Text, new Font("Courier New", 14), Brushes.Black, 160, 150);
            e.Graphics.DrawString(metroLabel3.Text, new Font("Courier New", 14), Brushes.Black, 160, 175);
            e.Graphics.DrawString(metroLabel4.Text, new Font("Courier New", 14), Brushes.Black, 160, 200);
            e.Graphics.DrawString(metroLabel5.Text, new Font("Courier New", 14), Brushes.Black, 160, 225);
            e.Graphics.DrawString(metroLabel6.Text, new Font("Courier New", 14), Brushes.Black, 160, 250);
            e.Graphics.DrawString(metroLabel7.Text, new Font("Courier New", 14), Brushes.Black, 160, 275);
            e.Graphics.DrawString(metroLabel8.Text, new Font("Courier New", 14), Brushes.Black, 160, 300);
            e.Graphics.DrawString(metroLabel9.Text, new Font("Courier New", 14), Brushes.Black, 160, 325);
            e.Graphics.DrawString(metroLabel10.Text, new Font("Courier New", 14), Brushes.Black, 160, 350);
            e.Graphics.DrawString(metroLabel11.Text, new Font("Courier New", 14), Brushes.Black, 160, 375);
            e.Graphics.DrawString(metroLabel12.Text, new Font("Courier New", 14), Brushes.Black, 160, 400);
            e.Graphics.DrawString(metroLabel13.Text, new Font("Courier New", 14), Brushes.Black, 160, 425);
            e.Graphics.DrawString(metroLabel14.Text, new Font("Courier New", 14), Brushes.Black, 160, 450);
            e.Graphics.DrawString(metroLabel15.Text, new Font("Courier New", 14), Brushes.Black, 160, 475);
            e.Graphics.DrawString(metroLabel16.Text, new Font("Courier New", 14,FontStyle.Bold), Brushes.Black, 160, 500);
            e.Graphics.DrawString(metroLabel31.Text, new Font("Courier New", 14), Brushes.Black, 500, 150);
            e.Graphics.DrawString(metroLabel30.Text, new Font("Courier New", 14), Brushes.Black, 500, 175);
            e.Graphics.DrawString(metroLabel29.Text, new Font("Courier New", 14), Brushes.Black, 500, 200);
            e.Graphics.DrawString(metroLabel28.Text, new Font("Courier New", 14), Brushes.Black, 500, 225);
            e.Graphics.DrawString(metroLabel27.Text, new Font("Courier New", 14), Brushes.Black, 500, 250);
            e.Graphics.DrawString(metroLabel26.Text, new Font("Courier New", 14), Brushes.Black, 500, 275);
            e.Graphics.DrawString(metroLabel25.Text, new Font("Courier New", 14), Brushes.Black, 500, 300);
            e.Graphics.DrawString(metroLabel24.Text, new Font("Courier New", 14), Brushes.Black, 500, 325);
            e.Graphics.DrawString(metroLabel23.Text, new Font("Courier New", 14), Brushes.Black, 500, 350);
            e.Graphics.DrawString(metroLabel22.Text, new Font("Courier New", 14), Brushes.Black, 500, 375);
            e.Graphics.DrawString(metroLabel21.Text, new Font("Courier New", 14), Brushes.Black, 500, 400);
            e.Graphics.DrawString(metroLabel20.Text, new Font("Courier New", 14), Brushes.Black, 500, 425);
            e.Graphics.DrawString(metroLabel19.Text, new Font("Courier New", 14), Brushes.Black, 500, 450);
            e.Graphics.DrawString(metroLabel18.Text, new Font("Courier New", 14), Brushes.Black, 500, 475);
            e.Graphics.DrawString(metroLabel17.Text, new Font("Courier New", 14,FontStyle.Bold), Brushes.Black, 500, 500);
        }
    }
}
