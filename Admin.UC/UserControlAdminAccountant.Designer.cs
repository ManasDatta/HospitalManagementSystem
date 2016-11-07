namespace HospitalManagementSystem.UI.Admin.UC
{
    partial class UserControlAdminAccountant
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
            this.metroPanelAdminAccountantButton = new MetroFramework.Controls.MetroPanel();
            this.metroTextButtonAdminAccountantList = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButtonAdminAddAccountant = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroPanelAdminAccountant = new MetroFramework.Controls.MetroPanel();
            this.metroPanelAdminAccountantButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanelAdminAccountantButton
            // 
            this.metroPanelAdminAccountantButton.Controls.Add(this.metroTextButtonAdminAccountantList);
            this.metroPanelAdminAccountantButton.Controls.Add(this.metroTextButtonAdminAddAccountant);
            this.metroPanelAdminAccountantButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanelAdminAccountantButton.HorizontalScrollbarBarColor = true;
            this.metroPanelAdminAccountantButton.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelAdminAccountantButton.HorizontalScrollbarSize = 10;
            this.metroPanelAdminAccountantButton.Location = new System.Drawing.Point(0, 0);
            this.metroPanelAdminAccountantButton.Name = "metroPanelAdminAccountantButton";
            this.metroPanelAdminAccountantButton.Size = new System.Drawing.Size(560, 50);
            this.metroPanelAdminAccountantButton.TabIndex = 0;
            this.metroPanelAdminAccountantButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelAdminAccountantButton.VerticalScrollbarBarColor = true;
            this.metroPanelAdminAccountantButton.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelAdminAccountantButton.VerticalScrollbarSize = 10;
            // 
            // metroTextButtonAdminAccountantList
            // 
            this.metroTextButtonAdminAccountantList.Image = null;
            this.metroTextButtonAdminAccountantList.Location = new System.Drawing.Point(3, 0);
            this.metroTextButtonAdminAccountantList.Name = "metroTextButtonAdminAccountantList";
            this.metroTextButtonAdminAccountantList.Size = new System.Drawing.Size(278, 50);
            this.metroTextButtonAdminAccountantList.TabIndex = 2;
            this.metroTextButtonAdminAccountantList.Text = "Accountant List";
            this.metroTextButtonAdminAccountantList.UseSelectable = true;
            this.metroTextButtonAdminAccountantList.UseVisualStyleBackColor = true;
            this.metroTextButtonAdminAccountantList.Click += new System.EventHandler(this.metroTextButtonAccountantList_Click);
            // 
            // metroTextButtonAdminAddAccountant
            // 
            this.metroTextButtonAdminAddAccountant.Image = null;
            this.metroTextButtonAdminAddAccountant.Location = new System.Drawing.Point(282, 0);
            this.metroTextButtonAdminAddAccountant.Name = "metroTextButtonAdminAddAccountant";
            this.metroTextButtonAdminAddAccountant.Size = new System.Drawing.Size(278, 50);
            this.metroTextButtonAdminAddAccountant.TabIndex = 3;
            this.metroTextButtonAdminAddAccountant.Text = "Add Accountant";
            this.metroTextButtonAdminAddAccountant.UseSelectable = true;
            this.metroTextButtonAdminAddAccountant.UseVisualStyleBackColor = true;
            this.metroTextButtonAdminAddAccountant.Click += new System.EventHandler(this.metroTextButtonAdminAddAccountant_Click);
            // 
            // metroPanelAdminAccountant
            // 
            this.metroPanelAdminAccountant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelAdminAccountant.HorizontalScrollbarBarColor = true;
            this.metroPanelAdminAccountant.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelAdminAccountant.HorizontalScrollbarSize = 10;
            this.metroPanelAdminAccountant.Location = new System.Drawing.Point(0, 50);
            this.metroPanelAdminAccountant.Name = "metroPanelAdminAccountant";
            this.metroPanelAdminAccountant.Size = new System.Drawing.Size(560, 420);
            this.metroPanelAdminAccountant.TabIndex = 1;
            this.metroPanelAdminAccountant.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelAdminAccountant.VerticalScrollbarBarColor = true;
            this.metroPanelAdminAccountant.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelAdminAccountant.VerticalScrollbarSize = 10;
            this.metroPanelAdminAccountant.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanelAdminAccountant_Paint);
            // 
            // UserControlAdminAccountant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanelAdminAccountant);
            this.Controls.Add(this.metroPanelAdminAccountantButton);
            this.Name = "UserControlAdminAccountant";
            this.Size = new System.Drawing.Size(560, 470);
            this.metroPanelAdminAccountantButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanelAdminAccountantButton;
        private MetroFramework.Controls.MetroPanel metroPanelAdminAccountant;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonAdminAccountantList;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonAdminAddAccountant;
    }
}
