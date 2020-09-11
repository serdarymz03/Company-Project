using Business.Concrete;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.Admin;
using UserInterface.Worker;

namespace UserInterface
{
    public partial class FrmLogin : Form
    {
        PersonnelManager personnelManager;
        public FrmLogin()
        {
            InitializeComponent();
            personnelManager = PersonnelManager.GetInstance();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
        private void FrmLogin_Shown(object sender, EventArgs e)
        {
            //MskSicil.Text = "902569";
            //MskSicil.Text = "563217";
            TxtPassword.Text = "123456";
            //BtnLogin.PerformClick();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (MskSicil.Text.Trim() == "" || TxtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen Sicil Numaranızla Birlikte Şifrenizi Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            object[] infos = personnelManager.Login(MskSicil.Text, TxtPassword.Text);

            if (infos == null)
            {
                MessageBox.Show("Hatalı Sicil No Veya Şifre Girdiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Sayın " + infos[2] + " Hoşgeldiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (infos[5].ConInt() == 1)
            {
                DialogResult dr = MessageBox.Show("Admin Pencerenizi Açmak İster Misiniz ? ", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    FrmAdminDashboard frmAdminDashboard = new FrmAdminDashboard();
                    frmAdminDashboard.infos = infos;
                    frmAdminDashboard.Show();
                }
                else
                {
                    ShowWorkerDahsboard(infos);
                }
                this.Hide();
            }
            else
            {
                ShowWorkerDahsboard(infos);
                this.Hide();
            }
        }

        void ShowWorkerDahsboard(object[] infos)
        {
            FrmWorkerDashboard frmWorkerDashboard = new FrmWorkerDashboard();
            frmWorkerDashboard.infos = infos;
            frmWorkerDashboard.Show();
        }
    }
}
