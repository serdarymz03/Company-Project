using Business.Concrete;
using DataAccess.Concrete;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.Admin
{
    public partial class FrmJobs : Form
    {
        JobManager jobManager;
        Job job;
        public FrmJobs()
        {
            InitializeComponent();
            jobManager = JobManager.GetInstance();
        }

        private void FrmJobs_Load(object sender, EventArgs e)
        {
            JobList();
        }
        public void JobList()
        {
            DtgJobs.DataSource = jobManager.GetList();
            job = null;
            Clear();
        }

        private void Clear()
        {
            TxtName.Text = ""; RchDescription.Text = "";
        }

        private void DtgJobs_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DtgJobs.CurrentRow == null)
            {
                MessageBox.Show("Öncelikle İş Bilgisi Seçiniz");
                return;
            }

            //TO DO Current Row

            DataGridViewRow row = DtgJobs.CurrentRow;
            job = new Job(
                row.Cells["Id"].Value.ConInt(),
                row.Cells["JobName"].Value.ToString(),
                row.Cells["JobContent"].Value.ToString(),
                row.Cells["Date"].Value.ConDate()
                );

            TxtName.Text = job.JobName;
            RchDescription.Text = job.JobContent;
            DatePicker.Value = job.Date;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (job == null)
            {
                MessageBox.Show("Öncelikle İş Bilgisi Seçiniz");
                return;
            }

            DialogResult dr = MessageBox.Show(TxtName.Text + " İş Kaydı Güncellenecektir. Onaylıyor Musunuz ? ", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                job.JobName = TxtName.Text;
                job.JobContent = RchDescription.Text;
                MessageBox.Show(jobManager.Update(job));
                JobList();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (job == null)
            {
                MessageBox.Show("Öncelikle İş Bilgisi Seçiniz");
                return;
            }

            DialogResult dr = MessageBox.Show(TxtName.Text + " İş Kaydı Silinecektir. Onaylıyor Musunuz ? ", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                MessageBox.Show(jobManager.Delete(job.Id));
                JobList();
            }
        }

        private void BtnNewJob_Click(object sender, EventArgs e)
        {
            FrmJobAdd frmJobAdd = new FrmJobAdd();
            frmJobAdd.ShowDialog();
        }
    }
}
