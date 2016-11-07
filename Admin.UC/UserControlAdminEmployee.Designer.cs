namespace HospitalManagementSystem.UI.Admin.UC
{
    partial class UserControlAdminEmployee
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
            this.metroPanelAdminEmployeeButton = new MetroFramework.Controls.MetroPanel();
            this.metroTextButtonAdminAddEmployee = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButtonAdminEmployeeList = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroPanelAdminEmployee = new MetroFramework.Controls.MetroPanel();
            this.metroPanelAdminEmployeeButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanelAdminEmployeeButton
            // 
            this.metroPanelAdminEmployeeButton.Controls.Add(this.metroTextButtonAdminAddEmployee);
            this.metroPanelAdminEmployeeButton.Controls.Add(this.metroTextButtonAdminEmployeeList);
            this.metroPanelAdminEmployeeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanelAdminEmployeeButton.HorizontalScrollbarBarColor = true;
            this.metroPanelAdminEmployeeButton.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelAdminEmployeeButton.HorizontalScrollbarSize = 10;
            this.metroPanelAdminEmployeeButton.Location = new System.Drawing.Point(0, 0);
            this.metroPanelAdminEmployeeButton.Name = "metroPanelAdminEmployeeButton";
            this.metroPanelAdminEmployeeButton.Size = new System.Drawing.Size(560, 50);
            this.metroPanelAdminEmployeeButton.TabIndex = 0;
            this.metroPanelAdminEmployeeButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelAdminEmployeeButton.VerticalScrollbarBarColor = true;
            this.metroPanelAdminEmployeeButton.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelAdminEmployeeButton.VerticalScrollbarSize = 10;
            // 
            // metroTextButtonAdminAddEmployee
            // 
            this.metroTextButtonAdminAddEmployee.Image = null;
            this.metroTextButtonAdminAddEmployee.Location = new System.Drawing.Point(282, 0);
            this.metroTextButtonAdminAddEmployee.Name = "metroTextButtonAdminAddEmployee";
            this.metroTextButtonAdminAddEmployee.Size = new System.Drawing.Size(278, 50);
            this.metroTextButtonAdminAddEmployee.TabIndex = 3;
            this.metroTextButtonAdminAddEmployee.Text = "Add Employee";
            this.metroTextButtonAdminAddEmployee.UseSelectable = true;
            this.metroTextButtonAdminAddEmployee.UseVisualStyleBackColor = true;
            this.metroTextButtonAdminAddEmployee.Click += new System.EventHandler(this.metroTextButtonAdminAddEmployee_Click);
            // 
            // metroTextButtonAdminEmployeeList
            // 
            this.metroTextButtonAdminEmployeeList.Image = null;
            this.metroTextButtonAdminEmployeeList.Location = new System.Drawing.Point(3, 0);
            this.metroTextButtonAdminEmployeeList.Name = "metroTextButtonAdminEmployeeList";
            this.metroTextButtonAdminEmployeeList.Size = new System.Drawing.Size(278, 50);
            this.metroTextButtonAdminEmployeeList.TabIndex = 2;
            this.metroTextButtonAdminEmployeeList.Text = "Employee List";
            this.metroTextButtonAdminEmployeeList.UseSelectable = true;
            this.metroTextButtonAdminEmployeeList.UseVisualStyleBackColor = true;
            this.metroTextButtonAdminEmployeeList.Click += new System.EventHandler(this.metroTextButtonAdminEmployeeList_Click);
            // 
            // metroPanelAdminEmployee
            // 
            this.metroPanelAdminEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelAdminEmployee.HorizontalScrollbarBarColor = true;
            this.metroPanelAdminEmployee.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelAdminEmployee.HorizontalScrollbarSize = 10;
            this.metroPanelAdminEmployee.Location = new System.Drawing.Point(0, 50);
            this.metroPanelAdminEmployee.Name = "metroPanelAdminEmployee";
            this.metroPanelAdminEmployee.Size = new System.Drawing.Size(560, 420);
            this.metroPanelAdminEmployee.TabIndex = 1;
            this.metroPanelAdminEmployee.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelAdminEmployee.VerticalScrollbarBarColor = true;
            this.metroPanelAdminEmployee.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelAdminEmployee.VerticalScrollbarSize = 10;
            this.metroPanelAdminEmployee.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanelAdminEmployee_Paint);
            // 
            // UserControlAdminEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanelAdminEmployee);
            this.Controls.Add(this.metroPanelAdminEmployeeButton);
            this.Name = "UserControlAdminEmployee";
            this.Size = new System.Drawing.Size(560, 470);
            this.Load += new System.EventHandler(this.UserControlAdminEmployee_Load);
            this.metroPanelAdminEmployeeButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanelAdminEmployeeButton;
        private MetroFramework.Controls.MetroPanel metroPanelAdminEmployee;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonAdminEmployeeList;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonAdminAddEmployee;
    }
}
