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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            Form1 frm = new Form1();
            frm.Show();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if(txtUserName.Text != "" && txtPassword.Text != "")
            {
                if(clsUser.FindUserByUserNameAndPassword(txtUserName.Text , txtPassword.Text))
                {
                    Form1 frm = new Form1();
                    frm.Show();
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

        }
    }
}
