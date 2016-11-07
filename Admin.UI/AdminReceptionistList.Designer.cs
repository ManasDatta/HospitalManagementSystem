namespace HospitalManagementSystem.UI.Admin.UI
{
    partial class AdminReceptionistList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminReceptionistList));
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.receptionistNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptionistAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptionistPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptionistSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptionistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMSDataSet = new HospitalManagementSystem.UI.HMSDataSet();
            this.receptionistTableAdapter = new HospitalManagementSystem.UI.HMSDataSetTableAdapters.ReceptionistTableAdapter();
            this.metroTextButton1 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGrid1
            // 
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
            this.receptionistNameDataGridViewTextBoxColumn,
            this.receptionistAddressDataGridViewTextBoxColumn,
            this.receptionistPhoneDataGridViewTextBoxColumn,
            this.receptionistSalaryDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.receptionistBindingSource;
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
            // 
            // receptionistNameDataGridViewTextBoxColumn
            // 
            this.receptionistNameDataGridViewTextBoxColumn.DataPropertyName = "ReceptionistName";
            this.receptionistNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.receptionistNameDataGridViewTextBoxColumn.Name = "receptionistNameDataGridViewTextBoxColumn";
            this.receptionistNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // receptionistAddressDataGridViewTextBoxColumn
            // 
            this.receptionistAddressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.receptionistAddressDataGridViewTextBoxColumn.DataPropertyName = "ReceptionistAddress";
            this.receptionistAddressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.receptionistAddressDataGridViewTextBoxColumn.Name = "receptionistAddressDataGridViewTextBoxColumn";
            // 
            // receptionistPhoneDataGridViewTextBoxColumn
            // 
            this.receptionistPhoneDataGridViewTextBoxColumn.DataPropertyName = "ReceptionistPhone";
            this.receptionistPhoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.receptionistPhoneDataGridViewTextBoxColumn.Name = "receptionistPhoneDataGridViewTextBoxColumn";
            this.receptionistPhoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // receptionistSalaryDataGridViewTextBoxColumn
            // 
            this.receptionistSalaryDataGridViewTextBoxColumn.DataPropertyName = "ReceptionistSalary";
            this.receptionistSalaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.receptionistSalaryDataGridViewTextBoxColumn.Name = "receptionistSalaryDataGridViewTextBoxColumn";
            this.receptionistSalaryDataGridViewTextBoxColumn.Width = 150;
            // 
            // receptionistBindingSource
            // 
            this.receptionistBindingSource.DataMember = "Receptionist";
            this.receptionistBindingSource.DataSource = this.hMSDataSet;
            // 
            // hMSDataSet
            // 
            this.hMSDataSet.DataSetName = "HMSDataSet";
            this.hMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receptionistTableAdapter
            // 
            this.receptionistTableAdapter.ClearBeforeFill = true;
            // 
            // metroTextButton1
            // 
            this.metroTextButton1.Image = global::HospitalManagementSystem.UI.Properties.Resources.admin_with_cogwheels_78948;
            this.metroTextButton1.Location = new System.Drawing.Point(23, 29);
            this.metroTextButton1.Name = "metroTextButton1";
            this.metroTextButton1.Size = new System.Drawing.Size(50, 25);
            this.metroTextButton1.TabIndex = 5;
            this.metroTextButton1.UseSelectable = true;
            this.metroTextButton1.UseVisualStyleBackColor = true;
            this.metroTextButton1.Click += new System.EventHandler(this.metroTextButton1_Click);
            // 
            // AdminReceptionistList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.metroTextButton1);
            this.Controls.Add(this.metroGrid1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminReceptionistList";
            this.Resizable = false;
            this.Text = "Receptionist List";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.AdminReceptionistList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private HMSDataSet hMSDataSet;
        private System.Windows.Forms.BindingSource receptionistBindingSource;
        private HMSDataSetTableAdapters.ReceptionistTableAdapter receptionistTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptionistNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptionistAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptionistPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptionistSalaryDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton1;
    }
}