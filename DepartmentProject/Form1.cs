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
        private StudentMangementTC UCstudentMangenet = new StudentMangementTC();
        private UCExpensesManagement UCExpenses = new UCExpensesManagement();
        private MainInterface UCmainInerface = new MainInterface();
        private UC_UsersMangement UCusersMangement = new UC_UsersMangement();
        private UCAboutProgrammer UCAboutProgrammer = new UCAboutProgrammer();
        private UCViolationsMangement UCViolations = new UCViolationsMangement();
        private UCStudentPayment  UCStudentPayment = new UCStudentPayment();

      

        public Form1()
        {
            InitializeComponent();
           
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            AddUserControlToPanel.InitilializePanel(PnContainer);
            this.Size = new Size(1253, 660);
            PnContainer.Controls.Clear();
            PnContainer.Controls.Add(UCmainInerface);
            UCmainInerface.Dock = DockStyle.Fill;
            UCmainInerface.BringToFront();
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
