using DepartmentBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepartmentProject
{
    public partial class UCYearlyReprot : UserControl
    {
       
        public UCYearlyReprot()
        {
            InitializeComponent();
        }

        private void UCYearlyReprot_Load(object sender, EventArgs e)
        {
            LoadAllViolationInfoIn();

        }

        void LoadAllViolationInfoIn()
        {
            DataTable dt = new DataTable();
            dt = clsViolation.GetReportYearsData();
            dgvReoprtViolationData.DataSource = dt;
            ChangeDataGridViewViolationHeader();
        }

        void ChangeDataGridViewViolationHeader()
        {
            dgvReoprtViolationData.Columns["ID"].HeaderText = "الرقم";
            dgvReoprtViolationData.Columns["StudentName"].HeaderText = "اسم الطلب ";
            dgvReoprtViolationData.Columns["Vajer"].HeaderText = "مخالفةالصلاة";
            dgvReoprtViolationData.Columns["Quran"].HeaderText = "محالفة حلقات الفجر";
            dgvReoprtViolationData.Columns["Activties"].HeaderText = "مخالفة الانشطة";
            dgvReoprtViolationData.Columns["Behavior"].HeaderText = " مخالفة السلوك";
            dgvReoprtViolationData.Columns["Clean"].HeaderText = "مخالفة النظافة";
            dgvReoprtViolationData.Columns["WeaklyHalak"].HeaderText = " الحلاقات الاسبوعية";
            dgvReoprtViolationData.Columns["TotalViolations"].HeaderText = " مجموع المخالفات";


            dgvReoprtViolationData.Columns[0].Width = 50;
            dgvReoprtViolationData.Columns[1].Width = 220;
            dgvReoprtViolationData.Columns[2].Width = 140;
            dgvReoprtViolationData.Columns[3].Width = 110;
            dgvReoprtViolationData.Columns[4].Width = 110;
            dgvReoprtViolationData.Columns[5].Width = 110;
            dgvReoprtViolationData.Columns[6].Width = 110;
            dgvReoprtViolationData.Columns[7].Width = 110;
            dgvReoprtViolationData.Columns[8].Width = 110;
            
        }

        
        void FilterDataGridView()
        {
            string Filter = "";
            if (txtSearchData.Text !="")
            {
                Filter = "where s.Name like '%" + txtSearchData.Text+"%' ;";
                DataTable dt = new DataTable();
                dt = clsViolation.GetReportYearsDataFiltered(Filter);
                dgvReoprtViolationData.DataSource = dt;
            }
            else
            {
                LoadAllViolationInfoIn();
            }
        }
        private void txtSearchData_TextChanged(object sender, EventArgs e)
        {
            FilterDataGridView();
        }

        private void btnAllStudentViolations_Click(object sender, EventArgs e)
        {
            UCAllStudentViolations UCStudentViolations = new UCAllStudentViolations((int)dgvReoprtViolationData.CurrentRow.Cells[0].Value);
            AddUserControlToPanel.ShowUserControl(UCStudentViolations);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UCViolationsMangement UCViolationMangement = new UCViolationsMangement();
            AddUserControlToPanel.ShowUserControl(UCViolationMangement);
        }
    }
}
