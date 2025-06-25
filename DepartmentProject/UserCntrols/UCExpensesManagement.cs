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
using DepartmentBusinessLayer;

namespace DepartmentProject
{
    public partial class UCExpensesManagement : UserControl
    {
        public UCExpensesManagement()
        {
            InitializeComponent();
            loadAllDataGridViewInfo();
        }

        private void UCExpensesManagement_Load(object sender, EventArgs e)
        {
            loadAllDataGridViewInfo();
        }

        void loadAllDataGridViewInfo()
        {
            DataTable dt = new DataTable();
            dt = clsExpense.GetAllExpenseData();
            dgvShowExpensesInfo.DataSource = dt;
            ChangeDataGridViewHeader();
        }

        void ChangeDataGridViewHeader()
        {
            dgvShowExpensesInfo.Columns["ID"].HeaderText = "الرقم";
            dgvShowExpensesInfo.Columns["ItemName"].HeaderText = "اسم الصنف";
            dgvShowExpensesInfo.Columns["Price"].HeaderText = "سعر الحبة";
            dgvShowExpensesInfo.Columns["Amount"].HeaderText = "الكمية";
            dgvShowExpensesInfo.Columns["BuyerName"].HeaderText = " اسم المشتري";
            dgvShowExpensesInfo.Columns["BuyDate"].HeaderText = "تاريخ الشراء";
            dgvShowExpensesInfo.Columns["TotalPrice"].HeaderText = "الاجمالي";

            dgvShowExpensesInfo.Columns[0].Width = 50;
            dgvShowExpensesInfo.Columns[1].Width = 220;
            dgvShowExpensesInfo.Columns[2].Width = 120;
            dgvShowExpensesInfo.Columns[3].Width = 120;
            dgvShowExpensesInfo.Columns[4].Width = 130;
            dgvShowExpensesInfo.Columns[5].Width = 170;
            dgvShowExpensesInfo.Columns[6].Width = 150;
        }

        private void btnDeleteBills_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confitm", "Are You Sure For Delete this Bills?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                if (clsExpense.DeleteBills((int)dgvShowExpensesInfo.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("information", "Bills Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadAllDataGridViewInfo();
                }
                else
                {
                    MessageBox.Show("error", "Fail Deleted this Bills!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            
        }

        private void btnAddBills_Click(object sender, EventArgs e)
        {
            AddUpdateBills frm = new AddUpdateBills(-1);
            frm.Show();
            loadAllDataGridViewInfo();
        }

        private void btnUpdateBills_Click(object sender, EventArgs e)
        {
            AddUpdateBills frm = new AddUpdateBills((int)dgvShowExpensesInfo.CurrentRow.Cells[0].Value);
            frm.Show();
            loadAllDataGridViewInfo();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadAllDataGridViewInfo();
        }
    }
}



     


