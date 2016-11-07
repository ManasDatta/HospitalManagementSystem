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
    public partial class UserControlAccountantSalary : UserControl
    {
        private static UserControlAccountantSalary _instance;
        public static UserControlAccountantSalary Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControlAccountantSalary();
                return _instance;
            }
        }
        public UserControlAccountantSalary()
        {
            InitializeComponent();
        }

        private void metroTextButtonAccountantSalaryList_Click(object sender, EventArgs e)
        {
            FormAccountant.ActiveForm.Hide();
            new AccountantSalaryList().Show();

        }
    }
}
