namespace HospitalManagementSystem.UI.Admin.UC
{
    partial class UserControlAdminDepartment
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
            this.metroPanelAdminDepartmentButton = new MetroFramework.Controls.MetroPanel();
            this.metroTextButtonAdminAddDepartment = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButtonAdminDepartmentList = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroPanelAdminDepartment = new MetroFramework.Controls.MetroPanel();
            this.metroPanelAdminDepartmentButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanelAdminDepartmentButton
            // 
            this.metroPanelAdminDepartmentButton.Controls.Add(this.metroTextButtonAdminAddDepartment);
            this.metroPanelAdminDepartmentButton.Controls.Add(this.metroTextButtonAdminDepartmentList);
            this.metroPanelAdminDepartmentButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanelAdminDepartmentButton.HorizontalScrollbarBarColor = true;
            this.metroPanelAdminDepartmentButton.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelAdminDepartmentButton.HorizontalScrollbarSize = 10;
            this.metroPanelAdminDepartmentButton.Location = new System.Drawing.Point(0, 0);
            this.metroPanelAdminDepartmentButton.Name = "metroPanelAdminDepartmentButton";
            this.metroPanelAdminDepartmentButton.Size = new System.Drawing.Size(560, 50);
            this.metroPanelAdminDepartmentButton.TabIndex = 0;
            this.metroPanelAdminDepartmentButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelAdminDepartmentButton.VerticalScrollbarBarColor = true;
            this.metroPanelAdminDepartmentButton.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelAdminDepartmentButton.VerticalScrollbarSize = 10;
            this.metroPanelAdminDepartmentButton.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanelAdminDepartmentButton_Paint);
            // 
            // metroTextButtonAdminAddDepartment
            // 
            this.metroTextButtonAdminAddDepartment.Image = null;
            this.metroTextButtonAdminAddDepartment.Location = new System.Drawing.Point(282, 0);
            this.metroTextButtonAdminAddDepartment.Name = "metroTextButtonAdminAddDepartment";
            this.metroTextButtonAdminAddDepartment.Size = new System.Drawing.Size(278, 50);
            this.metroTextButtonAdminAddDepartment.TabIndex = 3;
            this.metroTextButtonAdminAddDepartment.Text = "Add Department";
            this.metroTextButtonAdminAddDepartment.UseSelectable = true;
            this.metroTextButtonAdminAddDepartment.UseVisualStyleBackColor = true;
            this.metroTextButtonAdminAddDepartment.Click += new System.EventHandler(this.metroTextButton2_Click);
            // 
            // metroTextButtonAdminDepartmentList
            // 
            this.metroTextButtonAdminDepartmentList.Image = null;
            this.metroTextButtonAdminDepartmentList.Location = new System.Drawing.Point(3, 0);
            this.metroTextButtonAdminDepartmentList.Name = "metroTextButtonAdminDepartmentList";
            this.metroTextButtonAdminDepartmentList.Size = new System.Drawing.Size(278, 50);
            this.metroTextButtonAdminDepartmentList.TabIndex = 2;
            this.metroTextButtonAdminDepartmentList.Text = "Department List";
            this.metroTextButtonAdminDepartmentList.UseSelectable = true;
            this.metroTextButtonAdminDepartmentList.UseVisualStyleBackColor = true;
            this.metroTextButtonAdminDepartmentList.Click += new System.EventHandler(this.metroTextButtonAdminDepartmentList_Click);
            // 
            // metroPanelAdminDepartment
            // 
            this.metroPanelAdminDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelAdminDepartment.HorizontalScrollbarBarColor = true;
            this.metroPanelAdminDepartment.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelAdminDepartment.HorizontalScrollbarSize = 10;
            this.metroPanelAdminDepartment.Location = new System.Drawing.Point(0, 50);
            this.metroPanelAdminDepartment.Name = "metroPanelAdminDepartment";
            this.metroPanelAdminDepartment.Size = new System.Drawing.Size(560, 420);
            this.metroPanelAdminDepartment.TabIndex = 1;
            this.metroPanelAdminDepartment.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelAdminDepartment.VerticalScrollbarBarColor = true;
            this.metroPanelAdminDepartment.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelAdminDepartment.VerticalScrollbarSize = 10;
            this.metroPanelAdminDepartment.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanelAdminDepartment_Paint);
            // 
            // UserControlAdminDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanelAdminDepartment);
            this.Controls.Add(this.metroPanelAdminDepartmentButton);
            this.Name = "UserControlAdminDepartment";
            this.Size = new System.Drawing.Size(560, 470);
            this.metroPanelAdminDepartmentButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanelAdminDepartmentButton;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonAdminAddDepartment;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonAdminDepartmentList;
        private MetroFramework.Controls.MetroPanel metroPanelAdminDepartment;
    }
}
