namespace HospitalManagementSystem.UI.Accountant.UC
{
    partial class UserControlAccountantInvoice
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
            this.metroPanelAccountantInvoiceButtton = new MetroFramework.Controls.MetroPanel();
            this.metroTextButtonAccountantCreateInvoice = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButtonAccountantInvoiceList = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroPanelAccountantInvoice = new MetroFramework.Controls.MetroPanel();
            this.metroPanelAccountantInvoiceButtton.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanelAccountantInvoiceButtton
            // 
            this.metroPanelAccountantInvoiceButtton.Controls.Add(this.metroTextButtonAccountantCreateInvoice);
            this.metroPanelAccountantInvoiceButtton.Controls.Add(this.metroTextButtonAccountantInvoiceList);
            this.metroPanelAccountantInvoiceButtton.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanelAccountantInvoiceButtton.HorizontalScrollbarBarColor = true;
            this.metroPanelAccountantInvoiceButtton.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelAccountantInvoiceButtton.HorizontalScrollbarSize = 10;
            this.metroPanelAccountantInvoiceButtton.Location = new System.Drawing.Point(0, 0);
            this.metroPanelAccountantInvoiceButtton.Name = "metroPanelAccountantInvoiceButtton";
            this.metroPanelAccountantInvoiceButtton.Size = new System.Drawing.Size(560, 50);
            this.metroPanelAccountantInvoiceButtton.TabIndex = 0;
            this.metroPanelAccountantInvoiceButtton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelAccountantInvoiceButtton.VerticalScrollbarBarColor = true;
            this.metroPanelAccountantInvoiceButtton.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelAccountantInvoiceButtton.VerticalScrollbarSize = 10;
            this.metroPanelAccountantInvoiceButtton.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // metroTextButtonAccountantCreateInvoice
            // 
            this.metroTextButtonAccountantCreateInvoice.Image = null;
            this.metroTextButtonAccountantCreateInvoice.Location = new System.Drawing.Point(282, 0);
            this.metroTextButtonAccountantCreateInvoice.Name = "metroTextButtonAccountantCreateInvoice";
            this.metroTextButtonAccountantCreateInvoice.Size = new System.Drawing.Size(278, 50);
            this.metroTextButtonAccountantCreateInvoice.TabIndex = 3;
            this.metroTextButtonAccountantCreateInvoice.Text = "Create Invoice";
            this.metroTextButtonAccountantCreateInvoice.UseSelectable = true;
            this.metroTextButtonAccountantCreateInvoice.UseVisualStyleBackColor = true;
            this.metroTextButtonAccountantCreateInvoice.Click += new System.EventHandler(this.metroTextButtonAccountantAddInvoice_Click);
            // 
            // metroTextButtonAccountantInvoiceList
            // 
            this.metroTextButtonAccountantInvoiceList.Image = null;
            this.metroTextButtonAccountantInvoiceList.Location = new System.Drawing.Point(3, 0);
            this.metroTextButtonAccountantInvoiceList.Name = "metroTextButtonAccountantInvoiceList";
            this.metroTextButtonAccountantInvoiceList.Size = new System.Drawing.Size(278, 50);
            this.metroTextButtonAccountantInvoiceList.TabIndex = 2;
            this.metroTextButtonAccountantInvoiceList.Text = "Invoice List";
            this.metroTextButtonAccountantInvoiceList.UseSelectable = true;
            this.metroTextButtonAccountantInvoiceList.UseVisualStyleBackColor = true;
            this.metroTextButtonAccountantInvoiceList.Click += new System.EventHandler(this.metroTextButtonAccountantInvoiceList_Click);
            // 
            // metroPanelAccountantInvoice
            // 
            this.metroPanelAccountantInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelAccountantInvoice.HorizontalScrollbarBarColor = true;
            this.metroPanelAccountantInvoice.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelAccountantInvoice.HorizontalScrollbarSize = 10;
            this.metroPanelAccountantInvoice.Location = new System.Drawing.Point(0, 50);
            this.metroPanelAccountantInvoice.Name = "metroPanelAccountantInvoice";
            this.metroPanelAccountantInvoice.Size = new System.Drawing.Size(560, 420);
            this.metroPanelAccountantInvoice.TabIndex = 1;
            this.metroPanelAccountantInvoice.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanelAccountantInvoice.VerticalScrollbarBarColor = true;
            this.metroPanelAccountantInvoice.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelAccountantInvoice.VerticalScrollbarSize = 10;
            // 
            // UserControlAccountantInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanelAccountantInvoice);
            this.Controls.Add(this.metroPanelAccountantInvoiceButtton);
            this.Name = "UserControlAccountantInvoice";
            this.Size = new System.Drawing.Size(560, 470);
            this.metroPanelAccountantInvoiceButtton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanelAccountantInvoiceButtton;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonAccountantCreateInvoice;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButtonAccountantInvoiceList;
        private MetroFramework.Controls.MetroPanel metroPanelAccountantInvoice;
    }
}
