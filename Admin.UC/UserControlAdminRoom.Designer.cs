namespace HospitalManagementSystem.UI.Admin.UC
{
    partial class UserControlAdminRoom
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
            this.metroPanelAdminRoomButton = new MetroFramework.Controls.MetroPanel();
            this.metroTextButtonAdminRoomList = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroPanelAdminRoom = new MetroFramework.Controls.MetroPanel();
            this.metroPanelAdminRoomButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanelAdminRoomButton
            // 
            this.metroPanelAdminRoomButton.Controls.Add(this.metroTextButtonAdminRoomList);
            this.metroPanelAdminRoomButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanelAdminRoomButton.HorizontalScrollbarBarColor = true;
            this.metroPanelAdminRoomButton.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelAdminRoomButton.HorizontalScrollbarSize = 10;
            this.metroPanelAdminRoomButton.Location = new System.Drawing.Point(0, 0);
            this.metroPanelAdminRoomButton.Name = "metroPanelAdminRoomButton";
            this.metroPanelAdminRoomButton.Size = new System.Drawing.Size(560, 50);
            this.metroPanelAdminRoomButton.TabIndex = 0;
            this.metroPanelAdminRoomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelAdminRoomButton.VerticalScrollbarBarColor = true;
            this.metroPanelAdminRoomButton.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelAdminRoomButton.VerticalScrollbarSize = 10;
            // 
            // metroTextButtonAdminRoomList
            // 
            this.metroTextButtonAdminRoomList.Image = null;
            this.metroTextButtonAdminRoomList.Location = new System.Drawing.Point(3, 0);
            this.metroTextButtonAdminRoomList.Name = "metroTextButtonAdminRoomList";
            this.metroTextButtonAdminRoomList.Size = new System.Drawing.Size(557, 50);
            this.metroTextButtonAdminRoomList.TabIndex = 2;
            this.metroTextButtonAdminRoomList.Text = "Room List";
            this.metroTextButtonAdminRoomList.UseSelectable = true;
            this.metroTextButtonAdminRoomList.UseVisualStyleBackColor = true;
            this.metroTextButtonAdminRoomList.Click += new System.EventHandler(this.metroTextButtonAdminRoomList_Click);
            // 
            // metroPanelAdminRoom
            // 
            this.metroPanelAdminRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelAdminRoom.HorizontalScrollbarBarColor = true;
            this.metroPanelAdminRoom.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelAdminRoom.HorizontalScrollbarSize = 10;
            this.metroPanelAdminRoom.Location = new System.Drawing.Point(0, 50);
            this.metroPanelAdminRoom.Name = "metroPanelAdminRoom";
            this.metroPanelAdminRoom.Size = new System.Drawing.Size(560, 420);
            this.metroPanelAdminRoom.TabIndex = 1;
            this.metroPanelAdminRoom.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelAdminRoom.VerticalScrollbarBarColor = true;
            this.metroPanelAdminRoom.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelAdminRoom.VerticalScrollbarSize = 10;
            // 
            // UserControlAdminRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanelAdminRoom);
            this.Controls.Add(this.metroPanelAdminRoomButton);
            this.Name = "UserControlAdminRoom";
            this.Size = new System.Drawing.Size(560, 470);
            this.metroPanelAdminRoomButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanelAdminRoomButton;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonAdminRoomList;
        private MetroFramework.Controls.MetroPanel metroPanelAdminRoom;
    }
}
