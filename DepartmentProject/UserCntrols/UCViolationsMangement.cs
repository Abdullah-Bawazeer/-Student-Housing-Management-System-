using DepartmentBusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace DepartmentProject
{
    public partial class UCViolationsMangement : UserControl
    {
        UCYearlyReprot UCReport = new UCYearlyReprot();
        UCStatistics UCStatistics = new UCStatistics();
        public UCViolationsMangement()
        {
            InitializeComponent();
            LoadAllViolationInfoIn();
        }

        private void btnAddViolation_Click(object sender, EventArgs e)
        {
            frmAddUpdateShowViolations frm = new frmAddUpdateShowViolations(-1);
            frm.Show();
            LoadAllViolationInfoIn();
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
            dgvViolationsData.Columns[1].Width = 220;
            dgvViolationsData.Columns[2].Width = 140;
            dgvViolationsData.Columns[3].Width = 120;
            dgvViolationsData.Columns[4].Width = 140;
            dgvViolationsData.Columns[5].Width = 130;
        }

        void LoadAllViolationInfoIn()
        {
            DataTable dt = new DataTable();
            dt = clsViolation.GetAllDataGridInfo();
            dgvViolationsData.DataSource = dt;
            ChangeDataGridViewViolationHeader();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف هذه المخالفة؟", "حذف مخالفة", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                clsViolation.DeleteViolation((int)dgvViolationsData.CurrentRow.Cells[0].Value);
                MessageBox.Show("تم الحذف بنجاح ", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllViolationInfoIn();
            };
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmAddUpdateShowViolations frm = new frmAddUpdateShowViolations((int)dgvViolationsData.CurrentRow.Cells[0].Value);
            frm.Show();
            LoadAllViolationInfoIn();
        }

        private void btnViolationDetails_Click(object sender, EventArgs e)
        {
            frmAddUpdateShowViolations frm = new frmAddUpdateShowViolations((int)dgvViolationsData.CurrentRow.Cells[0].Value, true);
            frm.Show();
            LoadAllViolationInfoIn();
        }

        private void UCViolationsMangement_Load(object sender, EventArgs e)
        {
            LoadAllViolationInfoIn();
            FailCmbViolayionListData();
        }

        private void btnRefreash_Click(object sender, EventArgs e)
        {
            LoadAllViolationInfoIn();
        }
        void AddUserContrilToScreen(UserControl UC)
        {
            
            UC.Dock = DockStyle.Fill;
            UC.BringToFront();
        }

        private void btnYearlyReport_Click(object sender, EventArgs e)
        {
             AddUserControlToPanel.ShowUserControl(UCReport);
        }


        void FailCmbViolayionListData()
        {
            DataTable dt = new DataTable();
            dt = clsViolation.GetViolationsListCmbData();
            foreach (DataRow record in dt.Rows)
            {
                cmbViolationList.Items.Add(record["Name"]);

            }
            cmbViolationList.SelectedIndex = 0;
        }

      
        void FilterDataUseingComboBox()
        {
            string Filter = "where ";
            if (cmbViolationList.SelectedItem != "الكل")
            {
                
                 Filter += " v.Name = '"+cmbViolationList.SelectedItem+"' and";
                
            }
                        
            if (numViolations.Value > 0)
            {
                Filter += " ViolationCount = " + numViolations.Value + " and";
            }

            //if (dateTimeViolation.Value != null)
            //{
            //    Filter += " vd.ViolationDate = '" + dateTimeViolation.Value + "' and";
            //}


            string EndWord = "and";
            if (Filter.EndsWith("and") || Filter.EndsWith("where"))
            {
                Filter = Filter.Substring(0, Filter.Length - EndWord.Length);
            }

            Filter += " ; ";


            DataTable dt = new DataTable();
            dt = clsViolation.GetAllDataGridInfoFiltered(Filter);
            if(dt.Rows.Count > 0)
            {
                dgvViolationsData.DataSource = dt;
            }
            //else
            //{
            //    LoadAllViolationInfoIn();
            //}


        }

        private void cmbViolationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDataUseingComboBox();
        }

        private void numViolations_ValueChanged(object sender, EventArgs e)
        {
           FilterDataUseingComboBox();
        }

        private void dateTimeViolation_ValueChanged(object sender, EventArgs e)
        {
            //FilterDataUseingComboBox();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            AddUserControlToPanel.ShowUserControl(UCStatistics);
        }

        private void txtSearchData_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchData.Text != "")
            {
                string Filte = "where s.Name like '%" + txtSearchData.Text + "%' ";
                DataTable dt = new DataTable();
                dt = clsViolation.GetAllDataGridInfoFiltered(Filte);

                dgvViolationsData.DataSource = dt;
                //ChangeDataGridViewSrudentHeader();


            }
            else
            {
                LoadAllViolationInfoIn();

            }
        }
    }
}
