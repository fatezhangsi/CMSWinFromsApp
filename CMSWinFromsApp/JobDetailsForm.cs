using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSWinFromsApp
{
    public partial class JobDetailsForm : Form
    {
        public JobDetailsForm()
        {
            InitializeComponent();
        }

        private void btnCancelAll_Click(object sender, EventArgs e)
        {
       

        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {

        }

        private void label1_Leave(object sender, EventArgs e)
        {

        }

        private void JobDetailsForm_Leave(object sender, EventArgs e)
        {
          
        }

        private void txtRemarks_Leave(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCarNo_Leave(object sender, EventArgs e)
        {
            if ((txtCarNo.Text == "") || (txtCarNo.Text == null))
            {
                MessageBox.Show("Please Specify a valid value" +
                    "of the car Number", "Error in input");
                txtCarNo.Focus();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCarNo.Text.Length < 6)
            {
                MessageBox.Show("Please specify a valid car number");
                txtCarNo.Focus();
                return;
            }
            try
            {
                if (Convert.ToInt32(txtWorkerId.Text) < 1)
                {
                    MessageBox.Show("Please specify a valid worker Id");
                    txtWorkerId.Focus();
                    return;
                }
                if (Convert.ToDateTime(dateTimePicker1.Value) > DateTime.Today)
                {
                    MessageBox.Show("Please specify valid Date");
                    dateTimePicker1.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }
