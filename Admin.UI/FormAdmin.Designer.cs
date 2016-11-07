namespace HospitalManagementSystem.UI.Admin.UI
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.metroPanelAdminMenu = new MetroFramework.Controls.MetroPanel();
            this.metroTextButtonAdminRoom = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButtonDepartment = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButtonDoctor = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButtonPatient = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButtonProfile = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButtonReceptionist = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButtonAccountant = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButtonEmployee = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButtonDashboard = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroPanelAdminBody = new MetroFramework.Controls.MetroPanel();
            this.metroTileAdminRoom = new MetroFramework.Controls.MetroTile();
            this.metroTileAdminProfile = new MetroFramework.Controls.MetroTile();
            this.metroTileAdminDepartment = new MetroFramework.Controls.MetroTile();
            this.metroTileAdminReceptionist = new MetroFramework.Controls.MetroTile();
            this.metroTileAdminDoctor = new MetroFramework.Controls.MetroTile();
            this.metroTileAdminAccountant = new MetroFramework.Controls.MetroTile();
            this.metroTileAdminPatient = new MetroFramework.Controls.MetroTile();
            this.metroTileAdminEmployee = new MetroFramework.Controls.MetroTile();
            this.metroTileAdminDate = new MetroFramework.Controls.MetroTile();
            this.metroTileAdminTime = new MetroFramework.Controls.MetroTile();
            this.metroTileAdminLogOut = new MetroFramework.Controls.MetroTile();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroPanelAdminMenu.SuspendLayout();
            this.metroPanelAdminBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanelAdminMenu
            // 
            this.metroPanelAdminMenu.Controls.Add(this.metroTextButtonAdminRoom);
            this.metroPanelAdminMenu.Controls.Add(this.metroTextButtonDepartment);
            this.metroPanelAdminMenu.Controls.Add(this.metroTextButtonDoctor);
            this.metroPanelAdminMenu.Controls.Add(this.metroTextButtonPatient);
            this.metroPanelAdminMenu.Controls.Add(this.metroTextButtonProfile);
            this.metroPanelAdminMenu.Controls.Add(this.metroTextButtonReceptionist);
            this.metroPanelAdminMenu.Controls.Add(this.metroTextButtonAccountant);
            this.metroPanelAdminMenu.Controls.Add(this.metroTextButtonEmployee);
            this.metroPanelAdminMenu.Controls.Add(this.metroTextButtonDashboard);
            this.metroPanelAdminMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanelAdminMenu.HorizontalScrollbarBarColor = true;
            this.metroPanelAdminMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelAdminMenu.HorizontalScrollbarSize = 10;
            this.metroPanelAdminMenu.Location = new System.Drawing.Point(20, 60);
            this.metroPanelAdminMenu.Name = "metroPanelAdminMenu";
            this.metroPanelAdminMenu.Size = new System.Drawing.Size(250, 470);
            this.metroPanelAdminMenu.TabIndex = 0;
            this.metroPanelAdminMenu.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelAdminMenu.VerticalScrollbarBarColor = true;
            this.metroPanelAdminMenu.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelAdminMenu.VerticalScrollbarSize = 10;
            this.metroPanelAdminMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanelAdminMenu_Paint);
            // 
            // metroTextButtonAdminRoom
            // 
            this.metroTextButtonAdminRoom.Image = null;
            this.metroTextButtonAdminRoom.Location = new System.Drawing.Point(0, 357);
            this.metroTextButtonAdminRoom.Name = "metroTextButtonAdminRoom";
            this.metroTextButtonAdminRoom.Size = new System.Drawing.Size(250, 50);
            this.metroTextButtonAdminRoom.TabIndex = 10;
            this.metroTextButtonAdminRoom.Text = "Room";
            this.metroTextButtonAdminRoom.UseSelectable = true;
            this.metroTextButtonAdminRoom.UseVisualStyleBackColor = true;
            this.metroTextButtonAdminRoom.Click += new System.EventHandler(this.metroTextButtonAdminRoom_Click);
            // 
            // metroTextButtonDepartment
            // 
            this.metroTextButtonDepartment.Image = null;
            this.metroTextButtonDepartment.Location = new System.Drawing.Point(0, 51);
            this.metroTextButtonDepartment.Name = "metroTextButtonDepartment";
            this.metroTextButtonDepartment.Size = new System.Drawing.Size(250, 50);
            this.metroTextButtonDepartment.TabIndex = 9;
            this.metroTextButtonDepartment.Text = "Department";
            this.metroTextButtonDepartment.UseSelectable = true;
            this.metroTextButtonDepartment.UseVisualStyleBackColor = true;
            this.metroTextButtonDepartment.Click += new System.EventHandler(this.metroTextButtonDepartment_Click);
            // 
            // metroTextButtonDoctor
            // 
            this.metroTextButtonDoctor.Image = null;
            this.metroTextButtonDoctor.Location = new System.Drawing.Point(0, 102);
            this.metroTextButtonDoctor.Name = "metroTextButtonDoctor";
            this.metroTextButtonDoctor.Size = new System.Drawing.Size(250, 50);
            this.metroTextButtonDoctor.TabIndex = 8;
            this.metroTextButtonDoctor.Text = "Doctor";
            this.metroTextButtonDoctor.UseSelectable = true;
            this.metroTextButtonDoctor.UseVisualStyleBackColor = true;
            this.metroTextButtonDoctor.Click += new System.EventHandler(this.metroTextButtonDoctor_Click);
            // 
            // metroTextButtonPatient
            // 
            this.metroTextButtonPatient.Image = null;
            this.metroTextButtonPatient.Location = new System.Drawing.Point(0, 153);
            this.metroTextButtonPatient.Name = "metroTextButtonPatient";
            this.metroTextButtonPatient.Size = new System.Drawing.Size(250, 50);
            this.metroTextButtonPatient.TabIndex = 7;
            this.metroTextButtonPatient.Text = "Patient";
            this.metroTextButtonPatient.UseSelectable = true;
            this.metroTextButtonPatient.UseVisualStyleBackColor = true;
            this.metroTextButtonPatient.Click += new System.EventHandler(this.metroTextButtonPatient_Click);
            // 
            // metroTextButtonProfile
            // 
            this.metroTextButtonProfile.Image = null;
            this.metroTextButtonProfile.Location = new System.Drawing.Point(0, 408);
            this.metroTextButtonProfile.Name = "metroTextButtonProfile";
            this.metroTextButtonProfile.Size = new System.Drawing.Size(250, 50);
            this.metroTextButtonProfile.TabIndex = 6;
            this.metroTextButtonProfile.Text = "Profile";
            this.metroTextButtonProfile.UseSelectable = true;
            this.metroTextButtonProfile.UseVisualStyleBackColor = true;
            this.metroTextButtonProfile.Click += new System.EventHandler(this.metroTextButtonProfile_Click);
            // 
            // metroTextButtonReceptionist
            // 
            this.metroTextButtonReceptionist.Image = null;
            this.metroTextButtonReceptionist.Location = new System.Drawing.Point(0, 306);
            this.metroTextButtonReceptionist.Name = "metroTextButtonReceptionist";
            this.metroTextButtonReceptionist.Size = new System.Drawing.Size(250, 50);
            this.metroTextButtonReceptionist.TabIndex = 5;
            this.metroTextButtonReceptionist.Text = "Receptionist";
            this.metroTextButtonReceptionist.UseSelectable = true;
            this.metroTextButtonReceptionist.UseVisualStyleBackColor = true;
            this.metroTextButtonReceptionist.Click += new System.EventHandler(this.metroTextButtonReceptionist_Click);
            // 
            // metroTextButtonAccountant
            // 
            this.metroTextButtonAccountant.Image = null;
            this.metroTextButtonAccountant.Location = new System.Drawing.Point(0, 255);
            this.metroTextButtonAccountant.Name = "metroTextButtonAccountant";
            this.metroTextButtonAccountant.Size = new System.Drawing.Size(250, 50);
            this.metroTextButtonAccountant.TabIndex = 4;
            this.metroTextButtonAccountant.Text = "Accountant";
            this.metroTextButtonAccountant.UseSelectable = true;
            this.metroTextButtonAccountant.UseVisualStyleBackColor = true;
            this.metroTextButtonAccountant.Click += new System.EventHandler(this.metroTextButtonAccountant_Click);
            // 
            // metroTextButtonEmployee
            // 
            this.metroTextButtonEmployee.Image = null;
            this.metroTextButtonEmployee.Location = new System.Drawing.Point(0, 204);
            this.metroTextButtonEmployee.Name = "metroTextButtonEmployee";
            this.metroTextButtonEmployee.Size = new System.Drawing.Size(250, 50);
            this.metroTextButtonEmployee.TabIndex = 3;
            this.metroTextButtonEmployee.Text = "Employee";
            this.metroTextButtonEmployee.UseSelectable = true;
            this.metroTextButtonEmployee.UseVisualStyleBackColor = true;
            this.metroTextButtonEmployee.Click += new System.EventHandler(this.metroTextButtonEmployee_Click);
            // 
            // metroTextButtonDashboard
            // 
            this.metroTextButtonDashboard.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTextButtonDashboard.Image = null;
            this.metroTextButtonDashboard.Location = new System.Drawing.Point(0, 0);
            this.metroTextButtonDashboard.Name = "metroTextButtonDashboard";
            this.metroTextButtonDashboard.Size = new System.Drawing.Size(250, 50);
            this.metroTextButtonDashboard.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextButtonDashboard.TabIndex = 2;
            this.metroTextButtonDashboard.TabStop = false;
            this.metroTextButtonDashboard.Text = "Dashboard";
            this.metroTextButtonDashboard.UseSelectable = true;
            this.metroTextButtonDashboard.UseVisualStyleBackColor = true;
            this.metroTextButtonDashboard.FontChanged += new System.EventHandler(this.metroTextButtonDashboard_Click);
            this.metroTextButtonDashboard.Click += new System.EventHandler(this.metroTextButtonDashboard_Click);
            // 
            // metroPanelAdminBody
            // 
            this.metroPanelAdminBody.Controls.Add(this.metroTileAdminRoom);
            this.metroPanelAdminBody.Controls.Add(this.metroTileAdminProfile);
            this.metroPanelAdminBody.Controls.Add(this.metroTileAdminDepartment);
            this.metroPanelAdminBody.Controls.Add(this.metroTileAdminReceptionist);
            this.metroPanelAdminBody.Controls.Add(this.metroTileAdminDoctor);
            this.metroPanelAdminBody.Controls.Add(this.metroTileAdminAccountant);
            this.metroPanelAdminBody.Controls.Add(this.metroTileAdminPatient);
            this.metroPanelAdminBody.Controls.Add(this.metroTileAdminEmployee);
            this.metroPanelAdminBody.Controls.Add(this.metroTileAdminDate);
            this.metroPanelAdminBody.Controls.Add(this.metroTileAdminTime);
            this.metroPanelAdminBody.Controls.Add(this.metroTileAdminLogOut);
            this.metroPanelAdminBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelAdminBody.HorizontalScrollbarBarColor = true;
            this.metroPanelAdminBody.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelAdminBody.HorizontalScrollbarSize = 10;
            this.metroPanelAdminBody.Location = new System.Drawing.Point(270, 60);
            this.metroPanelAdminBody.Name = "metroPanelAdminBody";
            this.metroPanelAdminBody.Size = new System.Drawing.Size(560, 470);
            this.metroPanelAdminBody.TabIndex = 2;
            this.metroPanelAdminBody.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelAdminBody.VerticalScrollbarBarColor = true;
            this.metroPanelAdminBody.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelAdminBody.VerticalScrollbarSize = 10;
            this.metroPanelAdminBody.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // metroTileAdminRoom
            // 
            this.metroTileAdminRoom.ActiveControl = null;
            this.metroTileAdminRoom.Location = new System.Drawing.Point(283, 154);
            this.metroTileAdminRoom.Name = "metroTileAdminRoom";
            this.metroTileAdminRoom.Size = new System.Drawing.Size(277, 150);
            this.metroTileAdminRoom.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTileAdminRoom.TabIndex = 19;
            this.metroTileAdminRoom.Text = "Room";
            this.metroTileAdminRoom.TileImage = global::HospitalManagementSystem.UI.Properties.Resources.bed;
            this.metroTileAdminRoom.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAdminRoom.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileAdminRoom.UseCustomForeColor = true;
            this.metroTileAdminRoom.UseSelectable = true;
            this.metroTileAdminRoom.UseTileImage = true;
            this.metroTileAdminRoom.Click += new System.EventHandler(this.metroTileAdminRoom_Click);
            // 
            // metroTileAdminProfile
            // 
            this.metroTileAdminProfile.ActiveControl = null;
            this.metroTileAdminProfile.Location = new System.Drawing.Point(283, 307);
            this.metroTileAdminProfile.Name = "metroTileAdminProfile";
            this.metroTileAdminProfile.Size = new System.Drawing.Size(137, 151);
            this.metroTileAdminProfile.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTileAdminProfile.TabIndex = 13;
            this.metroTileAdminProfile.Text = "Profile";
            this.metroTileAdminProfile.TileImage = global::HospitalManagementSystem.UI.Properties.Resources.user_list;
            this.metroTileAdminProfile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAdminProfile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileAdminProfile.UseCustomForeColor = true;
            this.metroTileAdminProfile.UseSelectable = true;
            this.metroTileAdminProfile.UseStyleColors = true;
            this.metroTileAdminProfile.UseTileImage = true;
            this.metroTileAdminProfile.Click += new System.EventHandler(this.metroTileAdminProfile_Click);
            // 
            // metroTileAdminDepartment
            // 
            this.metroTileAdminDepartment.ActiveControl = null;
            this.metroTileAdminDepartment.Location = new System.Drawing.Point(3, 0);
            this.metroTileAdminDepartment.Name = "metroTileAdminDepartment";
            this.metroTileAdminDepartment.Size = new System.Drawing.Size(137, 151);
            this.metroTileAdminDepartment.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileAdminDepartment.TabIndex = 15;
            this.metroTileAdminDepartment.Text = "Department";
            this.metroTileAdminDepartment.TileImage = global::HospitalManagementSystem.UI.Properties.Resources.cardiogram__1_;
            this.metroTileAdminDepartment.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAdminDepartment.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileAdminDepartment.UseCustomForeColor = true;
            this.metroTileAdminDepartment.UseSelectable = true;
            this.metroTileAdminDepartment.UseTileImage = true;
            this.metroTileAdminDepartment.Click += new System.EventHandler(this.metroTileAdminDepartment_Click);
            // 
            // metroTileAdminReceptionist
            // 
            this.metroTileAdminReceptionist.ActiveControl = null;
            this.metroTileAdminReceptionist.Location = new System.Drawing.Point(143, 154);
            this.metroTileAdminReceptionist.Name = "metroTileAdminReceptionist";
            this.metroTileAdminReceptionist.Size = new System.Drawing.Size(137, 150);
            this.metroTileAdminReceptionist.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroTileAdminReceptionist.TabIndex = 11;
            this.metroTileAdminReceptionist.Text = "Receptionist";
            this.metroTileAdminReceptionist.TileImage = global::HospitalManagementSystem.UI.Properties.Resources.manager;
            this.metroTileAdminReceptionist.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAdminReceptionist.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileAdminReceptionist.UseCustomForeColor = true;
            this.metroTileAdminReceptionist.UseSelectable = true;
            this.metroTileAdminReceptionist.UseTileImage = true;
            this.metroTileAdminReceptionist.Click += new System.EventHandler(this.metroTileAdminReceptionist_Click);
            // 
            // metroTileAdminDoctor
            // 
            this.metroTileAdminDoctor.ActiveControl = null;
            this.metroTileAdminDoctor.ForeColor = System.Drawing.Color.Black;
            this.metroTileAdminDoctor.Location = new System.Drawing.Point(143, 0);
            this.metroTileAdminDoctor.Name = "metroTileAdminDoctor";
            this.metroTileAdminDoctor.Size = new System.Drawing.Size(137, 151);
            this.metroTileAdminDoctor.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTileAdminDoctor.TabIndex = 18;
            this.metroTileAdminDoctor.Text = "Doctor";
            this.metroTileAdminDoctor.TileImage = global::HospitalManagementSystem.UI.Properties.Resources.doctor;
            this.metroTileAdminDoctor.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAdminDoctor.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileAdminDoctor.UseCustomForeColor = true;
            this.metroTileAdminDoctor.UseSelectable = true;
            this.metroTileAdminDoctor.UseTileImage = true;
            this.metroTileAdminDoctor.Click += new System.EventHandler(this.metroTileAdminDoctor_Click);
            // 
            // metroTileAdminAccountant
            // 
            this.metroTileAdminAccountant.ActiveControl = null;
            this.metroTileAdminAccountant.Location = new System.Drawing.Point(3, 154);
            this.metroTileAdminAccountant.Name = "metroTileAdminAccountant";
            this.metroTileAdminAccountant.Size = new System.Drawing.Size(137, 150);
            this.metroTileAdminAccountant.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTileAdminAccountant.TabIndex = 10;
            this.metroTileAdminAccountant.Text = "Accountant";
            this.metroTileAdminAccountant.TileImage = global::HospitalManagementSystem.UI.Properties.Resources.businessman_showing_calculator;
            this.metroTileAdminAccountant.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAdminAccountant.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileAdminAccountant.UseCustomForeColor = true;
            this.metroTileAdminAccountant.UseSelectable = true;
            this.metroTileAdminAccountant.UseTileImage = true;
            this.metroTileAdminAccountant.Click += new System.EventHandler(this.metroTileAdminAccountant_Click);
            // 
            // metroTileAdminPatient
            // 
            this.metroTileAdminPatient.ActiveControl = null;
            this.metroTileAdminPatient.Location = new System.Drawing.Point(283, 0);
            this.metroTileAdminPatient.Name = "metroTileAdminPatient";
            this.metroTileAdminPatient.Size = new System.Drawing.Size(137, 151);
            this.metroTileAdminPatient.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTileAdminPatient.TabIndex = 17;
            this.metroTileAdminPatient.Text = "Patient";
            this.metroTileAdminPatient.TileImage = global::HospitalManagementSystem.UI.Properties.Resources.patient_lying_on_stretcher_with_medical_doctor__1_;
            this.metroTileAdminPatient.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAdminPatient.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileAdminPatient.UseCustomForeColor = true;
            this.metroTileAdminPatient.UseSelectable = true;
            this.metroTileAdminPatient.UseTileImage = true;
            this.metroTileAdminPatient.Click += new System.EventHandler(this.metroTileAdminPatient_Click);
            // 
            // metroTileAdminEmployee
            // 
            this.metroTileAdminEmployee.ActiveControl = null;
            this.metroTileAdminEmployee.Location = new System.Drawing.Point(423, 0);
            this.metroTileAdminEmployee.Name = "metroTileAdminEmployee";
            this.metroTileAdminEmployee.Size = new System.Drawing.Size(137, 151);
            this.metroTileAdminEmployee.TabIndex = 9;
            this.metroTileAdminEmployee.Text = "Employee";
            this.metroTileAdminEmployee.TileImage = global::HospitalManagementSystem.UI.Properties.Resources.nurse;
            this.metroTileAdminEmployee.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAdminEmployee.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileAdminEmployee.UseCustomForeColor = true;
            this.metroTileAdminEmployee.UseSelectable = true;
            this.metroTileAdminEmployee.UseTileImage = true;
            this.metroTileAdminEmployee.Click += new System.EventHandler(this.metroTileAdminEmployee_Click);
            // 
            // metroTileAdminDate
            // 
            this.metroTileAdminDate.ActiveControl = null;
            this.metroTileAdminDate.Location = new System.Drawing.Point(143, 307);
            this.metroTileAdminDate.Name = "metroTileAdminDate";
            this.metroTileAdminDate.Size = new System.Drawing.Size(137, 151);
            this.metroTileAdminDate.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTileAdminDate.TabIndex = 12;
            this.metroTileAdminDate.Text = "Date";
            this.metroTileAdminDate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileAdminDate.TileImage = global::HospitalManagementSystem.UI.Properties.Resources.calendar;
            this.metroTileAdminDate.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAdminDate.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileAdminDate.UseCustomForeColor = true;
            this.metroTileAdminDate.UseSelectable = true;
            this.metroTileAdminDate.UseTileImage = true;
            this.metroTileAdminDate.Click += new System.EventHandler(this.metroTileAdminDate_Click);
            // 
            // metroTileAdminTime
            // 
            this.metroTileAdminTime.ActiveControl = null;
            this.metroTileAdminTime.Location = new System.Drawing.Point(3, 307);
            this.metroTileAdminTime.Name = "metroTileAdminTime";
            this.metroTileAdminTime.Size = new System.Drawing.Size(137, 151);
            this.metroTileAdminTime.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroTileAdminTime.TabIndex = 14;
            this.metroTileAdminTime.Text = "Time";
            this.metroTileAdminTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileAdminTime.TileImage = global::HospitalManagementSystem.UI.Properties.Resources.clock;
            this.metroTileAdminTime.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAdminTime.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileAdminTime.UseCustomForeColor = true;
            this.metroTileAdminTime.UseSelectable = true;
            this.metroTileAdminTime.UseTileImage = true;
            this.metroTileAdminTime.Click += new System.EventHandler(this.metroTileAdminTime_Click);
            // 
            // metroTileAdminLogOut
            // 
            this.metroTileAdminLogOut.ActiveControl = null;
            this.metroTileAdminLogOut.Location = new System.Drawing.Point(423, 307);
            this.metroTileAdminLogOut.Name = "metroTileAdminLogOut";
            this.metroTileAdminLogOut.Size = new System.Drawing.Size(137, 151);
            this.metroTileAdminLogOut.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTileAdminLogOut.TabIndex = 16;
            this.metroTileAdminLogOut.Text = "Log Out";
            this.metroTileAdminLogOut.TileImage = global::HospitalManagementSystem.UI.Properties.Resources.power_button__1_;
            this.metroTileAdminLogOut.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileAdminLogOut.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileAdminLogOut.UseSelectable = true;
            this.metroTileAdminLogOut.UseTileImage = true;
            this.metroTileAdminLogOut.Click += new System.EventHandler(this.metroTileAdminLogOut_Click_1);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(630, 25);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 3;
            this.metroDateTime1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroDateTime1.ValueChanged += new System.EventHandler(this.metroDateTime1_ValueChanged);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.metroPanelAdminBody);
            this.Controls.Add(this.metroPanelAdminMenu);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAdmin";
            this.Resizable = false;
            this.Text = "Admin";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.metroPanelAdminMenu.ResumeLayout(false);
            this.metroPanelAdminBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanelAdminMenu;
        private MetroFramework.Controls.MetroPanel metroPanelAdminBody;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonDepartment;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonDoctor;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonPatient;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonProfile;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonReceptionist;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonAccountant;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonEmployee;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonDashboard;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonAdminRoom;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroTile metroTileAdminRoom;
        private MetroFramework.Controls.MetroTile metroTileAdminDoctor;
        private MetroFramework.Controls.MetroTile metroTileAdminPatient;
        private MetroFramework.Controls.MetroTile metroTileAdminLogOut;
        private MetroFramework.Controls.MetroTile metroTileAdminDepartment;
        private MetroFramework.Controls.MetroTile metroTileAdminProfile;
        private MetroFramework.Controls.MetroTile metroTileAdminReceptionist;
        private MetroFramework.Controls.MetroTile metroTileAdminAccountant;
        private MetroFramework.Controls.MetroTile metroTileAdminEmployee;
        private MetroFramework.Controls.MetroTile metroTileAdminTime;
        private MetroFramework.Controls.MetroTile metroTileAdminDate;
    }
}