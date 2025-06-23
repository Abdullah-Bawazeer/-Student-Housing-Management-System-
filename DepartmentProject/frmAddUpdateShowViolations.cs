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
    public partial class frmAddUpdateShowViolations : Form
    {
        int ViolationId = -1;
        clsViolation _Vailoatin;
        enum eMode { Add = 0, Update = 1, Show = 2 };
        eMode Mode;


        public frmAddUpdateShowViolations(int ViolationId, bool Show = false)
        {
            InitializeComponent();
            this.ViolationId = ViolationId;
            if (ViolationId == -1)
            {
                Mode = eMode.Add;
            }
            else if (ViolationId != -1 && Show == true)
            {
                Mode = eMode.Show;
                Show = false;
            }
            else
            {
                Mode = eMode.Update;
            }

        }


      

        private void frmAddUpdateShowViolations_Load(object sender, EventArgs e)
        {
            FailCmbViolayionListData();
            _LoadData();
        }

        void _LoadData()
        {
            if (Mode == eMode.Add)
            {
                lblFormTitle.Text = "اضافة مخالفة";
                _Vailoatin = new clsViolation();
                return;
            }

            else if (Mode == eMode.Update)
            {
                lblFormTitle.Text = "تعديل مخالفة";
                _Vailoatin = clsViolation.FindViolationById(ViolationId);
                if (_Vailoatin != null)
                {
                    txtStudentName.Text = clsStudent.GetStudentNameById(_Vailoatin.StudentID);
                    cmbListVuolations.SelectedItem = clsViolation.GetViolationNameById(_Vailoatin.ViolationID);
                    violationDate.Value = _Vailoatin.ViolationDate;
                    txtDescription.Text = _Vailoatin.ViolationDescription;
                }
            }
            else if (Mode == eMode.Show)
            {
                lblFormTitle.Text = "عرض مخالفة";
                _Vailoatin = clsViolation.FindViolationById(ViolationId);
                if (_Vailoatin != null)
                {
                    txtStudentName.Text = clsStudent.GetStudentNameById(_Vailoatin.StudentID);
                    cmbListVuolations.SelectedItem = clsViolation.GetViolationNameById(_Vailoatin.ViolationID);
                    violationDate.Value = _Vailoatin.ViolationDate;
                    txtDescription.Text = _Vailoatin.ViolationDescription;
                }
                txtStudentName.Enabled = false;
                cmbListVuolations.Enabled = false;
                violationDate.Enabled = false;    
                txtDescription.Enabled = false;
                btnSave.Enabled = false;

            }
        }


        void FailCmbViolayionListData()
        {
            DataTable dt = new DataTable();
            dt = clsViolation.GetViolationsListCmbData();
            foreach (DataRow record in dt.Rows)
            {
                cmbListVuolations.Items.Add(record["Name"]);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int StudentId = clsStudent.GetIdStudentByName(txtStudentName.Text);
            if (StudentId > 0 )
            {
                _Vailoatin.StudentID = StudentId;
                _Vailoatin.ViolationID = cmbListVuolations.SelectedIndex  + 1;
                _Vailoatin.ViolationDate = violationDate.Value;
                _Vailoatin.ViolationDescription = txtDescription.Text;
                if(_Vailoatin.Save())
                {
                    MessageBox.Show("تم اضافة المخالفة بنجاح", "تمت الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("  فشل اضفة مخالفة! ", "فشل الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("  هذا الطالب غير موجود في النظام  ! ", "فشل الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
