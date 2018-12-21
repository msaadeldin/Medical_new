namespace Medical1
{
    partial class Resrvation
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbEmpCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMobile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbIntNo = new System.Windows.Forms.TextBox();
            this.tbDpet = new System.Windows.Forms.TextBox();
            this.tbJob = new System.Windows.Forms.TextBox();
            this.cbEmpName = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.mEDICALCDataSet = new Medical1.MEDICALCDataSet();
            this.tblEmpDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEmpDataTableAdapter = new Medical1.MEDICALCDataSetTableAdapters.TblEmpDataTableAdapter();
            this.tblReservBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblReservTableAdapter = new Medical1.MEDICALCDataSetTableAdapters.TblReservTableAdapter();
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
            this.cbInvoice = new System.Windows.Forms.CheckBox();
            this.cbVacation = new System.Windows.Forms.CheckBox();
            this.cbCheckUp = new System.Windows.Forms.CheckBox();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICALCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblReservBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emp Code:";
            // 
            // tbEmpCode
            // 
            this.tbEmpCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmpDataBindingSource, "Emp_code", true));
            this.tbEmpCode.Location = new System.Drawing.Point(120, 34);
            this.tbEmpCode.Name = "tbEmpCode";
            this.tbEmpCode.Size = new System.Drawing.Size(155, 20);
            this.tbEmpCode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Emp Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dept:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Job:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mobile:";
            // 
            // tbMobile
            // 
            this.tbMobile.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmpDataBindingSource, "mobile", true));
            this.tbMobile.Location = new System.Drawing.Point(358, 60);
            this.tbMobile.Name = "tbMobile";
            this.tbMobile.Size = new System.Drawing.Size(155, 20);
            this.tbMobile.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Internal No:";
            // 
            // tbIntNo
            // 
            this.tbIntNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmpDataBindingSource, "Ext_no", true));
            this.tbIntNo.Location = new System.Drawing.Point(358, 86);
            this.tbIntNo.Name = "tbIntNo";
            this.tbIntNo.Size = new System.Drawing.Size(155, 20);
            this.tbIntNo.TabIndex = 6;
            // 
            // tbDpet
            // 
            this.tbDpet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmpDataBindingSource, "Dept", true));
            this.tbDpet.Location = new System.Drawing.Point(120, 86);
            this.tbDpet.Name = "tbDpet";
            this.tbDpet.Size = new System.Drawing.Size(155, 20);
            this.tbDpet.TabIndex = 3;
            // 
            // tbJob
            // 
            this.tbJob.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmpDataBindingSource, "Job", true));
            this.tbJob.Location = new System.Drawing.Point(358, 34);
            this.tbJob.Name = "tbJob";
            this.tbJob.Size = new System.Drawing.Size(155, 20);
            this.tbJob.TabIndex = 4;
            // 
            // cbEmpName
            // 
            this.cbEmpName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEmpDataBindingSource, "Emp_name", true));
            this.cbEmpName.DataSource = this.tblEmpDataBindingSource;
            this.cbEmpName.DisplayMember = "Emp_name";
            this.cbEmpName.FormattingEnabled = true;
            this.cbEmpName.Location = new System.Drawing.Point(120, 60);
            this.cbEmpName.Name = "cbEmpName";
            this.cbEmpName.Size = new System.Drawing.Size(155, 21);
            this.cbEmpName.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 526);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(589, 53);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // mEDICALCDataSet
            // 
            this.mEDICALCDataSet.DataSetName = "MEDICALCDataSet";
            this.mEDICALCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEmpDataBindingSource
            // 
            this.tblEmpDataBindingSource.DataMember = "TblEmpData";
            this.tblEmpDataBindingSource.DataSource = this.mEDICALCDataSet;
            // 
            // tblEmpDataTableAdapter
            // 
            this.tblEmpDataTableAdapter.ClearBeforeFill = true;
            // 
            // tblReservBindingSource
            // 
            this.tblReservBindingSource.DataMember = "TblReserv";
            this.tblReservBindingSource.DataSource = this.mEDICALCDataSet;
            // 
            // tblReservTableAdapter
            // 
            this.tblReservTableAdapter.ClearBeforeFill = true;
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
            // cbInvoice
            // 
            this.cbInvoice.AutoSize = true;
            this.cbInvoice.Location = new System.Drawing.Point(53, 127);
            this.cbInvoice.Name = "cbInvoice";
            this.cbInvoice.Size = new System.Drawing.Size(61, 17);
            this.cbInvoice.TabIndex = 7;
            this.cbInvoice.Text = "Invoice";
            this.cbInvoice.UseVisualStyleBackColor = true;
            // 
            // cbVacation
            // 
            this.cbVacation.AutoSize = true;
            this.cbVacation.Location = new System.Drawing.Point(120, 127);
            this.cbVacation.Name = "cbVacation";
            this.cbVacation.Size = new System.Drawing.Size(67, 17);
            this.cbVacation.TabIndex = 8;
            this.cbVacation.Text = "Vacation";
            this.cbVacation.UseVisualStyleBackColor = true;
            // 
            // cbCheckUp
            // 
            this.cbCheckUp.AutoSize = true;
            this.cbCheckUp.Location = new System.Drawing.Point(193, 127);
            this.cbCheckUp.Name = "cbCheckUp";
            this.cbCheckUp.Size = new System.Drawing.Size(71, 17);
            this.cbCheckUp.TabIndex = 9;
            this.cbCheckUp.Text = "Check Up";
            this.cbCheckUp.UseVisualStyleBackColor = true;
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Location = new System.Drawing.Point(270, 126);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(57, 17);
            this.cbStatus.TabIndex = 10;
            this.cbStatus.Text = "Status";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // Resrvation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 701);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.cbCheckUp);
            this.Controls.Add(this.cbVacation);
            this.Controls.Add(this.cbInvoice);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbEmpName);
            this.Controls.Add(this.tbIntNo);
            this.Controls.Add(this.tbMobile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbJob);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDpet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbEmpCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Resrvation";
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICALCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblReservBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEmpCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMobile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbIntNo;
        private System.Windows.Forms.TextBox tbDpet;
        private System.Windows.Forms.TextBox tbJob;
        private System.Windows.Forms.ComboBox cbEmpName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private MEDICALCDataSet mEDICALCDataSet;
        private System.Windows.Forms.BindingSource tblEmpDataBindingSource;
        private MEDICALCDataSetTableAdapters.TblEmpDataTableAdapter tblEmpDataTableAdapter;
        private System.Windows.Forms.BindingSource tblReservBindingSource;
        private MEDICALCDataSetTableAdapters.TblReservTableAdapter tblReservTableAdapter;
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
        private System.Windows.Forms.CheckBox cbInvoice;
        private System.Windows.Forms.CheckBox cbVacation;
        private System.Windows.Forms.CheckBox cbCheckUp;
        private System.Windows.Forms.CheckBox cbStatus;
    }
}