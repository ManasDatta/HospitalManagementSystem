namespace HospitalManagementSystem.UI.Doctor.UI
{
    partial class FormDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoctor));
            this.metroPanelDoctorMenu = new MetroFramework.Controls.MetroPanel();
            this.metroTextButtonDoctorProfile = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButtonDoctorPatient = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButtonDoctorDashboard = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroPanelDoctorBody = new MetroFramework.Controls.MetroPanel();
            this.metroTileDoctorTime = new MetroFramework.Controls.MetroTile();
            this.metroTileDoctorProfile = new MetroFramework.Controls.MetroTile();
            this.metroTileDoctorDate = new MetroFramework.Controls.MetroTile();
            this.metroTileDoctorLogOut = new MetroFramework.Controls.MetroTile();
            this.metroTileDoctorPatient = new MetroFramework.Controls.MetroTile();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroPanelDoctorMenu.SuspendLayout();
            this.metroPanelDoctorBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanelDoctorMenu
            // 
            this.metroPanelDoctorMenu.BackColor = System.Drawing.Color.White;
            this.metroPanelDoctorMenu.Controls.Add(this.metroTextButtonDoctorProfile);
            this.metroPanelDoctorMenu.Controls.Add(this.metroTextButtonDoctorPatient);
            this.metroPanelDoctorMenu.Controls.Add(this.metroTextButtonDoctorDashboard);
            this.metroPanelDoctorMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanelDoctorMenu.HorizontalScrollbarBarColor = true;
            this.metroPanelDoctorMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelDoctorMenu.HorizontalScrollbarSize = 10;
            this.metroPanelDoctorMenu.Location = new System.Drawing.Point(20, 60);
            this.metroPanelDoctorMenu.Name = "metroPanelDoctorMenu";
            this.metroPanelDoctorMenu.Size = new System.Drawing.Size(250, 470);
            this.metroPanelDoctorMenu.TabIndex = 0;
            this.metroPanelDoctorMenu.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelDoctorMenu.VerticalScrollbarBarColor = true;
            this.metroPanelDoctorMenu.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelDoctorMenu.VerticalScrollbarSize = 10;
            // 
            // metroTextButtonDoctorProfile
            // 
            this.metroTextButtonDoctorProfile.Image = null;
            this.metroTextButtonDoctorProfile.Location = new System.Drawing.Point(0, 102);
            this.metroTextButtonDoctorProfile.Name = "metroTextButtonDoctorProfile";
            this.metroTextButtonDoctorProfile.Size = new System.Drawing.Size(250, 50);
            this.metroTextButtonDoctorProfile.TabIndex = 4;
            this.metroTextButtonDoctorProfile.Text = "Profile";
            this.metroTextButtonDoctorProfile.UseSelectable = true;
            this.metroTextButtonDoctorProfile.UseVisualStyleBackColor = true;
            this.metroTextButtonDoctorProfile.Click += new System.EventHandler(this.metroTextButton4_Click);
            // 
            // metroTextButtonDoctorPatient
            // 
            this.metroTextButtonDoctorPatient.Image = null;
            this.metroTextButtonDoctorPatient.Location = new System.Drawing.Point(0, 51);
            this.metroTextButtonDoctorPatient.Name = "metroTextButtonDoctorPatient";
            this.metroTextButtonDoctorPatient.Size = new System.Drawing.Size(250, 50);
            this.metroTextButtonDoctorPatient.TabIndex = 3;
            this.metroTextButtonDoctorPatient.Text = "Patient";
            this.metroTextButtonDoctorPatient.UseSelectable = true;
            this.metroTextButtonDoctorPatient.UseVisualStyleBackColor = true;
            this.metroTextButtonDoctorPatient.Click += new System.EventHandler(this.metroTextButtonDoctorPatient_Click);
            // 
            // metroTextButtonDoctorDashboard
            // 
            this.metroTextButtonDoctorDashboard.Image = null;
            this.metroTextButtonDoctorDashboard.Location = new System.Drawing.Point(0, 0);
            this.metroTextButtonDoctorDashboard.Name = "metroTextButtonDoctorDashboard";
            this.metroTextButtonDoctorDashboard.Size = new System.Drawing.Size(250, 50);
            this.metroTextButtonDoctorDashboard.TabIndex = 2;
            this.metroTextButtonDoctorDashboard.Text = "Dashboard";
            this.metroTextButtonDoctorDashboard.UseSelectable = true;
            this.metroTextButtonDoctorDashboard.UseVisualStyleBackColor = true;
            this.metroTextButtonDoctorDashboard.Click += new System.EventHandler(this.metroTextButton2_Click);
            // 
            // metroPanelDoctorBody
            // 
            this.metroPanelDoctorBody.Controls.Add(this.metroTileDoctorTime);
            this.metroPanelDoctorBody.Controls.Add(this.metroTileDoctorProfile);
            this.metroPanelDoctorBody.Controls.Add(this.metroTileDoctorDate);
            this.metroPanelDoctorBody.Controls.Add(this.metroTileDoctorLogOut);
            this.metroPanelDoctorBody.Controls.Add(this.metroTileDoctorPatient);
            this.metroPanelDoctorBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelDoctorBody.HorizontalScrollbarBarColor = true;
            this.metroPanelDoctorBody.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelDoctorBody.HorizontalScrollbarSize = 10;
            this.metroPanelDoctorBody.Location = new System.Drawing.Point(270, 60);
            this.metroPanelDoctorBody.Name = "metroPanelDoctorBody";
            this.metroPanelDoctorBody.Size = new System.Drawing.Size(560, 470);
            this.metroPanelDoctorBody.TabIndex = 2;
            this.metroPanelDoctorBody.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelDoctorBody.VerticalScrollbarBarColor = true;
            this.metroPanelDoctorBody.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelDoctorBody.VerticalScrollbarSize = 10;
            this.metroPanelDoctorBody.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanelDoctorBody_Paint);
            // 
            // metroTileDoctorTime
            // 
            this.metroTileDoctorTime.ActiveControl = null;
            this.metroTileDoctorTime.Location = new System.Drawing.Point(3, 307);
            this.metroTileDoctorTime.Name = "metroTileDoctorTime";
            this.metroTileDoctorTime.Size = new System.Drawing.Size(277, 152);
            this.metroTileDoctorTime.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroTileDoctorTime.TabIndex = 11;
            this.metroTileDoctorTime.Text = "Time";
            this.metroTileDoctorTime.TileImage = global::HospitalManagementSystem.UI.Properties.Resources.clock;
            this.metroTileDoctorTime.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileDoctorTime.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileDoctorTime.UseCustomForeColor = true;
            this.metroTileDoctorTime.UseSelectable = true;
            this.metroTileDoctorTime.UseStyleColors = true;
            this.metroTileDoctorTime.UseTileImage = true;
            this.metroTileDoctorTime.Click += new System.EventHandler(this.metroTileDoctorTime_Click);
            // 
            // metroTileDoctorProfile
            // 
            this.metroTileDoctorProfile.ActiveControl = null;
            this.metroTileDoctorProfile.Location = new System.Drawing.Point(283, 154);
            this.metroTileDoctorProfile.Name = "metroTileDoctorProfile";
            this.metroTileDoctorProfile.Size = new System.Drawing.Size(277, 150);
            this.metroTileDoctorProfile.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTileDoctorProfile.TabIndex = 8;
            this.metroTileDoctorProfile.Text = "Profile";
            this.metroTileDoctorProfile.TileImage = global::HospitalManagementSystem.UI.Properties.Resources.user_list;
            this.metroTileDoctorProfile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileDoctorProfile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileDoctorProfile.UseCustomForeColor = true;
            this.metroTileDoctorProfile.UseSelectable = true;
            this.metroTileDoctorProfile.UseStyleColors = true;
            this.metroTileDoctorProfile.UseTileImage = true;
            this.metroTileDoctorProfile.Click += new System.EventHandler(this.metroTileDoctorProfile_Click);
            // 
            // metroTileDoctorDate
            // 
            this.metroTileDoctorDate.ActiveControl = null;
            this.metroTileDoctorDate.Location = new System.Drawing.Point(283, 0);
            this.metroTileDoctorDate.Name = "metroTileDoctorDate";
            this.metroTileDoctorDate.Size = new System.Drawing.Size(277, 151);
            this.metroTileDoctorDate.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTileDoctorDate.TabIndex = 10;
            this.metroTileDoctorDate.Text = "Date";
            this.metroTileDoctorDate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileDoctorDate.TileImage = global::HospitalManagementSystem.UI.Properties.Resources.calendar;
            this.metroTileDoctorDate.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileDoctorDate.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileDoctorDate.UseCustomForeColor = true;
            this.metroTileDoctorDate.UseSelectable = true;
            this.metroTileDoctorDate.UseStyleColors = true;
            this.metroTileDoctorDate.UseTileImage = true;
            this.metroTileDoctorDate.Click += new System.EventHandler(this.metroTileDoctorDate_Click);
            // 
            // metroTileDoctorLogOut
            // 
            this.metroTileDoctorLogOut.ActiveControl = null;
            this.metroTileDoctorLogOut.Location = new System.Drawing.Point(283, 307);
            this.metroTileDoctorLogOut.Name = "metroTileDoctorLogOut";
            this.metroTileDoctorLogOut.Size = new System.Drawing.Size(277, 152);
            this.metroTileDoctorLogOut.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTileDoctorLogOut.TabIndex = 9;
            this.metroTileDoctorLogOut.Text = "Log Out";
            this.metroTileDoctorLogOut.TileImage = global::HospitalManagementSystem.UI.Properties.Resources.power_button__1_;
            this.metroTileDoctorLogOut.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileDoctorLogOut.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileDoctorLogOut.UseCustomForeColor = true;
            this.metroTileDoctorLogOut.UseSelectable = true;
            this.metroTileDoctorLogOut.UseStyleColors = true;
            this.metroTileDoctorLogOut.UseTileImage = true;
            this.metroTileDoctorLogOut.Click += new System.EventHandler(this.metroTileDoctorLogOut_Click);
            // 
            // metroTileDoctorPatient
            // 
            this.metroTileDoctorPatient.ActiveControl = null;
            this.metroTileDoctorPatient.Location = new System.Drawing.Point(3, 0);
            this.metroTileDoctorPatient.Name = "metroTileDoctorPatient";
            this.metroTileDoctorPatient.Size = new System.Drawing.Size(277, 304);
            this.metroTileDoctorPatient.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileDoctorPatient.TabIndex = 7;
            this.metroTileDoctorPatient.Text = "Patient";
            this.metroTileDoctorPatient.TileImage = global::HospitalManagementSystem.UI.Properties.Resources.patient_lying_on_stretcher_with_medical_doctor__2_;
            this.metroTileDoctorPatient.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileDoctorPatient.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileDoctorPatient.UseCustomForeColor = true;
            this.metroTileDoctorPatient.UseSelectable = true;
            this.metroTileDoctorPatient.UseStyleColors = true;
            this.metroTileDoctorPatient.UseTileImage = true;
            this.metroTileDoctorPatient.Click += new System.EventHandler(this.metroTileDoctorPatient_Click);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(628, 25);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 3;
            this.metroDateTime1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // FormDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.metroPanelDoctorBody);
            this.Controls.Add(this.metroPanelDoctorMenu);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormDoctor";
            this.Resizable = false;
            this.Text = "Doctor";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.FormDoctor_Load);
            this.metroPanelDoctorMenu.ResumeLayout(false);
            this.metroPanelDoctorBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanelDoctorMenu;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonDoctorProfile;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonDoctorPatient;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonDoctorDashboard;
        private MetroFramework.Controls.MetroPanel metroPanelDoctorBody;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroTile metroTileDoctorTime;
        private MetroFramework.Controls.MetroTile metroTileDoctorDate;
        private MetroFramework.Controls.MetroTile metroTileDoctorLogOut;
        private MetroFramework.Controls.MetroTile metroTileDoctorProfile;
        private MetroFramework.Controls.MetroTile metroTileDoctorPatient;
    }
}