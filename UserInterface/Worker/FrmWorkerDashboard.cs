using Business.Concrete;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.Worker
{
    public partial class FrmWorkerDashboard : Form
    {
        JobDetailManager jobDetailManager;
        public object[] infos;
        string personNo;
        bool start;


        public FrmWorkerDashboard()
        {
            InitializeComponent();
            jobDetailManager = JobDetailManager.GetInstance();
        }

        private void FrmWorkerDashboard_Load(object sender, EventArgs e)
        {
            start = true;
            FillInfos();
            CmbJobsLoad();
            LblTarih.Text = DateTime.Now.ToLongDateString();
            JobList();
            GetImage();
            start = false;
        }

        void CmbJobsLoad()
        {
            CmbJobs.DataSource = JobManager.GetInstance().GetComboJobs(personNo);
            CmbJobs.ValueMember = "Id";
            CmbJobs.DisplayMember = "JobName";
            CmbJobs.SelectedValue = 0;
        }

        void GetImage()
        {
            string imagePath = Properties.Settings.Default.ImagePath;
            if (!string.IsNullOrEmpty(imagePath))
            {
                PctBox.ImageLocation = imagePath;
            }
        }

        void FillInfos()
        {
            personNo = infos[1].ToString();
            LblSicil.Text = personNo; ;
            LblName.Text = infos[2].ToString();
            LblDepartment.Text = infos[4].ToString();
            LblAuth.Text = infos[6].ToString();
        }

        void JobList()
        {
            DtgJobs.DataSource = jobDetailManager.GetList("IsDetayListesi", personNo);
            DataGridDisplay();
        }

        void DataGridDisplay()
        {
            DtgJobs.Columns["ID"].Visible = false;
            DtgJobs.Columns["JobId"].Visible = false;
            DtgJobs.Columns["WorkerNo"].Visible = false;
            DtgJobs.Columns["JobName"].HeaderText = "İş Adı";
            DtgJobs.Columns["JobContent"].HeaderText = "Açıklama";
            DtgJobs.Columns["EmployerNo"].HeaderText = "Yetkili No";
            DtgJobs.Columns["Name"].HeaderText = "Yetkili Ad";
            DtgJobs.Columns["EmployerNo"].Width = 80;
        }

        private void DtgJobs_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DtgJobs.CurrentRow == null)
            {
                MessageBox.Show("Detaylarını Görmek İstediğiniz İşi Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TxtJobName.Text = DtgJobs.CurrentRow.Cells["JobName"].Value.ToString();
            RchJobContent.Text = DtgJobs.CurrentRow.Cells["JobContent"].Value.ToString();

        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            JobList();
        }

        private void PctBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string imagePath = openFileDialog1.FileName;

                if (Path.GetExtension(imagePath) == ".jpg" || Path.GetExtension(imagePath) == ".png")
                {
                    PctBox.ImageLocation = imagePath;
                    Properties.Settings.Default.ImagePath = imagePath;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("İş Listenizi Rapor Olarak Çıkarmak İstiyor Musunuz", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                string content = Html_Out(DtgJobs);

                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//masaüstü

                //C:\\serdar\Masaüstü\\rapor.html

                File.WriteAllText(desktopPath + "\\rapor.html", content);
            }
        }

        public string Html_Out(DataGridView dg)
        {
            StringBuilder strB = new StringBuilder();
            //create html & table
            strB.AppendLine("<html><head><meta charset=utf-8><style>table{padding:10px;} th,td{padding:8px;}</style></head><body><center><table border='1' cellpadding='0' cellspacing='0'>");
            strB.AppendLine("<tr>");
            //create table header
            for (int i = 0; i < dg.Columns.Count; i++)
            {
                if (dg.Columns[i].Visible == true)
                {
                    strB.AppendLine("<th align='center' valign='middle'>" + dg.Columns[i].HeaderText + "</th>"); //tablo head
                }
            }
            //create table body
            strB.AppendLine("</tr>"); //tablo satırı
            for (int i = 0; i < dg.Rows.Count; i++)
            {
                if (dg.Rows[i].Visible)
                {
                    strB.AppendLine("<tr>");
                    foreach (DataGridViewCell dgvc in dg.Rows[i].Cells)
                    {
                        if (dgvc.OwningColumn.Visible == true)
                        {
                            strB.AppendLine("<td align='center' valign='middle'>" + dgvc.Value.ToString() + "</td>");
                        } //tablonun hücresi
                    }
                    strB.AppendLine("</tr>");
                }
            }
            //table footer & end of html file
            strB.AppendLine("</table></center>");
            strB.AppendLine("</body></html>");
            return strB.ToString();
        }

        private void TxtJobName_KeyPress(object sender, KeyPressEventArgs e) { e.Handled = true; }
        private void RchJobContent_KeyPress(object sender, KeyPressEventArgs e) { e.Handled = true; }

        private void TxtJobName_KeyDown(object sender, KeyEventArgs e) { e.Handled = true; }
        private void RchJobContent_KeyDown(object sender, KeyEventArgs e) { e.Handled = true; }

        private void FrmWorkerDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cmbJobs_SelectedValueChanged(object sender, EventArgs e)
        {
            if (start)
            {
                return;
            }

            int jobId = CmbJobs.SelectedValue.ConInt();

            for (int i = 0; i < DtgJobs.RowCount; i++)
            {
                if (DtgJobs.Rows[i].Cells["JobId"].Value.ConInt() == jobId)
                {
                    DtgJobs.Rows[i].Selected = true;
                    TxtJobName.Text = DtgJobs.CurrentRow.Cells["JobName"].Value.ToString();
                    RchJobContent.Text = DtgJobs.CurrentRow.Cells["JobContent"].Value.ToString();
                    break;
                }
            }
        }

        private void CmbJobs_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if (start)
            {
                return;
            }

            int jobId = CmbJobs.SelectedValue.ConInt();

            for (int i = 0; i < DtgJobs.RowCount; i++)
            {
                if (DtgJobs.Rows[i].Cells["JobId"].Value.ConInt() == jobId)
                {
                    DtgJobs.Rows[i].Selected = true;
                    TxtJobName.Text = DtgJobs.Rows[i].Cells["JobName"].Value.ToString();
                    RchJobContent.Text = DtgJobs.Rows[i].Cells["JobContent"].Value.ToString();
                    break;
                }
            }
        }
    }
}
