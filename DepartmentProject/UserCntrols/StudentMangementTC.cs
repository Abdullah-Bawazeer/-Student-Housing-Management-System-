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
    public partial class StudentMangementTC : UserControl
    {
        
        public StudentMangementTC()
        {
            InitializeComponent();
            LoadAllStudentInfoInDgv();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            frmAddStudent frm = new frmAddStudent(-1);
            frm.Show();
            LoadAllStudentInfoInDgv();
        }

        private void StudentMangementTC_Load(object sender, EventArgs e)
        {
            
            FillAllComboboxByData();
            SelectedItemWhenFormLoad();
            LoadAllStudentInfoInDgv();
        }

        void SelectedItemWhenFormLoad()
        {
            cmbUniversity.SelectedItem = "الكل";
            cmbLevels.SelectedItem = "الكل";
            cmbMajors.SelectedItem = "الكل";
            cmbTimePeriod.SelectedItem = "الكل";
            cmbStudent.SelectedItem = "الكل";
        }
        void FillAllComboboxByData()
        {
            FillEachCombobox("Universtys", "Universty", cmbUniversity);
            FillEachCombobox("Levels", "Level", cmbLevels);
            FillEachCombobox("Majors", "Major", cmbMajors);
            FillEachCombobox("Periods", "Period", cmbTimePeriod);
        }

        void FillEachCombobox(string TableName, string ColumnName, System.Windows.Forms.ComboBox CmbBoxName)
        {
            DataTable dt = new DataTable();
            dt = clsStudent.GetWhatDoYouWhantCmbData(TableName);
            foreach (DataRow record in dt.Rows)
            {
                CmbBoxName.Items.Add(record[ColumnName]);

            }
        }

        void ChangeDataGridViewSrudentHeader()
        {
            dgvShowStudentInfo.Columns["ID"].HeaderText = "الرقم";
            dgvShowStudentInfo.Columns["Name"].HeaderText = "الاسم الكامل";
            dgvShowStudentInfo.Columns["Phone"].HeaderText = "رقم الهاتف";
            //dgvShowStudentInfo.Columns["Stutus"].HeaderText = "حالة الطالب";
            dgvShowStudentInfo.Columns["Level"].HeaderText = "المستوى الدراسي";
            dgvShowStudentInfo.Columns["Universty"].HeaderText = "الجامعة";
            dgvShowStudentInfo.Columns["Major"].HeaderText = "التخصص";
            dgvShowStudentInfo.Columns["Period"].HeaderText = " فترة الدوام ";

            dgvShowStudentInfo.Columns[0].Width = 50;
            dgvShowStudentInfo.Columns[1].Width = 250;
            dgvShowStudentInfo.Columns[2].Width = 150;
            dgvShowStudentInfo.Columns[3].Width = 120;
            dgvShowStudentInfo.Columns[4].Width = 150;
            dgvShowStudentInfo.Columns[5].Width = 150;
            dgvShowStudentInfo.Columns[6].Width = 145;
        }

        void LoadAllStudentInfoInDgv()
        {
            DataTable dt = new DataTable();
            dt = clsStudent.GetDataGridStudentInfo();
            dgvShowStudentInfo.DataSource = dt;
            ChangeDataGridViewSrudentHeader();
        }

       
        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ?" ,"Delete Student",MessageBoxButtons.YesNo ,MessageBoxIcon.Information) == DialogResult.Yes)
            {
                clsStudent.DeleteStudent((int)dgvShowStudentInfo.CurrentRow.Cells[0].Value);
                MessageBox.Show("Deleted Syccessfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllStudentInfoInDgv();
            };
        }

        private void btnShowStudentInfo_Click(object sender, EventArgs e)
        {
            frmAddStudent frm = new frmAddStudent((int)dgvShowStudentInfo.CurrentRow.Cells[0].Value , true);
            frm.Show();
            LoadAllStudentInfoInDgv();
        }

        private void btnUpadetStudentInfo_Click(object sender, EventArgs e)
        {
            frmAddStudent frm = new frmAddStudent((int)dgvShowStudentInfo.CurrentRow.Cells[0].Value);
            frm.Show();
        }

        private void btnRefreash_Click(object sender, EventArgs e)
        {
             SelectedItemWhenFormLoad();
             LoadAllStudentInfoInDgv();
        }

      

        private void txtSearchData_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchData.Text != "")
            {
                string Filte ="where Name like '%"+txtSearchData.Text+"%' ";
                DataTable dt = new DataTable();
                dt = clsStudent.GetDataGridStudentInfo(Filte);
                
                dgvShowStudentInfo.DataSource = dt;
                //ChangeDataGridViewSrudentHeader();
               
               
            }
            else
            {
                LoadAllStudentInfoInDgv();

            }
        }

        void FilterDataUseingComboBox()
        {
            string  Filter = "where ";
            if(cmbStudent.SelectedItem != "الكل")
            {
                if(cmbStudent.SelectedItem =="الخريجين")
                {
                    Filter += "Stutus = '0' and";
                }
                else
                {
                    Filter += "Stutus = '1' and";
                }
            }

            if (cmbUniversity.SelectedItem != "الكل")
            {
                Filter += " Universtys.Universty = '" + cmbUniversity.SelectedItem + "' and";
            }
            if (cmbMajors.SelectedItem != "الكل")
            {
                Filter += " Majors.Major = '" + cmbMajors.SelectedItem + "' and";
            }
            if (cmbLevels.SelectedItem != "الكل")
            {
                Filter += " Levels.Level = '" + cmbLevels.SelectedItem + "' and";
            }
            if (cmbTimePeriod.SelectedItem != "الكل")
            {
                Filter += " Periods.Period = '" + cmbTimePeriod.SelectedItem + "' and";
            }

            string EndWord = "and";
            if (Filter.EndsWith("and"))
            {
                Filter = Filter.Substring(0, Filter.Length - EndWord.Length);
            }
            if(Filter == "where ")
            {
                Filter = " ";
            }

            Filter += " ; ";

           
            DataTable dt = new DataTable();
            dt = clsStudent.GetDataGridStudentInfo(Filter);

            dgvShowStudentInfo.DataSource = dt;
        }

        private void cmbUniversity_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDataUseingComboBox();
        }

        private void cmbMajors_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDataUseingComboBox();
        }

        private void cmbLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDataUseingComboBox();
        }

        private void cmbTimePeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDataUseingComboBox();
        }

        private void cmbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDataUseingComboBox();
        }
    }


    
}
