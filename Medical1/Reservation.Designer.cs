namespace Medical1
{
    partial class Reservation
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
            System.Windows.Forms.Label emp_codeLabel;
            System.Windows.Forms.Label emp_nameLabel;
            System.Windows.Forms.Label jobLabel;
            System.Windows.Forms.Label deptLabel;
            System.Windows.Forms.Label mobileLabel;
            this.tblEmpDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEmpDataTableAdapter = new Medical1.MEDICALCDataSetTableAdapters.TblEmpDataTableAdapter();
            this.emp_codeTextBox = new System.Windows.Forms.TextBox();
            this.jobTextBox = new System.Windows.Forms.TextBox();
            this.deptTextBox = new System.Windows.Forms.TextBox();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.emp_nameComboBox = new System.Windows.Forms.ComboBox();
            this.invoiceCheckBox = new System.Windows.Forms.CheckBox();
            this.vacationCheckBox = new System.Windows.Forms.CheckBox();
            this.checkupCheckBox = new System.Windows.Forms.CheckBox();
            this.statusCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mEDICALCDataSet = new Medical1.MEDICALCDataSet();
            this.tblReservBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicalidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invconfirmDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vacconfirmDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.checkuptypeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.statusviewDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            emp_codeLabel = new System.Windows.Forms.Label();
            emp_nameLabel = new System.Windows.Forms.Label();
            jobLabel = new System.Windows.Forms.Label();
            deptLabel = new System.Windows.Forms.Label();
            mobileLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICALCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblReservBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblEmpDataTableAdapter
            // 
            this.tblEmpDataTableAdapter.ClearBeforeFill = true;
            // 
            // emp_codeLabel
            // 
            emp_codeLabel.AutoSize = true;
            emp_codeLabel.Location = new System.Drawing.Point(133, 101);
            emp_codeLabel.Name = "emp_codeLabel";
            emp_codeLabel.Size = new System.Drawing.Size(75, 17);
            emp_codeLabel.TabIndex = 2;
            emp_codeLabel.Text = "Emp code:";
            // 
            // emp_codeTextBox
            // 
            this.emp_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmpDataBindingSource, "Emp_code", true));
            this.emp_codeTextBox.Location = new System.Drawing.Point(214, 98);
            this.emp_codeTextBox.Name = "emp_codeTextBox";
            this.emp_codeTextBox.Size = new System.Drawing.Size(100, 24);
            this.emp_codeTextBox.TabIndex = 3;
            // 
            // emp_nameLabel
            // 
            emp_nameLabel.AutoSize = true;
            emp_nameLabel.Location = new System.Drawing.Point(140, 157);
            emp_nameLabel.Name = "emp_nameLabel";
            emp_nameLabel.Size = new System.Drawing.Size(79, 17);
            emp_nameLabel.TabIndex = 4;
            emp_nameLabel.Text = "Emp name:";
            // 
            // jobLabel
            // 
            jobLabel.AutoSize = true;
            jobLabel.Location = new System.Drawing.Point(144, 261);
            jobLabel.Name = "jobLabel";
            jobLabel.Size = new System.Drawing.Size(35, 17);
            jobLabel.TabIndex = 6;
            jobLabel.Text = "Job:";
            // 
            // jobTextBox
            // 
            this.jobTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmpDataBindingSource, "Job", true));
            this.jobTextBox.Location = new System.Drawing.Point(185, 258);
            this.jobTextBox.Name = "jobTextBox";
            this.jobTextBox.Size = new System.Drawing.Size(100, 24);
            this.jobTextBox.TabIndex = 7;
            // 
            // deptLabel
            // 
            deptLabel.AutoSize = true;
            deptLabel.Location = new System.Drawing.Point(155, 205);
            deptLabel.Name = "deptLabel";
            deptLabel.Size = new System.Drawing.Size(43, 17);
            deptLabel.TabIndex = 8;
            deptLabel.Text = "Dept:";
            // 
            // deptTextBox
            // 
            this.deptTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmpDataBindingSource, "Dept", true));
            this.deptTextBox.Location = new System.Drawing.Point(204, 202);
            this.deptTextBox.Name = "deptTextBox";
            this.deptTextBox.Size = new System.Drawing.Size(100, 24);
            this.deptTextBox.TabIndex = 9;
            // 
            // mobileLabel
            // 
            mobileLabel.AutoSize = true;
            mobileLabel.Location = new System.Drawing.Point(64, 303);
            mobileLabel.Name = "mobileLabel";
            mobileLabel.Size = new System.Drawing.Size(52, 17);
            mobileLabel.TabIndex = 10;
            mobileLabel.Text = "mobile:";
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmpDataBindingSource, "mobile", true));
            this.mobileTextBox.Location = new System.Drawing.Point(122, 300);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(100, 24);
            this.mobileTextBox.TabIndex = 11;
            // 
            // emp_nameComboBox
            // 
            this.emp_nameComboBox.DataSource = this.tblEmpDataBindingSource;
            this.emp_nameComboBox.DisplayMember = "Emp_name";
            this.emp_nameComboBox.FormattingEnabled = true;
            this.emp_nameComboBox.Location = new System.Drawing.Point(225, 154);
            this.emp_nameComboBox.Name = "emp_nameComboBox";
            this.emp_nameComboBox.Size = new System.Drawing.Size(255, 24);
            this.emp_nameComboBox.TabIndex = 14;
            // 
            // invoiceCheckBox
            // 
            this.invoiceCheckBox.AutoSize = true;
            this.invoiceCheckBox.Location = new System.Drawing.Point(406, 303);
            this.invoiceCheckBox.Name = "invoiceCheckBox";
            this.invoiceCheckBox.Size = new System.Drawing.Size(74, 21);
            this.invoiceCheckBox.TabIndex = 15;
            this.invoiceCheckBox.Text = "Invoice";
            this.invoiceCheckBox.UseVisualStyleBackColor = true;
            // 
            // vacationCheckBox
            // 
            this.vacationCheckBox.AutoSize = true;
            this.vacationCheckBox.Location = new System.Drawing.Point(406, 330);
            this.vacationCheckBox.Name = "vacationCheckBox";
            this.vacationCheckBox.Size = new System.Drawing.Size(82, 21);
            this.vacationCheckBox.TabIndex = 15;
            this.vacationCheckBox.Text = "Vacation";
            this.vacationCheckBox.UseVisualStyleBackColor = true;
            // 
            // checkupCheckBox
            // 
            this.checkupCheckBox.AutoSize = true;
            this.checkupCheckBox.Location = new System.Drawing.Point(406, 357);
            this.checkupCheckBox.Name = "checkupCheckBox";
            this.checkupCheckBox.Size = new System.Drawing.Size(89, 21);
            this.checkupCheckBox.TabIndex = 15;
            this.checkupCheckBox.Text = "Check Up";
            this.checkupCheckBox.UseVisualStyleBackColor = true;
            // 
            // statusCheckBox
            // 
            this.statusCheckBox.AutoSize = true;
            this.statusCheckBox.Location = new System.Drawing.Point(406, 384);
            this.statusCheckBox.Name = "statusCheckBox";
            this.statusCheckBox.Size = new System.Drawing.Size(69, 21);
            this.statusCheckBox.TabIndex = 15;
            this.statusCheckBox.Text = "Status";
            this.statusCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(706, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservnoDataGridViewTextBoxColumn,
            this.reservdateDataGridViewTextBoxColumn,
            this.medicalidDataGridViewTextBoxColumn,
            this.empidDataGridViewTextBoxColumn,
            this.empnameDataGridViewTextBoxColumn,
            this.doctorDataGridViewTextBoxColumn,
            this.invconfirmDataGridViewCheckBoxColumn,
            this.vacconfirmDataGridViewCheckBoxColumn,
            this.checkuptypeDataGridViewCheckBoxColumn,
            this.statusviewDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tblReservBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 445);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(1193, 418);
            this.dataGridView1.TabIndex = 17;
            // 
            // mEDICALCDataSet
            // 
            this.mEDICALCDataSet.DataSetName = "MEDICALCDataSet";
            this.mEDICALCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblReservBindingSource
            // 
            this.tblReservBindingSource.DataMember = "TblReserv";
            this.tblReservBindingSource.DataSource = this.mEDICALCDataSet;
            // 
            // reservnoDataGridViewTextBoxColumn
            // 
            this.reservnoDataGridViewTextBoxColumn.DataPropertyName = "Reserv_no";
            this.reservnoDataGridViewTextBoxColumn.HeaderText = "Reserv_no";
            this.reservnoDataGridViewTextBoxColumn.Name = "reservnoDataGridViewTextBoxColumn";
            // 
            // reservdateDataGridViewTextBoxColumn
            // 
            this.reservdateDataGridViewTextBoxColumn.DataPropertyName = "Reserv_date";
            this.reservdateDataGridViewTextBoxColumn.HeaderText = "Reserv_date";
            this.reservdateDataGridViewTextBoxColumn.Name = "reservdateDataGridViewTextBoxColumn";
            // 
            // medicalidDataGridViewTextBoxColumn
            // 
            this.medicalidDataGridViewTextBoxColumn.DataPropertyName = "medical_id";
            this.medicalidDataGridViewTextBoxColumn.HeaderText = "medical_id";
            this.medicalidDataGridViewTextBoxColumn.Name = "medicalidDataGridViewTextBoxColumn";
            // 
            // empidDataGridViewTextBoxColumn
            // 
            this.empidDataGridViewTextBoxColumn.DataPropertyName = "Emp_id";
            this.empidDataGridViewTextBoxColumn.HeaderText = "Emp_id";
            this.empidDataGridViewTextBoxColumn.Name = "empidDataGridViewTextBoxColumn";
            // 
            // empnameDataGridViewTextBoxColumn
            // 
            this.empnameDataGridViewTextBoxColumn.DataPropertyName = "Emp_name";
            this.empnameDataGridViewTextBoxColumn.HeaderText = "Emp_name";
            this.empnameDataGridViewTextBoxColumn.Name = "empnameDataGridViewTextBoxColumn";
            // 
            // doctorDataGridViewTextBoxColumn
            // 
            this.doctorDataGridViewTextBoxColumn.DataPropertyName = "Doctor";
            this.doctorDataGridViewTextBoxColumn.HeaderText = "Doctor";
            this.doctorDataGridViewTextBoxColumn.Name = "doctorDataGridViewTextBoxColumn";
            // 
            // invconfirmDataGridViewCheckBoxColumn
            // 
            this.invconfirmDataGridViewCheckBoxColumn.DataPropertyName = "inv_confirm";
            this.invconfirmDataGridViewCheckBoxColumn.HeaderText = "inv_confirm";
            this.invconfirmDataGridViewCheckBoxColumn.Name = "invconfirmDataGridViewCheckBoxColumn";
            // 
            // vacconfirmDataGridViewCheckBoxColumn
            // 
            this.vacconfirmDataGridViewCheckBoxColumn.DataPropertyName = "vac_confirm";
            this.vacconfirmDataGridViewCheckBoxColumn.HeaderText = "vac_confirm";
            this.vacconfirmDataGridViewCheckBoxColumn.Name = "vacconfirmDataGridViewCheckBoxColumn";
            // 
            // checkuptypeDataGridViewCheckBoxColumn
            // 
            this.checkuptypeDataGridViewCheckBoxColumn.DataPropertyName = "check_up_type";
            this.checkuptypeDataGridViewCheckBoxColumn.HeaderText = "check_up_type";
            this.checkuptypeDataGridViewCheckBoxColumn.Name = "checkuptypeDataGridViewCheckBoxColumn";
            // 
            // statusviewDataGridViewCheckBoxColumn
            // 
            this.statusviewDataGridViewCheckBoxColumn.DataPropertyName = "Status_view";
            this.statusviewDataGridViewCheckBoxColumn.HeaderText = "Status_view";
            this.statusviewDataGridViewCheckBoxColumn.Name = "statusviewDataGridViewCheckBoxColumn";
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 863);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusCheckBox);
            this.Controls.Add(this.checkupCheckBox);
            this.Controls.Add(this.vacationCheckBox);
            this.Controls.Add(this.invoiceCheckBox);
            this.Controls.Add(this.emp_nameComboBox);
            this.Controls.Add(mobileLabel);
            this.Controls.Add(this.mobileTextBox);
            this.Controls.Add(deptLabel);
            this.Controls.Add(this.deptTextBox);
            this.Controls.Add(jobLabel);
            this.Controls.Add(this.jobTextBox);
            this.Controls.Add(emp_nameLabel);
            this.Controls.Add(emp_codeLabel);
            this.Controls.Add(this.emp_codeTextBox);
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICALCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblReservBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource tblEmpDataBindingSource;
        private MEDICALCDataSetTableAdapters.TblEmpDataTableAdapter tblEmpDataTableAdapter;
        private System.Windows.Forms.TextBox emp_codeTextBox;
        private System.Windows.Forms.TextBox jobTextBox;
        private System.Windows.Forms.TextBox deptTextBox;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.ComboBox emp_nameComboBox;
        private System.Windows.Forms.CheckBox invoiceCheckBox;
        private System.Windows.Forms.CheckBox vacationCheckBox;
        private System.Windows.Forms.CheckBox checkupCheckBox;
        private System.Windows.Forms.CheckBox statusCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicalidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn invconfirmDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vacconfirmDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkuptypeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusviewDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource tblReservBindingSource;
        private MEDICALCDataSet mEDICALCDataSet;
    }
}