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
    public partial class FrmJobDetailProcess : Form
    {
        JobDetailManager detailManager;
        JobManager jobManager;
        Job job;
        bool start;
        string workerNo;
        public string employerNo;
        public FrmJobDetailProcess()
        {
            InitializeComponent();
            jobManager = JobManager.GetInstance();
            detailManager = JobDetailManager.GetInstance();
        }

        private void FrmJobDetailProcess_Load(object sender, EventArgs e)
        {
            start = true;
            CmbPersonnelLoad();
            JobList();
            start = false;
        }
        void CmbPersonnelLoad()
        {
            CmbPersonnels.DataSource = PersonnelManager.GetInstance().GetList();
            CmbPersonnels.ValueMember = "PersonNo";
            CmbPersonnels.DisplayMember = "Name";
            CmbPersonnels.SelectedValue = 0;
        }

        void JobList()
        {
            DtgJobs.DataSource = jobManager.GetList();
            job = null;
            Clear();
        }

        private void DtgJobs_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DtgJobs.CurrentRow == null)
            {
                MessageBox.Show("Öncelikle İş Bilgisi Seçiniz");
                return;
            }

            DataGridViewRow row = DtgJobs.CurrentRow;

            job = new Job(
                row.Cells["Id"].Value.ConInt(),
                row.Cells["JobName"].Value.ToString(),
                row.Cells["JobContent"].Value.ToString(),
                row.Cells["Date"].Value.ConDate()
                );

            TxtJobName.Text = job.JobName;
            RchJobContent.Text = job.JobContent;
        }
        void Clear()
        {
            TxtJobName.Text = ""; RchJobContent.Text = ""; CmbPersonnels.SelectedValue = 0; TxtDepartment.Text = "";
        }

        private void CmbPersonnels_SelectedValueChanged(object sender, EventArgs e)
        {
            if (start || CmbPersonnels.SelectedValue == null)
            {
                return;
            }

            workerNo = CmbPersonnels.SelectedValue.ToString();
            TxtDepartment.Text = DepartmentManager.GetInstance().GetDepartmentNameByPersonNo(workerNo);
        }

        private void TxtJobName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void TxtJobName_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }
        private void RchJobContent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void RchJobContent_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }
        private void TxtDepartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void TxtDepartment_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void BtnSendJob_Click(object sender, EventArgs e)
        {
            JobDetail jobDetail = new JobDetail(job.Id, employerNo, workerNo);
            string controlText = detailManager.IsJobDetailComplete(jobDetail);

            if (controlText != "")
            {
                MessageBox.Show(controlText, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            DialogResult dr = MessageBox.Show(CmbPersonnels.Text + " Personeli İçin " + TxtJobName.Text + " Görevi Atanacaktır. Onaylıyor Musunuz", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                MessageBox.Show(detailManager.Add(jobDetail));
                Clear();
            }
        }
    }
}
