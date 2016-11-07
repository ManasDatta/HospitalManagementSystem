namespace HospitalManagementSystem.UI.Accountant.UC
{
    partial class UserControlAccountantSalary
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
            this.metroPanelAccountantSalaryButton = new MetroFramework.Controls.MetroPanel();
            this.metroTextButtonAccountantSalaryList = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroPanelAccountantSalary = new MetroFramework.Controls.MetroPanel();
            this.metroPanelAccountantSalaryButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanelAccountantSalaryButton
            // 
            this.metroPanelAccountantSalaryButton.Controls.Add(this.metroTextButtonAccountantSalaryList);
            this.metroPanelAccountantSalaryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanelAccountantSalaryButton.HorizontalScrollbarBarColor = true;
            this.metroPanelAccountantSalaryButton.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelAccountantSalaryButton.HorizontalScrollbarSize = 10;
            this.metroPanelAccountantSalaryButton.Location = new System.Drawing.Point(0, 0);
            this.metroPanelAccountantSalaryButton.Name = "metroPanelAccountantSalaryButton";
            this.metroPanelAccountantSalaryButton.Size = new System.Drawing.Size(560, 50);
            this.metroPanelAccountantSalaryButton.TabIndex = 0;
            this.metroPanelAccountantSalaryButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelAccountantSalaryButton.VerticalScrollbarBarColor = true;
            this.metroPanelAccountantSalaryButton.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelAccountantSalaryButton.VerticalScrollbarSize = 10;
            // 
            // metroTextButtonAccountantSalaryList
            // 
            this.metroTextButtonAccountantSalaryList.Image = null;
            this.metroTextButtonAccountantSalaryList.Location = new System.Drawing.Point(3, 0);
            this.metroTextButtonAccountantSalaryList.Name = "metroTextButtonAccountantSalaryList";
            this.metroTextButtonAccountantSalaryList.Size = new System.Drawing.Size(557, 50);
            this.metroTextButtonAccountantSalaryList.TabIndex = 2;
            this.metroTextButtonAccountantSalaryList.Text = "Salary List";
            this.metroTextButtonAccountantSalaryList.UseSelectable = true;
            this.metroTextButtonAccountantSalaryList.UseVisualStyleBackColor = true;
            this.metroTextButtonAccountantSalaryList.Click += new System.EventHandler(this.metroTextButtonAccountantSalaryList_Click);
            // 
            // metroPanelAccountantSalary
            // 
            this.metroPanelAccountantSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelAccountantSalary.HorizontalScrollbarBarColor = true;
            this.metroPanelAccountantSalary.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelAccountantSalary.HorizontalScrollbarSize = 10;
            this.metroPanelAccountantSalary.Location = new System.Drawing.Point(0, 50);
            this.metroPanelAccountantSalary.Name = "metroPanelAccountantSalary";
            this.metroPanelAccountantSalary.Size = new System.Drawing.Size(560, 420);
            this.metroPanelAccountantSalary.TabIndex = 2;
            this.metroPanelAccountantSalary.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelAccountantSalary.VerticalScrollbarBarColor = true;
            this.metroPanelAccountantSalary.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelAccountantSalary.VerticalScrollbarSize = 10;
            // 
            // UserControlAccountantSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanelAccountantSalary);
            this.Controls.Add(this.metroPanelAccountantSalaryButton);
            this.Name = "UserControlAccountantSalary";
            this.Size = new System.Drawing.Size(560, 470);
            this.metroPanelAccountantSalaryButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanelAccountantSalaryButton;
        private MetroFramework.Controls.MetroPanel metroPanelAccountantSalary;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonAccountantSalaryList;
    }
}
