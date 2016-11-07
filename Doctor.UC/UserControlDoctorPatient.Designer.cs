namespace HospitalManagementSystem.UI.Doctor.UC
{
    partial class UserControlDoctorPatient
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
            this.metroPanelDoctorPatientButton = new MetroFramework.Controls.MetroPanel();
            this.metroTextButtonDoctorPatientList = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroPanelDoctorPatient = new MetroFramework.Controls.MetroPanel();
            this.metroPanelDoctorPatientButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanelDoctorPatientButton
            // 
            this.metroPanelDoctorPatientButton.Controls.Add(this.metroTextButtonDoctorPatientList);
            this.metroPanelDoctorPatientButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanelDoctorPatientButton.HorizontalScrollbarBarColor = true;
            this.metroPanelDoctorPatientButton.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelDoctorPatientButton.HorizontalScrollbarSize = 10;
            this.metroPanelDoctorPatientButton.Location = new System.Drawing.Point(0, 0);
            this.metroPanelDoctorPatientButton.Name = "metroPanelDoctorPatientButton";
            this.metroPanelDoctorPatientButton.Size = new System.Drawing.Size(560, 50);
            this.metroPanelDoctorPatientButton.TabIndex = 0;
            this.metroPanelDoctorPatientButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelDoctorPatientButton.VerticalScrollbarBarColor = true;
            this.metroPanelDoctorPatientButton.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelDoctorPatientButton.VerticalScrollbarSize = 10;
            // 
            // metroTextButtonDoctorPatientList
            // 
            this.metroTextButtonDoctorPatientList.Image = null;
            this.metroTextButtonDoctorPatientList.Location = new System.Drawing.Point(3, 0);
            this.metroTextButtonDoctorPatientList.Name = "metroTextButtonDoctorPatientList";
            this.metroTextButtonDoctorPatientList.Size = new System.Drawing.Size(557, 50);
            this.metroTextButtonDoctorPatientList.TabIndex = 2;
            this.metroTextButtonDoctorPatientList.Text = "Patient List";
            this.metroTextButtonDoctorPatientList.UseSelectable = true;
            this.metroTextButtonDoctorPatientList.UseVisualStyleBackColor = true;
            this.metroTextButtonDoctorPatientList.Click += new System.EventHandler(this.metroTextButtonDoctorPatientList_Click);
            // 
            // metroPanelDoctorPatient
            // 
            this.metroPanelDoctorPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelDoctorPatient.HorizontalScrollbarBarColor = true;
            this.metroPanelDoctorPatient.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelDoctorPatient.HorizontalScrollbarSize = 10;
            this.metroPanelDoctorPatient.Location = new System.Drawing.Point(0, 50);
            this.metroPanelDoctorPatient.Name = "metroPanelDoctorPatient";
            this.metroPanelDoctorPatient.Size = new System.Drawing.Size(560, 420);
            this.metroPanelDoctorPatient.TabIndex = 1;
            this.metroPanelDoctorPatient.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelDoctorPatient.VerticalScrollbarBarColor = true;
            this.metroPanelDoctorPatient.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelDoctorPatient.VerticalScrollbarSize = 10;
            // 
            // UserControlDoctorPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanelDoctorPatient);
            this.Controls.Add(this.metroPanelDoctorPatientButton);
            this.Name = "UserControlDoctorPatient";
            this.Size = new System.Drawing.Size(560, 470);
            this.metroPanelDoctorPatientButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanelDoctorPatientButton;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonDoctorPatientList;
        private MetroFramework.Controls.MetroPanel metroPanelDoctorPatient;
    }
}
