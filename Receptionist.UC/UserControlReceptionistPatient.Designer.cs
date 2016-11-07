namespace HospitalManagementSystem.UI.Receptionist.UC
{
    partial class UserControlReceptionistPatient
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
            this.metroPanelReceptionistPatientButton = new MetroFramework.Controls.MetroPanel();
            this.metroTextButtonReceptionistAddPatient = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButtonReceptionistPatientList = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroPanelReceptionistPatient = new MetroFramework.Controls.MetroPanel();
            this.metroPanelReceptionistPatientButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanelReceptionistPatientButton
            // 
            this.metroPanelReceptionistPatientButton.Controls.Add(this.metroTextButtonReceptionistAddPatient);
            this.metroPanelReceptionistPatientButton.Controls.Add(this.metroTextButtonReceptionistPatientList);
            this.metroPanelReceptionistPatientButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanelReceptionistPatientButton.HorizontalScrollbarBarColor = true;
            this.metroPanelReceptionistPatientButton.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelReceptionistPatientButton.HorizontalScrollbarSize = 10;
            this.metroPanelReceptionistPatientButton.Location = new System.Drawing.Point(0, 0);
            this.metroPanelReceptionistPatientButton.Name = "metroPanelReceptionistPatientButton";
            this.metroPanelReceptionistPatientButton.Size = new System.Drawing.Size(560, 50);
            this.metroPanelReceptionistPatientButton.TabIndex = 0;
            this.metroPanelReceptionistPatientButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelReceptionistPatientButton.VerticalScrollbarBarColor = true;
            this.metroPanelReceptionistPatientButton.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelReceptionistPatientButton.VerticalScrollbarSize = 10;
            // 
            // metroTextButtonReceptionistAddPatient
            // 
            this.metroTextButtonReceptionistAddPatient.Image = null;
            this.metroTextButtonReceptionistAddPatient.Location = new System.Drawing.Point(282, 0);
            this.metroTextButtonReceptionistAddPatient.Name = "metroTextButtonReceptionistAddPatient";
            this.metroTextButtonReceptionistAddPatient.Size = new System.Drawing.Size(278, 50);
            this.metroTextButtonReceptionistAddPatient.TabIndex = 3;
            this.metroTextButtonReceptionistAddPatient.Text = "Add Patient";
            this.metroTextButtonReceptionistAddPatient.UseSelectable = true;
            this.metroTextButtonReceptionistAddPatient.UseVisualStyleBackColor = true;
            this.metroTextButtonReceptionistAddPatient.Click += new System.EventHandler(this.metroTextButtonReceptionistAddPatient_Click);
            // 
            // metroTextButtonReceptionistPatientList
            // 
            this.metroTextButtonReceptionistPatientList.Image = null;
            this.metroTextButtonReceptionistPatientList.Location = new System.Drawing.Point(3, 0);
            this.metroTextButtonReceptionistPatientList.Name = "metroTextButtonReceptionistPatientList";
            this.metroTextButtonReceptionistPatientList.Size = new System.Drawing.Size(278, 50);
            this.metroTextButtonReceptionistPatientList.TabIndex = 2;
            this.metroTextButtonReceptionistPatientList.Text = "Patient List";
            this.metroTextButtonReceptionistPatientList.UseSelectable = true;
            this.metroTextButtonReceptionistPatientList.UseVisualStyleBackColor = true;
            this.metroTextButtonReceptionistPatientList.Click += new System.EventHandler(this.metroTextButtonReceptionistPatientList_Click);
            // 
            // metroPanelReceptionistPatient
            // 
            this.metroPanelReceptionistPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelReceptionistPatient.HorizontalScrollbarBarColor = true;
            this.metroPanelReceptionistPatient.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelReceptionistPatient.HorizontalScrollbarSize = 10;
            this.metroPanelReceptionistPatient.Location = new System.Drawing.Point(0, 50);
            this.metroPanelReceptionistPatient.Name = "metroPanelReceptionistPatient";
            this.metroPanelReceptionistPatient.Size = new System.Drawing.Size(560, 420);
            this.metroPanelReceptionistPatient.TabIndex = 1;
            this.metroPanelReceptionistPatient.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelReceptionistPatient.VerticalScrollbarBarColor = true;
            this.metroPanelReceptionistPatient.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelReceptionistPatient.VerticalScrollbarSize = 10;
            // 
            // UserControlReceptionistPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanelReceptionistPatient);
            this.Controls.Add(this.metroPanelReceptionistPatientButton);
            this.Name = "UserControlReceptionistPatient";
            this.Size = new System.Drawing.Size(560, 470);
            this.metroPanelReceptionistPatientButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanelReceptionistPatientButton;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonReceptionistAddPatient;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonReceptionistPatientList;
        private MetroFramework.Controls.MetroPanel metroPanelReceptionistPatient;
    }
}
