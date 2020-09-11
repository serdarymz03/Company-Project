using Business.Concrete;
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
    public partial class FrmAdminDashboard : Form
    {
        JobDetailManager jobDetailManager;
        public object[] infos;
        string personNo;
        public FrmAdminDashboard()
        {
            InitializeComponent();
            jobDetailManager = JobDetailManager.GetInstance();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            FillInfos();
            JobList();
        }

        void FillInfos()
        {
            personNo = infos[1].ToString();
            LblSicil.Text = personNo;
            LblName.Text = infos[2].ToString();
        }

        void JobList()
        {
            DtgJobs.DataSource = jobDetailManager.GetList("AdminIsDetayListesi", personNo);
            DataDisplay();
            CountInfos();
        }

        void DataDisplay()
        {
            DtgJobs.Columns["ID"].Visible = false;
            DtgJobs.Columns["JobId"].Visible = false;
            DtgJobs.Columns["EmployerNo"].Visible = false;
            DtgJobs.Columns["JobName"].HeaderText = "İş Adı";
            DtgJobs.Columns["JobContent"].HeaderText = "Açıklama";
            DtgJobs.Columns["WorkerNo"].HeaderText = "Çalışan No";
            DtgJobs.Columns["Name"].HeaderText = "Çalışan Ad";
            DtgJobs.Columns["WorkerNo"].Width = 110;
            DtgJobs.Columns["Name"].Width = 150;
        }

        void CountInfos()
        {
            LblJobCount.Text = DtgJobs.RowCount.ToString();
            LblPersonCount.Text = jobDetailManager.AdminPersonCount(personNo).ToString();
            LblTotal.Text = jobDetailManager.AdminTotalJobs().ToString();
        }

        private void personellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonnels frmPersonnels = new FrmPersonnels();
            frmPersonnels.ShowDialog();
        }

        private void FrmAdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void departmanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDepartments frmDepartments = new FrmDepartments();
            frmDepartments.ShowDialog();
        }

        private void işlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJobs frmJobs = new FrmJobs();
            frmJobs.ShowDialog();
        }

        private void işDetaylarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJobDetailProcess frmJobDetailProcess = new FrmJobDetailProcess();
            frmJobDetailProcess.employerNo = personNo;
            frmJobDetailProcess.ShowDialog();
        }
    }
}
