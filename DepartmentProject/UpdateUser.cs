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
    public partial class UpdateUser : Form
    {
        int UserID;
        clsUser _User;
        public UpdateUser(int ID)
        {
            InitializeComponent();
            this.UserID = ID;
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            LoadFormData();
        }

        void LoadFormData()
        {
            _User = clsUser.FindUserByID(UserID);
            if(_User != null)
            {
                txtCurrentUserName.Text = _User.UserName;
                txtCurrentPassword.Text = _User.Password;
                if((_User.Permmions & 1 ) == 1)
                {
                    chkbStudentMang.Checked = true;
                }
                if ((_User.Permmions & 2) == 2)
                {
                    chkbUsersMang.Checked = true;
                }
                if ((_User.Permmions & 4) == 4)
                {
                    chkbExpensesMang.Checked = true;
                }
                if ((_User.Permmions & 8) == 8)
                {
                    chkbActivitesMang.Checked = true;
                }
                if ((_User.Permmions & 16) == 16)
                {
                    chkbViolationsMang.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("NotFound User !!", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
          
            int Permistions = 0;

            _User.Id = UserID;
            _User.UserName =txtNewUserName.Text;
            _User.Password = txtNewPassword.Text;
            if (chkbStudentMang.Checked)
            {
                Permistions += 1;
            }
            if (chkbUsersMang.Checked)
            {
                Permistions += 2;
            }
            if (chkbExpensesMang.Checked)
            {
                Permistions += 4;
            }
            if (chkbActivitesMang.Checked)
            {
                Permistions += 8;
            }
            if (chkbViolationsMang.Checked)
            {
                Permistions += 16;
            }
            _User.Permmions = Permistions;
            if (_User.Save())
            {
                MessageBox.Show("User Updated Successfully", "Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                
            }
            else
            {
                MessageBox.Show("User Updated Fail", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
