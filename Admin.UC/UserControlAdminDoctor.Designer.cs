namespace HospitalManagementSystem.UI.Admin.UC
{
    partial class UserControlAdminDoctor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanelAdminDoctorButton = new MetroFramework.Controls.MetroPanel();
            this.metroTextButtonAdminAddDoctor = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButtonAdminDoctorList = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroPanelAdminDoctor = new MetroFramework.Controls.MetroPanel();
            this.metroPanelAdminDoctorButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanelAdminDoctorButton
            // 
            this.metroPanelAdminDoctorButton.Controls.Add(this.metroTextButtonAdminAddDoctor);
            this.metroPanelAdminDoctorButton.Controls.Add(this.metroTextButtonAdminDoctorList);
            this.metroPanelAdminDoctorButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanelAdminDoctorButton.HorizontalScrollbarBarColor = true;
            this.metroPanelAdminDoctorButton.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelAdminDoctorButton.HorizontalScrollbarSize = 10;
            this.metroPanelAdminDoctorButton.Location = new System.Drawing.Point(0, 0);
            this.metroPanelAdminDoctorButton.Name = "metroPanelAdminDoctorButton";
            this.metroPanelAdminDoctorButton.Size = new System.Drawing.Size(560, 50);
            this.metroPanelAdminDoctorButton.TabIndex = 0;
            this.metroPanelAdminDoctorButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelAdminDoctorButton.VerticalScrollbarBarColor = true;
            this.metroPanelAdminDoctorButton.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelAdminDoctorButton.VerticalScrollbarSize = 10;
            // 
            // metroTextButtonAdminAddDoctor
            // 
            this.metroTextButtonAdminAddDoctor.Image = null;
            this.metroTextButtonAdminAddDoctor.Location = new System.Drawing.Point(282, 0);
            this.metroTextButtonAdminAddDoctor.Name = "metroTextButtonAdminAddDoctor";
            this.metroTextButtonAdminAddDoctor.Size = new System.Drawing.Size(278, 50);
            this.metroTextButtonAdminAddDoctor.TabIndex = 3;
            this.metroTextButtonAdminAddDoctor.Text = "Add Doctor";
            this.metroTextButtonAdminAddDoctor.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextButtonAdminAddDoctor.UseSelectable = true;
            this.metroTextButtonAdminAddDoctor.UseVisualStyleBackColor = true;
            this.metroTextButtonAdminAddDoctor.Click += new System.EventHandler(this.metroTextButtonAdminAddDoctor_Click);
            // 
            // metroTextButtonAdminDoctorList
            // 
            this.metroTextButtonAdminDoctorList.Image = null;
            this.metroTextButtonAdminDoctorList.Location = new System.Drawing.Point(3, 0);
            this.metroTextButtonAdminDoctorList.Name = "metroTextButtonAdminDoctorList";
            this.metroTextButtonAdminDoctorList.Size = new System.Drawing.Size(278, 50);
            this.metroTextButtonAdminDoctorList.TabIndex = 2;
            this.metroTextButtonAdminDoctorList.Text = "Doctor List";
            this.metroTextButtonAdminDoctorList.UseSelectable = true;
            this.metroTextButtonAdminDoctorList.UseVisualStyleBackColor = true;
            this.metroTextButtonAdminDoctorList.Click += new System.EventHandler(this.metroTextButton1_Click);
            // 
            // metroPanelAdminDoctor
            // 
            this.metroPanelAdminDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelAdminDoctor.HorizontalScrollbarBarColor = true;
            this.metroPanelAdminDoctor.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelAdminDoctor.HorizontalScrollbarSize = 10;
            this.metroPanelAdminDoctor.Location = new System.Drawing.Point(0, 50);
            this.metroPanelAdminDoctor.Name = "metroPanelAdminDoctor";
            this.metroPanelAdminDoctor.Size = new System.Drawing.Size(560, 420);
            this.metroPanelAdminDoctor.TabIndex = 4;
            this.metroPanelAdminDoctor.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelAdminDoctor.VerticalScrollbarBarColor = true;
            this.metroPanelAdminDoctor.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelAdminDoctor.VerticalScrollbarSize = 10;
            // 
            // UserControlAdminDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanelAdminDoctor);
            this.Controls.Add(this.metroPanelAdminDoctorButton);
            this.Name = "UserControlAdminDoctor";
            this.Size = new System.Drawing.Size(560, 470);
            this.metroPanelAdminDoctorButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanelAdminDoctorButton;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonAdminAddDoctor;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonAdminDoctorList;
        private MetroFramework.Controls.MetroPanel metroPanelAdminDoctor;
    }
}
