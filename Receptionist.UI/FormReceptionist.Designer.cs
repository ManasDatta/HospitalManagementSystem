namespace HospitalManagementSystem.UI.Receptionist.UI
{
    partial class FormReceptionist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReceptionist));
            this.metroPanelReceptionistMenu = new MetroFramework.Controls.MetroPanel();
            this.metroTextButtonReceptionistProfile = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButtonReceptionistPatient = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButtonReceptionistDashboard = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroPanelReceptionistBody = new MetroFramework.Controls.MetroPanel();
            this.metroTileReceptionistTime = new MetroFramework.Controls.MetroTile();
            this.metroTileReceptionistDate = new MetroFramework.Controls.MetroTile();
            this.metroTileReceptionistLogOut = new MetroFramework.Controls.MetroTile();
            this.metroTileReceptionistProfile = new MetroFramework.Controls.MetroTile();
            this.metroTileReceptionistPatient = new MetroFramework.Controls.MetroTile();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroPanelReceptionistMenu.SuspendLayout();
            this.metroPanelReceptionistBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanelReceptionistMenu
            // 
            this.metroPanelReceptionistMenu.Controls.Add(this.metroTextButtonReceptionistProfile);
            this.metroPanelReceptionistMenu.Controls.Add(this.metroTextButtonReceptionistPatient);
            this.metroPanelReceptionistMenu.Controls.Add(this.metroTextButtonReceptionistDashboard);
            this.metroPanelReceptionistMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanelReceptionistMenu.HorizontalScrollbarBarColor = true;
            this.metroPanelReceptionistMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelReceptionistMenu.HorizontalScrollbarSize = 10;
            this.metroPanelReceptionistMenu.Location = new System.Drawing.Point(20, 60);
            this.metroPanelReceptionistMenu.Name = "metroPanelReceptionistMenu";
            this.metroPanelReceptionistMenu.Size = new System.Drawing.Size(250, 470);
            this.metroPanelReceptionistMenu.TabIndex = 0;
            this.metroPanelReceptionistMenu.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelReceptionistMenu.VerticalScrollbarBarColor = true;
            this.metroPanelReceptionistMenu.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelReceptionistMenu.VerticalScrollbarSize = 10;
            // 
            // metroTextButtonReceptionistProfile
            // 
            this.metroTextButtonReceptionistProfile.Image = null;
            this.metroTextButtonReceptionistProfile.Location = new System.Drawing.Point(0, 102);
            this.metroTextButtonReceptionistProfile.Name = "metroTextButtonReceptionistProfile";
            this.metroTextButtonReceptionistProfile.Size = new System.Drawing.Size(250, 50);
            this.metroTextButtonReceptionistProfile.TabIndex = 4;
            this.metroTextButtonReceptionistProfile.Text = "Profile";
            this.metroTextButtonReceptionistProfile.UseSelectable = true;
            this.metroTextButtonReceptionistProfile.UseVisualStyleBackColor = true;
            this.metroTextButtonReceptionistProfile.Click += new System.EventHandler(this.metroTextButtonReceptionistProfile_Click);
            // 
            // metroTextButtonReceptionistPatient
            // 
            this.metroTextButtonReceptionistPatient.Image = null;
            this.metroTextButtonReceptionistPatient.Location = new System.Drawing.Point(0, 51);
            this.metroTextButtonReceptionistPatient.Name = "metroTextButtonReceptionistPatient";
            this.metroTextButtonReceptionistPatient.Size = new System.Drawing.Size(250, 50);
            this.metroTextButtonReceptionistPatient.TabIndex = 3;
            this.metroTextButtonReceptionistPatient.Text = "Patient";
            this.metroTextButtonReceptionistPatient.UseSelectable = true;
            this.metroTextButtonReceptionistPatient.UseVisualStyleBackColor = true;
            this.metroTextButtonReceptionistPatient.Click += new System.EventHandler(this.metroTextButtonReceptionistPatient_Click);
            // 
            // metroTextButtonReceptionistDashboard
            // 
            this.metroTextButtonReceptionistDashboard.Image = null;
            this.metroTextButtonReceptionistDashboard.Location = new System.Drawing.Point(0, 0);
            this.metroTextButtonReceptionistDashboard.Name = "metroTextButtonReceptionistDashboard";
            this.metroTextButtonReceptionistDashboard.Size = new System.Drawing.Size(250, 50);
            this.metroTextButtonReceptionistDashboard.TabIndex = 2;
            this.metroTextButtonReceptionistDashboard.Text = "Dashboard";
            this.metroTextButtonReceptionistDashboard.UseSelectable = true;
            this.metroTextButtonReceptionistDashboard.UseVisualStyleBackColor = true;
            this.metroTextButtonReceptionistDashboard.Click += new System.EventHandler(this.metroTextButtonReceptionistDashboard_Click);
            // 
            // metroPanelReceptionistBody
            // 
            this.metroPanelReceptionistBody.Controls.Add(this.metroTileReceptionistTime);
            this.metroPanelReceptionistBody.Controls.Add(this.metroTileReceptionistDate);
            this.metroPanelReceptionistBody.Controls.Add(this.metroTileReceptionistLogOut);
            this.metroPanelReceptionistBody.Controls.Add(this.metroTileReceptionistProfile);
            this.metroPanelReceptionistBody.Controls.Add(this.metroTileReceptionistPatient);
            this.metroPanelReceptionistBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelReceptionistBody.HorizontalScrollbarBarColor = true;
            this.metroPanelReceptionistBody.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelReceptionistBody.HorizontalScrollbarSize = 10;
            this.metroPanelReceptionistBody.Location = new System.Drawing.Point(270, 60);
            this.metroPanelReceptionistBody.Name = "metroPanelReceptionistBody";
            this.metroPanelReceptionistBody.Size = new System.Drawing.Size(560, 470);
            this.metroPanelReceptionistBody.TabIndex = 2;
            this.metroPanelReceptionistBody.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelReceptionistBody.VerticalScrollbarBarColor = true;
            this.metroPanelReceptionistBody.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelReceptionistBody.VerticalScrollbarSize = 10;
            // 
            // metroTileReceptionistTime
            // 
            this.metroTileReceptionistTime.ActiveControl = null;
            this.metroTileReceptionistTime.Location = new System.Drawing.Point(3, 307);
            this.metroTileReceptionistTime.Name = "metroTileReceptionistTime";
            this.metroTileReceptionistTime.Size = new System.Drawing.Size(277, 152);
            this.metroTileReceptionistTime.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroTileReceptionistTime.TabIndex = 11;
            this.metroTileReceptionistTime.Text = "Time";
            this.metroTileReceptionistTime.TileImage = global::HospitalManagementSystem.UI.Properties.Resources.clock;
            this.metroTileReceptionistTime.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileReceptionistTime.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileReceptionistTime.UseCustomForeColor = true;
            this.metroTileReceptionistTime.UseSelectable = true;
            this.metroTileReceptionistTime.UseStyleColors = true;
            this.metroTileReceptionistTime.UseTileImage = true;
            // 
            // metroTileReceptionistDate
            // 
            this.metroTileReceptionistDate.ActiveControl = null;
            this.metroTileReceptionistDate.Location = new System.Drawing.Point(283, 0);
            this.metroTileReceptionistDate.Name = "metroTileReceptionistDate";
            this.metroTileReceptionistDate.Size = new System.Drawing.Size(277, 151);
            this.metroTileReceptionistDate.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTileReceptionistDate.TabIndex = 10;
            this.metroTileReceptionistDate.Text = "Date";
            this.metroTileReceptionistDate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileReceptionistDate.TileImage = global::HospitalManagementSystem.UI.Properties.Resources.calendar;
            this.metroTileReceptionistDate.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileReceptionistDate.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileReceptionistDate.UseCustomForeColor = true;
            this.metroTileReceptionistDate.UseSelectable = true;
            this.metroTileReceptionistDate.UseStyleColors = true;
            this.metroTileReceptionistDate.UseTileImage = true;
            // 
            // metroTileReceptionistLogOut
            // 
            this.metroTileReceptionistLogOut.ActiveControl = null;
            this.metroTileReceptionistLogOut.Location = new System.Drawing.Point(283, 307);
            this.metroTileReceptionistLogOut.Name = "metroTileReceptionistLogOut";
            this.metroTileReceptionistLogOut.Size = new System.Drawing.Size(277, 152);
            this.metroTileReceptionistLogOut.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTileReceptionistLogOut.TabIndex = 9;
            this.metroTileReceptionistLogOut.Text = "Log Out";
            this.metroTileReceptionistLogOut.TileImage = global::HospitalManagementSystem.UI.Properties.Resources.power_button__1_;
            this.metroTileReceptionistLogOut.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileReceptionistLogOut.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileReceptionistLogOut.UseCustomForeColor = true;
            this.metroTileReceptionistLogOut.UseSelectable = true;
            this.metroTileReceptionistLogOut.UseStyleColors = true;
            this.metroTileReceptionistLogOut.UseTileImage = true;
            this.metroTileReceptionistLogOut.Click += new System.EventHandler(this.metroTileReceptionistLogOut_Click);
            // 
            // metroTileReceptionistProfile
            // 
            this.metroTileReceptionistProfile.ActiveControl = null;
            this.metroTileReceptionistProfile.Location = new System.Drawing.Point(283, 154);
            this.metroTileReceptionistProfile.Name = "metroTileReceptionistProfile";
            this.metroTileReceptionistProfile.Size = new System.Drawing.Size(277, 150);
            this.metroTileReceptionistProfile.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTileReceptionistProfile.TabIndex = 8;
            this.metroTileReceptionistProfile.Text = "Profile";
            this.metroTileReceptionistProfile.TileImage = global::HospitalManagementSystem.UI.Properties.Resources.user_list;
            this.metroTileReceptionistProfile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileReceptionistProfile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileReceptionistProfile.UseCustomForeColor = true;
            this.metroTileReceptionistProfile.UseSelectable = true;
            this.metroTileReceptionistProfile.UseStyleColors = true;
            this.metroTileReceptionistProfile.UseTileImage = true;
            this.metroTileReceptionistProfile.Click += new System.EventHandler(this.metroTileReceptionistProfile_Click);
            // 
            // metroTileReceptionistPatient
            // 
            this.metroTileReceptionistPatient.ActiveControl = null;
            this.metroTileReceptionistPatient.Location = new System.Drawing.Point(3, 0);
            this.metroTileReceptionistPatient.Name = "metroTileReceptionistPatient";
            this.metroTileReceptionistPatient.Size = new System.Drawing.Size(277, 304);
            this.metroTileReceptionistPatient.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTileReceptionistPatient.TabIndex = 7;
            this.metroTileReceptionistPatient.Text = "Patient";
            this.metroTileReceptionistPatient.TileImage = global::HospitalManagementSystem.UI.Properties.Resources.patient_lying_on_stretcher_with_medical_doctor__2_;
            this.metroTileReceptionistPatient.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileReceptionistPatient.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileReceptionistPatient.UseCustomForeColor = true;
            this.metroTileReceptionistPatient.UseSelectable = true;
            this.metroTileReceptionistPatient.UseStyleColors = true;
            this.metroTileReceptionistPatient.UseTileImage = true;
            this.metroTileReceptionistPatient.Click += new System.EventHandler(this.metroTileReceptionistPatient_Click);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(630, 25);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 3;
            this.metroDateTime1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // FormReceptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.metroPanelReceptionistBody);
            this.Controls.Add(this.metroPanelReceptionistMenu);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormReceptionist";
            this.Resizable = false;
            this.Text = "Receptionist";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.FormReceptionist_Load);
            this.metroPanelReceptionistMenu.ResumeLayout(false);
            this.metroPanelReceptionistBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanelReceptionistMenu;
        private MetroFramework.Controls.MetroPanel metroPanelReceptionistBody;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonReceptionistProfile;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonReceptionistPatient;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonReceptionistDashboard;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroTile metroTileReceptionistTime;
        private MetroFramework.Controls.MetroTile metroTileReceptionistDate;
        private MetroFramework.Controls.MetroTile metroTileReceptionistLogOut;
        private MetroFramework.Controls.MetroTile metroTileReceptionistProfile;
        private MetroFramework.Controls.MetroTile metroTileReceptionistPatient;
    }
}