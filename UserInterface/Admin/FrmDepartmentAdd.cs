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
    public partial class FrmDepartmentAdd : Form
    {
        DepartmentManager departmentManager;
        public FrmDepartmentAdd()
        {
            InitializeComponent();
            departmentManager = DepartmentManager.GetInstance();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtName.Text.Trim() == "")
            {
                MessageBox.Show("Öncelikle İsim Bilgisi Giriniz");
                return;
            }

            DialogResult dr = MessageBox.Show(TxtName.Text + " Departmanı Kaydedilecektir Emin Misiniz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                MessageBox.Show(departmentManager.Add(new Department(TxtName.Text, RchDescription.Text)));
                var form = (FrmDepartments)Application.OpenForms["FrmDepartments"];
                form.DepartmentList();
                Close();
            }
        }
    }
}
