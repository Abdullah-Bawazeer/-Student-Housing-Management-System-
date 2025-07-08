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
    public partial class AddUpdateBills : Form
    {
        int _BillsId =-1;
        clsExpense _Bills;
        enum eMode { eAdd = 0 , eUpdate =1 , eShow = 2};
        eMode _Mode;
        public AddUpdateBills(int BillsID  , bool show = false)
        {
         
            InitializeComponent();
            _BillsId = BillsID;
            if (_BillsId == -1)
            {
                _Mode = eMode.eAdd;
            }
            //else if (_BillsId > 0 && show == true)
            //{
            //    _Mode = eMode.eShow;
            //    show = false;
            //}
            else if(_BillsId > 0)
            {
                _Mode = eMode.eUpdate;
            }
        }

        private void AddUpdateBills_Load(object sender, EventArgs e)
        {
            this.Size = new Size(823, 632);
           
            _LoadData();
         
        }

        void _LoadData()
        {
            if (_Mode == eMode.eAdd)
            {
                _Bills = new clsExpense();
                return;
            }
            else if (_Mode == eMode.eUpdate)
            {
                _Bills = clsExpense.FindBillById(_BillsId);
                if(_Bills != null)
                {
                    txtItemName.Text = _Bills.Name;
                    txtPrice.Text = _Bills.Price.ToString();
                    txtBuyerName.Text = _Bills.BuyerName;
                    numItem.Value = _Bills.Amount;
                    dateTime.Text = _Bills.BuyDate.ToString();
                    return;
                }
            }
            else if (_Mode == eMode.eShow)
            {
                _Bills = clsExpense.FindBillById(_BillsId);
                if (_Bills != null)
                {
                    btnCanel.Enabled = false;
                    btnSave.Enabled = false;

                    txtItemName.Text = _Bills.Name;
                    txtPrice.Text = _Bills.Price.ToString();
                    txtBuyerName.Text = _Bills.BuyerName;
                    numItem.Value = _Bills.Amount;
                    dateTime.Text = _Bills.BuyDate.ToString();
                    return;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Bills.Name = txtItemName.Text;
            _Bills.Price = Convert.ToInt32(txtPrice.Text);
            _Bills.BuyerName = txtBuyerName.Text;
            _Bills.Amount = Convert.ToInt32(numItem.Text);
            _Bills.TotalPrice =Convert.ToDecimal(txtTotalPrice.Text);
            _Bills.BuyDate = dateTime.Value;


            if (_Bills.Save())
            {
                MessageBox.Show("Bills added successefully", "Seccessed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Fail  add Bills ", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void txtTotalPrice_TextChanged(object sender, EventArgs e)
        {

            txtTotalPrice.Text = (Convert.ToDecimal(txtPrice.Text.ToString()) * Convert.ToInt32(numItem.Value.ToString())).ToString();
        }

        private void txtBuyerName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            
            int num = Convert.ToInt32(numItem.Value);
            decimal price = Convert.ToDecimal(txtPrice.Text.ToString());
            txtTotalPrice.Text = (num * price).ToString();
        }

        private void numItem_ValueChanged_1(object sender, EventArgs e)
        {
            if (txtPrice.Text != "")
            {
                int num = Convert.ToInt32(numItem.Value);
                decimal price = Convert.ToDecimal(txtPrice.Text.ToString());
                txtTotalPrice.Text = (num * price).ToString();
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
