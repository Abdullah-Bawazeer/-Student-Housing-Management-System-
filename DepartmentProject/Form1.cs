using DepartmentBusinessLayer;
using DepartmentProject.Global_Class;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Form1 : Form
    {
        Login _frmLogin;
        private StudentMangementTC UCstudentMangenet = new StudentMangementTC();
        private UCExpensesManagement UCExpenses = new UCExpensesManagement();
        private MainInterface UCmainInerface = new MainInterface();
        private UC_UsersMangement UCusersMangement = new UC_UsersMangement();
        private UCAboutProgrammer UCAboutProgrammer = new UCAboutProgrammer();
        private UCViolationsMangement UCViolations = new UCViolationsMangement();
        private UCStudentPayment  UCStudentPayment = new UCStudentPayment();

      

        public Form1(Login frm)
        {
            InitializeComponent();
            this._frmLogin = frm;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            AddUserControlToPanel.InitilializePanel(PnContainer);
            this.Size = new Size(1253, 660);
            PnContainer.Controls.Clear();
            PnContainer.Controls.Add(UCmainInerface);
            UCmainInerface.Dock = DockStyle.Fill;
            UCmainInerface.BringToFront();
            CheckAndSetPermmion();
        }

        private void CheckAndSetPermmion()
        {
            if ((CurrentUser.Permmions & 1) == 1)
            {
                btnStudentMangement.Enabled = true;
            }
            if ((CurrentUser.Permmions & 2) == 2)
            {
                btnUsersMangement.Enabled = true;
            }
            if ((CurrentUser.Permmions & 4) == 4)
            {
                btnExpensesMangement.Enabled = true;
            }
            if ((CurrentUser.Permmions & 8) == 8)
            {
                btnActivtiesMangement.Enabled = true;
            }
            if ((CurrentUser.Permmions & 16) == 16)
            {
                btnViolationMangement.Enabled = true;
            }
            if ((CurrentUser.Permmions & 32) == 32)
            {
                btnSyudentPayment.Enabled = true;
            }
            if(CurrentUser.UserName =="admin")
            {
                btmEmpMangement.Enabled = true;
            }
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            //this.Hide();
            // Login frm = new Login();
            // frm.ShowDialog();
            _frmLogin.Show();
            this.Close();

        }

        void AddUserContrilToScreen(UserControl UC)
        {
            PnContainer.Controls.Clear();
            PnContainer.Controls.Add(UC);
            UC.Dock = DockStyle.Fill;
            UC.BringToFront();
            
        }

        private void btnStudentMangement_Click(object sender, EventArgs e)
        {
             AddUserControlToPanel.ShowUserControl(UCstudentMangenet);
        }

        private void btnExpensesMangement_Click(object sender, EventArgs e)
        {
            AddUserControlToPanel.ShowUserControl(UCExpenses);
        }

        private void btnUsersMangement_Click(object sender, EventArgs e)
        {
            AddUserControlToPanel.ShowUserControl(UCusersMangement);
        }

        private void btnMainInf_Click(object sender, EventArgs e)
        {
            AddUserControlToPanel.ShowUserControl(UCmainInerface);
        }

        private void btnAboutus_Click(object sender, EventArgs e)
        {
            AddUserControlToPanel.ShowUserControl(UCAboutProgrammer);
        }

        private void btnActivtiesMangement_Click(object sender, EventArgs e)
        {
            //UCAllStudentViolations UCStudentViolations = new UCAllStudentViolations(3);
        }

        private void btnViolationMangement_Click(object sender, EventArgs e)
        {
            AddUserControlToPanel.ShowUserControl(UCViolations);
        }

        private void btnSyudentPayment_Click(object sender, EventArgs e)
        {
            AddUserControlToPanel.ShowUserControl(UCStudentPayment);
        }
    }
}
