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






       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {



                tblReservTableAdapter.Insert(12, DateTime.Now, 0, Convert.ToInt16(tbEmpCode.Text), cbEmpName.Text, cbInvoice.Checked, cbVacation.Checked, cbCheckUp.Checked, cbStatus.Checked, "محمد جمال");

            }
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
