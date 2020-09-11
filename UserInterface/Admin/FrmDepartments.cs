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
    public partial class FrmDepartments : Form
    {
        DepartmentManager departmentManager;
        Department department;
        string oldName;
        public FrmDepartments()
        {
            InitializeComponent();
            departmentManager = DepartmentManager.GetInstance();
        }

        private void FrmDepartments_Load(object sender, EventArgs e)
        {
            DepartmentList();
        }

        public void DepartmentList()
        {
            DtgDepartments.DataSource = departmentManager.GetList();
            department = null;
            Clear();
        }

        void Clear()
        {
            TxtName.Text = ""; RchDescription.Text = "";
        }

        private void DtgDepartments_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DtgDepartments.CurrentRow == null)
            {
                MessageBox.Show("Departman Seçiniz");
                return;
            }

            oldName = DtgDepartments.CurrentRow.Cells["Name"].Value.ToString();

            department = new Department(
                DtgDepartments.CurrentRow.Cells["Id"].Value.ConInt(),
                oldName,
                DtgDepartments.CurrentRow.Cells["Description"].Value.ToString()
                );

            TxtName.Text = department.Name;
            RchDescription.Text = department.Description;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (department == null)
            {
                MessageBox.Show("Departman Seçiniz");
                return;
            }

            DialogResult dr = MessageBox.Show(department.Name + " Departmanıyla İlgili Güncelleme İşlemi Yapılsın Mı ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                department.Name = TxtName.Text;
                department.Description = RchDescription.Text;
                MessageBox.Show(departmentManager.Update(department, oldName));
                DepartmentList();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (department == null)
            {
                MessageBox.Show("Departman Seçiniz");
                return;
            }

            DialogResult dr = MessageBox.Show(department.Name + " Departmanıyla İlgili Silme İşlemi Yapılacaktır. Onaylıyor Musunuz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {               
                MessageBox.Show(departmentManager.Delete(department.Id));
                DepartmentList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDepartmentAdd frmDepartmentAdd = new FrmDepartmentAdd();
            frmDepartmentAdd.ShowDialog();
        }
    }
}
