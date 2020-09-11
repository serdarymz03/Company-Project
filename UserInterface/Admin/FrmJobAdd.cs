using Business.Concrete;
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
    public partial class FrmJobAdd : Form
    {
        JobManager jobManager;
        public FrmJobAdd()
        {
            InitializeComponent();
            jobManager = JobManager.GetInstance();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(TxtName.Text + " İşi Kaydedilecektir Emin Misiniz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                MessageBox.Show(jobManager.Add(new Job(TxtName.Text, RchDescription.Text, DateTime.Now)));
                var form = (FrmJobs)Application.OpenForms["FrmJobs"];
                form.JobList();
                Close();
            }
        }
    }
}
