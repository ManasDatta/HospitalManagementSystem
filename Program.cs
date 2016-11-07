using HospitalManagementSystem.UI.Accountant.UI;
using HospitalManagementSystem.UI.Admin.UI;
using HospitalManagementSystem.UI.Doctor.UI;
using HospitalManagementSystem.UI.Login.UI;
using HospitalManagementSystem.UI.Receptionist.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>s
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login.UI.FormMain());
        }
    }
}
