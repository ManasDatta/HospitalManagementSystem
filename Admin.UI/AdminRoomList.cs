using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.UI.Admin.UI
{
    public partial class AdminRoomList : MetroFramework.Forms.MetroForm
    {
        public AdminRoomList()
        {
            InitializeComponent();
        }

        private void AdminRoomList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.hMSDataSet.Room);
            // TODO: This line of code loads data into the 'hMSDataSet.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.hMSDataSet.Room);

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            AdminRoomList.ActiveForm.Hide();
            new FormAdmin().Show();
        }
    }
}
