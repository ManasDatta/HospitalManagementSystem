using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagementSystem.UI.Accountant.UI;

namespace HospitalManagementSystem.UI.Accountant.UC
{
    public partial class UserControlAccountantInvoice : UserControl
    {
        private static UserControlAccountantInvoice _instance;
        public static UserControlAccountantInvoice Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlAccountantInvoice();
                return _instance;
            }
        }
        public UserControlAccountantInvoice()
        {
            InitializeComponent();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTextButtonAccountantInvoiceList_Click(object sender, EventArgs e)
        {
            FormAccountant.ActiveForm.Hide();
            new AccountantInvoiceList().Show();

        }

        private void metroTextButtonAccountantAddInvoice_Click(object sender, EventArgs e)
        {
            if (!metroPanelAccountantInvoice.Controls.Contains(UserControlAccountantCreateInvoice.Instance))
            {
                metroPanelAccountantInvoice.Controls.Add(UserControlAccountantCreateInvoice.Instance);
                UserControlAccountantCreateInvoice.Instance.Dock = DockStyle.Fill;
                UserControlAccountantCreateInvoice.Instance.BringToFront();
            }
            else
            {
                UserControlAccountantCreateInvoice.Instance.BringToFront();
            }
        }
    }
}
