namespace HospitalManagementSystem.UI.Admin.UC
{
    partial class UserControlAdminPatient
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
            this.metroPanelAdminPatientButton = new MetroFramework.Controls.MetroPanel();
            this.metroTextButtonAdminPatientList = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroPanelAdminPatient = new MetroFramework.Controls.MetroPanel();
            this.metroPanelAdminPatientButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanelAdminPatientButton
            // 
            this.metroPanelAdminPatientButton.Controls.Add(this.metroTextButtonAdminPatientList);
            this.metroPanelAdminPatientButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanelAdminPatientButton.HorizontalScrollbarBarColor = true;
            this.metroPanelAdminPatientButton.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelAdminPatientButton.HorizontalScrollbarSize = 10;
            this.metroPanelAdminPatientButton.Location = new System.Drawing.Point(0, 0);
            this.metroPanelAdminPatientButton.Name = "metroPanelAdminPatientButton";
            this.metroPanelAdminPatientButton.Size = new System.Drawing.Size(560, 50);
            this.metroPanelAdminPatientButton.TabIndex = 0;
            this.metroPanelAdminPatientButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelAdminPatientButton.VerticalScrollbarBarColor = true;
            this.metroPanelAdminPatientButton.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelAdminPatientButton.VerticalScrollbarSize = 10;
            // 
            // metroTextButtonAdminPatientList
            // 
            this.metroTextButtonAdminPatientList.Image = null;
            this.metroTextButtonAdminPatientList.Location = new System.Drawing.Point(3, 0);
            this.metroTextButtonAdminPatientList.Name = "metroTextButtonAdminPatientList";
            this.metroTextButtonAdminPatientList.Size = new System.Drawing.Size(557, 50);
            this.metroTextButtonAdminPatientList.TabIndex = 2;
            this.metroTextButtonAdminPatientList.Text = "Patient List";
            this.metroTextButtonAdminPatientList.UseSelectable = true;
            this.metroTextButtonAdminPatientList.UseVisualStyleBackColor = true;
            this.metroTextButtonAdminPatientList.Click += new System.EventHandler(this.metroTextButtonAdminPatientList_Click);
            // 
            // metroPanelAdminPatient
            // 
            this.metroPanelAdminPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelAdminPatient.HorizontalScrollbarBarColor = true;
            this.metroPanelAdminPatient.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelAdminPatient.HorizontalScrollbarSize = 10;
            this.metroPanelAdminPatient.Location = new System.Drawing.Point(0, 50);
            this.metroPanelAdminPatient.Name = "metroPanelAdminPatient";
            this.metroPanelAdminPatient.Size = new System.Drawing.Size(560, 420);
            this.metroPanelAdminPatient.TabIndex = 1;
            this.metroPanelAdminPatient.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelAdminPatient.VerticalScrollbarBarColor = true;
            this.metroPanelAdminPatient.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelAdminPatient.VerticalScrollbarSize = 10;
            // 
            // UserControlAdminPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanelAdminPatient);
            this.Controls.Add(this.metroPanelAdminPatientButton);
            this.Name = "UserControlAdminPatient";
            this.Size = new System.Drawing.Size(560, 470);
            this.metroPanelAdminPatientButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanelAdminPatientButton;
        private MetroFramework.Controls.MetroPanel metroPanelAdminPatient;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonAdminPatientList;
    }
}
