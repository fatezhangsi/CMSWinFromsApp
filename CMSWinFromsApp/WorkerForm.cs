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
    public partial class WorkerForm : Form
    {
        public WorkerForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSava_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(this.cMSDateBaseDataSet.tblWorker);
            MessageBox.Show("The Worker Table is updated");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.cMSDateBaseDataSet.tblWorker.Clear();
            sqlDataAdapter1.Fill(this.cMSDateBaseDataSet.tblWorker);
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.cMSDateBaseDataSet.tblWorker.Clear();
            sqlDataAdapter1.Fill(this.cMSDateBaseDataSet.tblWorker);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cMSDateBaseDataSet.tblWorker' table. You can move, or remove it, as needed.
            this.tblWorkerTableAdapter.Fill(this.cMSDateBaseDataSet.tblWorker);

        }

        private void sqlDataAdapter1_RowUpdated(object sender, System.Data.SqlClient.SqlRowUpdatedEventArgs e)
        {

        }
    }
}
