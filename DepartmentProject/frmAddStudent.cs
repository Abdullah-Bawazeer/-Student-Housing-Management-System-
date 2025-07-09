using DepartmentBusinessLayer;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepartmentProject
{
    public partial class frmAddStudent : Form
    {
        int StudentID;
        clsStudent _Student;

        enum enMode { AddNew = 0, Update = 1 , Show = 2};
        enMode Mode;
        string personImage = "";
        string proofImage = "";
        string CardImage = "";
        string FormImage = "";
        public frmAddStudent(int StudentId , bool Show = false)
        {
            InitializeComponent();
            this.StudentID = StudentId;
            if (StudentID == -1)
            {
                Mode = enMode.AddNew;
            }
            else if (StudentID != -1 && Show == true)
            {
                Mode = enMode.Show;
                Show=  false;
            }
            else
            {
                Mode = enMode.Update;
            }
        }



        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1350, 700);
            FillAllComboboxByData();
            _LoadData();
        }

        void SelectItemInCmboboxWhenFormLaod()
        {
            cmbMajor.SelectedItem =cmbMajor.Items[0]; //(clsSt
            cmbUniversty.SelectedItem= cmbUniversty.Items[0]; 
            cmbLevel.SelectedItem = cmbLevel.Items[0];
            cmbTimePeriod.SelectedItem = cmbTimePeriod.Items[0];
            cmbStudentStatus.SelectedItem= cmbStudentStatus.Items[0];

        }
        private void _LoadData()
        {
            if(Mode == enMode.AddNew)
            {
                lblTitleForm.Text = "اضافة طالب جديد";
                _Student = new clsStudent();
                SelectItemInCmboboxWhenFormLaod();
                return;
            }
            else if(Mode == enMode.Show)
            {
                lblTitleForm.Text = "عرض معلومات الطالب";
                _Student = clsStudent.FindStudentById(StudentID);
                if (_Student != null)
                {
                    txtStudentName.Text = _Student.FullName;
                    StudentDate.Text = _Student.BirthDay.ToString();
                    txtPhoneNumber.Text = _Student.phoneNumber;
                    txtWhatsappNum.Text = _Student.whatsappNumber;
                    txtFatherName.Text = _Student.FatherName;
                    txtFatherPhone.Text = _Student.FatherNumber;
                    txtPlaceLive.Text = _Student.PlaceLiving;
                    if(_Student.Status == true)
                    {
                        cmbStudentStatus.Text = "طالب";
                    }
                    else
                    {
                        cmbStudentStatus.Text = "خريج";
                    }
                    //cmbStudentStatus.Text = _Student.Status;
                    //cmbMajor.Text = clsStudent.GetItemNameByItemID(this.StudentID, "Majors", "Major");
                    cmbMajor.SelectedItem =     cmbMajor.Items[_Student.MajorId - 1]; //(clsStudent.GetItemNameByItemID(this.StudentID, "Majors", "Major"));
                    cmbUniversty.SelectedItem = cmbUniversty.Items[_Student.UniverstyId - 1];     //clsStudent.GetItemNameByItemID(this.StudentID, "Universtys", "Universty");
                    cmbLevel.SelectedItem =     cmbLevel.Items[_Student.CurrentLevelId - 1];        //clsStudent.GetItemNameByItemID(this.StudentID, "Levels", "Level");
                    cmbTimePeriod.SelectedItem = cmbTimePeriod.Items[_Student.TimeStudyId - 1];    //clsStudent.GetItemNameByItemID(this.StudentID, "Periods", "Period");
                    if (_Student.Picture != "")
                    {
                        personalPictur.Load(_Student.Picture);
                    }
                    if (_Student.Identity != "")
                    {
                        PcIdentityCard.Load(_Student.Identity);
                    }
                    if (_Student.formImage != "")
                    {
                        pcEstmara.Load(_Student.formImage);
                    }
                    if (_Student.proofRegistration != "")
                    {
                        pcGaeed.Load(_Student.proofRegistration);
                    }
                    btnSave.Enabled = false;
                    btnEmptyFaild.Enabled = false;
                    btnLoadPictur.Enabled = false;
                    btnIdentity.Enabled = false;
                    btnGaeed.Enabled = false;
                    btnEstmara.Enabled = false;
                    return;
                }
               
            }
            else if (Mode == enMode.Update)
            {
                lblTitleForm.Text = "تعديل معلومات الطالب";
               
                _Student = clsStudent.FindStudentById(StudentID);
                if (_Student != null)
                {
                    txtStudentName.Text = _Student.FullName;
                    StudentDate.Text = _Student.BirthDay.ToString();
                    txtPhoneNumber.Text = _Student.phoneNumber;
                    txtWhatsappNum.Text = _Student.whatsappNumber;
                    txtFatherName.Text = _Student.FatherName;
                    txtFatherPhone.Text = _Student.FatherNumber;
                    txtPlaceLive.Text = _Student.PlaceLiving;
                    if (_Student.Status == true)
                    {
                        cmbStudentStatus.Text = "طالب";
                    }
                    else
                    {
                        cmbStudentStatus.Text = "خريج";
                    }
                   
                    cmbMajor.SelectedItem = cmbMajor.Items[_Student.MajorId - 1]; //(clsStudent.GetItemNameByItemID(this.StudentID, "Majors", "Major"));
                    cmbUniversty.SelectedItem = cmbUniversty.Items[_Student.UniverstyId - 1];     //clsStudent.GetItemNameByItemID(this.StudentID, "Universtys", "Universty");
                    cmbLevel.SelectedItem = cmbLevel.Items[_Student.CurrentLevelId - 1];        //clsStudent.GetItemNameByItemID(this.StudentID, "Levels", "Level");
                    cmbTimePeriod.SelectedItem = cmbTimePeriod.Items[_Student.TimeStudyId - 1];
                    if (_Student.Picture != "")
                    {
                        personalPictur.Load(_Student.Picture);
                    }
                    if (_Student.Identity != "")
                    {
                        PcIdentityCard.Load(_Student.Identity);
                    }
                    if (_Student.formImage != "")
                    {
                        pcEstmara.Load(_Student.formImage);
                    }
                    if (_Student.proofRegistration != "")
                    {
                        pcGaeed.Load(_Student.proofRegistration);
                    }
                    return;
                }
                
            }
        }

        void FillAllComboboxByData()
        {
            FillEachCombobox("Universtys", "Universty", cmbUniversty);
            FillEachCombobox("Levels", "Level", cmbLevel);
            FillEachCombobox("Majors", "Major", cmbMajor);
            FillEachCombobox("Periods", "Period", cmbTimePeriod);
        }

        void FillEachCombobox( string TableName , string ColumnName , System.Windows.Forms.ComboBox CmbBoxName)
        {
            DataTable dt = new DataTable();
            dt = clsStudent.GetWhatDoYouWhantCmbData(TableName);
            foreach (DataRow record in dt.Rows)
            {
                CmbBoxName.Items.Add(record[ColumnName]);
                
            }
        }

        void chooseImageFunction(ref string PicurPath)
        {
            //= "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.Filter = "Image Files |*.jpg;*.jpeg;*.png;*.gif*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                 PicurPath = openFileDialog1.FileName;
              
            }
        }

        private void btnIdentity_Click(object sender, EventArgs e)
        {
            chooseImageFunction(ref CardImage);
            PcIdentityCard.Image = Image.FromFile(CardImage);
        }

        private void btnLoadPictur_Click(object sender, EventArgs e)
        {
            chooseImageFunction(ref personImage);
            personalPictur.Image = Image.FromFile(personImage);
        }

        private void btnGaeed_Click(object sender, EventArgs e)
        {
            chooseImageFunction(ref proofImage);
            pcGaeed.Image = Image.FromFile(proofImage);
        }

        private void btnEstmara_Click(object sender, EventArgs e)
        {
            chooseImageFunction(ref FormImage);
            pcEstmara.Image = Image.FromFile(FormImage);
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            if( txtStudentName.Text == "" || txtPhoneNumber.Text == ""|| txtWhatsappNum.Text == "" || StudentDate.Value == null ||
                txtFatherName.Text == "" || txtFatherPhone.Text == "" || txtPlaceLive.Text == "" || txtPlaceLive.Text == "" ||
               cmbStudentStatus.SelectedItem.ToString() == "" || cmbUniversty.SelectedItem == "" || cmbLevel.SelectedItem == "" ||
               cmbMajor.SelectedItem == "" || cmbTimePeriod.SelectedItem == "")
            { 
                MessageBox.Show("Plesae Fail all Faild" ,"Fail All Faild" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

           
                _Student.FullName =txtStudentName.Text;
                _Student.phoneNumber =txtPhoneNumber.Text;
                _Student.whatsappNumber = txtWhatsappNum.Text;
                _Student.BirthDay =(DateTime)StudentDate.Value;
                _Student.FatherName = txtFatherName.Text;
                _Student.FatherNumber = txtFatherPhone.Text;
                _Student.PlaceLiving = txtPlaceLive.Text;
                if ( cmbStudentStatus.Text == "طالب")
                {
                    _Student.Status = true;
                }
                else
                {
                    _Student.Status = false;
                }

                //_Student.Status = cmbStudentStatus.SelectedItem.ToString();
                _Student.UniverstyId = cmbUniversty.SelectedIndex + 1;
                _Student.CurrentLevelId = cmbLevel.SelectedIndex  + 1;
                _Student.MajorId = cmbMajor.SelectedIndex + 1;
                _Student.TimeStudyId = cmbTimePeriod.SelectedIndex + 1;

                //_Student.MajorId = clsStudent.GetIdValueForCmbBoxItem("Majors", "Major", cmbMajor.Text);
                //_Student.UniverstyId = clsStudent.GetIdValueForCmbBoxItem("Universtys", "Universty", cmbUniversty.Text);
                //_Student.CurrentLevelId = clsStudent.GetIdValueForCmbBoxItem("Levels", "Level", cmbLevel.Text);
                //_Student.TimeStudyId = clsStudent.GetIdValueForCmbBoxItem("Periods", "Period", cmbTimePeriod.Text);

                if (personImage != "")
                {
                    _Student.Picture = personImage;
                }
                else
                {
                    _Student.Picture = "";
                }

                if (CardImage != "")
                {
                    _Student.Identity = CardImage;
                }
                else
                {
                    _Student.Identity = "";
                }

                if (FormImage != "")
                {
                    _Student.formImage = FormImage;
                }
                else
                {
                    _Student.formImage = "";
                }

                if (proofImage != "")
                {
                    _Student.proofRegistration = proofImage;
                }
                else
                {
                    _Student.proofRegistration = "";
                }
            
                if(_Student.Save())
                {
                    MessageBox.Show("Sstudent Added Successfully" ,"confirm" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();        
                }
                else
                {
                    MessageBox.Show("FAIL Student Add ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
        }

        private void txtValidate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NumValidate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnEmptyFaild_Click(object sender, EventArgs e)
        {
            txtStudentName.Text ="";
            StudentDate.Text  ="";
            txtPhoneNumber.Text ="";
            txtWhatsappNum.Text ="";
            txtFatherName.Text  ="";
            txtFatherPhone.Text ="";
            txtPlaceLive.Text   = "";

        }
    }
}



//private void llOpenFileDialog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
//{
//    openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"; 
//    openFileDialog1.FilterIndex = 1; 
//    openFileDialog1.RestoreDirectory = true;

//    if (openFileDialog1.ShowDialog() == DialogResult.OK)
//    {

//        string selectedFilePath = openFileDialog1.FileName; 
//        pictureBox1.Load(selectedFilePath);
//        llRemoveImage.Visible = true;
//    }
//}