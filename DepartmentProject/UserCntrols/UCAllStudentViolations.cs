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
    public partial class UCAllStudentViolations : UserControl
    {
        int _StudentID = 0;
        UCYearlyReprot UCReport= new UCYearlyReprot();
        public UCAllStudentViolations( int ID)
        {
            this._StudentID = ID;
            InitializeComponent();
        }

        private void UCAllStudentViolations_Load(object sender, EventArgs e)
        {
            LoadAllStudentViolation();
            UCTitle.Text += "  : " + clsStudent.GetStudentNameById(_StudentID);
        }

        void ChangeDataGridViewViolationHeader()
        {
            dgvViolationsData.Columns["ID"].HeaderText = "الرقم";
            dgvViolationsData.Columns["StudentName"].HeaderText = "اسم الطلب ";
            dgvViolationsData.Columns["ViolationName"].HeaderText = " نوع المخالفة";
            dgvViolationsData.Columns["ViolationDate"].HeaderText = " تاريخ المخالفة";
            dgvViolationsData.Columns["ViolationDescription"].HeaderText = "وصف المخالفة ";
            dgvViolationsData.Columns["ViolationCount"].HeaderText = " عدد المخالفات";


            dgvViolationsData.Columns[0].Width = 50;
            dgvViolationsData.Columns[1].Width = 250;
            dgvViolationsData.Columns[2].Width = 170;
            dgvViolationsData.Columns[3].Width = 160;
            dgvViolationsData.Columns[4].Width = 320;
            dgvViolationsData.Columns[5].Width = 130;
        }

        void LoadAllStudentViolation()
        {
            DataTable dt = new DataTable();
            dt = clsViolation.GetAllStudentViloationsByID(_StudentID);
            if(dt.Rows.Count > 0)
            {
                dgvViolationsData.DataSource = dt;
                ChangeDataGridViewViolationHeader();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AddUserControlToPanel.ShowUserControl(UCReport);
        }
    }
}
