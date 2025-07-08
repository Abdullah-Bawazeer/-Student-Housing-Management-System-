using DepartmentBusinessLayer;
using DepartmentProject.Global_Class;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            Form1 frm = new Form1(this);
            frm.Show();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if(txtUserName.Text != "" && txtPassword.Text != "")
            {
                clsUser user = clsUser.FindUserByUserNameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());
                if(user != null)
                {
                   
                    CurrentUser.ID = user.Id;
                    CurrentUser.UserName = user.UserName;
                    CurrentUser.Password = user.Password;
                    CurrentUser.Permmions = user.Permmions;
                    if(chkbRemmberMe.Checked == true)
                        CurrentUser.remmberMe = true;
                    else 
                        CurrentUser.remmberMe = false;
                    
                    Form1 frm = new Form1(this);
                    frm.ShowDialog();

                    //this.Hide();

                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid userName and password", "Fail Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Text = txtPassword.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Fail empty faild", "Fail Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Text = txtPassword.Text = "";

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            ResetUserNameAndPassword();
        }

        private void ResetUserNameAndPassword()
        {
            Form1 frm = new Form1(this);
            frm.Close();
            if(CurrentUser.remmberMe == true)
            {
                txtUserName.Text = CurrentUser.UserName;
                txtPassword.Text = CurrentUser.Password;
                chkbRemmberMe.Checked = true;
            }
            else
            {
                txtUserName.Text = "";
                txtPassword.Text = "";
                chkbRemmberMe.Checked = false;
            }
        }
    }
}
