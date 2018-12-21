using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical1
{
    public partial class Resrvation : Form
    {
        public Resrvation()
        {
            InitializeComponent();
        }



        private void Reservation_Load(object sender, EventArgs e)
        {
            tblReservTableAdapter.Fill(this.mEDICALCDataSet.TblReserv);
            tblReservBindingSource.DataSource = this.mEDICALCDataSet.TblReserv;


            this.tblEmpDataTableAdapter.Fill(this.mEDICALCDataSet.TblEmpData);
            clear();


        }






        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dt = new DataSet();
                DataTable table = new DataTable("TblReserv");
                table.Columns.Add(new DataColumn("Reserv_no", typeof(int)));
                table.Columns.Add(new DataColumn("Reserv_date", typeof(DateTime)));
                table.Columns.Add(new DataColumn("Emp_id", typeof(int)));
                table.Columns.Add(new DataColumn("Emp_name", typeof(string)));
                table.Columns.Add(new DataColumn("inv_confirm", typeof(bool)));
                table.Columns.Add(new DataColumn("vac_confirm", typeof(bool)));
                table.Columns.Add(new DataColumn("check_up_type", typeof(bool)));
                table.Columns.Add(new DataColumn("Status_view", typeof(bool)));

                DataRow row = table.NewRow();
                row["Reserv_no"] = 11;
                row["Reserv_date"] = DateTime.Now;
                //row["Emp_id"] = emp_codeTextBox.Text;
                //row["Emp_name"] = emp_nameComboBox.Text;
                //row["inv_confirm"] = invoiceCheckBox.Checked;
                //row["vac_confirm"] = vacationCheckBox.Checked;
                //row["check_up_type"] = checkupCheckBox.Checked;
                //row["Status_view"] = statusCheckBox.Checked;


                table.Rows.Add(row);
                dt.Tables.Add(table);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                           
                               
                
                tblReservTableAdapter.Insert(12, DateTime.Now, 0, Convert.ToInt16( tbEmpCode.Text), cbEmpName.Text, cbInvoice.Checked, cbVacation.Checked, cbCheckUp.Checked, cbStatus.Checked,"محمد جمال"); 
                    

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tblReservBindingSource.ResetBindings(false);
            }
        }

        private void clear()
        {
            //tbEmpCode.Text = "";
            //tbDpet.Text = "";
            //tbJob.Text = "";
            //tbMobile.Text = "";
            //tbIntNo.Text = "";
            tblEmpDataBindingSource.Clear();
            cbEmpName.Text = "";
            cbInvoice.Checked = false;
            cbVacation.Checked = false;
            cbCheckUp.Checked = false;
            cbStatus.Checked = false;
        }
    }
}
