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
    public partial class UC_UsersMangement : UserControl
    {
        public UC_UsersMangement()
        {
            InitializeComponent();
            LoadAllDataGridViewInfo();
        }

        private void UC_UsersMangement_Load(object sender, EventArgs e)
        {
            LoadAllDataGridViewInfo();
        }

        void LoadAllDataGridViewInfo()
        {
           
            DataTable dt = new DataTable();
            dt = clsUser.GetAllUsers();
            dgvUsersInfo.DataSource = dt;
            ChangeDataridViewHeader();
        }




        void ChangeDataridViewHeader()
        {
            dgvUsersInfo.Columns["ID"].HeaderText = "الرقم";
            dgvUsersInfo.Columns["UserName"].HeaderText = "اسم المستخدم";
            dgvUsersInfo.Columns["Password"].HeaderText = "كلمة المرور";
            dgvUsersInfo.Columns["StudentMangement"].HeaderText = "ادارة الطلاب ";
            dgvUsersInfo.Columns["UsersMangement"].HeaderText = "ادارة الحسابات";
            dgvUsersInfo.Columns["ExpensesMangement"].HeaderText = "ادارة المصروفات";
            dgvUsersInfo.Columns["ActivitiesMangement"].HeaderText = "ادارة الخالفات";
            dgvUsersInfo.Columns["VioltionsMangement"].HeaderText = "ادارة الانشطة";
            dgvUsersInfo.Columns["PaymentMangement"].HeaderText = "ادارة الدفوعات";

            dgvUsersInfo.Columns[0].Width = 60;
            dgvUsersInfo.Columns[1].Width = 140;
            dgvUsersInfo.Columns[2].Width = 135;
            dgvUsersInfo.Columns[3].Width = 120;
            dgvUsersInfo.Columns[4].Width = 100;
            dgvUsersInfo.Columns[5].Width = 100;
            dgvUsersInfo.Columns[6].Width = 100;
            dgvUsersInfo.Columns[7].Width = 100;
            dgvUsersInfo.Columns[8].Width = 100;

        }

        private void btnAddBills_Click(object sender, EventArgs e)
        {
            AddUser frm = new AddUser();
            frm.Show();
            LoadAllDataGridViewInfo();
        }

        private void btnUpdateBills_Click(object sender, EventArgs e)
        {
            UpdateUser frm = new UpdateUser((int) dgvUsersInfo.CurrentRow.Cells[0].Value);
            frm.Show();
            LoadAllDataGridViewInfo();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAllDataGridViewInfo();
        }

        private void btnDeleteBills_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure Want Delete this User" ,"Confirm" ,MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                if(clsUser.DeleteUser((int)dgvUsersInfo.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("User Deleted Succussflly", "Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllDataGridViewInfo();
                }
                else
                {
                    MessageBox.Show("Fail User Deleted ", "waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }
    }
}
