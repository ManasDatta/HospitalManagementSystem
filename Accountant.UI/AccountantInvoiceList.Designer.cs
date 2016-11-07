namespace HospitalManagementSystem.UI.Accountant.UI
{
    partial class AccountantInvoiceList
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountantInvoiceList));
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.metroTextButton1 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.hMSDataSet = new HospitalManagementSystem.UI.HMSDataSet();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceTableAdapter = new HospitalManagementSystem.UI.HMSDataSetTableAdapters.InvoiceTableAdapter();
            this.invoiceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoicePatientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDoctorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceRoomNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDateOfAdmissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDateOfReleaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceAdmissionChargeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceServiceChargeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDoctorFeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceRoomChargePerDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceRoomNoOfDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDiscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceVatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceTotalBillDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToOrderColumns = true;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceIdDataGridViewTextBoxColumn,
            this.invoiceDateDataGridViewTextBoxColumn,
            this.invoicePatientNameDataGridViewTextBoxColumn,
            this.invoiceDoctorNameDataGridViewTextBoxColumn,
            this.invoiceRoomNoDataGridViewTextBoxColumn,
            this.invoiceDateOfAdmissionDataGridViewTextBoxColumn,
            this.invoiceDateOfReleaseDataGridViewTextBoxColumn,
            this.invoiceAdmissionChargeDataGridViewTextBoxColumn,
            this.invoiceServiceChargeDataGridViewTextBoxColumn,
            this.invoiceDoctorFeesDataGridViewTextBoxColumn,
            this.invoiceRoomChargePerDayDataGridViewTextBoxColumn,
            this.invoiceRoomNoOfDaysDataGridViewTextBoxColumn,
            this.invoiceDiscountDataGridViewTextBoxColumn,
            this.invoiceVatDataGridViewTextBoxColumn,
            this.invoiceTotalBillDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.invoiceBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGrid1.Location = new System.Drawing.Point(23, 60);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(804, 458);
            this.metroGrid1.TabIndex = 0;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // metroTextButton1
            // 
            this.metroTextButton1.Image = global::HospitalManagementSystem.UI.Properties.Resources.worker_in_front_of_a_computer_monitor_31618;
            this.metroTextButton1.Location = new System.Drawing.Point(23, 29);
            this.metroTextButton1.Name = "metroTextButton1";
            this.metroTextButton1.Size = new System.Drawing.Size(50, 25);
            this.metroTextButton1.TabIndex = 3;
            this.metroTextButton1.UseSelectable = true;
            this.metroTextButton1.UseVisualStyleBackColor = true;
            this.metroTextButton1.Click += new System.EventHandler(this.metroTextButton1_Click);
            // 
            // hMSDataSet
            // 
            this.hMSDataSet.DataSetName = "HMSDataSet";
            this.hMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.hMSDataSet;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceIdDataGridViewTextBoxColumn
            // 
            this.invoiceIdDataGridViewTextBoxColumn.DataPropertyName = "InvoiceId";
            this.invoiceIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.invoiceIdDataGridViewTextBoxColumn.Name = "invoiceIdDataGridViewTextBoxColumn";
            this.invoiceIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceIdDataGridViewTextBoxColumn.Width = 40;
            // 
            // invoiceDateDataGridViewTextBoxColumn
            // 
            this.invoiceDateDataGridViewTextBoxColumn.DataPropertyName = "InvoiceDate";
            this.invoiceDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.invoiceDateDataGridViewTextBoxColumn.Name = "invoiceDateDataGridViewTextBoxColumn";
            this.invoiceDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceDateDataGridViewTextBoxColumn.Width = 75;
            // 
            // invoicePatientNameDataGridViewTextBoxColumn
            // 
            this.invoicePatientNameDataGridViewTextBoxColumn.DataPropertyName = "InvoicePatientName";
            this.invoicePatientNameDataGridViewTextBoxColumn.HeaderText = "Patient Name";
            this.invoicePatientNameDataGridViewTextBoxColumn.Name = "invoicePatientNameDataGridViewTextBoxColumn";
            this.invoicePatientNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoiceDoctorNameDataGridViewTextBoxColumn
            // 
            this.invoiceDoctorNameDataGridViewTextBoxColumn.DataPropertyName = "InvoiceDoctorName";
            this.invoiceDoctorNameDataGridViewTextBoxColumn.HeaderText = "Doctor Name";
            this.invoiceDoctorNameDataGridViewTextBoxColumn.Name = "invoiceDoctorNameDataGridViewTextBoxColumn";
            this.invoiceDoctorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoiceRoomNoDataGridViewTextBoxColumn
            // 
            this.invoiceRoomNoDataGridViewTextBoxColumn.DataPropertyName = "InvoiceRoomNo";
            this.invoiceRoomNoDataGridViewTextBoxColumn.HeaderText = "RoomNo";
            this.invoiceRoomNoDataGridViewTextBoxColumn.Name = "invoiceRoomNoDataGridViewTextBoxColumn";
            this.invoiceRoomNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceRoomNoDataGridViewTextBoxColumn.Width = 75;
            // 
            // invoiceDateOfAdmissionDataGridViewTextBoxColumn
            // 
            this.invoiceDateOfAdmissionDataGridViewTextBoxColumn.DataPropertyName = "InvoiceDateOfAdmission";
            this.invoiceDateOfAdmissionDataGridViewTextBoxColumn.HeaderText = "Date Of Admission";
            this.invoiceDateOfAdmissionDataGridViewTextBoxColumn.Name = "invoiceDateOfAdmissionDataGridViewTextBoxColumn";
            this.invoiceDateOfAdmissionDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceDateOfAdmissionDataGridViewTextBoxColumn.Width = 140;
            // 
            // invoiceDateOfReleaseDataGridViewTextBoxColumn
            // 
            this.invoiceDateOfReleaseDataGridViewTextBoxColumn.DataPropertyName = "InvoiceDateOfRelease";
            this.invoiceDateOfReleaseDataGridViewTextBoxColumn.HeaderText = "Date Of Release";
            this.invoiceDateOfReleaseDataGridViewTextBoxColumn.Name = "invoiceDateOfReleaseDataGridViewTextBoxColumn";
            this.invoiceDateOfReleaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceDateOfReleaseDataGridViewTextBoxColumn.Width = 135;
            // 
            // invoiceAdmissionChargeDataGridViewTextBoxColumn
            // 
            this.invoiceAdmissionChargeDataGridViewTextBoxColumn.DataPropertyName = "InvoiceAdmissionCharge";
            this.invoiceAdmissionChargeDataGridViewTextBoxColumn.HeaderText = "Admission Charge";
            this.invoiceAdmissionChargeDataGridViewTextBoxColumn.Name = "invoiceAdmissionChargeDataGridViewTextBoxColumn";
            this.invoiceAdmissionChargeDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceAdmissionChargeDataGridViewTextBoxColumn.Width = 140;
            // 
            // invoiceServiceChargeDataGridViewTextBoxColumn
            // 
            this.invoiceServiceChargeDataGridViewTextBoxColumn.DataPropertyName = "InvoiceServiceCharge";
            this.invoiceServiceChargeDataGridViewTextBoxColumn.HeaderText = "Service Charge";
            this.invoiceServiceChargeDataGridViewTextBoxColumn.Name = "invoiceServiceChargeDataGridViewTextBoxColumn";
            this.invoiceServiceChargeDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceServiceChargeDataGridViewTextBoxColumn.Width = 130;
            // 
            // invoiceDoctorFeesDataGridViewTextBoxColumn
            // 
            this.invoiceDoctorFeesDataGridViewTextBoxColumn.DataPropertyName = "InvoiceDoctorFees";
            this.invoiceDoctorFeesDataGridViewTextBoxColumn.HeaderText = "Doctor Fees";
            this.invoiceDoctorFeesDataGridViewTextBoxColumn.Name = "invoiceDoctorFeesDataGridViewTextBoxColumn";
            this.invoiceDoctorFeesDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceDoctorFeesDataGridViewTextBoxColumn.Width = 125;
            // 
            // invoiceRoomChargePerDayDataGridViewTextBoxColumn
            // 
            this.invoiceRoomChargePerDayDataGridViewTextBoxColumn.DataPropertyName = "InvoiceRoomChargePerDay";
            this.invoiceRoomChargePerDayDataGridViewTextBoxColumn.HeaderText = "Charge Per Day";
            this.invoiceRoomChargePerDayDataGridViewTextBoxColumn.Name = "invoiceRoomChargePerDayDataGridViewTextBoxColumn";
            this.invoiceRoomChargePerDayDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceRoomChargePerDayDataGridViewTextBoxColumn.Width = 140;
            // 
            // invoiceRoomNoOfDaysDataGridViewTextBoxColumn
            // 
            this.invoiceRoomNoOfDaysDataGridViewTextBoxColumn.DataPropertyName = "InvoiceRoomNoOfDays";
            this.invoiceRoomNoOfDaysDataGridViewTextBoxColumn.HeaderText = "No Of Days";
            this.invoiceRoomNoOfDaysDataGridViewTextBoxColumn.Name = "invoiceRoomNoOfDaysDataGridViewTextBoxColumn";
            this.invoiceRoomNoOfDaysDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceRoomNoOfDaysDataGridViewTextBoxColumn.Width = 125;
            // 
            // invoiceDiscountDataGridViewTextBoxColumn
            // 
            this.invoiceDiscountDataGridViewTextBoxColumn.DataPropertyName = "InvoiceDiscount";
            this.invoiceDiscountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.invoiceDiscountDataGridViewTextBoxColumn.Name = "invoiceDiscountDataGridViewTextBoxColumn";
            this.invoiceDiscountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoiceVatDataGridViewTextBoxColumn
            // 
            this.invoiceVatDataGridViewTextBoxColumn.DataPropertyName = "InvoiceVat";
            this.invoiceVatDataGridViewTextBoxColumn.HeaderText = "Vat";
            this.invoiceVatDataGridViewTextBoxColumn.Name = "invoiceVatDataGridViewTextBoxColumn";
            this.invoiceVatDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceVatDataGridViewTextBoxColumn.Width = 50;
            // 
            // invoiceTotalBillDataGridViewTextBoxColumn
            // 
            this.invoiceTotalBillDataGridViewTextBoxColumn.DataPropertyName = "InvoiceTotalBill";
            this.invoiceTotalBillDataGridViewTextBoxColumn.HeaderText = "Total Bill";
            this.invoiceTotalBillDataGridViewTextBoxColumn.Name = "invoiceTotalBillDataGridViewTextBoxColumn";
            this.invoiceTotalBillDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AccountantInvoiceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.metroTextButton1);
            this.Controls.Add(this.metroGrid1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AccountantInvoiceList";
            this.Resizable = false;
            this.Text = "Invoice List";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.AccountantInvoiceList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalBillDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton1;
        private HMSDataSet hMSDataSet;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private HMSDataSetTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoicePatientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDoctorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceRoomNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDateOfAdmissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDateOfReleaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceAdmissionChargeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceServiceChargeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDoctorFeesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceRoomChargePerDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceRoomNoOfDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDiscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceVatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceTotalBillDataGridViewTextBoxColumn;
    }
}