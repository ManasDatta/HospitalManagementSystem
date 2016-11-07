namespace HospitalManagementSystem.UI.Admin.UC
{
    partial class UserControlAdminReceptionist
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
            this.metroPanelAdminReceptionistButton = new MetroFramework.Controls.MetroPanel();
            this.metroTextButtonAdminAddReceptionist = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButtonAdminReceptionistList = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroPanelAdminReceptionist = new MetroFramework.Controls.MetroPanel();
            this.metroPanelAdminReceptionistButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanelAdminReceptionistButton
            // 
            this.metroPanelAdminReceptionistButton.Controls.Add(this.metroTextButtonAdminAddReceptionist);
            this.metroPanelAdminReceptionistButton.Controls.Add(this.metroTextButtonAdminReceptionistList);
            this.metroPanelAdminReceptionistButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanelAdminReceptionistButton.HorizontalScrollbarBarColor = true;
            this.metroPanelAdminReceptionistButton.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelAdminReceptionistButton.HorizontalScrollbarSize = 10;
            this.metroPanelAdminReceptionistButton.Location = new System.Drawing.Point(0, 0);
            this.metroPanelAdminReceptionistButton.Name = "metroPanelAdminReceptionistButton";
            this.metroPanelAdminReceptionistButton.Size = new System.Drawing.Size(560, 50);
            this.metroPanelAdminReceptionistButton.TabIndex = 0;
            this.metroPanelAdminReceptionistButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelAdminReceptionistButton.VerticalScrollbarBarColor = true;
            this.metroPanelAdminReceptionistButton.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelAdminReceptionistButton.VerticalScrollbarSize = 10;
            // 
            // metroTextButtonAdminAddReceptionist
            // 
            this.metroTextButtonAdminAddReceptionist.Image = null;
            this.metroTextButtonAdminAddReceptionist.Location = new System.Drawing.Point(282, 0);
            this.metroTextButtonAdminAddReceptionist.Name = "metroTextButtonAdminAddReceptionist";
            this.metroTextButtonAdminAddReceptionist.Size = new System.Drawing.Size(278, 50);
            this.metroTextButtonAdminAddReceptionist.TabIndex = 3;
            this.metroTextButtonAdminAddReceptionist.Text = "Add Receptionist";
            this.metroTextButtonAdminAddReceptionist.UseSelectable = true;
            this.metroTextButtonAdminAddReceptionist.UseVisualStyleBackColor = true;
            this.metroTextButtonAdminAddReceptionist.Click += new System.EventHandler(this.metroTextButtonAdminAddReceptionist_Click);
            // 
            // metroTextButtonAdminReceptionistList
            // 
            this.metroTextButtonAdminReceptionistList.Image = null;
            this.metroTextButtonAdminReceptionistList.Location = new System.Drawing.Point(3, 0);
            this.metroTextButtonAdminReceptionistList.Name = "metroTextButtonAdminReceptionistList";
            this.metroTextButtonAdminReceptionistList.Size = new System.Drawing.Size(278, 50);
            this.metroTextButtonAdminReceptionistList.TabIndex = 2;
            this.metroTextButtonAdminReceptionistList.Text = "Receptionist List";
            this.metroTextButtonAdminReceptionistList.UseSelectable = true;
            this.metroTextButtonAdminReceptionistList.UseVisualStyleBackColor = true;
            this.metroTextButtonAdminReceptionistList.Click += new System.EventHandler(this.metroTextButtonAdminReceptionistList_Click);
            // 
            // metroPanelAdminReceptionist
            // 
            this.metroPanelAdminReceptionist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelAdminReceptionist.HorizontalScrollbarBarColor = true;
            this.metroPanelAdminReceptionist.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelAdminReceptionist.HorizontalScrollbarSize = 10;
            this.metroPanelAdminReceptionist.Location = new System.Drawing.Point(0, 50);
            this.metroPanelAdminReceptionist.Name = "metroPanelAdminReceptionist";
            this.metroPanelAdminReceptionist.Size = new System.Drawing.Size(560, 420);
            this.metroPanelAdminReceptionist.TabIndex = 1;
            this.metroPanelAdminReceptionist.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelAdminReceptionist.VerticalScrollbarBarColor = true;
            this.metroPanelAdminReceptionist.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelAdminReceptionist.VerticalScrollbarSize = 10;
            // 
            // UserControlAdminReceptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanelAdminReceptionist);
            this.Controls.Add(this.metroPanelAdminReceptionistButton);
            this.Name = "UserControlAdminReceptionist";
            this.Size = new System.Drawing.Size(560, 470);
            this.metroPanelAdminReceptionistButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanelAdminReceptionistButton;
        private MetroFramework.Controls.MetroPanel metroPanelAdminReceptionist;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonAdminReceptionistList;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonAdminAddReceptionist;
    }
}
