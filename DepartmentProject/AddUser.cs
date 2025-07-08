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
    public partial class AddUser : Form
    {
        clsUser _User;
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text == "" || txtUserName.Text == "")
            {
                MessageBox.Show("Fail all Forms Data", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
            _User = new clsUser();
            int Permistions = 0;

                if (clsUser.IsFindUser(txtUserName.Text, txtPassword.Text))
                {
                    MessageBox.Show("This UserName And Password Exist in System !", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _User.UserName = txtUserName.Text;
                    _User.Password = txtPassword.Text;
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
                    if (chkPaymentManag.Checked)
                    {
                        Permistions += 32;
                    }
                    _User.Permmions = Permistions;
                    if (_User.Save())
                    {
                        MessageBox.Show("User Added Successfully", "Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("User Added Fail", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
        }
    }
}
